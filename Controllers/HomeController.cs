using Microsoft.AspNetCore.Mvc;

namespace PTime.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
