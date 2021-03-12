using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                NationalityId = "10000000000",
                FirstName = "Galip",
                LastName = "Doğan",
                DateOfBirth = new DateTime(1986, 11, 4)
            }) ;
            Console.ReadLine();
        }
    }


}
