using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;

namespace Myportolyo.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        Myportfolio portfolioContext = new Myportfolio();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle= portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutsubdescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }

    }
}
