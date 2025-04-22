using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static csharpConsoleTutorial.Task2Student;

namespace csharpConsoleTutorial
{
    internal class task2AverageGradeOOP
    {
        public static void Main(String[] args)
        {
            string userChoice;
            int numChoice;
            bool exit = false;

            do
            {
                //Home menu
                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Calculate Average");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------");

                //White Space
                Console.WriteLine("");

                //user input
                Console.Write("Please choose from option 1 or 2: ");
                userChoice = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                if (int.TryParse(userChoice, out numChoice))
                {
                    switch (numChoice)
                    {
                        case 1:
                            Task2UserInput.UserInput();
                            break;
                        case 2:
                            Console.WriteLine("Program End");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Input Invalid! Enter 1 or 2 only.");
                            Console.WriteLine("");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter numeric value only!");
                    Console.WriteLine("Please choose from option 1 or 2 again");
                    Console.WriteLine("");
                }
            } while (!exit);
                

            //Enter more?
        }
    }
}
