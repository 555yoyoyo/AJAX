using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TEST.Models;

namespace TEST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;
        
        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Category()
        {
            var category = _context.Categories;
               
            return View(category);
        }
        public IActionResult First()
        {
             return View();
        }
        public IActionResult Address()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Spots()
        {

            return View();
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult JSONTTest()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}