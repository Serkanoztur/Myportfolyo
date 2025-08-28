using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
