using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace WebApp.Models
{
    public class SiteProvider : BaseProvider
    {
        IDbConnection connection;

        public SiteProvider(IConfiguration configuration) : base(configuration)
        {
        }

        BrandRepository brand;
        MemberInRoleRepository member;
        MemberInRoleRepository memberInRoleRepository;
        RoleRepository role;
        StoreRepository store;

        public StoreRepository Store
        {
            get
            {
                if (store is null)
                {
                    store = new StoreRepository(Connection);
                }
                return store;
            }
        }

        public BrandRepository Brand
        {
            get
            {
                if (brand is null)
                {
                    brand = new BrandRepository(Connection);
                }
                return brand;
            }
        }
    }
}

