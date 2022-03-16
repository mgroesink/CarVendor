using CarVendor.Data;
using CarVendor.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVendor.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View(Cars.Stock);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }
            Cars.Stock.Add(car);
            return View("Index" , Cars.Stock);
        }

    }
}
