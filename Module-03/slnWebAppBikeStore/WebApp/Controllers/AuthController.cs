using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        MemberRepository repository;

        public AuthController(IConfiguration configuration)
        {
            repository = new MemberRepository(configuration);
        }

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
    }
}
