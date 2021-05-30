using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class OtherCustomerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        private ICustomerService _customerService;


        public OtherCustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public IActionResult Index(DateTime dateOfBirth, string firstName, string lastName, string nationalityId)
        {
            Customer customer = new Customer()
            {
                DateOfBirth = dateOfBirth,
                FirstName = firstName,
                LastName = lastName,
                NationalityId = nationalityId
            };



            _customerService.Add(customer);


            return View();
        }
    }
}
