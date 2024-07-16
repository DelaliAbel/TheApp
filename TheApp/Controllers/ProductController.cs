using Microsoft.AspNetCore.Mvc;

namespace TheApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
