using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
