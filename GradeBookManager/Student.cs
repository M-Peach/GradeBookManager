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

            Console.WriteLine("Enter a Assignment ID:");

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

        public bool Completed()
        {
            bool r = false;
            foreach (var assignment in assignments)
            {
                bool result = assignment.IsGraded();

                if (result) { r = true; }
                else { return false; }
            }
            if (r)
            {
                return true;
            }
            return false;
        }

        public double StudentAverage()
        {
            List<double> allGrades = new List<double>();

            if(assignments.Count > 0)
            {
                Console.WriteLine("ERROR: No Grades");
                return 0;
            }

            foreach (var assignment in assignments)
            {
                allGrades.Add(assignment.ReturnGrade());
            }

            double sAvg = allGrades.Average();

            return sAvg;
        }
        public void StudentSummary(Student selectedStudent)
        {
            Console.Clear();

            int assignmentNumber = assignments.Count;
            bool complete = Completed();

            Console.WriteLine("Student Summary:");
            Console.WriteLine();
            Console.WriteLine($"Student Name: {Name}");

            Console.WriteLine($"Current Number of Assignments: {assignmentNumber}");

            if(StudentAverage() == 0)
            {
                Console.WriteLine($"Student Average : No Grades Yet!");
            }
            else
            {
                Console.WriteLine($"Student Average : {StudentAverage()}%");
            }

            Console.WriteLine($"All Assignments Completed: {complete}");

            Console.WriteLine("A '0%' may indicate a grade has not yet been added for this student.");
            Console.WriteLine("Press ENTER to continue:");
            Console.ReadLine();
            Console.Clear();
            
        }
        public void ShowTopAssignment()
        {
            Console.Clear();
            double i = 0;
            string a = null;

            foreach (var assignment in assignments)
            {
                if (assignment.ReturnGrade() > i)
                {
                    i = assignment.ReturnGrade();
                    a = assignment.AssignmentName;

                }
            }
            Console.WriteLine($"Highest Assignment Grade: {i}% on {a}");

            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
            Console.Clear();
        }
        public double TopAssignment()
        {
            double i = 0;
            string a = null;

            foreach(var assignment in assignments)
            {
                if(assignment.ReturnGrade() > i)
                {
                    i = assignment.ReturnGrade();
                }
            }
            return i;
        }

        public double LowAssignment()
        {
            double i = 900;
            string a = null;

            foreach (var assignment in assignments)
            {
                if (assignment.ReturnGrade() < i)
                {
                    i = assignment.ReturnGrade();
                }
            }
            return i;
        }
        public void ShowLowAssignment()
        {
            Console.Clear();
            double i = 900;
            string a = null;

            foreach (var assignment in assignments)
            {
                if (assignment.ReturnGrade() < i)
                {
                    i = assignment.ReturnGrade();
                    a = assignment.AssignmentName;

                }
            }
            Console.WriteLine($"Lowest Assignment Grade: {i}% on {a}");

            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
