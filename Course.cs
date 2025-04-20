using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
        public abstract class Course
        {
            private string _courseName;

            public string CourseName
            {
                get => _courseName;
                set => _courseName = !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ArgumentException("Course name cannot be empty");
            }

            protected Course(string name)
            {
                CourseName = name;
            }
        public abstract string GetGradeDetails();
        public abstract bool Passed();
        }
    }