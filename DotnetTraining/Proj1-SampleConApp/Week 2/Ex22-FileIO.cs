using System;
using System.IO;

namespace Proj1_SampleConApp.Week_2
{
    using Proj1_SampleConApp.Models;
    using System.Collections.Generic;

    class Ex22_FileIO
    {
        const string filename = "../../EmpData.csv";

        static void Main(string[] args)
        {
            //readAllContents(filename);
            var emp = new Models.Employee();
            emp.EmpId = Utilities.GetInteger("Enter the Id");
            emp.EmpName = Utilities.GetString("Enter the Name");
            emp.EmpAddress = Utilities.GetString("Enter the Address");
            emp.EmpSalary = Utilities.GetDouble("Enter the Salary");
            writeEmpRecordToFile(emp);
            //List<Models.Employee> employees = readAllRecords(filename);
            //foreach(var rec in employees)
            //    Console.WriteLine(rec.EmpName + " from " + rec.EmpAddress);
            //int id = Utilities.GetInteger("Enter the Id of the record to delete");
            //deleteRecordFromFile(id);
        }

        private static void deleteRecordFromFile(int id)
        {
            var records = readAllRecords(filename);
            for (int i = 0; i < records.Count; i++)
            {
                if(records[i].EmpId == id)
                {
                    records.RemoveAt(i);
                    break;
                }
            }
            File.Delete(filename);
            bulkInsertRecords(records);
        }

        private static void bulkInsertRecords(List<Models.Employee> records)
        {
            foreach(var emp in records)
            {
                writeEmpRecordToFile(emp);
            }
        }

        private static List<Models.Employee> readAllRecords(string filename)
        {
            //Create a blank List<Employee>....
            List<Models.Employee> empList = new List<Models.Employee>();
            //Get all the lines. 
            string [] lines = File.ReadAllLines(filename);
            //Iterate each line and split the line into words. 
            foreach(string line in lines)
            {
                string[] words = line.Split(',');
                //1st Word is id, and .....
               //Create the Emp object and set the values from the words taken
                var emp = new Models.Employee
                {
                    EmpId = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpAddress = words[2],
                    EmpSalary = double.Parse(words[3])
                };
                //Add the obj to the List collection
                empList.Add(emp);
            }
            return empList;
        }

        private static void writeEmpRecordToFile(Models.Employee emp)
        {
            var line = $"{emp.EmpId},{emp.EmpName},{emp.EmpAddress},{emp.EmpSalary}\n";
            File.AppendAllText(filename, line);
            Console.WriteLine("Data Saved to the file");
        }

        private static void readAllContents(string filename)
        {
            var content = File.ReadAllText(filename);
            Console.WriteLine(content);
        }
    }
}
