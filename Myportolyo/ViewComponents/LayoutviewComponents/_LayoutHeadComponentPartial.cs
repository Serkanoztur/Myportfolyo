using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents.LayoutviewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
