using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Areas.Dashboard.Controllers
{
    [Area("dashboard")]
    public class StoreController : Controller
    {
        SiteProvider provider;

        public StoreController(SiteProvider provider)
        {
            this.provider = provider;
        }

        public IActionResult Index()
        {
            return View(provider.Store.GetStores());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
