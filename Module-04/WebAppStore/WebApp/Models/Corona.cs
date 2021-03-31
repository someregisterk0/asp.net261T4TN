using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Corona
    {
        public long Updated { get; set; }
        public string Country { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
    }
}
