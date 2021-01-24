using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10; //required (ref)
            int number2 = 50;
            int number3; //not required (out)


            var result = math(ref number1, number2);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Number1: {number1}");

            Console.WriteLine("--------------------");

            var result2 = math2(out number3, number2);
            Console.WriteLine($"Result: {result2}");
            Console.WriteLine($"Number3: {number3}");

        }
        static int math(ref int number1, int number2)
        {
            number1 += 5;
            //number1 += 5; //not required
            return number1 + number2;
        }
        static int math2(out int number3, int number2)
        {
            //required
            number3 = 5;
            return number3 + number2;
        }
    }
}