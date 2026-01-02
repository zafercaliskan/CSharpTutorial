using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    //I am not dependent on Starbucks, we are making a general system.
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(); This is not done like this. 
            //You are dependent on Mernis, if Mernis does not work, the system does not work either. You cannot do anything for testing purposes, you have to connect to the real system. 
            //So you are dependent. Mernis changes, something else happens, trouble. We gave up on Mernis, we will use our own db, trouble.
            //There is a need for an adapter here. While adapting an external system to the system, the design pattern called Adapter is used.

            return true; //Assumed verified.
        }
    }
}
