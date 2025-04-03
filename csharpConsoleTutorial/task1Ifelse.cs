using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class task1Ifelse
    {

        public static void taskifelse()
        {
            //variable declaration.
            String userName;
            int subjectCount;
            String mySubject1,mySubject2,mySubject3,mySubject4,mySubject5,mySubject6,mySubject7,mySubject8;
            double subjGrade1,subjGrade2,subjGrade3,subjGrade4,subjGrade5,subjGrade6,subjGrade7,subjGrade8;
            double percentage;
            double average;
            double subjGradeTotal;


            //Ask user input for his/her name.
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();

            //Ask user for input for his/her number of enrolled subjects.
            Console.Write("Please enter how many subjects you currently take: ");
            subjectCount = int.Parse(Console.ReadLine()); 

            //if else statement asking user for list of enrolled subject.
            if (subjectCount == 0)
            {
                Console.Write("Number entered invalid. ");
            }
            // 1 user subject input.
            else if (subjectCount == 1)
            {
                //Ask user input for subject name.
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for "+mySubject1+" Subject:" );
                subjGrade1 = int.Parse(Console.ReadLine());
                
                subjGradeTotal = subjGrade1;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average "+userName+" is: "+average.ToString("0.00"));
            }
            // 2 user subject input.
            else if (subjectCount == 2)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));
            }
            // 3 user subject input.
            else if (subjectCount == 3)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));
            }
            // 4 user subject input.
            else if (subjectCount == 4)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                Console.Write("Please enter Subject Number 4: ");
                mySubject4 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject4 + " Subject:");
                subjGrade4 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3 + subjGrade4;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));

            }
            // 5 user subject input.
            else if (subjectCount == 5)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                Console.Write("Please enter Subject Number 4: ");
                mySubject4 = Console.ReadLine();

                Console.Write("Please enter Subject Number 5: ");
                mySubject5 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject4 + " Subject:");
                subjGrade4 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject5 + " Subject:");
                subjGrade5 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3 + subjGrade4 + subjGrade5;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));

            }
            // 6 user subject input.
            else if (subjectCount == 6)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                Console.Write("Please enter Subject Number 4: ");
                mySubject4 = Console.ReadLine();

                Console.Write("Please enter Subject Number 5: ");
                mySubject5 = Console.ReadLine();

                Console.Write("Please enter Subject Number 6: ");
                mySubject6 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject4 + " Subject:");
                subjGrade4 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject5 + " Subject:");
                subjGrade5 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject6 + " Subject:");
                subjGrade6 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3 + subjGrade4 + subjGrade5 + subjGrade6;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));

            }
            // 7 user subject input.
            else if (subjectCount == 7)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                Console.Write("Please enter Subject Number 4: ");
                mySubject4 = Console.ReadLine();

                Console.Write("Please enter Subject Number 5: ");
                mySubject5 = Console.ReadLine();

                Console.Write("Please enter Subject Number 6: ");
                mySubject6 = Console.ReadLine();

                Console.Write("Please enter Subject Number 7: ");
                mySubject7 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject4 + " Subject:");
                subjGrade4 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject5 + " Subject:");
                subjGrade5 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject6 + " Subject:");
                subjGrade6 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject7 + " Subject:");
                subjGrade7 = int.Parse(Console.ReadLine());

                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3 + subjGrade4 + subjGrade5 + subjGrade6 + subjGrade7 ;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));

            }
            // 8 user subject input.
            else if (subjectCount == 8)
            {
                Console.Write("Please enter Subject Number 1: ");
                mySubject1 = Console.ReadLine();

                Console.Write("Please enter Subject Number 2: ");
                mySubject2 = Console.ReadLine();

                Console.Write("Please enter Subject Number 3: ");
                mySubject3 = Console.ReadLine();

                Console.Write("Please enter Subject Number 4: ");
                mySubject4 = Console.ReadLine();

                Console.Write("Please enter Subject Number 5: ");
                mySubject5 = Console.ReadLine();

                Console.Write("Please enter Subject Number 6: ");
                mySubject6 = Console.ReadLine();

                Console.Write("Please enter Subject Number 7: ");
                mySubject7 = Console.ReadLine();

                Console.Write("Please enter Subject Number 8: ");
                mySubject8 = Console.ReadLine();

                //White Space
                Console.WriteLine("");

                //Ask user input for subject grades.
                Console.Write("Please enter your grade for " + mySubject1 + " Subject:");
                subjGrade1 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject2 + " Subject:");
                subjGrade2 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject3 + " Subject:");
                subjGrade3 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject4 + " Subject:");
                subjGrade4 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject5 + " Subject:");
                subjGrade5 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject6 + " Subject:");
                subjGrade6 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject7 + " Subject:");
                subjGrade7 = int.Parse(Console.ReadLine());

                Console.Write("Please enter your grade for " + mySubject8 + " Subject:");
                subjGrade8 = int.Parse(Console.ReadLine());


                subjGradeTotal = subjGrade1 + subjGrade2 + subjGrade3 + subjGrade4 + subjGrade5 + subjGrade6 + subjGrade7 + subjGrade8;

                percentage = subjectCount * 100;
                average = (subjGradeTotal / percentage) * 100;

                Console.Write("Your Final Average " + userName + " is: " + average.ToString("0.00"));
            }

            else
            {
                Console.Write("Number entered invalid!");
            }

           
        }

       
}
    }

