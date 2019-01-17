using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the About Controllers Index's action");
        }
        public IActionResult History()
        {
            return Content("This is the About Controllers History's action");
        }
        public IActionResult Location()
        {
            return Content("This is the About Controllers Location's action");
        }
    }
}