using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class ClassroomArchive
    {
        public static List<string> classrooms00 = new List<string>();

        public static void ShowClassrooms()
        {
            for (int i = 0; i < classrooms.Count; i++)
            {
                Console.WriteLine($"Classroom {i } - {string.Join(System.Environment.NewLine, classrooms)}");
            }
        }


        public static void AddClassrooms()
        {
            Console.Clear();
            Console.WriteLine("Enter Class Name:");

            string userInput = Console.ReadLine();

            classrooms.Add(userInput);
        }

        public static void RemoveClassrooms()
        {
            Console.Clear();
            ShowClassrooms();
            Console.WriteLine();
            Console.WriteLine("Select a Classroom to remove:");

            int userInput = int.Parse(Console.ReadLine());

            classrooms.RemoveAt(userInput);
        }

        public static void EditClassroom(int userSelection)
        {
            Console.Clear();
            Console.WriteLine($"Editing: {classrooms[userSelection]}");
            Console.WriteLine();

            Menu.DetailsMenu(userSelection);
        }
    }
}