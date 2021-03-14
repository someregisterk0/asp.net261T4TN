using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected SiteProvider provider;

        protected BaseController(SiteProvider provider)
        {
            this.provider = provider;
        }
    }
}
