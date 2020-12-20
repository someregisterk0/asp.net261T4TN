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

        public Employee GetEmployees()
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Employees";

            connection.Open();

            IDataReader reader = command.ExecuteReader();
            Employee obj = null;
            while(reader.Read())
            {
                obj = new Employee()
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
                    Region = (string)reader["Region"],
                    PostalCode = (string)reader["PostalCode"],
                    Country = (string)reader["Country"],
                    HomePhone = (string)reader["HomePhone"],
                    Extension = (string)reader["Extension"],
                    Photo = (byte[])reader["Photo"],
                    Notes = (string)reader["Notes"],
                    ReportsTo = (int)reader["ReportsTo"]
                };
            }
            reader.Close();

            connection.Close();

            return obj;
        }
    }
}
