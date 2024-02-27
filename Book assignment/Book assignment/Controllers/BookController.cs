using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Book_assignment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Book_assignment.Controllers
{
    public class BookController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            
        }
        public IActionResult hello(string name,string author, int page_number ,DateTime due_date, int a)
        {
            Book book = new Book();
            book.name = name;
            book.author = author;
            book.page_number = page_number;
            book.due_date = due_date;
            ///book.remainingTime = remainingTime;
            DateTime now = DateTime.Now;
            ///remainingTime = due_date - now;

            TimeSpan remainingTime = due_date - now;
            ///a = remainingTime.TotalDays;
            book.remainingTime = remainingTime;
            return View(book);
        }
    }
     
}

