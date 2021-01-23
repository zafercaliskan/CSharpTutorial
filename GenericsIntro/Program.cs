using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Zafer");

            Console.WriteLine($"Length: {names.Length}\n--------");
            names.Add("Onur");

            foreach (var name in names.Items)
            {
                Console.WriteLine($"Name: {name}");
            }
        }
    }
}