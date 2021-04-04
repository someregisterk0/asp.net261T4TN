using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Category
    {
        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
    }
}
