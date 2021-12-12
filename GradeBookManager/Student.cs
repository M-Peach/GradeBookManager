using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Student
    {
        public static List<Assignment> assignments = new List<Assignment>();

        public Student()
        {
            assignments = new List<Assignment>();
        }
        public string Name { get; set; }

        public void AddAssignment()
        {
            bool loop;

            while (loop = true)
            {
                Assignment assignment = new Assignment();

                Console.Clear();

                ShowAssignment();

                Console.WriteLine();

                Console.WriteLine("Enter Assignment Name:");

                string name = Console.ReadLine();

                assignment.AssignmentName = name;

                assignments.Add(assignment);

                Console.WriteLine();

                Console.WriteLine($"Added: {assignment} to {Name}");

                Console.WriteLine();

                Console.WriteLine("Add Another Student? (Y / N)");

                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    loop = false;
                }
                else { return; }
            }
        }
            public void ShowAssignment()
            {
                Console.Clear();

                foreach (Assignment assignment in assignments)
                {
                    Console.WriteLine(assignment.AssignmentName);
                }
            }
        



        /*public static List<Assignment> assignments = new List<Assignment>();

       // public string assignment { get; set; }


        public string Name { get; set; }

        public double Grade { get; set; }
        

        public string Name { get; set; }

        public void StudentName(string Name)
        {
            this.Name = Name;   
        }

        */

    }
}
