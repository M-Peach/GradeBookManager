using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    internal class Menu
    {
        public static void MainMenu()
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
                    Program.CheckMainSelection(userSelection);
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

        public static void ClassroomSelectionMenu()
        {
            Console.Clear();
            Classroom.ShowClassrooms();
            Console.WriteLine();
            Console.WriteLine("Enter Classroom Number:");

            int userSelection = int.Parse(Console.ReadLine());

            Classroom.EditClassroom(userSelection);
        }

        public static void DetailsMenu(int userSelection)
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

            Program.CheckClassroomSelection(userInput, userSelection);

        }
    }
}
