using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class Ex03_MathClass
    {
        static string getString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static bool getResult(double v1, double v2, string choice)
        {
            switch (choice)
            {
                case "+": Console.WriteLine($"The Added value is {v1 + v2}"); return true;
                case "-": Console.WriteLine($"The Added value is {v1 - v2}"); return true;
                case "*": Console.WriteLine($"The Added value is {v1 * v2}"); return true;
                case "/": Console.WriteLine($"The Added value is {v1 / v2}"); return true;
                default: Console.WriteLine("Its an invalid choice"); return false;
            }
        }
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                //Console.WriteLine("Enter the First Value");
                //double v1 = double.Parse(Console.ReadLine());
                double v1 = double.Parse(getString("Enter the first value"));


                //Console.WriteLine("Enter the Second Value");
                //double v2 = double.Parse(Console.ReadLine());

                double v2 = double.Parse(getString("Enter the Second Value"));

                //Console.WriteLine("Enter the choice of operation: +, -, * or /");
                //string choice = Console.ReadLine();

                string choice = getString("Enter the choice of operation: +, -, * or /");

                processing = getResult(v1, v2, choice);

            } while (processing);

        }
    }
}
//toDo: Implement a loan calculator program that takes inputs of the loan amount, tenure and the rate of interest and it returns the total amount to be paid. (Use the SI formula). 
//Improvise the App to give the List of EMIs that has to be paid for the loan amount. 
//Create a Temperature conversion software that takes the possible conversion formats and displays the value based on the selected conversion. 
