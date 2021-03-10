using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        //DI
        protected SiteProvider provider;

        protected BaseController(IConfiguration configuration )
        {
            provider = new SiteProvider(configuration);
        }

        protected override void Dispose(bool disposing)
        {
            provider.Dispose();
        }
    }
}
