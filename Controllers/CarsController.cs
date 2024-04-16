using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoDealer_Assignment3.Controllers
{
    public class CarsController : Controller
    {
        // Action method for the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the About view
        public IActionResult About()
        {
            return View();
        }

        // Action method for the Services view
        public IActionResult Services()
        {
            return View();
        }

    }
}

