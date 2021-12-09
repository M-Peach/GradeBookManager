using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Student
    {
        public static List<Assignment> assignments = new List<Assignment>();

        public string assignment { get; set; }



        public static Dictionary<string, double> NameGrade = new Dictionary<string, double>();

        public string name { get; set; }

        public double grade { get; set; }


    }
}
