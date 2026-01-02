using System;

namespace Attributes
{
    class Program
    {
        //Attribute: Attributes are structures that we can apply to an object, a method or a property, in short, to C# structures.
        //Through these structures, we add meaning to the object we apply the attribute to. In short, with Attributes
        //we make use of Attributes to add meaning to your objects or their properties or methods at runtime.
        static void Main(string[] args)
        {
        }
    }

    //Here we set the parameter via constructor.
    [ToTable("Customers")] //Corresponds to Customers table in Db. We use this to generate dynamic queries. Along with mandatory sub-fields. 
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty] //Make firstname mandatory. I can build a structure that makes sense by coming over the property. 
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        //We can mark the old methods we don't want to use as Obsolete and direct them to use the new one.
        [Obsolete("Dont use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added! ");
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added! ");
        }
    }

    //We can also give attributes to Attributes with AttributeUsage.
    //[AttributeUsage(AttributeTargets.All)] //You can use this attribute for everyone. whether to a class or a method of a class or a property, you can use it everywhere.
    //[AttributeUsage(AttributeTargets.Class)] //can only be added on top of classes.
    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] //we can also use it in properties or fields of objects.
    //[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] //We specify whether we can write more than once on top of each other. 
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}