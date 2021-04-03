using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber = 13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
