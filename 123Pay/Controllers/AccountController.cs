using _123Pay.DB;
using _123Pay.DB.Entities;
using _123Pay.Interfaces;
using _123Pay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;
        private readonly ILogger<AccountController> logger;
        private readonly ICurrentUserService currentUserService;
        private readonly AppDbContext _context;
        public AccountController(SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager,
            ILogger<AccountController> logger,
            ICurrentUserService currentUserService,
            AppDbContext context)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.logger = logger;
            this.currentUserService = currentUserService;
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (signInManager.IsSignedIn(User))
            {
                return RedirectToAction("index", "home");
            }

            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = userManager.Users.Where(x => x.UserName == model.UserName).FirstOrDefault();
                    if (user != null)
                    {
                        if (user.IsActive != true)
                        {
                            ModelState.AddModelError(string.Empty, "Inactive User");
                        }
                        else
                        {
                            var res = await signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);

                            if (res.Succeeded)
                            {
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                    }
                }
                return View(model);

            }
            catch (Exception e)
            {
                throw e;
            }
            

            
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
