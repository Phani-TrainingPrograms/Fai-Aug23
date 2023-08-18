using System;

namespace Proj1_SampleConApp
{
    class BaseClass
    {
        public string Data { get; set; }
        public void BaseFunction()
        {
            Data = "Base version has set some data";
            Console.WriteLine("Base Version of the Func implemented");
        }
    }

    //Syntax in C# for extending the class. Following the OPEN-CLOSED Principle, we will not modify the base class but rather extend it to the derived and make any modifications we want to our class.  
    class DerivedClass : BaseClass
    {
        public void DerivedFunction()
        {
            Console.WriteLine("The data set by the base version is : " + Data);
            Console.WriteLine("Derived Version of the Func implemented");
        }
    }

    class Ex12_Inheritance
    {
        static void Main(string[] args)
        {
            BaseClass cls = new BaseClass();
            cls.BaseFunction();

            //DerivedClass cls2 = new DerivedClass();
            //cls2.BaseFunction();
            //cls2.DerivedFunction();

            cls = new DerivedClass();//A Base class object can be instantiated to the derived class. But the reverse is not possible
            cls.BaseFunction();//cls does not have derived functions. 
            //U should do the downcasting of the object
            DerivedClass copy = cls as DerivedClass;//Casting in C# for Reference types. 
            
            copy.DerivedFunction();
            //copy is not a new object but the reference of cls object. 
        }
    }
}
//Todo: Create an Application that contains Book info System. There are different kinds of Books like AutoBiography, Biography, Science, History, Mythology. Create different classes for each genre and thru Run time polymorphism, provide a Book Management Software that shows all kinds of books and filtered books based on Genre. U can add additional properties specific to each Book Type. 

