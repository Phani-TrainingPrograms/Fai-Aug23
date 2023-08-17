using System;

namespace Proj1_SampleConApp
{
    class Utilities
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetInteger(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        public static double GetDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
    }
}
