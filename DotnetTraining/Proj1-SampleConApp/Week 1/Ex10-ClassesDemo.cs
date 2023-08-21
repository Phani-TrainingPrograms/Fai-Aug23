using Proj1_SampleConApp.Models;
using System;

namespace Proj1_SampleConApp
{
   
    class Ex10_ClassesDemo
    {
        static void Main(string[] args)
        {
            Models.Employee emp = new Models.Employee();
            EmployeeCollection collection = new EmployeeCollection();
            collection.AddNewEmployee(emp);
        }
    }
}
