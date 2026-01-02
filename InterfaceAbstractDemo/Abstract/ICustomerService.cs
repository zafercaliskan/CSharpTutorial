using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //In any case, I will need a single interface. If I have a Customer object, that customer object must have an ICustomerService.
    public interface ICustomerService //It will serve as a basic interface. Because the object has a customerservice.
    {
        void Save(Customer customer); //Both customers want us to do this. That's why it is necessary to abstract with an interface.
        //Nero and Starbucks request this. It may come in new future companies. Kahve Dunyasi may come, it will be in it too.

        //Kahve Dunyasi may request not to save to the database. It may want to work in memory but it is coded accordingly. 
        //There is a reality called Over Design, a weakness. Must not fall into this too. 
    }
}