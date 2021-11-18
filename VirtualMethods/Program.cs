using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Database
        {
            public virtual void Add() //Virtual keyword'u ile Add methodunun inhertance yapılan sınıflarda
                                      //override edilebileceğini belirttik. Isterse Base'deki Add methodunu override edebilir.
            {
                Console.WriteLine("Added by default");
            }
            public void Delete()
            {
                Console.WriteLine("Deleted by default");
            }
        }

        class SqlServer : Database
        {
            //Bunu interfaceler ile yapamayız. inhertance kullanmamızı gerektiren bir durum.
            public override void Add()
            {
                Console.WriteLine("Added by Sql code");  //İkisini de aynı anda (base dahil) çalıştırabiliriz.
                                                         //Yada sadece buraya özgü birşeylerde yazabiliriz.

                //Örneğin önden bir konfigürasyon çalıştırıp base'i de çalıştırabiliriz.
                base.Add(); //Base'deki default add'i çalıştırır.
            }
        }
        class MySql : Database
        {

        }
    }
}