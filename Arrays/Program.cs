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
            //index 0 dan başlar.Burada index taştığı için patlarız. 

            //students = new string[4]; dediğimizde ise students içerisindeki değerleri kaybederiz.

            int[] numbers = { 1, 2, 3, 4 }; //Şeklinde de tanımlama yapabiliriz.

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
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            //GetUpperBound ile dizinin ilk Dimension'ı (boyutunu) alırız
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("-------------");
                //GetUpperBound ile dizinin ikinci Dimension'ı (boyutunu) alırız
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.WriteLine("-------------");
        }
    }
}