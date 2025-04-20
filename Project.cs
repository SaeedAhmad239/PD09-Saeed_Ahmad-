using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Project
    {
        private string _projectName;
        private List<Course> _courses;

        public Project(string name, Course course1, Course course2, Course course3, Course course4)
        {
            _projectName = name;
            _courses = new List<Course> { course1, course2, course3, course4 };
        }

        public bool Passed() => _courses.Count(c => c.Passed()) >= 3;

        public void DisplayProjectStatus()
        {
            Console.WriteLine($"Project: {_projectName}");

            foreach (var course in _courses)
            {
                Console.WriteLine($"- {course.CourseName}: {course.GetGradeDetails()}, Passed={course.Passed()}");
            }

            Console.WriteLine($"Overall Project Status: {(Passed() ? "PASSED" : "FAILED")}\n");
        }
    }
}
