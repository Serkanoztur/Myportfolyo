using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;
using Myportolyo.Dal.entites;

namespace Myportolyo.Controllers
{
    public class StatisticController1 : Controller
    {
        Myportfolio context = new Myportfolio();

        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == false).Count();


            return View();
        }
    }
}
