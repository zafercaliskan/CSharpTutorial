using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagementSystem
{
    //Tüzel Müsteri
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
