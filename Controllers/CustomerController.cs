using Microsoft.AspNetCore.Mvc;
using SampleTest.Models;
using SampleTest.Services;

namespace SampleTest.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        public IActionResult Index()
        {
            return View(customerService.Customers());
        }

        public IActionResult Edit(int id)
        {
            var item = customerService.Customers().SingleOrDefault(x => x.ID.Equals(id));
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(CustomerModel customer)
        {
            if (ModelState.IsValid)
            {
                var item = customerService.Update(customer);
                return View("Index", customerService.Customers());
            }
            return View(customer);
        }
    }
}
