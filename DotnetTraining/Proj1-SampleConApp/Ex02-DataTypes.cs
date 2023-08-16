using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class Ex02_DataTypes
    {
        static void showDataTypeRanges()
        {
            Console.WriteLine($"The Range of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The Range of short is {short.MinValue} and {short.MaxValue}");
            Console.WriteLine($"The Range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The Range of long is {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The Range of float is {float.MinValue} and {float.MaxValue}");
            Console.WriteLine($"The Range of double is {double.MinValue} and {double.MaxValue}");
        }
        static void Main()
        {
            //showDataTypeRanges();
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the date of birth");
            DateTime dt = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - dt.Year;
            
            Console.WriteLine("Enter the phone no");
            long phoneno = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the salary");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Name entered is {name} aged {age}\nHe will be available at {phoneno} and he earns a salary of {salary:c}");
        }
    }
}
//Todo: Create a program that takes inputs from the user on his/her information including college and strength of the college and its details and display on the Console. 
