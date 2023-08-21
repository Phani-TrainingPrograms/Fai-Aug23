using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp.Models
{
    class EmpListDatabase : IEmpDatabase
    {
        private List<Employee> employees = new List<Employee>();

        public Employee this[int index] => employees[index];

        public int Count => employees.Count;

        public void AddEmployee(Employee emp) => employees.Add(emp);

        public void DeleteEmployee(int id)
        {
            foreach(var emp in employees)
            {
                if(emp.EmpId == id)
                {
                    employees.Remove(emp);
                    return;
                }
            }
            throw new Exception("No Employee found to Delete");
        }

       
       
        //Implicit Implementation
        public IEnumerator GetEnumerator()
        {
            //It gets each object at a time when its executed in a foreach statement. 
            return employees.GetEnumerator();
        }

        public void UpdateEmployee(int id, Employee emp)
        {
            foreach (var copy in employees)
            {
                if (copy.EmpId == id)
                {
                    copy.DeepCopy(emp);
                    return;
                }
            }
            throw new Exception("No Employee found to update");
        }

        //explicit implementatoin
        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            foreach (var element in employees)
                yield return element;
        }
    }
}
