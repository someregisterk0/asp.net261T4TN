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
    public class CoronaController : BaseController
    {
        public CoronaController(SiteProvider provider) : base(provider)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<string> GetCoronas()
        {
            return await provider.Corona.GetCoronas();
        }
    }
}
