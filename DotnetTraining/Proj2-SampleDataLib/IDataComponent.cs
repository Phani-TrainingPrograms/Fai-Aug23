using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_SampleDataLib
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddres { get; set; }
        public double EmpSalary { get; set; }

        public int DeptId { get; set; }
    }
    public interface IDataComponent
    {
        void AddEmployee(string name, string address, int salary, int deptId);
        void UpdateEmployee(string name, string address, int salary, int deptId);

        List<Employee> GetAllEmployees();
        Employee FindEmployee(int id);
        List<Employee> FindEmployee(string name);
    }

    class EmpDataComponent : IDataComponent
    {
        public void AddEmployee(string name, string address, int salary, int deptId)
        {
            var emp = new EmpTable
            {
                Address = address,
                DeptId = deptId,
                Name = name,
                Salary = (int)salary
            };
            var context = new EmpDataDataContext();
            context.EmpTables.InsertOnSubmit(emp);
            context.SubmitChanges();
        }

        public Employee FindEmployee(int id)
        {
            var context = new EmpDataDataContext();
            var rec = context.EmpTables.FirstOrDefault((e) => e.Id == id);
            if (rec != null)
                return new Employee
                {
                    DeptId = rec.DeptId,
                    EmpAddres = rec.Address,
                    EmpName = rec.Name,
                    EmpId = rec.Id,
                    EmpSalary = rec.Salary
                };
            else throw new Exception("Employee not found");
        }

        public List<Employee> FindEmployee(string name)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            var context = new EmpDataDataContext();
            var data = from emp in context.EmpTables
                       select new Employee
                       {
                           DeptId = emp.DeptId,
                           EmpAddres = emp.Address,
                           EmpName = emp.Name,
                           EmpSalary = emp.Salary,
                           EmpId = emp.Id
                       };
            return data.ToList();
        }

        public void UpdateEmployee(string name, string address, int salary, int deptId)
        {
            throw new NotImplementedException();
        }
    }

    public static class DataComponentFactory
    {
        public static IDataComponent GetComponent()
        {
            return new EmpDataComponent();
        }
    }
}
