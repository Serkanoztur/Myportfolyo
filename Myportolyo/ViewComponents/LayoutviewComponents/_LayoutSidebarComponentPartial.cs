using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents.LayoutviewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
