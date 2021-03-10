using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class StoreRepository : BaseRepository
    {
        public StoreRepository(IDbConnection connection) : base(connection)
        {
        }

        public List<Store> GetStores()
        {
            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM sales.Store";
                command.CommandType = CommandType.Text;

                //connection.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Store> list = new List<Store>();
                    while (reader.Read())
                    {
                        list.Add(new Store
                        {
                            Id = (short)reader["StoreId"],
                            Name = (string)reader["StoreName"],
                            Phone = (string)reader["Phone"],
                            Email = (string)reader["Email"],
                            Street = (string)reader["Street"],
                            City = (string)reader["City"],
                            State = (string)reader["State"],
                            ZipCode = (string)reader["ZipCode"],
                        });
                    }
                    return list;
                }
            }
        }
    }
}
