using ABMWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace ABMWeb.Controllers
{
    public class LoginController : Controller
    {
        ApplicationDbContext dbContext;
        public LoginController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(AdminPage admin)
        {
            //var info = dbContext.AdminPages.FirstOrDefault(x => adminname = );

                    if (admin.Username == "AhmetBurak" && admin.Password == "1907")
                    {

                        return RedirectToAction("Index", "Admin");
                    }
            ModelState.AddModelError("", "Invalid username or password");
            return View("Index");
        }

        public IActionResult LogOut()
        {
            return RedirectToAction("Login", "Login");
        }
    }
}
