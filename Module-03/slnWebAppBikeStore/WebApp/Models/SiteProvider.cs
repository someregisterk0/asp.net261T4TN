using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp.Models
{
    public class SiteProvider : IDisposable
    {
        IDbConnection connection;

        public SiteProvider(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration.GetConnectionString("BikeStore"));
            connection.Open();
        }

        BrandRepository brand;
        MemberInRoleRepository member;
        MemberInRoleRepository memberInRoleRepository;
        RoleRepository role;

        public BrandRepository Brand
        {
            get
            {
                if (brand is null)
                {
                    brand = new BrandRepository(connection);
                }
                return brand;
            }
        }

        public void Dispose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}

