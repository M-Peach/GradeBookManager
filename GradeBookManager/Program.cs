using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Program
    {
        public static List<Classroom> classrooms = new List<Classroom>();

        public void Main()
        {

            MainMenu();
        }
        /// --- SWITCH STATEMENTS --- ///
        public void CheckMainSelection(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    ShowClassroom();
                    break;

                case 2:
                    AddClassroom();
                    break;

                case 3:
                    RemoveClassroom();
                    break;

                case 4:
                    ClassroomSelectionMenu();
                    break;
            }
        }

       public void CheckClassroomSelection(int userInput, Classroom classroom)
        {
            switch (userInput)
            {
                case 1:
                    ShowStudent(classroom);
                    break;

                case 2:
                    AddStudent(classroom);
                    break;

                case 3:
                    
                    break;

                case 4:
                   
                    break;
            }
        }

        /// --- CLASSROOM METHODS --- ///
        public void AddClassroom()
        {
                
                Console.Clear();
                Console.WriteLine("Enter Class Name:");

                string userInput = Console.ReadLine();

                Classroom classroom = new Classroom(userInput);

                classrooms.Add(classroom);       
        }

        public static void ShowClassroom()
        {
            Console.Clear();

            for (int i = 0; i < classrooms.Count; i++)
            {
                Console.WriteLine($"ID {i} : {classrooms[i].ClassName}");
            }
        }

        public void RemoveClassroom()
        {
            Console.Clear();

            ShowClassroom();
            Console.WriteLine();
            Console.WriteLine("To Remove a Classroom, Select an ID:");

            int userInput = int.Parse(Console.ReadLine());

            classrooms.RemoveAt(userInput);
            Console.WriteLine();
            Console.WriteLine($"Removed Classroom ID {userInput}");
        }

        public void ClassroomSelection(int userSelection)
        {
            Console.Clear();
            Console.WriteLine($"Now Editing {classrooms[userSelection].ClassName}");
            Console.WriteLine();

        }

        /// --- STUDENT METHODS --- ///

        public void AddStudent(Classroom classroom)
        {
            Student student = new Student();

            Console.Clear();

            ShowClassroom();
            Console.WriteLine();
            Console.WriteLine("Enter Classroom ID:");

            int userSelection = int.Parse(Console.ReadLine());

            Classroom selectedClassroom = classrooms[userSelection];

            Console.WriteLine("Enter Student Name:");

            string name = Console.ReadLine();

            student.Name = name;

            classroom.students.Add(student);

            Console.WriteLine(classroom.students);
                 
        }

        public void ShowStudent(Classroom classroom)
        {
            Console.Clear();

            for (int i = 0; i < classroom.students.Count; i++)
            {
                Console.WriteLine($"ID {i} : {string.Join(Environment.NewLine, classroom.students)}");
                
            }
        }

        /// --- Menus --- ///
        public void MainMenu()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Grade Manager");
                Console.WriteLine();
                Console.WriteLine("[1] Show Classrooms");
                Console.WriteLine("[2] Add Classerooms");
                Console.WriteLine("[3] Remove Classroom");
                Console.WriteLine("[4] Classroom Details");
                Console.WriteLine("[5] Exit");
                Console.WriteLine();
                Console.WriteLine("Select an option: 1 - 5");


            ERROR1:
                string userInput = Console.ReadLine();

                bool isNumber = int.TryParse(userInput, out int userSelection);

                if (isNumber == false)
                {
                    Console.WriteLine("ERROR: ENTER A VALID OPTION");
                    Console.WriteLine();
                    goto ERROR1;
                }
                else if (userSelection == 5)
                {
                    loop = false;
                    return;
                }
                else
                {
                    CheckMainSelection(userSelection);
                }

            ERROR2:
                Console.WriteLine();
                Console.WriteLine("Return to menu? (Y / N)");

                userInput = Console.ReadLine().ToUpper();

                if (userInput != "Y")
                {
                    goto ERROR2;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        public void ClassroomSelectionMenu(Classroom classroom)
        {
            Console.Clear();
            Program.ShowClassroom();
            Console.WriteLine();
            Console.WriteLine("Enter Classroom ID:");

            int userSelection = int.Parse(Console.ReadLine());

            ClassroomSelection(userSelection);
            DetailsMenu(classroom, userSelection);


        }

        public void DetailsMenu(Classroom classroom, int userSelection)
        {
            Console.WriteLine();
            Console.WriteLine("[1] Show Students");
            Console.WriteLine("[2] Add Students");
            Console.WriteLine("[3] Remove Student");
            Console.WriteLine("[4] Classroom Average");
            Console.WriteLine("[5] Show Top Student");
            Console.WriteLine("[6] Show Lowest Student");
            Console.WriteLine("[7] Compare Two Students");
            Console.WriteLine("[8] Student Details Menu");
            Console.WriteLine("[9] Return to Main Menu");
            Console.WriteLine();
            Console.WriteLine("Select an option: 1 - 9");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    ShowStudent(classroom);
                    break;

                case 2:
                    AddStudent(classroom);
                    break;

                case 3:

                    break;

                case 4:

                    break;
            }
        }
    }
}