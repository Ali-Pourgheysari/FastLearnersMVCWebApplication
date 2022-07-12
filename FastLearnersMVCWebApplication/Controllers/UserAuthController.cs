using FastLearnersMVCWebApplication.Data;
using FastLearnersMVCWebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FastLearnersMVCWebApplication.Controllers
{
    public class UserAuthController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UserAuthController(SignInManager<ApplicationUser> signInManager,
                                  UserManager<ApplicationUser> userManager,
                                  ApplicationDbContext context)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            loginModel.LoginInValid = "true";

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password,
                                                                      loginModel.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    loginModel.LoginInValid = "";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt");
                }

            }
            return PartialView("_UserLoginPartial", loginModel);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return View("Index", "Home");
            }
        }
    }
}