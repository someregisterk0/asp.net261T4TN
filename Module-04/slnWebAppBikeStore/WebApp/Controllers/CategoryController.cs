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
        CategoryRepository repository;
        public CategoryController(IConfiguration configuration)
        {
            repository = new CategoryRepository(configuration);
        }

        public IActionResult Index()
        {
            //return View(repository.GetCategories());
            return View("index", repository.GetCategories());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            repository.Add(obj);
            return Redirect("/category");
        }

        public IActionResult Delete(int id)
        {
            if (repository.Delete(id) > 0)
            {
                return Redirect("/category");
            }
            else
            {
                return Error();
            }
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(repository.GetCategoryById(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Category obj)
        {
            try
            {
                repository.Edit(obj);
                return Redirect("/category");
            }
            catch
            {
                return Redirect("/category/error");
            }
        }

        public IActionResult DelAll(int[] a)
        {
            try
            {
                repository.Delete(a);
                return Redirect("/category");
            }
            catch 
            {
                return Redirect("/category/error");
            }
        }
    }
}
