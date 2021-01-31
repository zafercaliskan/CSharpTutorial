using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    //Starbucks'a bağlı değilim genel bir sistem yapıyoruz.
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(); Bu böyle yapılmaz. 
            //Mernis'e bağlısın mernis çalışmazsa sistemde çalışmaz. Test amaçlı birşey yapamazsın gerçek sisteme bağlanman gerekir. 
            //Bağımlısın yani. Mernis değişir başka birşey olur sıkıntı. mernisten vazgeçtik kendi dbimizi kullancaz sıkıntı.
            //Burada bir adaptör'e ihtiyaç var. Dış bir sistemi sisteme adapte ederken Adaptör denen dizayn pattern kullanılır.

            return true; //Doğrulanmış varsayıyoruz.
        }
    }
}
