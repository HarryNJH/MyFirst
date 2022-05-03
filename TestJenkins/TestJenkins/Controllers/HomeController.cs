using Microsoft.AspNetCore.Mvc;

namespace TestJenkins.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
