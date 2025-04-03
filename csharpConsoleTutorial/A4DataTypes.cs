using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class A4DataTypes
    {
        public static void TutorialDataTypes()
        {
            //Integer
            Console.WriteLine("--int - Integer stores whole number without decimals--");
            int intNumber = 0;
            Console.WriteLine(intNumber);

            //White Space
            Console.WriteLine();

            //Long
            Console.WriteLine("--long - stores whole number from negative to positive 9 quintillion--");
            double longNumber = 8990909090922222209L;
            Console.WriteLine(longNumber);

            //White Space
            Console.WriteLine();

            //Float
            Console.WriteLine("--Float - Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits--");
            float floatNumber = 9.123142932F;
            Console.WriteLine($"{floatNumber}");

            //White Space
            Console.WriteLine();

            //Double
            Console.WriteLine("--double - stores floating point numbers, with decimals--");
            double decimalnumber = 90.992321D;
            Console.WriteLine(decimalnumber);

            //White Space
            Console.WriteLine();

            //Scientific
            Console.WriteLine("--Scientific Numbers--");
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1); 

            //White Space
            Console.WriteLine();

            //Char
            Console.WriteLine("--char - Stores a single character/letter, surrounded by single quotes--");
            char letter = 'a';
            Console.WriteLine(letter);

            //White Space
            Console.WriteLine();

            //String
            Console.WriteLine("--string - Stores a sequence of characters, surrounded by double quotes--");
            string word = "Apple";
            Console.WriteLine(word);

            //White Space
            Console.WriteLine();

            //Bool
            Console.WriteLine("--bool - Stores true or false values--");
            bool boolState = true;
            Console.WriteLine(boolState);

            

        }
    }
}
