using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class  OtherCustomerManager : ICustomerService
    {
        //diğer firma müşterileri için doğrulama kullanmadık
        ICustomerDal _customerDal;
        public OtherCustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }
    }
}
