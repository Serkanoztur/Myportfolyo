using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;

namespace Myportolyo.Controllers
{
    public class MessageController : Controller
    {
        Myportfolio context = new Myportfolio();
        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
    }
}
