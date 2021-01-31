using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RoleController : Controller
    {
        RoleRepository repository;

        public RoleController(IConfiguration configuration)
        {
            repository = new RoleRepository(configuration);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Role obj)
        {
            repository.Add(obj);
            return RedirectToAction("index");
        }
    }
}
