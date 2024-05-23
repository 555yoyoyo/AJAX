using Microsoft.AspNetCore.Mvc;
using TEST.Models;

namespace TEST.Controllers
{
    public class HomeWorkController : Controller
    {
        public IActionResult Homework1()
        {

           return View();
        }
        public IActionResult Homework2() 
        {
            return View();
        }

    }
}
