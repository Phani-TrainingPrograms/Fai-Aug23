using System;
namespace Proj1_SampleConApp
{
    class Ex06_ReferenceTypes  
    {
        static void Main(string[] args)
        {
            //boxingAndUnboxing();
            referencingValueTypes();

        }

        private static void referencingValueTypes()
        {
            object intValue = new object();
            intValue = 123;

            int copy = (int)intValue;//As integer is a value type, it creates a new variable of the type int. So any changes U make to the copy will not be reflected on the actual object. 
            copy += 123;
            Console.WriteLine("The int value is " + intValue);
        }

        private static void boxingAndUnboxing()
        {
            object boxedValue = 123;//Integer is saved as object. object is a reference type.
            Console.WriteLine("The internal data type of the boxed value: " + boxedValue.GetType().Name);
            //When U want to modify the boxed value, U should explicitly unbox it and then perform any modification. When U do the explicit casting, it should casted to the same type from which it was boxed. 

            long tempValue = (int)boxedValue;
            tempValue += 12;
            boxedValue = tempValue;
            Console.WriteLine("The value currently in the object is " + boxedValue);
        }
    }
}