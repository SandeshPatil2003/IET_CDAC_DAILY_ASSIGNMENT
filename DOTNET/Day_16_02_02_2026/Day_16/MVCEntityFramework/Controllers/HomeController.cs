using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCEntityFramework.Models;

namespace MVCEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyDbContext _context;

        public HomeController(MyDbContext context)
        {
            _context= context;
        }

      


        public IActionResult Index1()
        {
            var emplist =_context.emps.ToList();

            return View(emplist);
        }

        [HttpGet]
        public IActionResult Create1()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Create1(Emp e)
        {
            _context.emps.Add(e);
            _context.SaveChanges();

            return RedirectToAction("Index1")  ;
        }


        [HttpGet]
        public IActionResult Edit1(int Id)
        {
            Emp e = _context.emps.Find(Id);
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit1(Emp emp ,int Id)
        {
            Emp e = _context.emps.Find(Id);
            e.Name=emp.Name;
            e.Address=emp.Address;


            _context.SaveChanges();

            return RedirectToAction("Index1");
        }

        [HttpGet]
        public IActionResult Delete1( int Id)
        {
            Emp e = _context.emps.Find(Id);
            
            _context.emps.Remove(e);

            _context.SaveChanges();

            return RedirectToAction("Index1");
        }



        public IActionResult Index()
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
