using Microsoft.AspNetCore.Mvc;

namespace GP_Project.Areas.Edit.Controllers
{
    public class HomeController : Controller
    {
        [Area("Edit")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
