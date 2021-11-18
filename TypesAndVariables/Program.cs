using System;

namespace TypesAndVariables
{
    class Program
    {
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            //Value Types
            //byte	8-bit unsigned integer	0 to 255
            byte byteNumberMin = 0, byteNumberMax = 255;
            Console.WriteLine("byte is min: {0}, byte is max {1}", byteNumberMin, byteNumberMax);

            //sbyte	8-bit signed integer	-128 to 127
            sbyte sByteNumberMin = -128, sByteNumberMax = 127;
            Console.WriteLine("sbyte is min: {0}, sbyte is max {1}", sByteNumberMin, sByteNumberMax);

            //short	16-bit signed integer	-32,768 to 32,767
            short shortNumberMin = -32768, shortNumberMax = 32767;
            Console.WriteLine("short is min: {0}, short is max {1}", shortNumberMin, shortNumberMax);

            //ushort	16-bit unsigned integer	0 to 65,535
            ushort uShortNumberMin = 0, uShortNumberMax = 65535;
            Console.WriteLine("ushort is min: {0}, ushort is max {1}", uShortNumberMin, uShortNumberMax);

            //int - 123 veya -123 gibi tam sayıları ondalık olmadan saklar. (32-bit signed integer -2,147,483,648 to 2,147,483,647)
            int intNumberMin = -2147483648, intNumberMax = 2147483647;
            Console.WriteLine("int is min: {0}, int is max {1}", intNumberMin, intNumberMax);

            //uint pozitif tam sayıları ondalık olmadan saklar.	(32-bit unsigned integer 0 to 4,294,967,295)
            uint uIntNumberMin = 0, uIntNumberMax = 4294967295;
            Console.WriteLine("uint is min: {0}, uint is max {1}", uIntNumberMin, uIntNumberMax);

            //long	64-bit signed integer	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long longNumberMin = -9223372036854775808, longNumberMax = 9223372036854775807;
            Console.WriteLine("long is min: {0}, long is max {1}", longNumberMin, longNumberMax);

            //ulong	64-bit unsigned integer	0 to 18,446,744,073,709,551,615	
            ulong uLongNumberMin = 0, uLongNumberMax = 18446744073709551615;
            Console.WriteLine("ulong is min: {0}, ulong is max {1}", uLongNumberMin, uLongNumberMax);

            //float	32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38

            //double	64-bit double-precision -1.79769313486232e308 to 1.79769313486232e308 gibi ondalıklı sayıları saklar
            double doubleNumber = 10.4;  //Virgülden sonra 15 16 tane değer tutabilir.
            Console.WriteLine("double is {0}", doubleNumber);

            //decimal	128-bit decimal type finansal ve parasal hesaplamalar için	
            decimal decimalNumber = 10.4M; //Virgülden sonra 28 29 tane değer tutabilir.
            Console.WriteLine("decimal is {0}", decimalNumber);

            //char	16-bit single Unicode character. 'a' veya 'B' gibi tek karakterleri saklar. Karakter değerleri tek tırnak içine alınır
            char character = 'A';
            Console.WriteLine("char is {0}", character);

            //string	Unicode karakter dizisi 
            string characters = "Abc"; //gibi metinleri saklar. Dize değerleri çift tırnak içine alınır.
            Console.WriteLine("Characters is {0}", characters);

            //bool	8-bit mantıksal true/false value (Doğru veya yanlış)
            bool condition = true;
            Console.WriteLine("Condition is {0}", condition);

            //enum
            Console.WriteLine("Day: {0}", Days.Friday);
            Console.WriteLine("Day number: {0}", (int)Days.Friday);
        }
    }
}