using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class UploadController : Controller
    {
        public IActionResult Index(IFormFile f)
        {
            if (f != null)
            {
                Console.WriteLine("Thu muc hien hanh:");
                Console.WriteLine(Directory.GetCurrentDirectory());

                string fileName = Helper.RandomString(32) + Path.GetExtension(f.FileName);

                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", fileName);
                Console.WriteLine(path);

                using (Stream stream = System.IO.File.Create(path))
                {
                    f.CopyTo(stream);
                }

                Console.WriteLine(f.Name);

                //Tên tập tên
                Console.WriteLine(f.FileName);
                Console.WriteLine(f.ContentType);
                Console.WriteLine(f.Length);

                return View("Index", fileName);
            }
            else
            {
                Console.WriteLine("NULL");
            }

            return View();
        }

        public IActionResult Multiple()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Multiple(IFormFile[] af)  /* af = Array file */
        {
            if (af != null)
            {
                List<string> list = new List<string>();
                string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload");
                foreach (IFormFile f in af)
                {
                    string path = Path.Combine(root, f.FileName);
                    using (Stream stream = System.IO.File.Create(path))
                    {
                        f.CopyTo(stream);
                    }
                    list.Add(f.FileName);
                }
                return View(list);
            }
            return View();
        }

        public IActionResult Online()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Online(string url)
        {
            // Đường dẫn url
            Console.WriteLine(url);
            // lấy tên file
            Console.WriteLine(Path.GetFileName(url));

            string fileName = Path.GetFileName(url);

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", fileName);

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, path);
            }
            return View("Online", fileName);
        }

        public IActionResult Ajax()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajax(IFormFile f)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload", f.FileName);
            using (Stream stream = System.IO.File.Create(path))
            {
                f.CopyTo(stream);
            }
            return Json(new { name = f.FileName });
        }

        public IActionResult Icon()
        {
            return View();
        }

        public IActionResult IconMultiple()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AjaxMultiple(IFormFile[] af)
        {
            List<string> list = new List<string>();
            string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "upload");
            foreach (IFormFile f in af)
            {
                using (Stream stream = System.IO.File.Create(Path.Combine(root, f.FileName)))
                {
                    f.CopyTo(stream);
                }
                list.Add(f.FileName);
            }
            return Json(list);
        }
    }
}
