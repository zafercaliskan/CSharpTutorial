using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(IsPrimeNumber(i) ? $"{i} asal bir sayıdır." : $"{i} asal bir sayı değildir.");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = { "Zafer", "Süleyman", "Hasan" };


            //Dizi temelli dataların dolaşılması iterate edilmesi (ienumerable array temelli)
            foreach (var student in students)
            {
                //student = "Ali"; foreach ile döndüğümüz elemanları foreach içerisinde değiştiremeyiz.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11); //Şart sağlanmasa bile 1 defa çalışır.
        }

        private static void WhileLoop()
        {
            int number = 0;
            while (number < 100)
            {
                Console.WriteLine(number);
                number++; //Koşul olarak sayıya bakıyor. Bunu artırmaz sabit bırakırsak sonsuz döngüye girer.
            }
        }

        private static void ForLoop()
        {
            //Başlangıç değeri; Koşul; Herbir döngü bittiğinde ne yapacağımız
            for (int i = 1; i < 100; i++)
            {
                //1,2,3,4.....
                Console.WriteLine(i);
            }

            for (int j = 1; j < 100; j += 2) //j+=2 => j=j+2
            {
                //1,3,5,7.....
                Console.WriteLine(j);
            }

            for (int k = 2; k < 100; k += 2)
            {
                //2,4,6,8.....
                Console.WriteLine(k);
            }
        }
    }
}