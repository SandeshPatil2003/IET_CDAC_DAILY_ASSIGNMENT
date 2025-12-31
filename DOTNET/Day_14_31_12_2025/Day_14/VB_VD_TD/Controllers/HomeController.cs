using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VB_VD_TD.Models;

namespace VB_VD_TD.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> empList = new List<Emp>()
            {
                new Emp(){ eId= 101, eName= "Pooja", eSal=523523},
                new Emp(){eId= 102, eName= "Neha", eSal=23434},
                new Emp(){ eId= 103, eName= "Tina", eSal=423},
                new Emp(){eId= 104, eName= "Pinky",eSal=234},
                new Emp(){ eId= 105, eName= "Jaspreet", eSal=1423},

            };

        List<Cust> customerList = new List<Cust>() {
         new Cust(){cId= 1, cName="Bob", Bill= 1234 },
         new Cust(){cId= 2, cName="Rob", Bill= 5678 },
         new Cust(){cId= 3, cName="Tom", Bill= 2468 },
        };

        public IActionResult Index()
        {

            string s = "john cena";
            return View("Index",s);
        }

        public IActionResult Emp()
        {
            return View(empList);
        }

        public IActionResult Both()
        {
            ViewModel1 vm = new ViewModel1()
            {
                elist = empList,
                clist = customerList
            };
          
            return View(vm);
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
