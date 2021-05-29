using Business.Adapters;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            StarbucksCustomerManager customerManager = new StarbucksCustomerManager(new EfCustomerDal(),new MernisServiceAdapter());
            customerManager.Add(new Customer { DateOfBirth = new DateTime(1998, 5, 5), FirstName = "Mısra", LastName = "Erol", NationalityId = "" });
            Console.ReadLine();
        }
    }
}
