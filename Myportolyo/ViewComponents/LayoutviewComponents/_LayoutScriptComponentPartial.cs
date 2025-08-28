using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents.LayoutviewComponents
{
    public class _LayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
