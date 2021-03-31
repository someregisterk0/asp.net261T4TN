using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Models;

namespace WebApp.Areas.Dashboard.Controllers
{
    [Area("dashboard")]
    public class HomeController : BaseController
    {
        public HomeController(SiteProvider provider) : base(provider)
        {
        }

        public IActionResult Index()
        {
            return View(provider.Category.GetStatistics());
        }

        public IActionResult PieChart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Pie()
        {
            return Json(provider.Category.GetStatistics());
        }
    }
}
