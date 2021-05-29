using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        //test amaçlı kullanımlar için var.
        public bool Validate(Customer customer)
        {
            return true;
        }
    }
}
