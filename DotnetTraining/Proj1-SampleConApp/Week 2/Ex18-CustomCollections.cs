using System;
using System.Collections.Generic;
namespace Proj1_SampleConApp.Week_2
{
    using Proj1_SampleConApp.Common;
    class Ex18_CustomCollections
    {
        static void Main(string[] args)
        {
            var component = EmpFactory.GetComponent("binary");
            component.AddEmployee(new Models.Employee
            {
                EmpId = 123,
                EmpName = "Phaniraj",
                EmpAddress = "Bangalore",
                EmpSalary = 67000
            });

            component.AddEmployee(new Models.Employee
            {
                EmpId = 124,
                EmpName = "Aravind",
                EmpAddress = "Bangalore",
                EmpSalary = 57000
            });

            component.AddEmployee(new Models.Employee
            {
                EmpId = 125,
                EmpName = "David Camron",
                EmpAddress = "Goa",
                EmpSalary = 47000
            });

            //component.DeleteEmployee(124);
            foreach (var emp in component)
            {
                Console.WriteLine(emp.EmpName);
            }
            Console.ReadLine();
            //for (int i = 0; i < component.Count; i++)
            //{
            //    Console.WriteLine(component[i].EmpName);
            //}
        }
    }
}
