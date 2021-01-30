using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek Müşteri(Bireysel)
    //Inheritance
    class IndividualCustomer :Customer
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
