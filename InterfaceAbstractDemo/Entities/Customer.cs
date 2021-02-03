using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    //Somut sınıflar eğer çıplak kalıyorsa yani herhangi inhertance veya implementasyon almıyorsa ilerde nesnellik zafiyeti yaşarız.
    //Sırf bu tip kurallar için IEntity'den implemente edelim. Bunun genelde veri tabanı nesnesi olarak göstermek için kullanırız.
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}