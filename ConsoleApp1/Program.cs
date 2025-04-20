using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Project 1: Software Development Project
            var project1 = new Project(
                "Software Development Project",
                new AbsoluteGradedCourse("Software Engineering", 85),
                new AbsoluteGradedCourse("Database Management", 75),
                new GradedCourse("Programming Fundamentals", 10),
                new GradedCourse("Algorithms and Data Structures", 7)
            );

            // Project 2: Research Project
            var project2 = new Project(
                "Research Project",
                new AbsoluteGradedCourse("Research Methods", 70),
                new AbsoluteGradedCourse("Literature Review", 80),
                new GradedCourse("Statistical Analysis", 12),
                new GradedCourse("Research Findings Presentation", 10)
            );

            // Display results
            project1.DisplayProjectStatus();
            project2.DisplayProjectStatus();
        }
    }
}
