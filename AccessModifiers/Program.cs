using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Customer
    {
        int Id; //default private'dır.

        protected int FirstName;
    }

    class Student : Customer
    {
        public void Save()
        {
            //Burada firstname erişebiliriz.
            Customer customer = new Customer();
            //customer.id = 1; burada id gelmez. Çünkü private tanımlandığı blakda geçerlidir.
        }
    }

    class Course //default internal
    {
        //private class NestedClass iç classda olur ama dış classda private yada protected olmaz.
        //{

        //}

        //protected class NestedClass
        //{

        //}
        public string Name { get; set; }
    }

    //Private: Tanımlandığı blok içerisinde geçerlidir. Class, field, property etc. olabilir.

    //Protected: Private'ın tüm özelliklerini karşılar. Protected'ı class seviyesinde kullanırız.
    //- Ayrıca artısı özellik değişken her neyse inherit edildiği sınıflarda da kullanılabilir.

    //Internal: Bulunduğu proje içerisinde referans ihtiyacı olmadan kullanılabilir. Proje içerisinde heryerden çağırabilir..
    //- iç içe class dışında private yada protected olamaz.

    //Public: Course class'ını başka bir projeden de kullanmak istersek public yaparak ve referans vererek kullanabiliriz.
}