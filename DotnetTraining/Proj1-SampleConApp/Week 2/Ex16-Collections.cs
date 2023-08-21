using System;
using System.Collections;

namespace Proj1_SampleConApp.Week_2
{
    class Ex16_Collections
    {
        static void Main(string[] args)
        {
            arrayListExample();
        }

        private static void arrayListExample()
        {
            ArrayList fruits = new ArrayList();//It creates a blank array with size 0.
            fruits.Add("Apples");
            fruits.Add("Mangoes");
            fruits.Add("Bananas");
            fruits.Add("Oranges");//Adds the item to the bottom of the list.  

            fruits.Insert(2, "Gauvas");//Insert in b/w the collection
            foreach(var item in fruits)
                Console.WriteLine(item);
            fruits.Remove("Oranges");//removes the specific element from the arrayList. 
            Console.WriteLine("The no of elements in the arraylist is " + fruits.Count);
            //todo: Remove vs. RomoveAt vs. RemoveRange. 

            /////////////Limitations of ArrayList//////////////////////////
            fruits.Add(123);//ArrayList storing any kind of data. 
            fruits.Add(123.45);
            fruits.Add("PineApples");
            fruits.Add(true);
            foreach (var item in fruits)
                Console.WriteLine(item);
            //If U want to compute a value, U should unbox it, reducing the optmization feature of the Application. 
        }
        //todo:Look on an example on HashTable where the data is stored in the form of key-value pairs. 
    }
}
