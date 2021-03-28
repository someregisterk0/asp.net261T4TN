using System.Collections.Generic;

namespace WebApp.Models
{
    public class Category
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public List<Product> Products { get; set; }
    }
}
