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
        InvoiceRepository invoice;
        InvoiceDetailRepository invoiceDetail;
        AccountRepository account;
        ProvinceRepository province;
        DistrictRepository district;
        WardRepository ward;

        public WardRepository Ward
        {
            get
            {
                if (ward is null)
                {
                    ward = new WardRepository(Connection);
                }
                return ward;
            }
        }

        public DistrictRepository District
        {
            get
            {
                if (district is null)
                {
                    district = new DistrictRepository(Connection);
                }
                return district;
            }
        }

        public ProvinceRepository Province
        {
            get
            {
                if (province is null)
                {
                    province = new ProvinceRepository(Connection);
                }
                return province;
            }
        }

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

        public InvoiceRepository Invoice
        {
            get
            {
                if (invoice is null)
                {
                    invoice = new InvoiceRepository(Connection);
                }
                return invoice;
            }
        }

        public InvoiceDetailRepository InvoiceDetail
        {
            get
            {
                if (invoiceDetail is null)
                {
                    invoiceDetail = new InvoiceDetailRepository(Connection);
                }
                return invoiceDetail;
            }
        }

        public AccountRepository Account
        {
            get
            {
                if (account is null)
                {
                    account = new AccountRepository(Connection);
                }
                return account;
            }
        }
    }
}
