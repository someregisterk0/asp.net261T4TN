using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository reporitory;

        public CategoryController(IConfiguration configuration)
        {
            reporitory = new CategoryRepository(configuration);
        }

        public IActionResult Index()
        {
            return View(reporitory.GetCategories());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            reporitory.Add(obj);
            return Redirect("/category");
        }
    }
}
