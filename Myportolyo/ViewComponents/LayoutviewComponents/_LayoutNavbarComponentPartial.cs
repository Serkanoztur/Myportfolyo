using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents.LayoutviewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
