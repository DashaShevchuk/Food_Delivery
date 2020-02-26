using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Food_Delivery.Data.EFContext;
using Food_Delivery.Data.Models;
using Food_Delivery.Services;
using Food_Delivery.View_Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Food_Delivery.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<DbUser> _userManager;
        private readonly SignInManager<DbUser> _signInManager;
        private readonly EFDbContext _context;


        public AccountController(UserManager<DbUser> userManager,
             SignInManager<DbUser> signInManager,
             EFDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        [HttpGet]
        [Route("Account/ChangePassword/{id}")]
        public IActionResult ChangePassword(string id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model, string id)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Цей користувач не зареєстрований");
                    return View(model);
                }
                var newPassword = _userManager.PasswordHasher.HashPassword(user, model.Password);
                user.PasswordHash = newPassword;
                var result = await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Login", "Account");
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.Users.FirstOrDefault(u => u.Email == model.Email);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "Цей email не зареєстрований");
                    return View(model);
                }
                EmailService emailService = new EmailService();
                //var userName = user.UserProfile;
                string url = "https://localhost:44315/Account/ChangePassword/" + user.Id;
                var username = user.UserName;
                await emailService.SendEmailAsync(user.Email, "Forgot Password",
                    $"Dear," +
                    $"<br/>" +
                    $"To change your password" +
                    $"you should visit this link: <a href='{url}'>Press</a>");
            }
            return View(model);
           // return RedirectToAction("Index", "Красіва сторіночка яка каже шо все добре");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _context.Users.FirstOrDefault(u => u.Email == model.Login);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Некоректний логін");
                return View(model);
            }

            var result = _signInManager
                .PasswordSignInAsync(user, model.Password, false, false).Result;

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Некоректний пароль");
                return View(model);
            }

            await _signInManager.SignInAsync(user, isPersistent: false);

            await Authenticate(model.Login);

            var userinfo = new UserInfo()
            {
                UserId = user.Id,
                Email = user.Email
            };

            HttpContext.Session.SetString("SessionUserData", JsonConvert.SerializeObject(userinfo));

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserProfile userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                DbUser user = new DbUser
                {
                    Email = model.Email,
                    UserName = model.Login,
                    UserProfile = userProfile
                };

                var rolename = "User";
                var result = await _userManager.CreateAsync(user, model.Password);
                result = _userManager.AddToRoleAsync(user, rolename).Result;

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
                return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}