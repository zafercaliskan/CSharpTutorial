using System;
using System.Collections.Generic;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            //CustomRecordNotFoundException();

            //ActionDemo();

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3, 5));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            //Method gönderiyoruz delegeler yardımıyla.
            //HandleException(() =>  //'()'-> Parametresiz method göndereceğim.'=>' -> karşılığıda ( => bunada lamda denir) '{}' -> kod kümesi
            //{
            //    Find();
            //}); //Burada yukarıdaki try catch yerine bunu yazmış olduk. Birden çok catch artarsa
            //Yönetilemez olur heryere yazmak. 5-6 tane catch olursa örneğin.

            HandleException(() =>
            {
                Find(); //Methodu merkezi bir try catch içine göndermiş oluyoruz.
            });
        }

        private static void CustomRecordNotFoundException()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        //Burası genellikle merkezi bir class içerisine koyarız oradan direk çalıştırırız.
        //Veya class'ımızı temel bir class yapıp bunu onun içerisine koyarız. Bütün sınıflarıda ondan inherit ederiz. Kullanabiliriz.
        private static void HandleException(Action action) //Birkere yazacağımız bir kod bloğu...
                                                           //Action parametresiz kod blogu demek. Void operasyonlar için kullanılır. herhangi bir return ifadesi göndermez.
        {
            try
            {
                action.Invoke(); //Parametre olarak gelen methodu çalıştır demek. Try içerisinde çalıştırmış olur.
                //Yani methodumuzu merkezi bir try catch içerisine göndermiş olduk.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>() { "Zafer", "Süleyman", "Hasan" };

            if (!students.Contains("Zafer2"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Zafer", "Süleyman", "Ali" };
                students[3] = "Ahmet";
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception) //Aldığın hatanın türü buysa bunu yap.
            {
                Console.WriteLine(exception.Message);
            }
            //Bütün exceptionların temeli base'i exceptiondır. Buna tüm exceptionlar uyar. Yukarıdakilere uyan bir hata değilse burası çalışır.
            catch (Exception exception) //Burada hata olduğunda o hata bilgisi exception diye bir nesneye aktarılıyor.
            {
                //Hata bilgisini uygulama hata verdiğinde son kullanıcıya göstermeyiz.
                //Örneğin sqlde bağlantı problemi olduğunda connectionstring gibi yada başka önemli bilgileri son kullanıcıya göstermeye neden olabilir.
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); //Burada daha detaylı hata bilgisi verebilir.
                //Bunu son kullanıcıya göstermek yerine dbye yada başka yere loglarız. 
            }
        }
    }
}