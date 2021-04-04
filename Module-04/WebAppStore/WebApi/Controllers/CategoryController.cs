using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        SiteProvider provider;

        public CategoryController(SiteProvider provider)
        {
            this.provider = provider;
        }

        public IEnumerable<Category> GetCategories()
        {
            return provider.Category.GetCategories();
        }

        [HttpPost]
        public int Post(Category obj)
        {
            return provider.Category.Add(obj);
        }

        //[HttpDelete("{id}/{pid}")] => public int Delete(short id, int pid)
        [HttpDelete("{id}")] 
        public int Delete(short id)
        {
            return provider.Category.Delete(id);
        }

        [HttpGet("{id}")]
        public Category GetCategoryById(short id)
        {
            return provider.Category.GetCategoryById(id);
        }

        [HttpPut]
        public int Put(Category obj)
        {
            return provider.Category.Edit(obj);
        }

        //public string Welcome()
        //{
        //    return "Welcome";
        //}
    }
}
