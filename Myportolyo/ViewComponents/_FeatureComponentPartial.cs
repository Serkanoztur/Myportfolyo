using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;

namespace Myportolyo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
       Myportfolio portfolioContext = new Myportfolio();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
      
    }
}
