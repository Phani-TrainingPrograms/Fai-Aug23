using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing .NET CODE");
            Console.WriteLine("Example for Coding");
            //Writes a text on the Console Window and moves the carrier return to the next line. 

            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();//ReadLine returns a string. 
 
            Console.WriteLine("Enter the Age");
            var age = Console.ReadLine();

            Console.WriteLine("Enter the City");
            var city = Console.ReadLine();

            //Console.WriteLine("The Name entered is " + name + " UR Age is " + age);
            Console.WriteLine($"The Name entered is {name} and UR Age is {age}");//Interpolation Syntax introduced in C# 6.0. 
            Console.WriteLine("The Name entered is {0}. Mr. {0}'s Age is {1}. Mr.{0} comes from {2}", name, age, city);//Old format of String...
        }
        //Run the App->Ctrl + F5
    }
}

