using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class GradedCourse : Course
    {
        private int _numericGrade;

        public int NumericGrade
        {
            get => _numericGrade;
            set
            {
                if (value !=-3 || value != 0 || value != 2 || value != 4 || value != 7 || value != 10 || value != 12)
                    _numericGrade = value;
            }
        }

        public GradedCourse(string name, int grade) : base(name)
        {
            NumericGrade = grade;
        }

        public override bool Passed() => _numericGrade >= 2;
        public override string GetGradeDetails()
    => $"Grade={NumericGrade}";
    }
}
