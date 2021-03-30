using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(SiteProvider provider) : base(provider)
        {
        }

        public IActionResult Index(int id = 1)
        {
            //ViewBag.welcome = "Hello <b>Danh</b>";

            ViewBag.categories = provider.Category.GetCategories();

            //Pagination, load sản phẩm theo phân trang
            int size = 10;
            int total;
            IEnumerable<Product> list = provider.Product.GetProducts((id - 1) * size, size, out total);
            ViewBag.n = ((total - 1) / size) + 1;
            ViewBag.total = total;
            return View(list);
        }

        [Route("/home/category/{id}/{p?}")]
        public IActionResult Category(short id, int p = 1)
        {
            ViewBag.categories = provider.Category.GetCategories();

            int total;
            int size = 10;
            IEnumerable<Product> list = provider.Product.GetProductsByCategory(id, p, size, out total);
            ViewBag.total = total;
            return View(list);
        }

        public IActionResult Detail(short id)
        {
            ViewBag.categories = provider.Category.GetCategories();
            Product obj = provider.Product.GetProduct(id);
            ViewBag.relations = provider.Product.GetProductsRelation(obj.CategoryId, id);
            return View(obj);
        }

        public IActionResult List()
        {
            IEnumerable<Category> list = provider.Category.GetCategories();
            Dictionary<short, List<Product>> dict = provider.Product.KeyValuePairs();
            foreach (Category item in list)
            {
                if (dict.ContainsKey(item.CategoryId))
                {
                    item.Products = dict[item.CategoryId];
                }
            }
            return View(list);
        }

        public IActionResult Search(string q)
        {
            ViewBag.categories = provider.Category.GetCategories();
            return View(provider.Product.SearchProducts(q));
        }
    }
}
