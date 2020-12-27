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
            using (IDbConnection connection = new SqlConnection(connectionString))
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

        public List<Customer> SearchCustomer(string q)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SearchCustomer";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@Q";
                    parameter.Value = "%" + q + "%";
                    command.Parameters.Add(parameter);

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

        public List<Customer> SearchCustomer(string q, int index, int size, out int total)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SearchAndPaginationCustomer";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@Q";
                    parameter.Value = "%" + q + "%";
                    command.Parameters.Add(parameter);

                    IDataParameter indexParameter = command.CreateParameter();
                    indexParameter.ParameterName = "@PageIndex";
                    indexParameter.Value = index;
                    command.Parameters.Add(indexParameter);

                    IDataParameter sizeParameter = command.CreateParameter();
                    sizeParameter.ParameterName = "@PageSize";
                    sizeParameter.Value = size;
                    command.Parameters.Add(sizeParameter);

                    IDataParameter totalParameter = command.CreateParameter();
                    totalParameter.ParameterName = "@Total";
                    totalParameter.DbType = DbType.Int32;
                    totalParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(totalParameter);

                    connection.Open();

                    List<Customer> list = new List<Customer>();
                    using (IDataReader reader = command.ExecuteReader())
                    {
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
                    }
                    // Lấy tham số đầu ra
                    IDataParameter output = (IDataParameter)command.Parameters["@Total"];
                    total = (int)output.Value;
                    return list;
                }
            }

        }

        public List<Customer> SearchCustomer2(string q, string city)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SearchCustomer2";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter parameter = command.CreateParameter();
                    parameter.ParameterName = "@Q";
                    parameter.Value = "%" + q + "%";
                    command.Parameters.Add(parameter);

                    IDataParameter cityParameter = command.CreateParameter();
                    cityParameter.ParameterName = "@City";
                    cityParameter.Value = city;
                    command.Parameters.Add(cityParameter);

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

        public List<string> GetCities(string state = null)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "GetCities";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter stateParameter = command.CreateParameter();
                    stateParameter.ParameterName = "@State";
                    stateParameter.Value = state;
                    command.Parameters.Add(stateParameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (reader.Read())
                        {
                            list.Add((string)reader["City"]);
                        }
                        return list;
                    }
                }
            }
        }

        /*
        public List<string> GetCities(string state)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT City FROM sales.Customer WHERE State = @State;";
                    command.CommandType = CommandType.Text;

                    IDataParameter stateParameter = command.CreateParameter();
                    stateParameter.ParameterName = "@State";
                    stateParameter.Value = state;
                    command.Parameters.Add(stateParameter);

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while(reader.Read())
                        {
                            list.Add((string)reader["City"]);
                        }
                        return list;
                    }
                }
            }
        }

        public List<string> GetCities()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT City FROM sales.Customer;";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (reader.Read())
                        {
                            list.Add((string)reader["City"]);
                        }
                        return list;
                    }
                }
            }
        }
        */

        public List<string> GetState()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT State FROM sales.Customer;";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (reader.Read())
                        {
                            list.Add((string)reader["State"]);
                        }
                        return list;
                    }
                }
            }
        }

        public List<string> GetFirstName()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT DISTINCT FirstName FROM sales.Customer;";
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<string> list = new List<string>();
                        while (reader.Read())
                        {
                            list.Add((string)reader["FirstName"]);
                        }
                        return list;
                    }
                }
            }
        }
    }
}
