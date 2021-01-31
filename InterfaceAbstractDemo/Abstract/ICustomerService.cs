using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //Her şartta bir taner interface'e ihtiyaç duyacağım. Customer nesnem varsa o customer nesnesinin ICustomerService'i olmak zorunda.
    public interface ICustomerService //Temel bir interface görevi görecek. Çünkü nesnenin bir customerservice'i vardır.
    {
        void Save(Customer customer); //Iki müşteride bunu yapmamızı istiyor. Bu yüzden bir interface ile soyutlamak gerekir. 
        //Nero ve starbucks'da bu isteniyor. Yeni gelecek firmalarda da gelebilir. Kahve dünyası gelebilir onda da olacaktır.

        //Kahve dünyası veritabanına kayıt edilmemesini isteyebilir. Memoryde çalışmakisteyebilir fakat ona göre kodlanır. 
        //Over dizayn denen bir gerçek var bir zafiyet. Bunada düşmemek lazım. 
    }
}