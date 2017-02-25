using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using CharEmServices.Models;

namespace CharEmServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> userManager;

        public HomeController(UserManager<User>
                              userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            User user = userManager.GetUserAsync
                         (HttpContext.User).Result;

            ViewBag.Message = $"Welcome {user.FirstName}!";
            if (userManager.IsInRoleAsync(user, "NormalUser").Result)
            {
                ViewBag.RoleMessage = "You are a NormalUser.";
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
