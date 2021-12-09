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

        public static void Main()
        {
            Menu.MainMenu();


        }

        public static void CheckMainSelection(int userSelection)
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
                    Menu.ClassroomSelectionMenu();
                    break;
            }
        }

       public static void CheckClassroomSelection(int userInput, int userSelection)
        {
            switch (userInput)
            {
                case 1:
                    ShowStudent();
                    break;

                case 2:
                    AddStudent(userSelection);
                    break;

                case 3:
                    
                    break;

                case 4:
                    Menu.ClassroomSelectionMenu();
                    break;
            }
        }

        /// --- CLASSROOM METHODS --- ///
        public static void AddClassroom()
        {
            Classroom classroom = new Classroom();

            Console.Clear();
            Console.WriteLine("Enter Class Name:");

            string userInput = Console.ReadLine();

            classroom.ClassName = userInput;

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

        public static void RemoveClassroom()
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

        public static void ClassroomSelection(int userSelection)
        {
            Console.Clear();
            Console.WriteLine($"Now Editing {classrooms[userSelection].ClassName}");
            Console.WriteLine();
            Menu.DetailsMenu(userSelection);

        }

        /// --- STUDENT METHODS --- ///
        
        public static void AddStudent(int userSelection)
        {
            Student student = new Student();

            Classroom classroom =  Classroom(student);

            Console.Clear();



                Console.WriteLine("Enter Student Name:");

                string name = Console.ReadLine();

                student.Name = name;

                Console.WriteLine("Enter Student Grade:");

                double grade = double.Parse(Console.ReadLine());

                student.Grade = grade;


                Classroom.NameGrade.Add(student.Name, student.Grade);
            
            

        }

        public static void ShowStudent()
        {
            Console.Clear();

            for (int i = 0; i < Classroom.NameGrade.Count; i++)
            {
                Console.WriteLine($"ID {i} : {string.Join(Environment.NewLine, Classroom.NameGrade)}");
            }
        }


    }
}