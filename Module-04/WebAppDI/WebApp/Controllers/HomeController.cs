using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        IAbc abc;

        IDbConnection connection;

        SiteProvider provider;

        //public HomeController(IAbc abc, IDbConnection connection)
        //{
        //    this.abc = abc;
        //    this.connection = connection;
        //}

        public HomeController(SiteProvider provider, IAbc abc)
        {
            this.provider = provider;
            this.abc = abc;
        }

        public IActionResult Index()
        {
            //abc.DoSomeThing();
            //connection.Open();

            //Console.WriteLine($"Connection State: {connection.State}");
            //Console.WriteLine(connection.ConnectionString);
            abc.DoSomeThing();
            provider.DoSomeThing();

            return View();
        }

        public IActionResult About()
        {
            provider.DoSomeThing();
            return View();
        }

    }
}
