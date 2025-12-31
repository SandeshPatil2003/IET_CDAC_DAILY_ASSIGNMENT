using Microsoft.AspNetCore.Mvc;

namespace ConventionalRouting.Controllers
{
    public class Controller1 : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }
    }
}
