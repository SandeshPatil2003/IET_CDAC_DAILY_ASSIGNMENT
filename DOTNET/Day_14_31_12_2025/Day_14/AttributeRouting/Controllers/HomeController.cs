using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{

    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("Index2")]
        public IActionResult Index2()
        {
            return View();
        }
    }
}
