using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class Task1Forloop
    {
        public static void taskforloop()
        {
            String name;
            int subjectCount;

            //Ask user for name.
            //Prints and collects user input for variable name.
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            //Ask user input for how many subjects he/she has taken.
            //Prints and collects user input for variable subjectCount.
            Console.Write("Please enter how many subjects you are currently take: ");
            subjectCount = int.Parse(Console.ReadLine());

            //Saves subject entered in a array.
            String[] mySubject = new String[subjectCount];

            //For loop, conditional looping asking user for list of enrolled subject.
            for (int i = 0; i < subjectCount; i++)
            {
                Console.Write("Please enter Subject Number " + (i + 1) + ": ");
                mySubject[i] = Console.ReadLine();
            }

            //For White space
            Console.WriteLine();

            //Saves subject grades in a array
            int[] myGrade = new int[subjectCount];

            //For loop, conditional looping asking user for list of the corresponding subject grades.
            for (int i = 0; i < mySubject.Length; i++)
            {
                Console.Write("Please Enter your grade for " + mySubject[i] + " Subject: ");
                myGrade[i] = int.Parse(Console.ReadLine());
            }

            //For White space
            Console.WriteLine();

            double sum = 0;

            //Grade calculation.
            for (int i = 0; i < myGrade.Length; i++)
            {
                sum += myGrade[i];
            }

            //Mathematical equation for average calculation
            int percentage = mySubject.Length * 100;
            double average = (sum / percentage) * 100;

            //Prints user average.
            Console.WriteLine("Your Final Average " + name + " is: " + average.ToString("0.00"));

        }
    }
}