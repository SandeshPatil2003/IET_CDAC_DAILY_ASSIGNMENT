using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCStudentDB.Models;

namespace MVCStudentDB.Controllers
{
    public class HomeController : Controller
    {
       

        private readonly MyDbContext mcontext;

        public HomeController(MyDbContext context)
        {
            mcontext = context;
        }
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show()
        {
           

            

           var s= mcontext.GetAllStudents();
            return View(s);
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
