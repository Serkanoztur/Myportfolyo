using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
