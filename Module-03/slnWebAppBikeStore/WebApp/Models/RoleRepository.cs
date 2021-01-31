using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace WebApp.Models
{
    public class RoleRepository : BaseRepository
    {
        public RoleRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public int Add(Role obj)
        {
            Parameter parameter = new Parameter { Name = "@Name", Value = obj.Name };
            return Save("AddRole", parameter, CommandType.StoredProcedure);
        }

        public List<Role> GetRoles()
        {
            using (IDbConnection connection = new SqlConnection(configuration.GetConnectionString("BikeStore")))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Role";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Role> list = new List<Role>();
                        while (reader.Read())
                        {
                            list.Add(Fetch(reader));
                        }
                        return list;
                    }
                }
            }
        }

        static Role Fetch(IDataReader reader)
        {
            return new Role
            {
                Id = (Guid)reader["RoleId"],
                Name = (string)reader["RoleName"],
            };
        }
    }
}
