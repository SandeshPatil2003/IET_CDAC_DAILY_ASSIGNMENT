using Microsoft.AspNetCore.Mvc;

namespace ConventionalRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
