using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents
{
    public class HeadComponentPartialViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}