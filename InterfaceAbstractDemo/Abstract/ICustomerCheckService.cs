using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //Kullanıcı kişiyle ilgili bir kontrolleri yapmak istiyorsun
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
