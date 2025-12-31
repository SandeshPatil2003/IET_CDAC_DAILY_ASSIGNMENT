using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace ReturnTypes.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult String1()
        {
            return Content( "hello this is a string" );
        }

        public IActionResult String2()
        {
            return Content("<h1>hello this is a html string</h1>","text/html");
        }


        public ActionResult<string> String3()
        {

            return "Hello this is string 3";
        }

        public ActionResult<int> Num1()
        {

            return 55;
        }

        public ViewResult View1()
        {
            return View("Index");

        }


        public string Upass (string un , string pw)
        {
            return $"This is username: {un} This is password: {pw}";
        }


        public JsonResult Json1()
        {
            var objdata = new
            {
                ID = 99,
                Name = "John Cena",
                Address = "America"
            };

            var jsondata = Json(objdata);
            return jsondata;
        }

        public StatusCodeResult Status200()
        {
            return StatusCode(200);
        }

        public StatusCodeResult Status404()
        {
            return StatusCode(404);
        }


        public ObjectResult Object1()
        {
            var obj = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            var objres = new ObjectResult(obj) ;

            return objres;
        }

        public EmptyResult Nothing()
        {
            return new EmptyResult();
        }

        public async Task<ViewResult> Slow3()
        {
            await Task.Delay(3000);
            return View("~/Views/Home/Index.cshtml");
        }


        public FileResult Down()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:\Users\IET\Desktop\Source Book\DAC_School_TG_MS.pdf");

            return File(byteArray, "application/pdf", "DAC_School_TG_MS.pdf");
        }
    }
}
