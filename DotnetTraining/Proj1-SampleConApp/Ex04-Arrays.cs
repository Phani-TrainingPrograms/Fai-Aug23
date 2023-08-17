using System;

namespace Proj1_SampleConApp
{
    class Ex04_Arrays
    {
        const int size = 3;
        static void simpleArrayExample()
        {
            //datatype [] identifier = new datatype[size];
            string[] basket = new string[size];
            //basket[0] = "Apples";
            //basket[1] = "Mangoes";
            //basket[2] = "Oranges";
            //basket[3] = "Tomatoes";
            //basket[4] = "Onions";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the item to be added to the basket");
                basket[i] = Console.ReadLine();
            }

            //Display the data using foreach statement. 
            foreach(string item in basket)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            //simpleArrayExample();
            multiDimensionalArrayExample();
        }

        static void multiDimensionalArrayExample()
        {
            int[,] TwoD = new int[2, 3];
            for (int i = 0; i < TwoD.GetLength(0); i++)
            {
                Console.WriteLine("Enter the values for the row " + i);
                for(int j =0; j <TwoD.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value for the column {j}");
                    TwoD[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("All inputs are take, lets display the data");
            
            for(int i =0; i < TwoD.GetLength(0); i++)
            {
                for (int j = 0; j < TwoD.GetLength(1); j++)
                {
                    Console.Write(TwoD[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
//todo: Get the concept of Jagged Arrays in C#. 
//Try to create an Array of the size taken as input from the User and even the data type taken as input from the user and develop an app that stores the values as array and display the items of the array. 
//Create an Array of integers taking inputs from the user and display the max, min and avg value of the array.

