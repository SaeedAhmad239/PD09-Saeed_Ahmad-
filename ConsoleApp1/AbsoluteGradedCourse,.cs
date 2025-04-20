using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbsoluteGradedCourse
    {
        private string courseName;
        private int marks;
        private char letterGrade;

        public string CourseName
        {
            get => courseName;
            set => courseName = value;
        }

        public int Marks
        {
            get => marks;
            set
            {
                marks = value;
                // Automatically calculate letter grade when marks are set
                letterGrade = CalculateLetterGrade(value);
            }
        }

        public char LetterGrade
        {
            get => letterGrade;
            private set => letterGrade = value;
        }

        public AbsoluteGradedCourse(string name, int marks)
        {
            CourseName = name;
            Marks = marks;
        }

        private char CalculateLetterGrade(int marks)
        {
            var gradeRanges = new Dictionary<Func<int, bool>, char>
            {
                [m => m >= 90] = 'A',
                [m => m >= 80] = 'A',
                [m => m >= 70] = 'B',
                [m => m >= 60] = 'C',
                [m => m >= 50] = 'D',
                [m => m >= 0] = 'F'
            };

            foreach (var range in gradeRanges)
            {
                if (range.Key(marks))
                    return range.Value;
            }

            throw new ArgumentOutOfRangeException(nameof(marks), "Invalid marks value");
        }

        public bool Passed()
        {
            return letterGrade != 'F';
        }
    }
}
