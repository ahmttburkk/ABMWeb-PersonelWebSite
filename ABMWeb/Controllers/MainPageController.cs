using ABMWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace ABMWeb.Controllers
{
    public class MainPageController : Controller
    {
        ApplicationDbContext dbContext;

        public MainPageController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var x = dbContext.MainPages.ToList();
            return View(x);
        }

        public PartialViewResult IconList()
        {
            var x = dbContext.Icons.ToList();
            return PartialView(x);
        }
    }
}
