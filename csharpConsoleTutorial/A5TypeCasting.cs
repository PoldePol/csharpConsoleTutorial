using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class A5TypeCasting
    {
        public static void tutorialTypeCasting()
        {
            /*
             * Implicit Casting (automatically) - converting a smaller type to a larger type size
             * char -> int -> long -> float -> double
             * 
             * Explicit Casting (manually) - converting a larger type to a smaller size type
             * double -> float -> long -> int -> char
             */


            //Implicit Casting
            int myInt = 10;
            float myFloat = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);

            //White Space
            Console.WriteLine();

            //Explicit Casting
            double myDouble = 9.89D;
            long myLong = (long) myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myLong);

            //White Space
            Console.WriteLine();

            /* Other form of conversion to explicit
             * 
             * Convert.ToBoolean
             * Convert.ToDouble
             * Convert.ToString
             * Convert.ToInt32 (int)
             * Convert.ToInt64 (long)
             * 
             */

            // Example

            int intNum = 20;
            double decimalNum = 90.90D;
            bool boolState = false;

            Console.WriteLine(Convert.ToString(intNum));
            Console.WriteLine(Convert.ToDouble(intNum));
            Console.WriteLine(Convert.ToInt32(decimalNum));
            Console.WriteLine(Convert.ToString(boolState));
        }
    }
}
