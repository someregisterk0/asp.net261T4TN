using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp
{
    class ProductRepository
    {
        readonly static string connectionString = @"Data Source=PM505-03\MSSQLSERVER2014;Initial Catalog=Stores;Integrated Security=True";

        public DataTable GetProduct()
        {
            IDbConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", connectionString);

            DataTable table = new DataTable();

            connection.Open();

            adapter.Fill(table);

            connection.Close();

            return table;
        }
    }
}
