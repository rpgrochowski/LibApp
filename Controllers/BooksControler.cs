using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp2.Models;

namespace LibApp2.Controllers
{
    public class BooksControler : Controller
    {
        public IActionResult Index()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            return View(firstBook);
        }
    }
}
