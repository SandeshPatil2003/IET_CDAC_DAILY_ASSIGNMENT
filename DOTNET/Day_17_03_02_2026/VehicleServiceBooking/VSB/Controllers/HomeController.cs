using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VSB.Models;

namespace VSB.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
