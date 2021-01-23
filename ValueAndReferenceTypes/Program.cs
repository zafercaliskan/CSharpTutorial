using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Value Type (int, decimal, float, double, bool) 
             * A data type is a value type if it holds a data value within its own memory space. 
             * It means the variables of these data types directly contain values. */
            int number1 = 10, number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1 -> 30

            /* Reference Type (array, class, abstract class, interface)
             * Unlike value types, a reference type doesn't store its value directly. 
             * Instead, it stores the address where the value is being stored. 
             * In other words, a reference type contains a pointer to another memory location that holds the data. */
            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0] -> 999
        }
    }
}