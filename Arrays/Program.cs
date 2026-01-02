using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Zafer";
            students[1] = "Süleyman";
            students[2] = "Hasan";

            //students[3] = "Ali"; System.IndexOutOfRangeException: 'Index was outside the bounds of the array
            //index starts from 0. Since the index overflows here, we throw an exception. 
            
            //students = new string[4]; when we say this, we lose the values inside students.

            int[] numbers = { 1, 2, 3, 4 }; //We can also define it like this.

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("-------");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            // Multidimensional Arrays
            string[,] regions = new string[5, 3]
            {
                {"Istanbul","Izmit","Balikesir"},
                {"Ankara","Konya","Kirikkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"Izmir","Mugla","Manisa"}
            };

            //With GetUpperBound(0), we get the first Dimension of the array.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("-------------");
                //With GetUpperBound(1), we get the second Dimension of the array.
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.WriteLine("-------------");
        }
    }
}