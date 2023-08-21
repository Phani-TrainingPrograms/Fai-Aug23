using System;

namespace Proj1_SampleConApp.Week_2
{
    interface IExample
    {
        void ExampleFunc();
    }

    interface ISimple
    {
        string ExampleFunc();
    }

    class SimpleExample : IExample, ISimple
    {
        public void ExampleFunc() => Console.WriteLine("ExampleFunc implicit Implementation");
        string ISimple.ExampleFunc() => "Test Result";//Explicit implementation

        void IExample.ExampleFunc() => Console.WriteLine("ExampleFunc explicit implementation");
    }
    class Ex19_ExplicitInterface
    {
        static void Main(string[] args)
        {
            IExample ex = new SimpleExample();
            ex.ExampleFunc();

            ISimple sim = new SimpleExample();
            Console.WriteLine(sim.ExampleFunc());

            SimpleExample simEx = new SimpleExample();
            simEx.ExampleFunc();
        }
    }
}
