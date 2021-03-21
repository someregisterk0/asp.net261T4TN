using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CartController : BaseController
    {
        public CartController(SiteProvider provider) : base(provider)
        {
        }

        public IActionResult Index()
        {
            if (Request.Cookies["cartId"] != null)
            {
                Guid cartId = Guid.Parse(Request.Cookies["cartId"]);
                IEnumerable<Cart> list = provider.Cart.GetCarts(cartId);
                return View(list);
            }
            return Redirect("/");
        }

        [HttpPost]
        public IActionResult Add(Cart obj)
        {
            /*
             * Lưu CartId bằng biến Static -> failed
            if (Helper.CartId is null)
            {
                Helper.CartId = Guid.NewGuid();
            }
            obj.CartId = Helper.CartId.Value;
            */

            /*
             * Lưu CartId bằng Cookie
            */
            if (Request.Cookies["cartId"] is null)
            {
                CookieOptions options = new CookieOptions
                {
                    Path = "/",
                    Expires = DateTime.UtcNow.AddDays(30)
                };
                obj.CartId = Guid.NewGuid();
                Response.Cookies.Append("cartId", obj.CartId.ToString(), options);
            }
            else
            {
                obj.CartId = Guid.Parse(Request.Cookies["cartId"]);
            }

            provider.Cart.Add(obj);
            return Redirect("/cart");
        }

        public IActionResult Delete(int id)
        {
            if (Request.Cookies["cartId"] != null)
            {
                Guid cartId = Guid.Parse(Request.Cookies["cartId"]);
                provider.Cart.Delete(cartId, id);
            }
            return Redirect("/cart");
        }

        public IActionResult Edit(Cart obj)
        {
            if (Request.Cookies["cartId"] != null)
            {
                obj.CartId = Guid.Parse(Request.Cookies["cartId"]);
                return Json(provider.Cart.Update(obj));
            }
            return Json(-1);
        }

        [Authorize]
        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Invoice obj)
        {
            if (Request.Cookies["cartId"] != null)
            {
                obj.InvoiceId = obj.CartId = Guid.Parse(Request.Cookies["cartId"]);
                provider.Invoice.Add(obj);
                // Xóa Cookie cũ
                Response.Cookies.Delete("cartId", new CookieOptions { Path = "/" });
                return Redirect($"/invoice/detail/{obj.CartId}");
            }
            return Redirect("/");
        }
    }
}
