using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SiteProvider : BaseProvider
    {
        public SiteProvider(IConfiguration configuration) : base(configuration)
        {
        }

        public void DoSomeThing()
        {
            Console.WriteLine($"Connection State: {Connection.State}");
            Console.WriteLine(Connection.ConnectionString);
            Console.WriteLine("SiteProvider Do Something.");
        }
    }
}
