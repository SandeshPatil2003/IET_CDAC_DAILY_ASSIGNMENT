using Microsoft.AspNetCore.Mvc;

namespace HelloWorldIndexRoute.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            
            return View();
        }
    }
}
