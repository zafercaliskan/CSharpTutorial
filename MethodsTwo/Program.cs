using System;
using System.Linq;

namespace MethodsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Gather(10, 20));
            Console.WriteLine(SquareOfNumber());
            Console.WriteLine(SquareOfNumber(9));

            int number1 = 20, number2 = 100;
            var result = Add2(number1, number2);
            //Above we only send the values of number1 and number2.

            Console.WriteLine("Add2 result {0}", result);
            Console.WriteLine("number1 {0}", number1);

            //Here we cannot send without assigning a value to number1.
            //If we send with ref keyword, the change made inside the method affects here as well.
            var result2 = Add3(ref number1, number2);
            Console.WriteLine("Add3 result {0}", result2);
            Console.WriteLine("ref number1 {0}", number1);

            number1 = 20;
            //Here default value assignment is not mandatory in out.
            var result3 = Add4(out number1, number2);
            Console.WriteLine("Add4 result {0}", result2);
            Console.WriteLine("out number1 {0}", number1);


            var result4 = Add5(12, 22, 33, 43, 55);
            Console.WriteLine("Add5 sum: {0}", result4);
        }

        //Why do we use methods?
        //Instead of writing a job we do everywhere repeatedly, we write it inside a method. 
        //We call this method from where we need it. We use methods for DON'T REPEAT YOURSELF (DRY). 

        //Does not return anything. Parameterless method.
        static void Add()
        {
            Console.WriteLine("Add...");
        }

        //Method Overloading: There are 2 methods with the same name but method signatures are different.
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        //Returns int. 
        static int Gather(int number1, int number2)
        {
            return number1 + number2;
        }

        //If number is not given, it assigns 1 by default. 
        static int SquareOfNumber(int number = 1)
        {
            return number * number;
        }

        //Even if it has the same name as the variable above, this number1 is different. Only value comes here from above.
        static int Add2(int number1, int number2)
        {
            number1 = 30; //The 30 we assigned here does not change number1 inside Main.
            //Because we are working with value types. In value types, the issue is only about value.
            return number1 + number2;
        }

        //With Ref keyword, it ensures usage of value types as reference types.
        static int Add3(ref int number1, int number2)
        {
            number1 = 30; //It changes number1 in main above because
                          //we said use the reference of the variable above instead of defining variable 2 times.
            return number1 + number2;
        }

        //Out keyword 
        static int Add4(out int number1, int number2)
        {
            number1 = 30; //setting initial value is not mandatory while sending with out.
                          //But giving value here is mandatory, if we don't we explode.

            return number1 + number2;
        }

        //With Params we can send as many parameters as we want to the method of the same type.
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}