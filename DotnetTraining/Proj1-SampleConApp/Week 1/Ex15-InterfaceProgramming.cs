using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Proj1_SampleConApp
{
    interface IEmpManager
    {
        void AddNewEmployee(int id, string name, string address);
        void UpdateEmployee(int id, string name, string address);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees();
    }

    class EmpManager : IEmpManager
    {
        private DataTable empTable;
        public EmpManager()
        {
            empTable = new DataTable();
            empTable.Columns.Add("empId", typeof(int));
            empTable.Columns.Add("empName", typeof(string));
            empTable.Columns.Add("empAddress", typeof(string));
            empTable.AcceptChanges();
        }
        public void AddNewEmployee(int id, string name, string address)
        {
            //Create a row with the matching schema
            DataRow row = empTable.NewRow();
            row[0] = id;
            row[1] = name;
            row[2] = address;
            empTable.Rows.Add(row);
            empTable.AcceptChanges();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllEmployees()
        {
            return empTable;
        }

        public void UpdateEmployee(int id, string name, string address)
        {
            throw new NotImplementedException();
        }
    }

    class EmpFactory
    {
        public static IEmpManager GetComponent()
        {
            return new EmpManager();
        }
    }

    class Ex15_InterfaceProgramming
    {
        const string fileName = @"C:\Trainings\Fai-August2023\DotnetTraining\Proj1-SampleConApp\Menu.txt";
        static IEmpManager mgr = EmpFactory.GetComponent();
        static void Main(string[] args)
        {
            mgr.AddNewEmployee(111, "Phaniraj", "Bangalore");
            mgr.AddNewEmployee(112, "Vinod", "Shimoga");
            mgr.AddNewEmployee(113, "Banu", "Mysore");
            mgr.AddNewEmployee(114, "Joy", "Kolkata");
            string content = File.ReadAllText(fileName);
            var processing = true;
            do
            {
                string choice = Utilities.GetString(content);
                processing = processMenu(choice);

            } while (processing);
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "N":
                    return addingHelper();
                case "U":
                case "F":
                    return findingHelper();
                case "D":
                    return true;
                default:
                    return false;
            }
        }

        private static bool findingHelper()
        {
            var table = mgr.GetAllEmployees();
            int id = Utilities.GetInteger("Enter the Id to find");
            foreach(DataRow row in table.Rows)
            {
                if(row[0].ToString() == id.ToString())
                    Console.WriteLine($"{row[0]} with Name {row["empName"]}");
            }
            return true;
        }

        private static bool addingHelper()
        {
            int id = Utilities.GetInteger("Enter the ID for this Employee");
            string name = Utilities.GetString("Enter the Name of this Employee");
            string address = Utilities.GetString("Enter the Address of this Employee");
            mgr.AddNewEmployee(id, name, address);
            Console.WriteLine("Employee added successfully");
            return true;
        }
    }
}
