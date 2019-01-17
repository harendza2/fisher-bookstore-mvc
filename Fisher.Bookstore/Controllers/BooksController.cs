using System;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is the Books Controllers Index's action");
        }
        public IActionResult New()
        {
            return Content("This is the Books Controllers New's action");
        }
        public IActionResult Best()
        {
            return Content("This is the Books Controllers Best's action");
        }
    }
}