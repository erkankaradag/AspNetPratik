using Microsoft.AspNetCore.Mvc;

namespace AspNetPratik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
