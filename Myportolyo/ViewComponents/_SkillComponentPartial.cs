using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;

namespace Myportolyo.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }

    }
}
