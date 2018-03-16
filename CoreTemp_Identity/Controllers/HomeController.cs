using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreTemp_Identity.Models;
using System.Security.Claims;
using CoreTemp_Identity.Models.SYSTEM;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using static CoreTemp_Identity.Controllers.Services.Services;

namespace CoreTemp_Identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Login(string em = null, string pwd = null)
        {
            var claims = new List<Claim>
                {
                    new Claim("user", ""),
                    new Claim("role", "Member")
                };

            HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, SysBase.cookieName, "user", "role")));

            return Redirect("/Home/About");
        }

        
        [Authorize]
        public IActionResult About()
        {
            var x = User.Identity.IsAuthenticated;
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
