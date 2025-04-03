using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class A6UserInput
    {
        public static void tutorialUserInput()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("User name is: " +  userName);
            Console.WriteLine($"Hello {userName}");
        }
    }
}
