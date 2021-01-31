using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    //-------------------------------- Senaryo --------------------------------
    //Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz. 
    //Starbucks ve Nero firması için çalışıyoruz.
    //İki firma da müşterilerini veri tabanına kaydetmek istiyor.
    //Starbucks müşterileri kaydederken mutlaka mernis doğrulaması istiyor. ---(Önce mernis doğrulaması. interface'e yazamayız.) ---
    //---(Abstract'ada yazamayız. Absract'a yazarsak nero problemi çıkar.) ---
    //Nero müşterilerini kaydederken böyle bir şey istemiyor.
    //Starbucks müşterileri için her kahve alımında yıldız kazandırmak istiyor.
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager(); Neroda artık doğrulama istiyor. 
            //customerManager.Save(new Customer
            //{
            //    DateOfBirth = new DateTime(1995, 8, 30),
            //    FirstName = "Zafer",
            //    LastName = "Çalışkan",
            //    NationalityId = "1234567899"
            //});


            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());  //Gerçek mernis ilede çalışabiliriz.
            customerManager2.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Çalışkan",
                NationalityId = "1234567899"
            });

            BaseCustomerManager customerManager3 = new StarbucksCustomerManager(new CustomerCheckManager());  //Fake service ilede çalışabiliriz.
            customerManager3.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Çalışkan",
                NationalityId = "1234567899"
            });


            //----
            BaseCustomerManager customerManager = new NeroCustomerManager( new MernisServiceAdapter()); //Neroda doğrulamayla çalışıyor.
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Çalışkan",
                NationalityId = "1234567899"
            });

            //Burada soyutlamanın gücünden yararlandık.
            //Customer kimlik doğrulaması için extension method kullansak? Single responsibility bozar. Customer nesnesi bir entitydir.
            //Entity içinde başka iş yapılmaz.
        }
    }
}