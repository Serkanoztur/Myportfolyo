using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents
{
    public class _ExperinceComponentPartial: ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
