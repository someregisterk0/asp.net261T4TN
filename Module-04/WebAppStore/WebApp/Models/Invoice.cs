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
        public string  Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string  Address { get; set; }
        public IEnumerable<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
