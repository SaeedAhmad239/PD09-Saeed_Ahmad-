
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GradedCourse
    {
        private string courseName;
        private int numericGrade;

        public string CourseName
        {
            get => courseName;
            set => courseName = value;
        }

        public int NumericGrade
        {
            get => numericGrade;
            set
            {
                if (value == 12 || value ==  10 || value == 7 || value == 4 || value == 2 || value == 0 || value == -3)
                    numericGrade = value;
                else
                    throw new ArgumentException("Invalid grade. Must be one of: 12, 10, 7, 4, 2, 0, -3");
            }
        }

        public GradedCourse(string name, int grade)
        {
            CourseName = name;
            NumericGrade = grade;
        }

        public bool Passed()
        {
            return numericGrade >= 2;
        }
    }
}
