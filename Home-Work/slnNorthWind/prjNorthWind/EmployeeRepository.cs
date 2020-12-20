using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace prjNorthWind
{
    class EmployeeRepository
    {
        public static readonly string connectionString = ConnectionString.connectionString;

        public List<Employee> GetEmployees()
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Employees";

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            List<Employee> list = new List<Employee>();
            while(reader.Read())
            {
                Employee obj = new Employee()
                {
                    EmployeeID = (int)reader["EmployeeID"],
                    LastName = (string)reader["LastName"],
                    FirstName = (string)reader["FirstName"],
                    Title = (string)reader["Title"],
                    TitleOfCourtesy = (string)reader["TitleOfCourtesy"],
                    BirthDate = (DateTime)reader["BirthDate"],
                    HireDate = (DateTime)reader["HireDate"],
                    Address = (string)reader["Address"],
                    City = (string)reader["City"],
                    Region = reader["Region"] != DBNull.Value ? (string)reader["Region"] : null,
                    PostalCode = (string)reader["PostalCode"],
                    Country = (string)reader["Country"],
                    HomePhone = (string)reader["HomePhone"],
                    Extension = (string)reader["Extension"],
                    Photo = (byte[])reader["Photo"],
                    Notes = (string)reader["Notes"],
                    ReportsTo = reader["ReportsTo"] != DBNull.Value ? (int?)reader["ReportsTo"] : null,
                };
                list.Add(obj);
            }
            reader.Close();

            connection.Close();

            return list;
        }
    }
}
