using Microsoft.AspNetCore.Mvc;
using Myportolyo.Dal.ConText;
using Myportolyo.Dal.entites;


namespace Myportolyo.Controllers
{
    [Route("experiences")]
    public class ExperienceController : Controller
    {
        Myportfolio context = new Myportfolio();

        [HttpGet("")]
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();

            return View(values);
        }
        [HttpGet("add")]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost("add")]
        public IActionResult CreateExperience(Experience experience)

        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)

        {
            var value = context.Experiences.FirstOrDefault(i => i.ExperienceId == id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
