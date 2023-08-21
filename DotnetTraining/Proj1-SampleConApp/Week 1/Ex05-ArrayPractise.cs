using System;

namespace Proj1_SampleConApp
{
    class Ex05_ArrayPractise
    {
        static void Main(string[] args)
        {
            //dynamicArrayExample();
            jaggedExample();
        }

        private static void jaggedExample()
        {
            int rowsCount = Utilities.GetInteger("Enter the no of classrooms in UR school");
            int[][] school = new int[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                int size = Utilities.GetInteger("Enter the no of students in UR class");
                school[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    school[i][j] = Utilities.GetInteger("Enter the value for the location");
                }
            }
            Console.WriteLine("All values are set, lets read them");
            //school[0] = new int[] { 45, 56, 55, 44 };
            //school[1] = new int[] { 66,55,44,33,66,87 };
            //school[2] = new int[] { 66,55,44,33,66,87,56,77,73,81,50 };
            //school[3] = new int[] { 66,55,44,33 };
            //school[4] = new int[] { 66,55 };

            //Display it in matrix format
            for (int i = 0; i < school.Length; i++)
            {
                foreach(int score in school[i])
                {
                    Console.Write(score + " ");
                }
                Console.WriteLine();
            }
        }

        private static void dynamicArrayExample()
        {
            int size = Utilities.GetInteger("Enter the size of the array");
            string dataType = Utilities.GetString("Enter the data Type(CTS name) for the Array");
            Type type = Type.GetType(dataType);
            if (type == null)
            {
                Console.WriteLine("Invalid data type, cannot create array");
                return;
            }
            Array array = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the Array at the index {i} of the data type {type.Name}");
                var value = Convert.ChangeType(Console.ReadLine(), type);
                array.SetValue(value, i);
            }
            Console.WriteLine("All the values are set!!!");
            foreach (var item in array)
                Console.WriteLine(item);
        }
    }
}
