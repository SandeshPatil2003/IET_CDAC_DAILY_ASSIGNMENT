using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{

    [Route("[controller]")]
    public class Controller1 : Controller
    {

        [Route("[action]")]
        public IActionResult Page1()
        {
            return View();
        }

        [Route("[action]")]
        public int Num()
        {
            return 99;
        }

        [Route("[action]/{id?}/{nm?}")]
        public string Show(int id , string nm)
        {
            return $"id: {id}  nm:{nm}";
        }


    }
}
