using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Project
    {
        private string projectName;
        private AbsoluteGradedCourse[] absoluteCourses;
        private GradedCourse[] gradedCourses;

        public Project(string name, AbsoluteGradedCourse course1, AbsoluteGradedCourse course2,
                      GradedCourse course3, GradedCourse course4)
        {
            projectName = name;
            absoluteCourses = new AbsoluteGradedCourse[] { course1, course2 };
            gradedCourses = new GradedCourse[] { course3, course4 };
        }

        public bool Passed()
        {
            int passedCount = 0;

            foreach (var course in absoluteCourses)
            {
                if (course.Passed()) passedCount++;
            }

            foreach (var course in gradedCourses)
            {
                if (course.Passed()) passedCount++;
            }

            return passedCount >= 3;
        }

        public void DisplayProjectStatus()
        {
            Console.WriteLine($"Project: {projectName}");
            Console.WriteLine("Absolute Graded Courses:");
            foreach (var course in absoluteCourses)
            {
                Console.WriteLine($"- {course.CourseName}: Marks={course.Marks}, Grade={course.LetterGrade}, Passed={course.Passed()}");
            }

            Console.WriteLine("Graded Courses:");
            foreach (var course in gradedCourses)
            {
                Console.WriteLine($"- {course.CourseName}: Grade={course.NumericGrade}, Passed={course.Passed()}");
            }

            Console.WriteLine($"Overall Project Status: {(Passed() ? "PASSED" : "FAILED")}\n");
        }
    }
}
