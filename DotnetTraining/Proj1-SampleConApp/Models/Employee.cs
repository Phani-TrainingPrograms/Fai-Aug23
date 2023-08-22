using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp.Models
{
    //Entity classes are those classes that are created to represent real world entities
    [Serializable]
    public class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public double EmpSalary { get; set; }

        public override int GetHashCode()
        {
            return EmpId;
        }

        public override bool Equals(object obj)
        {
            if(obj is Employee)//is checks if the object is of the type Employee
            {
                var temp = obj as Employee;//Unboxing reference types using as keyword...
                return temp.EmpId == this.EmpId;
            }
            return false;
        }

        public void DeepCopy(Employee other)
        {
            EmpId = other.EmpId;
            EmpName = other.EmpName;
            EmpAddress = other.EmpAddress;
            EmpSalary = other.EmpSalary;
        }
    }

    //A class that implements CRUD operations for a storage device(Database, file, Inmemory, Cloud etc
    class EmployeeCollection
    {
        private Employee[] _empList;

        public EmployeeCollection()
        {
            _empList = new Employee[100];
        }

        private Employee deepCopy(Employee emp)
        {
            Employee temp = new Employee();
            temp.EmpId = emp.EmpId;
            temp.EmpAddress = emp.EmpAddress;
            temp.EmpName = emp.EmpName;
            temp.EmpSalary = emp.EmpSalary;
            return temp;
        }
        public void AddNewEmployee(Employee emp)
        {
            for (int i = 0; i < 100; i++)
            {
                if(_empList[i] == null)
                {
                    _empList[i] = deepCopy(emp);
                }
            }
        }

        public Employee FindEmployee(int id)
        {
            return new Employee { EmpId = 111, EmpAddress = "Bangalore", EmpName ="Phaniraj", EmpSalary = 56000 };
        }

        public Employee[] FindAllEmployees()
        {
            return _empList;
        }

        public void DeleteEmployee(int id)
        {
            Console.WriteLine("Employee deleted successfully");
        }

        public void UpdateEmployee(int id, Employee updatedRec)
        {
            Console.WriteLine("Employee updated successfully");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            //How to use the class:
            Employee emp = new Employee();
            emp.EmpId = 3;
            emp.EmpAddress = "Bangalore";
            emp.EmpName = "Suresh";
            emp.EmpSalary = 45000;

            EmployeeCollection mgr = new EmployeeCollection();
            mgr.AddNewEmployee(emp);

        }
    }
}
//Todo: Complete the code with a menu driven program that performs the operations based on selection. 
