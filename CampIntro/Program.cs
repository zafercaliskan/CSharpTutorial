using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety
            //Do not reapet yourself

            string categoryLabel = "Category Label";
            Console.WriteLine(categoryLabel);

            double dollarYesterday = 7.55, dollarToday = 7.35;

            bool loggedIntoTheSystem = true;

            if (dollarYesterday > dollarToday)
            {
                Console.WriteLine("Decrease");
            }
            else if (dollarYesterday < dollarToday)
            {
                Console.WriteLine("Increase");
            }
            else
            {
                Console.WriteLine("constant");
            }

            if (loggedIntoTheSystem) //loggedIntoTheSystem == true
            {
                Console.WriteLine("Dashboard");
            }
            else
            {
                Console.WriteLine("Login screen");
            }
        }
    }
}