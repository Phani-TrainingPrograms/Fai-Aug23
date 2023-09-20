using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Right click on the Models->Add New Item->ADO.NET Entity Data Model.
//Run thru the wizard to link the database with the EF. 
//Select the tables from the Wizard for generating the classes. 
//Start using the DBContext class and the APIs. 
namespace Proj2MvcFramework.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }

        public int EmpSalary { get; set; }

        public int DeptId { get; set; }
        public override string ToString()
        {
            return $"<h1>Details of {EmpName}</h1><hr/><p>The Name: {EmpName}</p><p>The Address: {EmpAddress}</p><p>The ID: {EmpId}</p>";
        }
    }

    public class EmployeeManager
    {

        private Employee convert(Emptable record)
        {
            if(record == null) throw new Exception("Employee not found");
            return new Employee
            {
                DeptId = record.DeptId ?? 0,
                EmpAddress = record.empAddress,
                EmpId = record.empId,
                EmpName = record.empName,
                EmpSalary = (int)record.empSalary
            };
        }

        private Emptable convert(Employee record)
        {
            if (record == null) throw new Exception("Employee not found");
            return new Emptable
            {
                DeptId = record.DeptId,
                empAddress = record.EmpAddress,
                empId = record.EmpId,
                empName = record.EmpName,
                empSalary = record.EmpSalary
            };
        }
        public List<Employee> GetAllEmployees()
        {
            //create the context object
            var context = new FaiTrainingEntities();
            //get the Emp data
            var data = context.Emptables.ToList();
            //convert each record to Employee object
            var list = new List<Employee>();
            foreach (var emp in data)
            {
                var temp = new Employee();
                temp.EmpSalary = (int)emp.empSalary;
                temp.EmpAddress = emp.empAddress;
                temp.DeptId = emp.DeptId ?? 0;
                temp.EmpName = emp.empName;
                temp.EmpId = emp.empId;
                list.Add(temp);
            }
            //return the list of the Employee objects. 
            return list;
        }

        public Employee FindEmployee(int empId){
            var context = new FaiTrainingEntities();
            var data = context.Emptables.Find(empId);
            return convert(data) ?? new Employee { };
        }

        public void AddNewEmployee(Employee employee)
        {
            var context = new FaiTrainingEntities();
            var rec = convert(employee);
            context.Emptables.Add(rec);
            context.SaveChanges();
        }

        public List<DeptTable> GetAllDepts()
        {
            var context = new FaiTrainingEntities();
            var data = context.DeptTables.ToList();
            return data;
        }


        internal void UpdateEmployee(Employee emp)
        {
            var context = new FaiTrainingEntities();
            var rec = context.Emptables.Find(emp.EmpId);
            rec.empName = emp.EmpName;
            rec.empSalary = emp.EmpSalary;
            rec.empAddress = emp.EmpAddress;
            rec.DeptId = emp.DeptId;
            context.SaveChanges();
        }
    }
}