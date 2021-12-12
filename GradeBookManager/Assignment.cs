using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookManager
{
    public class Assignment
    {
        public string AssignmentName { get; set; }

        public static List<Assignment> assignmentGrades = new List<Assignment>();

        public Assignment()
        {
            assignmentGrades = new List<Assignment>();
        }

    }
}
