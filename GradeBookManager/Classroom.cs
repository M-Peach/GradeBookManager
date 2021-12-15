using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Classroom 
    {
        public string ClassName { get; set; }


        public List<Student> students = new List<Student>();

        public Classroom ()
        {
            students = new List<Student>();
        }

        public void AddStudent()
        {
            bool loop;

            while (loop = true)
            {
                Student student = new Student();

                Console.Clear();

                ShowStudent();

                Console.WriteLine();

                Console.WriteLine("Enter Student Name:");

                string name = Console.ReadLine();

                student.Name = name;

                students.Add(student);

                Console.WriteLine();

                Console.WriteLine($"Added: {student} to {ClassName}");

                Console.WriteLine();

                Console.WriteLine("Add Another Student? (Y / N)");

                string userInput = Console.ReadLine().ToUpper();

                if(userInput == "Y")
                {
                    loop = false;
                }
                else { return; }
            }

        }

        public void ShowStudent()
        {
            Console.Clear();

            foreach(Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void RemoveStudent()
        {
            Console.Clear ();

            Console.WriteLine("Remove Student Menu:");

            Console.WriteLine();

            Console.WriteLine("Enter a Student ID:");

            string userInput = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Equals(userInput))
                {
                    students.RemoveAt(i);
                }
            }

            Console.WriteLine($"Removed {userInput}");
        }

        public void StudentSelectionMenu()
        {
            Console.Clear();
            ShowStudent();
            Console.WriteLine();
            Console.WriteLine("Enter Student Name:");

            string userSelection = Console.ReadLine();

            bool loop = false;

            Student selectedStudent = new Student();

            foreach (var student in students)
            {
                if (userSelection.Equals(student.Name))
                {
                    selectedStudent = student;

                    loop = false;

                    StudentDetailsMenu(selectedStudent);

                    return;
                }

                else { loop = true; }


            }

            if (loop == true)
            {
                Console.WriteLine("ERROR");
            }
        }

        public void StudentDetailsMenu(Student selectedStudent)
        {
            Console.Clear();
            bool loop = true;
            while (loop = true)
            {
                Console.WriteLine();
                Console.WriteLine("[1] Student Summary");
                Console.WriteLine("[2] Add Assignment");
                Console.WriteLine("[3] Delete Assignment");
                Console.WriteLine("[4] Show Assignments");
                Console.WriteLine("[5] Add Grade to Assignment");
                Console.WriteLine("[6] Show Top Assignment Grade");
                Console.WriteLine("[7] Show Lowest Assingment Grade");
                Console.WriteLine("[0] Exit");
                Console.WriteLine();
                Console.WriteLine("Select a valid option:");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        selectedStudent.StudentSummary(selectedStudent);
                        break;

                    case 2:
                        selectedStudent.AddAssignment();
                        break;

                    case 3:
                        selectedStudent.DeleteAssignment();
                        break;

                    case 4:
                        selectedStudent.ShowAssignment();
                        break;

                    case 5:
                        selectedStudent.SelectAssignment();
                        break;

                    case 6:
                        selectedStudent.ShowTopAssignment();
                        break;

                    case 7:
                        selectedStudent.ShowLowAssignment();
                        break;

                    case 0:
                        loop = false;
                        return;
                }
            }
        }

        public void ClassAverage()
        {
            Console.Clear();
            List<double> allstudents = new List<double>();
            foreach (var student in students)
            {
                allstudents.Add(student.StudentAverage());
            }

            double sAvg =  allstudents.Average();

            Console.WriteLine($"Classroom Average: {sAvg}%");

            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
            Console.Clear();
        }

        public void TopStudent()
        {
            Console.Clear();
            double i = 0;
            string a = null;
            double ii = 0;
            string aa = null;

            foreach (var student in students)
            {
                if (student.TopAssignment() > i)
                {
                    i = student.TopAssignment();
                    a = student.Name;

                }
            }
            Console.WriteLine($"Highest Assignment Grade: {i}% on {a}");
            Console.WriteLine();

            foreach (var student in students)
            {
                if (student.StudentAverage() > i)
                {
                    ii = student.StudentAverage();
                    aa = student.Name;

                }
            }

            Console.WriteLine($"Highest Average Grade: {ii}% : {aa}");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
            Console.Clear();
        }
        public void LowStudent()
        {
            Console.Clear();
            double i = 900;
            string a = null;
            double ii = 900;
            string aa = null;

            foreach (var student in students)
            {
                if (student.LowAssignment() < i)
                {
                    i = student.LowAssignment();
                    a = student.Name;

                }
            }
            Console.WriteLine($"Lowest Assignment Grade: {i}% on {a}");
            Console.WriteLine();

            foreach (var student in students)
            {
                if (student.StudentAverage() < i)
                {
                    ii = student.StudentAverage();
                    aa = student.Name;

                }
            }

            Console.WriteLine($"Lowest Average Grade: {ii}% : {aa}");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
            Console.Clear();
        }

        public void StudentCompare()
        {
            Console.Clear();
            ShowStudent();

            double s1 = 0;
            double s2 = 0;
            string s11 = null;
            string s22 = null;

            Console.WriteLine("Enter the Name of the First Student:");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Enter the Name of the Second Student:");
            string userInput2 = Console.ReadLine();

            foreach(var student in students)
            {
                if (student.Name.Equals(userInput1))
                {
                    s1 = student.StudentAverage();
                    s11 = student.Name;
                }
                if (student.Name.Equals(userInput2))
                {
                    s2 = student.StudentAverage();
                    s22 = student.Name; 
                }
            }

            if(s1 > s2)
            {
                Console.WriteLine($"{s11} has a higher average.");
                Console.WriteLine();
                Console.WriteLine($"{s11} : {s1}%");
                Console.WriteLine($"{s22} : {s2}%");
            }
            else
            {
                Console.WriteLine($"{s22} has a higher average.");
                Console.WriteLine();
                Console.WriteLine($"{s22} : {s2}%");
                Console.WriteLine($"{s11} : {s1}%");
            }

        }
    }
}
