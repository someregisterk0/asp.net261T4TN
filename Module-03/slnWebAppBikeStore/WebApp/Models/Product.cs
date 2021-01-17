using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public short BrandId { get; set; }
        public string BrandName { get; set; }
        public short ModelYear { get; set; }
        public decimal Price { get; set; }
    }
}
