using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class CourseManager
    {
        public void Add()
        {
            Course course = new Course();
            //Referans'a ihtiyac duymadan başka dosyada ama aynı projedeki class'a erişebilirz.
            Console.WriteLine(course.Name);
        }
    }
}