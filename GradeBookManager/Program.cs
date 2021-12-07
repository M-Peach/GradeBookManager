using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Program
    {
        Students students = new Students();

        Classrooms classooms = new Classrooms();

        Menu Menu = new Menu();

        public static void Main()
        {
            Menu.MainMenu();


        }

        public static void CheckSelection(int userSelection)
        {
            switch (userSelection)
            {
                case 1:
                    Classrooms.ShowClassrooms();
                    break;

                case 2:
                    Classrooms.AddClassrooms();
                    break;

                case 3:
                    Classrooms.RemoveClassrooms();
                    break;

                case 4:
                    Menu.DetailsMenu();
                    break;
            }
        }
    }
}