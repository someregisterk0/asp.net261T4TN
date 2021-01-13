using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository(IConfiguration configuration) : base(configuration)
        {

        }

        Product Fetch(IDataReader reader)
        {
            return new Product
            {
                Id = (int)reader["ProductId"],
                Name = (string)reader["ProductName"],
                CategoryId = (short)reader["CategoryId"],
                BrandId = (short)reader["BrandId"],
                ModelYear = (short)reader["ModelYear"],
                Price = (decimal)reader["Price"]
            };
        }

        public List<Product> GetProducts()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetProducts";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Product> list = new List<Product>();
                        while (reader.Read())
                        {
                            list.Add(Fetch(reader));
                        }
                        return list;
                    }
                }
            }
        }

    }
}
