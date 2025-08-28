using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Myportolyo.ViewComponents
{
    public class _navbarComponentPartial: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
           
        }
    }
}



