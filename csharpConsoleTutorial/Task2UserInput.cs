using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class Task2UserInput
    {
        public static void UserInput()
        {
            string subjectName;
            double grade;
            bool exit = false;

            do
            {
            
                //Ask for student full name
                Console.Write("Enter Student Full Name: ");
                string StudentName = Console.ReadLine();
                Task2Student.student Student = new Task2Student.student(StudentName);

                //Ask for how many subjects enrolled
                Console.Write("How many subjects is the student enrolled in? ");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                //White Space
                Console.WriteLine();

                for (int i = 0; i < subjectCount; i++)
                {
                    Console.Write($"Enter name of subjects #{i + 1}: ");
                    subjectName = Console.ReadLine();

                    Console.Write($"Enter grade for {subjectName}: ");
                    grade = Convert.ToDouble(Console.ReadLine());

                    Student.addSubject(new Task2Student.Subject(subjectName, grade));
                }
                //White Space
                Console.WriteLine("");

                Student.PrintReport();

                //White Space
                Console.WriteLine("");

                Console.WriteLine("---------------");
                Console.WriteLine("1. Enter more?");
                Console.WriteLine("2. Exit to menu");
                Console.WriteLine("---------------");

                Console.Write("Enter choice: ");
                int loopChoice = Convert.ToInt32(Console.ReadLine());

                if (loopChoice == 2)
                {
                    exit = true;
                }

                //White Space
                Console.WriteLine("");


            } while (!exit);
        }
    }
}
