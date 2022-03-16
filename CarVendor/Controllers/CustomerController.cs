using CarVendor.Data;
using CarVendor.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVendor.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View(Customers.CustomerBase);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            // Remove spaces from postal code
            customer.PostalCode = customer.PostalCode.Replace(" ", "");
            
            // Check if model is valid
            if (!ModelState.IsValid)
            {
                // Back to the view because model is invalid
                return View(customer);
            }

            // Add customer to customer base
            Customers.CustomerBase.Add(customer);
            return View("Index", Customers.CustomerBase);
        }
    }
}
