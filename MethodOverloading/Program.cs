using System;

namespace MethodOverloading
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int number1 = PlusMethod(10, 5);
            double number2 = PlusMethod(9.5, 7.23);

            Console.WriteLine($"Int: {number1} Double: {number2}");
        }
    }
}