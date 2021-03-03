using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        MemberRepository repository;

        public AuthController(IConfiguration configuration)
        {
            repository = new MemberRepository(configuration);
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Member obj)
        {
            repository.Add(obj);
            return RedirectToAction("signin");
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(SignInModel obj)
        {
            if (ModelState.IsValid)
            {
                Member member = repository.SignIn(obj);
                if (member != null)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, member.Username),
                        new Claim(ClaimTypes.NameIdentifier, member.Id.ToString()),
                        new Claim(ClaimTypes.Email, member.Email)
                    };

                    // Xử lý Login
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);  // CookieAuthenticationDefaults.AuthenticationScheme == chuỗi "Cookies"
                    ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                    // Remember me?
                    AuthenticationProperties properties = new AuthenticationProperties
                    {

                    };

                    HttpContext.SignInAsync(principal, properties);
                    return Redirect("/auth");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "SignIn Failed");
                }
            }
            return View(obj);
        }
    }
}
