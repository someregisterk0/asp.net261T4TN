using System;

namespace WebApp.Models
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public int  ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitOfPrice { get; set; }
        public string ImageUrl { get; set; }
        public short Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
