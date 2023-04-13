using Microsoft.AspNetCore.Mvc;

namespace GP_Project.Areas.DashboardAdmin.Controllers
{
    public class adminController : Controller
    {
        [Area("DashboardAdmin")]
        public IActionResult Dash()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
