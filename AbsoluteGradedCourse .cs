using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class AbsoluteGradedCourse : Course
    {
        private int _marks;
        private char _letterGrade;

        public int Marks
        {
            get => _marks;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Marks must be between 0-100");

                _marks = value;
                _letterGrade = CalculateLetterGrade(value);
            }
        }

        public char LetterGrade => _letterGrade;

        public AbsoluteGradedCourse(string name, int marks) : base(name)
        {
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

        public override bool Passed() => _letterGrade != 'F';
        public override string GetGradeDetails()
    => $"Marks={Marks}, Grade={LetterGrade}";
    }
}
