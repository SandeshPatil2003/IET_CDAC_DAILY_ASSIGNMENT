using Microsoft.AspNetCore.Mvc;

namespace VB_VD_TD.Controllers
{
    public class VVTController : Controller
    {
        public IActionResult I()
        {
            ViewBag.message = "hello john cena";
            ViewData["key1"]="value1";
            TempData["key2"] = "value2";
            return View();
        }

        public IActionResult I2()
        {
            
            return View();
        }

        public IActionResult I3()
        {

            return View();
        }

    }
}
