using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var number = random.Next(8, 20);
            Console.WriteLine("Number: {0}", number);

            //if, else if, else
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 12)
            {
                Console.WriteLine("Number is 12");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 12");
            }

            //Single line if
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            //switch case
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 12:
                    Console.WriteLine("Number is 12");
                    break;

                default:
                    Console.WriteLine("Number is not 10 or 12");
                    break;
            }


            //Multiple condition

            if (number >= 10 && number <= 12)
            {
                Console.WriteLine("Number is between 10-12");
            }

            else if (number > 12 && number <= 16)
            {
                Console.WriteLine("Number is between 13-16");
            }

            else if (number > 18 || number < 10)
            {
                Console.WriteLine("Number is less than 10 or greater than 18");
            }

            else
            {
                Console.WriteLine("Else: Number is {0}", number);
            }

            //nested condition
            if (number < 18)
            {
                if (number >= 14)
                {
                    //...
                }
                else
                {
                    //...
                }

                //...
            }
        }
    }
}