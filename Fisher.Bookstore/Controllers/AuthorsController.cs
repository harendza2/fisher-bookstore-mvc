using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Author Controllers Index's action");
        }
        public IActionResult Featured()
        {
            return Content("This is the Author Controllers History's action");
        }
    }
}