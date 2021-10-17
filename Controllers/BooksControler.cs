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
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };
            //var secondBook = new Book() { Name = "German dictionary" };

            //ViewBag.Book1 = firstBook;
            //ViewBag.Book2 = secondBook;
            return View(firstBook);
        }

        public IActionResult Edit(int id)
        {
            return Content("id" + id);
        }

        public IActionResult Index (int? pageIndex, string sortBy)
        {
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        public IActionResult ByRelaseData (int year, int month)
        {
            return Content(year + "/" + month);
        }

        /*git add .
        git commit -m "Passing parameters to action" 
        git push origin master
         */
    }
}
