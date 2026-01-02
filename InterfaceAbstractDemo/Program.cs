using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    //-------------------------------- Scenario --------------------------------
    //We want to write a customer management system for coffee shops.
    //We are working for Starbucks and Nero companies.
    //Both companies want to save their customers to the database.
    //Starbucks strictly requires Mernis (Identity) verification when registering customers. ---(Validation first. We cannot write to interface.) ---
    //---(We cannot write to Abstract either. If we write to Abstract, Nero problem arises.) ---
    //Nero does not require such a thing when registering its customers.
    //Starbucks wants to earn stars for its customers for every coffee purchase.
    class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager(); Nero now requires validation too. 
            //customerManager.Save(new Customer
            //{
            //    DateOfBirth = new DateTime(1995, 8, 30),
            //    FirstName = "Zafer",
            //    LastName = "Caliskan",
            //    NationalityId = "1234567899"
            //});


            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());  //We can work with real Mernis too.
            customerManager2.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Caliskan",
                NationalityId = "1234567899"
            });

            BaseCustomerManager customerManager3 = new StarbucksCustomerManager(new CustomerCheckManager());  //We can work with Fake service too.
            customerManager3.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Caliskan",
                NationalityId = "1234567899"
            });


            //----
            BaseCustomerManager customerManager = new NeroCustomerManager( new MernisServiceAdapter()); //Nero works with validation too.
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1995, 8, 30),
                FirstName = "Zafer",
                LastName = "Caliskan",
                NationalityId = "1234567899"
            });

            //Here we benefited from the power of abstraction.
            //What if we used extension method for Customer identity verification? Breaks Single Responsibility. Customer object is an entity.
            //No other work is done inside Entity.
        }
    }
}