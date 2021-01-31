using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        //Neronun hiçbir şekilde doğrulamaya ihtiyacı yok.

        //Neroda aynı doğrulamayı istediğinde aşağıdaki satırları ekleriz.

        //--- Alt satırlar eklendi.
        private ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
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
    }
}