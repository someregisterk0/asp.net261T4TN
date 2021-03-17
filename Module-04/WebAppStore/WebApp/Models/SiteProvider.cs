using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SiteProvider : BaseProvider
    {
        public SiteProvider(IConfiguration configuration) : base(configuration)
        {
        }

        CategoryRepository category;
        ProductRepository product;
        CartRepository cart;

        public CategoryRepository Category
        {
            get
            {
                if (category is null)
                {
                    category = new CategoryRepository(Connection);
                }
                return category;
            }
        }

        public ProductRepository Product
        {
            get
            {
                if (product is null)
                {
                    product = new ProductRepository(Connection);
                }
                return product;
            }
        }

        public CartRepository Cart
        {
            get
            {
                if (cart is null)
                {
                    cart = new CartRepository(Connection);
                }
                return cart;
            }
        }
    }
}
