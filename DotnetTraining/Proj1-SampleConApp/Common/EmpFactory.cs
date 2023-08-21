using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp.Common
{
    using Proj1_SampleConApp.Models;
    //A Class that has only static methods, which makes sure that the instance for this class is not created. 
    static class EmpFactory
    {
        public static IEmpDatabase GetComponent(string type)
        {
            switch (type.ToLower())
            {
                case "list": return new EmpListDatabase();
                default: return new EmpListDatabase(); ;
            }
        }
    }
}
