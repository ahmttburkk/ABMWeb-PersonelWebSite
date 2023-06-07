using ABMWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABMWeb.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext dbContext;

        public AdminController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var x = dbContext.MainPages.ToList();
            return View(x);
        }

        public IActionResult GetMainPage(int id)
        {
            var x = dbContext.MainPages.Find(id);
            return View("GetMainPage", x);
        }

        public IActionResult UpdateMainPage(MainPage m)
        {
            var x = dbContext.MainPages.Find(m.Id);
            x.Name = m.Name;
            x.Profile = m.Profile;
            x.Title = m.Title;
            x.Explanation = m.Explanation;
            x.Experiences = m.Experiences;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
