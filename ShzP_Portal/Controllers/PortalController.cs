using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using ShzP_Portal.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShzP_Portal.Controllers
{
    public class PortalController : Controller
    {
        private readonly SignInManager<ShzP_PortalUser> _signInManager;

        public PortalController(SignInManager<ShzP_PortalUser> signInManager)
        {
            _signInManager = signInManager;
        }


        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult test_page()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync(); // Sign out the user
            return RedirectToAction("Index", "Portal"); // Redirect to the home page or any other desired page after logout
        }

        public IActionResult success()
        {

            TempData["success"] = "Registered Successfully. You can now login";
            return RedirectToPage("/Account/Login", new { area = "Identity" });
        }

    }
}
