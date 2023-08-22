using System;
using System.Threading;

namespace Proj1_SampleConApp.Week_2
{
    class MemClass : IDisposable
    {
        private string clsName;
        public MemClass(string name)
        {
            clsName = name;
            Console.WriteLine($"Object by name {clsName} is created");
        }

        
        ~MemClass()
        {
            Console.WriteLine($"Object by name {clsName} is destroyed");
        }

        public void Dispose()
        {
            Console.WriteLine($"Object by name {clsName} is destroyed");
            GC.SuppressFinalize(this);
        }
    }
    class Ex24_MemoryManagement
    {
        static void createAndDestoryObjects()
        {
            for (int i = 1; i <= 10; i++)
            {
                //MemClass cls = new MemClass("ClassName: " + i);
                //cls.Dispose();
                //GC.Collect();
                //GC.WaitForPendingFinalizers();
                ////Thread.Sleep(1);
                ///

                using (MemClass cls = new MemClass("ClassName : " + i))
                {
                    
                };
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        static void Main(string[] args)
        {
            createAndDestoryObjects();
            Console.WriteLine("The Main ends here................");
        }
    }
}
