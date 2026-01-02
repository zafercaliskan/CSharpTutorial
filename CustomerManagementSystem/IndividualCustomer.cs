using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem
{
    //Individual Customer
    //Inheritance
    class IndividualCustomer : Customer
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
