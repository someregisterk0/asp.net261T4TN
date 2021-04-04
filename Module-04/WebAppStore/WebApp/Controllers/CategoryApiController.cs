using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CategoryApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344");
                HttpResponseMessage responseMessage = await client.GetAsync("/api/category");
                if (responseMessage.IsSuccessStatusCode)
                {
                    List<Category> list = await responseMessage.Content.ReadAsAsync<List<Category>>();
                    return View(list);
                }
            }
            return View();
        }

        public async Task<IActionResult> Edit(short id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344");
                HttpResponseMessage responseMessage = await client.GetAsync("/api/category/" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    Category obj = await responseMessage.Content.ReadAsAsync<Category>();
                    return View(obj);
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(short id, Category obj)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344");
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync<Category>("/api/category/", obj);
                if (responseMessage.IsSuccessStatusCode)
                {
                    int ret = await responseMessage.Content.ReadAsAsync<int>();
                    Console.WriteLine(ret);
                }
            }
            return Redirect("/categoryapi");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category obj)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344");
                HttpResponseMessage responseMessage = await client.PostAsJsonAsync("/api/category", obj);
                if (responseMessage.IsSuccessStatusCode)
                {
                    int ret = await responseMessage.Content.ReadAsAsync<int>();
                }
                return Redirect("/categoryapi");
            }
        }

        //[HttpGet("/categoryapi/delete/{id}/{pid}")]
        public async Task<IActionResult> Delete(short id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44344");
                HttpResponseMessage responseMessage = await client.DeleteAsync($"/api/category/{id}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    int ret = await responseMessage.Content.ReadAsAsync<int>();
                }
                return Redirect("/categoryapi");
            }
        }
    }
}
