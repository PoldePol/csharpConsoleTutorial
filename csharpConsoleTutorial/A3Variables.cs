using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class A3Variables
    {
        public static void TutorialVariables()
        {   /*-----------------------------------------------------------------------*/
            //Variables are containers for storing data values.
            //Syntax( dataType variableName(Identifier) = value)
            //Variable Assignment with variable value
            int number = 99;
            double decimalNumber = 99.99D;
            char letter = 'A';
            string name = "Muring";
            bool boolState = false;

            //Another method for assignment
            string anotherName;

            anotherName = "Alan";
            Console.Write(anotherName);

            anotherName = "Paul";
            Console.WriteLine(anotherName);

            //White space
            Console.WriteLine();

            /*-----------------------------------------------------------------------*/
            //Constants is use when you want a variable to always store the same value.

            const string myFullName = "Alan Paul Muring";
            Console.WriteLine(myFullName);

            //White space
            Console.WriteLine();

            /*-----------------------------------------------------------------------*/
            //Display Variables
            string firstName = "Chilcee ";
            string lastName = "Navares";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x+y);

            //White space
            Console.WriteLine();

            //Another way for printing
            Console.WriteLine($"Hello {firstName}");

            /*-----------------------------------------------------------------------*/
            //Multiple Variables
            int a = 1, b = 2, c = 4;
            Console.WriteLine(a+b+c);

            int d, e, f;
            d = e = f = 50;

            //White space
            Console.WriteLine(d+e+f);

            /*-----------------------------------------------------------------------*/
            //Identifier
            //a.k.a variable names

            /* Naming Convention
             * Names can contain letters, digits and the underscore character (_)
             * Names must begin with a letter or underscore
             * Names should start with a lowercase letter, and cannot contain whitespace
             * Names are case-sensitive ("myVar" and "myvar" are different variables)
             * Reserved words (like C# keywords, such as int or double) cannot be used as names
             */

            //identify hour
            //descriptive name
            int minutesPerHour = 60;

            //vague short name
            int m = 60;
            
        }
    }
}
