using GP_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace GP_Project.Controllers
{
    public class UserLink : Controller
    {
        public UserLink ()
        {

        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Regestration()
        {
            return View(new Users());
        }
        [HttpPost]
        public IActionResult Regestration(Users _User)
        {
            return View(new Users());
        }
    }
}
