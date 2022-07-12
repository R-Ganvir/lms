using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View("AboutUs");
        }
        public IActionResult Terms()
        {
            return View("Terms");
        }
    }
}
