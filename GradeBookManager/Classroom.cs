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

            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine ($"ID: {i} : {students[i].Name}");
            }

            Console.WriteLine();

            Console.WriteLine("Enter a Student ID:");

            int userInput = int.Parse(Console.ReadLine());

            students.RemoveAt(userInput);
        }

        public void ClassroomSelectionMenu()
        {
            Console.Clear();
            ShowStudent();
            Console.WriteLine();
            Console.WriteLine("Enter Student Name:");

            string userSelection = Console.ReadLine();
            var selectedStudent = new Student();

            bool loop = false;


            foreach (var student in students)
            {
                if (userSelection.Equals(student.Name))
                {
                    selectedStudent = student;

                    DetailsMenu(student);

                    loop = false;

                    return;
                }

                else { loop = true; }
            }

            if (loop == true)
            {
                Console.WriteLine("ERROR");
            }
        }

        public void DetailsMenu(Student student)
        {
            Console.WriteLine();
            Console.WriteLine("[1] Student Summary");
            Console.WriteLine("[2] Add Assignment");
            Console.WriteLine("[3] Delete Assignment");
            Console.WriteLine("[4] Show Assignments");
            Console.WriteLine("[5] Add Grade to Assignment");
            Console.WriteLine("[6] Show Top Assignment Grade");
            Console.WriteLine("[7] Show Lowest Assingment Grade");
            Console.WriteLine("[9] Exit");
            Console.WriteLine();
            Console.WriteLine("Select a valid option:");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:

                    break;

                case 2:

                    break;
            }
        }
    }
}
