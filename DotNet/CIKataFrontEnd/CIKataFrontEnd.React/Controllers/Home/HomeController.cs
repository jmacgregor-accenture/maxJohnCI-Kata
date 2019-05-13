using Microsoft.AspNetCore.Mvc;

namespace CIKataFrontEnd.React
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}