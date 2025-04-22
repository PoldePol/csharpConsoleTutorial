using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpConsoleTutorial
{
    internal class Task2Student
    {
        public class Subject
        {
            public string Name { get; set; }
            public double Grade { get; set; }

            public Subject(string name, double grade)
            {
                Name = name;
                Grade = grade;
            }

        }

        public class student
        {
            public string Name { get; set; }
            public List<Subject> Subjects { get; set; }

            public student(string name)
            {
                Name = name;
                Subjects = new List<Subject>();
            }

            public void addSubject(Subject subject)
            {
                Subjects.Add(subject);
            }

            public double CalculateAverage()
            {
                double total = 0;
                foreach (var subject in Subjects)
                {
                    total += subject.Grade;
                }
                return Subjects.Count > 0 ? total / Subjects.Count : 0;
            }

            public void PrintReport()
            {
                Console.WriteLine($"Student Grade report for {Name}");
                foreach (var subject in Subjects)
                {
                    Console.WriteLine($"- {subject.Name}: {subject.Grade}");
                }
                Console.WriteLine($"Average Grade: {CalculateAverage():F2}");
            }
        }
    }
}
