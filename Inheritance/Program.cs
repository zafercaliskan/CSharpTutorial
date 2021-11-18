using System;

namespace Inheritance
{
    //Inheritance(Kalıtım | Miras)
    //Interfacelerde bir inheritance örneği gibi çalışırlar ama inheritance değil onlar implementasyondur.
    //Fakat inheritance gibi kullanılırlar yeni nesil dillerde. 
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Zafer"
                },

                new Student
                {
                    FirstName = "Hasan"
                },

                //Burada genel bir insan tanımı yapılabilir.//Base class'ın bir anlamı vardır.
                //newlenebilir. Fakat interfacelerin tek başına bir anlamı yoktur. newlenemez.
                new Person
                {
                    FirstName = "Süleyman"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            //? Interface mi inheritance mı kullanmalıyız?
            //- Inheritance kullanma zorunluluğumuz yoksa interfacelerden yürümek daha iyi çünkü interfaceler inheritance gibi kullanılabiliyor. 
            //? Peki inheritance kullanmayacak mıyız? 
            //- Abstract classlarıda baktıktan sonra ne zaman interface ne zaman inheritance kullanacağımız netleşecektir.
        }
    }

    class Person //base class (Customer ve Student'ın babası gibi düşünebiliriz.)
    {
        //field 
        //public int Id; burada field değil Property kullanılır.

        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person //Buradaki önemli husus sadece birkez inheritance yapabiliriz.
    //Yani bir base class'ı(her kişinin 1 babası) olur. Ama birden fazla interfaceden implementasyon yapılabilir.
    //Sıralama olarak önce inheritance yazılır sonra , ile ayırarak implementasyonlar yapılabilir.
    {
        public string City { get; set; }
    }
    //Örneğin.
    interface IPerson { }
    interface IPerson2 { }

    //Bir class birden fazla interface alabilir fakat bir class'ın 1 base class'o olabilir.
    class Student : Person, IPerson, IPerson2 //Önce Inheritance yazılır sonra kaç tane interface varsa o yazılır.
    {
        public string Department { get; set; }
    }

    //Classların tek başlarına bir anlamı vardır ama interfacelerin tek başına bir anlamı yoktur. İkiside inheritance gibi kullanılabiliyor. 
    //Aslında interfaceler bir implementasyondur. Fakat yeni nesil dillerde inheritance gibi kullanımı söz konusudur.

    //Öenmli
    //Hangisini kullanmalıyız? Inheritance Abstract sınıflar için önemlidir. 
    //Eğer interface kullanabiliyorsanız inheritance'a ihtiyacınız yoksa yada kullanmak zorunda olduğunuzu düşünmüyorsanız interface kullanınmalıyız.
}