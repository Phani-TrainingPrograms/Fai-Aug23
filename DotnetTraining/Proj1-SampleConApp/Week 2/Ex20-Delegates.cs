using System;

namespace Proj1_SampleConApp.Week_2
{
    delegate double Operation(int v1, int v2);

    class Ex20_Delegates
    {
        static void InvokeMathFunc(int v1, int v2, Operation function)
        {
            double rs = function(v1, v2);
            Console.WriteLine("The result of this operation is " + rs);
        }

        static void CallMathFuncWithFunc(int v1, int v2, Func<int, int, double> func)
        {
            double rs = func(v1, v2);
            Console.WriteLine("The result " + rs);
        }
        static void Main(string[] args)
        {
            InvokeMathFunc(12, 3, addFunc);
            InvokeMathFunc(13, 2, delegate(int x, int y)//Using Anonymous function
             {
                 return x * y - 123 * (x / 23);
             });

            InvokeMathFunc(13, 54,  (x, y) =>x - y + (123 + x)); //Lambda Expression....
            CallMathFuncWithFunc(14, 12, (x, y) => x / y);
        }

        static double addFunc(int v1, int v2) => v1 + v2;
    }
}
