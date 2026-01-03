using Microsoft.AspNetCore.Mvc;
using VSB.DAL;
using VSB.Models;

namespace VSB.Controllers
{

    [Route("Login")]

    public class LoginController : Controller
    {
        private readonly VSDbUtil _vsdb;

        public LoginController(VSDbUtil vsdb)
        {
            _vsdb = vsdb;
        }

        [HttpGet]
        [Route ("LoginPage")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult RegisterUser(User user)
        {

            _vsdb.users.Add(user);
            _vsdb.SaveChanges();
            return Redirect("/Login/LoginPage");
            // return RedirectToAction("Login");
        }

        [HttpPost]
        [Route("LoginPage")]
        public IActionResult ValidateLogin(User user)
        {

           var users = _vsdb.users.ToList();
            User loggedInUser = null;

            foreach (User u in users)
            {
                if(u.UserEmail == user.UserEmail && u.UserPass== user.UserPass)
                {
                     loggedInUser = u;
                    break;
                }
            }
            
            if (loggedInUser == null)
            {
                TempData["ErrMsg"] = "Invalid Credentials";
                return RedirectToAction("Login");
            }
            return RedirectToAction("VehicleServices", "Service");
        }
    }
}
