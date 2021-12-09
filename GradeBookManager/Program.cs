using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Program
    {
        Student students = new Student();

        Classroom classooms = new Classroom();

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
                    Classroom.ShowClassrooms();
                    break;

                case 2:
                    Classroom.AddClassrooms();
                    break;

                case 3:
                    Classroom.RemoveClassrooms();
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
                    Student.ShowStudents(userSelection);
                    break;

                case 2:
                    Student.AddStudents(userSelection);
                    break;

                case 3:
                    Classroom.RemoveClassrooms();
                    break;

                case 4:
                    Menu.ClassroomSelectionMenu();
                    break;
            }
        }
    }
}