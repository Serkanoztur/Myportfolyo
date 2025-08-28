using Microsoft.AspNetCore.Mvc;

namespace Myportolyo.ViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
