using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    //Dolaylı olarak Interfacedeki Save'ide miras aldı. Interface'ide refereans olarak kullanabileceğiz.
    public class StarbucksCustomerManager : BaseCustomerManager//, ICustomerCheckService'den implement'e olmak istiyorum diyebiliriz. Fakat daha güzel kullanımı aşağıda.
    {
        private ICustomerCheckService _customerCheckService; //Bunu dependency injection insulation edilir.

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService) // ^^
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer)) //Mernis doğrulaması yapacağız.
            {
                base.Save(customer); //True dönerse kaydet. //Veritabanına kaydeden kod. Burası kalacak. 
            }
            else
            {
                throw new Exception("Not a valid person!"); // Dönmezse hata verir.
            }
        }

        //Alt satırdaki yerler güncellendi yukarıdaki gibi yaptık.
        ////Bir class'ın içerisine sen bir method yazıyorsan orada bir düşüneceksin. Bu yazdığım sadece buraya özgü birşey mi? Yarın nero'da isteyebilir.
        //private void CheckIfRealPerson(Customer customer)
        //{
        //    //Burada bütün kodları yazıp mernis'e bağlanabilirim fakat yarın Nero'da aynı şeyi isterse?
        //    //-İşte böyle bir senaryoda interfacelerin ability(kabiliyet) dediğimiz durumu devreye giriyor. Operasyon sınıflandırması amacıylada kullanılırlar.
        //}
    }
}