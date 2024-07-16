using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheApp.Data;
using TheApp.Models;

namespace TheApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger /*DataContext DContext*/)
        {
            _logger = logger;
            //_dataContext = DContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Product product = new Product() { ProductID = 1, ProductName = "Soap" };
            //_dataContext.Products.Add(product);
            //_dataContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}