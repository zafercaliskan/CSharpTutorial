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
            //Yukarıda number1 ve number2 nin sadece değerlerini göndeririz.

            Console.WriteLine("Add2 result {0}", result);
            Console.WriteLine("number1 {0}", number1);

            //Burada number1'e bir değer ataması yapmadan gönderemeyiz.
            //ref keyword'ü ile gönderirsek method içerisinde yapılacak değişik burayıda etkiler.
            var result2 = Add3(ref number1, number2);
            Console.WriteLine("Add3 result {0}", result2);
            Console.WriteLine("ref number1 {0}", number1);

            number1 = 20;
            //Burada out'da ilk değer ataması zorunlu değildir.
            var result3 = Add4(out number1, number2);
            Console.WriteLine("Add4 result {0}", result2);
            Console.WriteLine("out number1 {0}", number1);


            var result4 = Add5(12, 22, 33, 43, 55);
            Console.WriteLine("Add5 sum: {0}", result4);
        }

        //Methodları neden kullanırız?
        //Yaptığımız bir işi heryerde tekrar tekrar yazmak yerine bir method içerisine yazarız. 
        //Bu methodu da ihtiyaç duyduğumuz yerlerden çağırırız. don't repeat yourself için methodları kullanırız. 

        //Geriye birşey döndürmez. Parametresiz method.
        static void Add()
        {
            Console.WriteLine("Add...");
        }

        //Method Overloading: Aynı isimlimli methoddan 2 tane var fakat method imzaları farklı.
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        //Geriye int döndürür. 
        static int Gather(int number1, int number2)
        {
            return number1 + number2;
        }

        //Eğer number verilmezse default olarak 1 atar. 
        static int SquareOfNumber(int number = 1)
        {
            return number * number;
        }

        //Yukarıdaki değişken ile aynı isim bile olsa bu number1 farklıdır. Sadece yukarıdan buraya değer gelir.
        static int Add2(int number1, int number2)
        {
            number1 = 30; //Burada atadğımız 30 Main içerisindeki number1'i değiştirmez.
            //Çünkü değer tipler ile çalışıyoruz. Değer tipde mevzu sadece değer ile ilgilidir.
            return number1 + number2;
        }

        //Ref keyword ile değer tiplerin referans tip gibi kullanılmasını sağlar.
        static int Add3(ref int number1, int number2)
        {
            number1 = 30; //Yukarıda main içerisindeki number1 de değiştirir çünkü 2 defa
                          //değişken tanımlamak yerine yukarıdaki değişkenin referansını kullan dedik.
            return number1 + number2;
        }

        //Out keyword 
        static int Add4(out int number1, int number2)
        {
            number1 = 30; //out ile gönderirken ilk değer set edilmesi zorunlu değil.
                          //Fakat burada değer verilmesi zorunlu vermezsek patlarız.

            return number1 + number2;
        }

        //Params ile aynı tipde methoda istediğimiz kadar parametre gönderebiliriz.
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}