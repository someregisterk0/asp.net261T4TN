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
        int size = 20;

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

        public IActionResult Index(int id = 1)
        {
            int total;
            List<Product> list = repository.GetProducts((id - 1) * size, size, out total);
            ViewBag.pages = ((total - 1) / size) + 1;
            ViewBag.p = id;
            Console.WriteLine(total);
            return View(list);
        }

        public IActionResult Create()
        {
            ViewBag.brands = brandRepository.GetBrands();
            ViewBag.categories = categoryRepository.GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            try
            {
                repository.Add(obj);
                return Redirect("/product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Redirect("/production/error");
            }
        }

        public IActionResult Edit(int id)
        {
            ViewBag.brands = brandRepository.GetBrands();
            ViewBag.categories = categoryRepository.GetCategories();
            return View(repository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            try
            {
                repository.Edit(obj);
                return Redirect("/product");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Redirect("/production/error");
            }
        }

        public IActionResult LoadMore()
        {
            int total;
            List<Product> list = repository.GetProducts(0, size, out total);
            ViewBag.n = ((total - 1) / size) + 1;
            return View(list);
        }
        [HttpPost]
        public IActionResult LoadMore(int id)
        {
            return Json(repository.GetProducts((id - 1) * size, size));
        }

        public IActionResult Lazy()
        {
            int total;
            List<Product> list = repository.GetProducts(0, size, out total);
            ViewBag.n = ((total - 1) / size) + 1;
            return View(list);
        }

        public IActionResult Search(string q, int id = 1)
        {
            int total;
            List<Product> list = repository.SearchProducts(q, (id - 1) * size, size, out total);
            ViewBag.n = (total - 1) / size + 1;
            return View(list);
        }
    }
}
