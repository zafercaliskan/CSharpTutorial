using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer //Müşerinin özelliklerini tutmak için propertylerden yararlanıyoruz.
    {
        //Field - Değişken tanımlamak.
        //public int id;

        // ** Class içerisinde class'a ait özellik tanımlayacasak filed değil property kullanmamız gerek.

        //Property
        public int Id { get; set; } //Değer atarken set, alırkende get bloğu çalışır. //Encapsulation için gerekiyor.
        //customer.Id = 1; bunu yapınca set blogu çalışır.

        //Encapsulation 
        //Yeni bir kural getiriyoruz. Firstname'i set ederse mr/mrs vs getirmek istediğimizde
        //Set; i daha açık yazarız.  
        //field
        private string _firstName;
        //Bir filed üzerinde get veya set ederken (değeri okurken veya verirken) başka birşey yapmak istersek
        //olayı bu şekilde yapmak gerekir. Implementasyon detayının gizlenmesi denir.
        public string FirstName
        {
            get { return "Mrs. " + _firstName; } //Önünde Mrs. olacak şekilde döndürür. //Pek böyle kullanılmaz.
            //get; set; olması oto property demek. İhtiyaç olursa {} açıp içerisini doldurabiliriz.
            set { _firstName = value; } //Set etmeye çalıştığımız değere karşılık gelir. 
        }

        public string LastName { get; set; }
        public string City { get; set; }
    }
}