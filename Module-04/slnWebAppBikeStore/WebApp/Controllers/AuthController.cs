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
        RoleRepository roleRepository;

        public AuthController(IConfiguration configuration)
        {
            repository = new MemberRepository(configuration);
            roleRepository = new RoleRepository(configuration);
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

                    //Roles
                    List<Role> roles = roleRepository.GetRoles(member.Id);
                    foreach (Role role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role.Name));
                    }

                    // Xử lý Login
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);  // CookieAuthenticationDefaults.AuthenticationScheme == chuỗi "Cookies"
                    ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                    // Remember me?
                    AuthenticationProperties properties = new AuthenticationProperties
                    {
                        IsPersistent = obj.Rem 
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

        [Authorize]
        public IActionResult LogOut() //Tên hàm SignOut bị trùng trong BaseController
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/auth/signin");
        }

        public IActionResult Denied()
        {
            return View();
        }
    }
}
