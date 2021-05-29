using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Service kullanabileceğimiz Crud metodlarından farklı kodlarımızı buraya yazacağız.
    //Örnek: iki database tablo birleşimi ihtiyacımızda
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CustomerManagementDbContext>, ICustomerDal
    {
    }
}
