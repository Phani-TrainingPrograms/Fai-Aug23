using System;

namespace Proj1_SampleConApp
{
    class MathComponent
    {
        public double AddFunc(double fValue, double sValue) => (fValue + sValue);
        public double SubFunc(double fValue, double sValue) => (fValue - sValue);
        public double MulFunc(double fValue, double sValue) => (fValue * sValue);
        public double DivFunc(double fValue, double sValue) => (fValue / sValue);

        public void AllOperations(double fValue, double sValue, out double added, out double substracted, out double multiplied, out double divided)
        {
            added = fValue + sValue;
            substracted = fValue - sValue;
            multiplied = fValue * sValue;
            if (sValue != 0)
                divided = fValue / sValue;
            else
                divided = 0;
        }

        public string GetFullName(params string[] values)
        {
            string fullName = string.Empty;
            foreach (string value in values)
                fullName += value + " ";
            return fullName.Trim();
        }

        public double GetSum(params int [] args)
        {
            double sum = 0;
            foreach(int arg in args)
            {
                sum += arg;
            }
            return sum;
        }

    }
    class Ex09_Functions
    {
        static void Main(string[] args)
        {
            //invokingMathFunc();
            double v1 = 123, v2 = 234, res1, res2, res3, res4;
            MathComponent cls = new MathComponent();
            cls.AllOperations(v1, v2, out res1, out res2, out res3, out res4);
            Console.WriteLine($"The Added value is {res1}\nThe Subtracted value is {res2}\nThe multiplied value is {res3}\nThe divided value is {res4}");
            var fullName = cls.GetFullName("Phani", "Raj", "B.N.");
            Console.WriteLine(fullName);

            res1 = cls.GetSum(123, 234, 43, 34, 5, 4, 3, 45, 5, 5, 5, 5, 5, 5, 65);
            Console.WriteLine("The sum is " + res1);
        }

        private static void invokingMathFunc()
        {
            var mathComponent = new MathComponent();
            double v1 = Utilities.GetDouble("Enter the First value");
            double v2 = Utilities.GetDouble("Enter the Second value");
            double res = mathComponent.AddFunc(v1, v2);
            Console.WriteLine("The Added value is " + res);
        }
    }
}
//Todo: implement the ref feature for square and square root of the math operations. 