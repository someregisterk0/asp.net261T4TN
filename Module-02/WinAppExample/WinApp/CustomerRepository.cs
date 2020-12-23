using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class CustomerRepository : BaseRepository
    {
        public int CountCustomer()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "CountCustomer";
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public List<Customer> GetCustomers(int index, int size)
        {
            using(IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetCustomers";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter indexParameter = command.CreateParameter();
                    indexParameter.ParameterName = "@PageIndex";
                    indexParameter.Value = index;
                    command.Parameters.Add(indexParameter);

                    IDataParameter sizeParameter = command.CreateParameter();
                    sizeParameter.ParameterName = "@PageSize";
                    sizeParameter.Value = size;
                    command.Parameters.Add(sizeParameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<Customer> list = new List<Customer>();
                        while (reader.Read())
                        {
                            Customer obj = new Customer
                            {
                                Id = (int)reader["CustomerId"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : null,
                                Email = (string)reader["Email"],
                                Street = (string)reader["Street"],
                                City = (string)reader["City"],
                                State = (string)reader["State"],
                                ZipCode = (string)reader["ZipCode"]
                            };
                            list.Add(obj);
                        }
                        return list;
                    }
                }
            }
        } 
    }
}
