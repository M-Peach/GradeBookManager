using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Assignment
    {
        public string AssignmentName { get; set; }

        public List<AssignmentGrade> assignmentGrades = new List<AssignmentGrade>();

        public Assignment()
        {
           assignmentGrades = new List<AssignmentGrade>();
        }

        public void AddGrade()
        {
            AssignmentGrade gradeNumber = new AssignmentGrade();

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine($"Enter Assignment Grade:");

            double value = double.Parse(Console.ReadLine());

            gradeNumber.Grade = value;

            assignmentGrades.Add(gradeNumber);

            Console.WriteLine();

            Console.WriteLine($"Added: {gradeNumber}% to {AssignmentName}");

            Console.WriteLine();

        }

        public void ShowGrade()
        {
            Console.Clear();

            foreach (AssignmentGrade grade in assignmentGrades)
            {
                Console.WriteLine(grade.Grade);
            }
        }
    }
}
