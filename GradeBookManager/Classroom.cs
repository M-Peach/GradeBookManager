using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Classroom : Student
    {
        public string ClassName { get; set; }

        //public static Dictionary<string, double> NameGrade = new Dictionary<string, double>();
        
        public static List<Student> students = new List<Student>();

        public void SetClassName(string ClassName)
        {
            this.ClassName = ClassName;
        }
    }

}
