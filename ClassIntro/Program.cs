using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Engin Demiroğ";
            course1.ViewRate = 95;

            //Or

            Course course2 = new Course()
            {
                CourseName = "Selenium",
                Instructor = "Zafer Çalışkan",
                ViewRate = 90
            };

            Course[] courses = new Course[] { course1, course2 };

            foreach (Course course in courses) //(var course in courses) 
            {
                Console.WriteLine("Course Name:{0}\nCourse Instructor: {1}\nView Rate: {2}\n\n", course.CourseName, course.Instructor, course.ViewRate);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int ViewRate { get; set; }
    }
}