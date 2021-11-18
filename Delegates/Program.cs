using System;

namespace Delegates
{

    public delegate void MyDelegate(); //Elçilik.
    //Bir delegate'den birden fazla benzer işleri yapan delegate yani elçi oluşturabiliriz.

    public delegate void MyDelegate2(string text); //string parametre alan methodlara elçilik yapar.

    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }

        private static void Intro()
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //Yukarıdaki formatta çalışan özel bir elçi.
            MyDelegate myDelegate = customerManager.SendMessage; //Bu elçi customerManager.SendMessage'ına delege edilmiş.
            //Burada görev verildi ama görevini yerine getir denilmedi.

            myDelegate += customerManager.ShowAlert; //2. bir görev daha ekledik delegeye.

            myDelegate -= customerManager.SendMessage; //SendMessage görevini çıkartada biliriz.

            myDelegate(); //Görevini yerine getirir.

            //Yemek yapma sürecinde işlemler benzerdir. Yağ ekler soğanı kavurursun vs. vs. 
            //Ama bütün yemeklerin bu sürecinde + ve - ler vardır. 

            //Yapılacak işlemleri belirli şartlara göre önce bir toplanır yapılacak sıra oluşturulmuş olur.
            //Sonra onu çağırma eyleminde buşunabiliriz. Bunu testlerde küçük method parçalarına bölüpde kullanılabilir.

            //MyDelegate2 myDelegate2 = customerManager.SendMessage(); //Bunu veremeyiz çünkü parametre almıyor.

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("hello"); //Buradaki kısıt gelegeye eklediğimiz iki method için aynı text'i göndermiş oluyoruz.


            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);

            Console.WriteLine(sonuc); //sonuc 6dır. Çünkü return type int olduğu için son methodu çalıştırır.
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}