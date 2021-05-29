using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StarbucksCustomerManager : ICustomerService
    {
        private IUserValidationService _userValidationService;
        private ICustomerDal _customerDal;

        //bağımlılığı azaltmak için Constructor kullandık
        public StarbucksCustomerManager(ICustomerDal customerDal, IUserValidationService userValidationService)
        {
            _customerDal = customerDal;
            _userValidationService = userValidationService;
        }

        public void Add(Customer customer)
        {
            if (_userValidationService.Validate(customer))
            {
                _customerDal.Add(customer);
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {
                Console.WriteLine("Kişi bulunamadı");
                //throw new Exception("Kişi bulunamadı");

            }
        }

    }
}
