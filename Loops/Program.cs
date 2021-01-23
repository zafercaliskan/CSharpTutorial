using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string course2 = "Programlamaya başlangıç için temel kurs";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);

            //Array
            string[] courses = new string[] { course1, "Programlamaya başlangıç için temel kurs", "Java", "Python", "C#" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("-----");

            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("-----");
        }
    }
}
