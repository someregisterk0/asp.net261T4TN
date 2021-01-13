using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repository;
        //
        CategoryRepository categoryRepository;
        BrandRepository brandRepository;

        public ProductController(IConfiguration configuration)
        {
            repository = new ProductRepository(configuration);
            categoryRepository = new CategoryRepository(configuration);
            brandRepository = new BrandRepository(configuration);
        }

        public IActionResult Index()
        {
            return View(repository.GetProducts());
        }

        public IActionResult Create()
        {
            ViewBag.brands = brandRepository.GetBrands();
            ViewBag.categories = categoryRepository.GetCategories();
            return View();
        }
    }
}
