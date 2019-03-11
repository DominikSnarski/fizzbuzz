using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Turde.Models;

namespace Turde.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int x)
        {
            string output;
            if(x<1 || x>100)
            {
                output = "Please submit integer between 1 and 100.";
            }
            else if (x % 3 == 0 && x % 5 == 0)
            {
                output = "fizzbuzz";
            }
            else if (x % 3 == 0)
            {
                output = "fizz";
            }
            else if (x % 5 == 0)
            {
                output = "buzz";
            }
            else
            {
                output = x.ToString();
            }
            ViewBag.Mydata = output;
            return View();
        }

    }
}
