using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Classroom 
    {
        public string ClassName { get; }

        //public static Dictionary<string, double> NameGrade = new Dictionary<string, double>();
        
        public List<Student> students = new List<Student>();

        public Classroom (string ClassName)
        {
            this.ClassName = ClassName;
        }
    }

}
