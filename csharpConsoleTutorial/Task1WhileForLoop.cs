using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharpConsoleTutorial
{
    internal class Task1WhileForLoop
    {
        public static void WhileForLoop()
        {
            String userName;
            int subjectCount;
            double average;

            Console.Write("Please Enter your name: ");
            userName = Console.ReadLine(); 

            while (true)
            {
            Console.Write("Please Enter how many subjects you currently take: ");
                if (int.TryParse(Console.ReadLine(), out subjectCount) && subjectCount > 0)
                    break;
             Console.Write("Invalid input! Please enter a valid positive number.");
            }

            string[] mySubjects = new string[subjectCount];

            int[] myGrades = new int[subjectCount];

            for (int i = 0; i < subjectCount; i++)
            {
                Console.Write("Please Enter the name of the subject number " + (i+1) + " : ");
                mySubjects[i] = Console.ReadLine();
            }

            //White space
            Console.WriteLine("");

            //Input grade
            for (int g = 0; g < subjectCount; g++)
            {
                while (true)
                {
                    Console.Write("Please Enter your grades for subject " + mySubjects[g] +" : ");
                    if (int.TryParse(Console.ReadLine(),out myGrades[g]) && myGrades[g] >= 0)
                        break;

                    Console.Write("Invalid Input! Please enter a number between 0 and 100");
                }

            }

            //Display results

            average = myGrades.Average();
            Console.WriteLine("Your Final Average " + userName + " is: " + average.ToString("0.00"));
        }
    }
}
