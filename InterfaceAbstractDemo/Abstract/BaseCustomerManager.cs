using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //BaseCustomerManager bu bizim için abstract görevi görececek çünkü kodun içi aynı. NeroCustomerManager ve StarbucksCustomerManager için
    //Ayrı ayrı yazabilirdim fakat aynı olduğu için BaseCustomerManager bizim için base görevi görecek.
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //virtual dersek ben bunu ezebilirim demek.
        {
            //Veri tabanaına yazma kodlarını buraya yazarız.
            Console.WriteLine("Saved to db :" + customer.FirstName);
        }
    }
}