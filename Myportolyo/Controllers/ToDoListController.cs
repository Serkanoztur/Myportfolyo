using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;
using Myportolyo.Dal.entites;

namespace Myportolyo.Controllers
{
    public class ToDoListController : Controller
    {
        Myportfolio context = new Myportfolio();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            var value = context.ToDoLists.Find(toDoList.ToDoListId);
            context.SaveChanges();
            return RedirectToAction("Index");
         
        }

    }
}
