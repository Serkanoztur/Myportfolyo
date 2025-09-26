using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
