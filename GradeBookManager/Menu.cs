using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Menu
    {
        public List<Classroom> classrooms { get; set; }

        public Menu()
        {
            classrooms = new List<Classroom>();
        }

        public void MainMenu()
        {
            bool loop = true;

            while (loop)
            {
                ERROR1:
                Console.Clear();
                Console.WriteLine("Grade Manager");
                Console.WriteLine();
                Console.WriteLine("[1] Show Classrooms");
                Console.WriteLine("[2] Add Classerooms");
                Console.WriteLine("[3] Remove Classroom");
                Console.WriteLine("[4] Classroom Details");
                Console.WriteLine("[5] Exit");
                Console.WriteLine();
                Console.WriteLine("Select an option: 1 - 5");

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

                Console.WriteLine();
                Console.WriteLine("Press ENTER to Continue:");
                Console.ReadLine();
            }
        }

        public void ClassroomSelectionMenu()
        {
            Console.Clear();
            ShowClassroom();
            Console.WriteLine();
            Console.WriteLine("Enter Classroom Name:");

            string userSelection = Console.ReadLine();
            var selectedClass = new Classroom();

            bool loop = false;


                foreach (var classroom in classrooms)
                {
                    if (userSelection.Equals(classroom.ClassName))
                    {
                        selectedClass = classroom;

                        DetailsMenu(selectedClass);

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

        public void DetailsMenu(Classroom selectedClass)
        {
            Console.Clear();
            bool loop = true;
            while (loop = true)
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
                Console.WriteLine("[0] Return to Main Menu");
                Console.WriteLine();
                Console.WriteLine("Select an option: 0 - 8");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        selectedClass.ShowStudent();
                        break;

                    case 2:
                        selectedClass.AddStudent();
                        break;

                    case 3:
                        selectedClass.RemoveStudent();
                        break;

                    case 4:
                        selectedClass.ClassAverage();
                        break;

                    case 5:
                        selectedClass.TopStudent();
                        break;

                    case 6:
                        selectedClass.LowStudent();
                        break;

                    case 7:
                        selectedClass.StudentCompare();
                        break;

                    case 8:
                        selectedClass.StudentSelectionMenu();
                        break;

                    case 9:
                        Credits();
                        break;

                    case 0:
                        loop = false;
                        return;
                        break;

                }
            }
        }
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

        public void Credits()
        {
            Console.WriteLine("Press ENTER:");
            Console.ReadLine();
            Console.WriteLine("Console App - GradeBookManager by:");
            Console.ReadLine();
            Console.WriteLine("Mike Peachman");
            Console.ReadLine();
            Console.WriteLine("Claim Academy 2021");
            Console.ReadLine();
            Console.WriteLine("What else do you want from me?");
            Console.ReadLine();
            Console.WriteLine("I have nothing left to say.");
            Console.ReadLine();
            Console.WriteLine("Alright enough");
            Console.ReadLine();
            Console.WriteLine("Oh wait...");
            Console.ReadLine();
            Console.WriteLine("I bet you want to go back to the main menu huh?");
            Console.ReadLine();
            Console.WriteLine("My bad.");
            Console.ReadLine();
            Console.WriteLine("Here you go:");
            Console.ReadLine();
        }

        /// \\\ CLASSROOM METHODS \\\ ///

        public void AddClassroom()
        {

            Console.Clear();
            Console.WriteLine("Enter Class Name:");

            string userInput = Console.ReadLine();

            Classroom classroom = new Classroom();

            classroom.ClassName = userInput;

            classrooms.Add(classroom);
        }

        public void ShowClassroom()
        {
            Console.Clear();

            for (int i = 0; i < classrooms.Count; i++)
            {
                Console.WriteLine($"Classroom Name: {classrooms[i].ClassName}");
            }
        }

        public void RemoveClassroom()
        {
            Console.Clear();

            ShowClassroom();
            Console.WriteLine();
            Console.WriteLine("Type the Name of the Classroom to Remove:");

            string userInput = Console.ReadLine();

            for (var i = 0;i < classrooms.Count; i++)
            {
                if (classrooms[i].Equals(userInput))
                {
                    classrooms.RemoveAt(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Removed Classroom {userInput}");
        }
    }
}
