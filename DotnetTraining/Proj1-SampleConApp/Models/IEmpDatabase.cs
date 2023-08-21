using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp.Models
{
    interface IEmpDatabase : IEnumerable<Employee>
    {
        void AddEmployee(Employee emp);
        void UpdateEmployee(int id, Employee emp);
        void DeleteEmployee(int id);
        int Count { get; }

        Employee this[int index] { get; }

    }
}
