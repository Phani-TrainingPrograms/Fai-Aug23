using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj2_SampleDataLib;

namespace Proj3_DllConsumerApp
{
    delegate void PerformDBOperation(IDataComponent component);
    class Program
    {

        static void CallDbFunc(PerformDBOperation operation)
        {
            IDataComponent component = DataComponentFactory.GetComponent();
            operation(component);
        }
        static void displayAllEmployees(IDataComponent component)
        {
            var empList = component.GetAllEmployees();
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.EmpName);
            }
        }
        static void Main(string[] args)
        {
            var component = DataComponentFactory.GetComponent();
            CallDbFunc(displayAllEmployees);
            //CallDbFunc(addEmployee);

        }

        private static void addEmployee(IDataComponent component)
        {
            Console.WriteLine("Enter the Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the Salary:");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Dept:");
            int deptId = int.Parse(Console.ReadLine());

            component.AddEmployee(name, address, salary, deptId);
        }
    }
}
