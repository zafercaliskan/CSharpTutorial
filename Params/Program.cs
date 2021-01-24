using System;
using System.Linq;

namespace Params
{
    class Program
    {
        static int Math(params int[] numbers)
        {
            return numbers.Sum();
        }
        static void Main(string[] args)
        {
            var result = Math(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Result {result}");
        }
    }
}