using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class BrandController : Controller
    {
        BrandRepository reporitory;

        public BrandController(IConfiguration configuration)
        {
            reporitory = new BrandRepository(configuration);
        }

        public IActionResult Index()
        {
            return View(reporitory.GetBrands());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brand obj)
        {
            reporitory.Add(obj);
            return Redirect("/brand");
        }
    }
}
