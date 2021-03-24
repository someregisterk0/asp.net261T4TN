using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Invoice
    {
        public Guid InvoiceId { get; set; }
        public Guid CartId { get; set; }
        public Guid AccountId { get; set; }
        public string  Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string  Address { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string WardId { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
