using System;

namespace AbstractClasses
{
    //Interface: Amacımız imzaları oluşturup onu implemente eden classların onları tekrardan yazmasını sağlamak bunu zorunlu hale getirir.
    //VirtualMethods: Isteyen istediği methodları ezebiliyordu.
    //AbstactClasses: Bunlarda bir class. Bunu interfaceler ile virtual methodların birleşimi gibi düşünebiliriz.
    //Tamamen inheritance amacı ile kullanır. Interfaceler ile virtul methodsların kullanım nedenlerini bir araya getirdiğimizde amaç neyse abstacrt classlarda da amaç odur.

    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle(); //Burada Database'i newleyemeyiz.(abstact classlar newlenmez)
            //Yani abstract classlar newlenemez.
            database.Add();
            database.Delete(); //Oracle'ın delete'i çalışır.

            Database database2 = new SqlServer();
            database2.Add();
            database2.Delete(); //Sql server delete çalışır.

            //Abstract classlar bir inheritancedır. SqlServer sadece 1 tane abstractten inherit edilebilir.
            //Baska bir class veya abstarctten inherit edilemez. Başka interfaceler varsa onlar implement edilebilir.
        }

        abstract class Database
        {
            //Tamamlanmış methods
            public void Add() //Ekleme hepsinde aynıdır.
            {
                Console.WriteLine("Added by default");
            }

            //Tamamlanmamış methods
            public abstract void Delete(); //Silme işlemi her veri tabanı için farklıdır.


            //Not: Hem tamamlanmış hemde tamamlanmamış methodlar yapabiliriz. 
        }

        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by sql server");
            }
        }

        class Oracle : Database
        {
            public override void Delete()  //tamamnlanmamış methodu override ediyoruz.
            {
                Console.WriteLine("Deleted by oracle");
            }
        }
    }
}