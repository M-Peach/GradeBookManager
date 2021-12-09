using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Program
    {
        StudentArchive students = new StudentArchive();

        ClassroomArchive classooms = new ClassroomArchive();

        Menu Menu = new Menu();

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
                    ClassroomArchive.ShowClassrooms();
                    break;

                case 2:
                    AddClassroom();
                    break;

                case 3:
                    ClassroomArchive.RemoveClassrooms();
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
                    StudentArchive.ShowStudents(userSelection);
                    break;

                case 2:
                    StudentArchive.AddStudents(userSelection);
                    break;

                case 3:
                    ClassroomArchive.RemoveClassrooms();
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

            foreach (Classroom classroom in classrooms)
            {
                Console.WriteLine(classroom.ClassName);
            }
        }
    }
}