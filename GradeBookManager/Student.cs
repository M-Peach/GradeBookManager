using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Student
    {
        public List<Assignment> assignments = new List<Assignment>();

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

                Console.WriteLine("Add Another Assignment? (Y / N)");

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
        public void DeleteAssignment()
        {
            Console.Clear();

            Console.WriteLine("Remove Assignment Menu:");

            Console.WriteLine();

            for (int i = 0; i < assignments.Count; i++)
            {
                Console.WriteLine($"ID: {i} : {assignments[i].AssignmentName}");
            }

            Console.WriteLine();

            Console.WriteLine("Enter a Student ID:");

            int userInput = int.Parse(Console.ReadLine());

            assignments.RemoveAt(userInput);
        }

        public void SelectAssignment()
        {
            Console.Clear();
            ShowAssignment();
            Console.WriteLine();
            Console.WriteLine("Enter Assignment Name:");

            string userSelection = Console.ReadLine();

            bool loop = false;


            foreach (var assignment in assignments)
            {
                if (userSelection.Equals(assignment.AssignmentName))
                {
                    assignment.AddGrade();

                    loop = false;

                    return;
                }

                else { loop = true; }

            }
        }
    }
}
