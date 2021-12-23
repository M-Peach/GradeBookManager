using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class StudentArchive
    {
        public static List<Dictionary<string, double>> studentGrades = new List<Dictionary<string, double>>();

        public static void ShowStudents(int userSelection)
        {
            Console.WriteLine(studentGrades[userSelection]);
        }
        public static void AddStudents(int userSelection)
        {
            if(userSelection == 0)
            {
                Console.WriteLine("Enter Student Name:");
                string studentName = Console.ReadLine();

                Console.WriteLine("Enter Student Grade:");
                double studentGrade = double.Parse(Console.ReadLine());

                studentGrades.Add(studentName, studentGrade);
            }

    }
}
