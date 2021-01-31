using System;

namespace Inheritance
{
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
                    FirstName = "Engin"
                },

                //Çünkü interface'de interface tek başına bir anlam ifade etmiyor.
                //Ama classlarda (class Person) tek başına bir anlam ifade ediyor. Veya inhertance verdiği noktada da.
                new Person
                {
                    FirstName = "Süleyman"
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        //field 
        //public int Id; burada field değil Property kullanılır.

        //Property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //Person base class yani buraya ,Person2 yazamayız çünkü class'ın sadece bir base class'ı olabilir. 
    //interface olsaydı 1 den fazla yazabilirdik.
    class Customer : Person
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