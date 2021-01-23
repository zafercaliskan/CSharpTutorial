using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Berkay", "Zafer" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //names = new string[4];
            //names[3] = "İlker";
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[0]);

            List<string> names = new List<string>
            {
                "Engin",
                "Berkay",
                "Zafer",
                "İlker"
            };
            Console.WriteLine($"{names[0]}\n{names[1]}\n{names[2]}\n{names[3]}\n");
        }
    }
}
