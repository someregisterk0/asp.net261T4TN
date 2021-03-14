using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(SiteProvider provider) : base(provider)
        {
        }

        public IActionResult Index()
        {
            ViewBag.welcome = "Hello <b>Danh</b>";

            ViewBag.categories = provider.Category.GetCategories();
            return View(provider.Product.GetProducts());
        }

        public IActionResult Category(short id)
        {
            ViewBag.categories = provider.Category.GetCategories();
            return View("Index", provider.Product.GetProductsByCategory(id));
        }

        public IActionResult Detail(short id)
        {
            ViewBag.categories = provider.Category.GetCategories();
            Product obj = provider.Product.GetProduct(id);
            ViewBag.relations = provider.Product.GetProductsRelation(obj.CategoryId, id);
            return View(obj);
        }
    }
}
