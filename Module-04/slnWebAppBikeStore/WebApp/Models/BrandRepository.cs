using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class BrandRepository : BaseRepository
    {
        public BrandRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public BrandRepository(IDbConnection connection) : base(connection)
        {

        }

        public List<Brand> GetBrands()
        {
            //using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            //{
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM production.Brand";
                    command.CommandType = CommandType.Text;

                    //connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Brand> list = new List<Brand>();
                        while (reader.Read())
                        {
                            list.Add(Fetch(reader));
                        }
                        return list;
                    }
                }
            //}
        }

        public int Add(Brand obj)
        {
            Parameter[] parameters =
            {
                new Parameter
                {
                    Name = "@Id",
                    Value = obj.Id
                },
                new Parameter
                {
                    Name = "@Name",
                    Value = obj.Name
                }
            };
            string sql = "AddBrand";
            return Save(sql, parameters, CommandType.StoredProcedure);
        }

        public Brand GetBrandById(int id)
        {
            //using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            //{
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM production.Brand WHERE BrandId = @Id";
                    command.CommandType = CommandType.Text;

                    //IDataParameter idParameter = command.CreateParameter();
                    //idParameter.ParameterName = "@Id";
                    //idParameter.Value = id;
                    //command.Parameters.Add(idParameter);
                    Add(command, new Parameter { Name = "@Id", Value = id });

                    //connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Fetch(reader);
                        }
                        return null;
                    }
                }
           // }
        }

        Brand Fetch(IDataReader reader)
        {
            return new Brand()
            {
                Id = (short)reader["BrandId"],
                Name = (string)reader["BrandName"]
            };
        }
    }
}
