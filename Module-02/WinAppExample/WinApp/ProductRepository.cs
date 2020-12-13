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

        public int Add(Product obj)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Product (CategoryId, ProductName, Price, Quantity, ImageUrl, Description) " +
                "VALUES (@CategoryId, @Name, @Price, @Quantity, @ImageUrl, @Description)";

            IDataParameter categoryParameter = command.CreateParameter();
            categoryParameter.ParameterName = "@CategoryId";
            categoryParameter.Value = obj.CategoryId;
            command.Parameters.Add(categoryParameter);

            IDataParameter nameParameter = command.CreateParameter();
            nameParameter.ParameterName = "@Name";
            nameParameter.Value = obj.Name;
            command.Parameters.Add(nameParameter);

            IDataParameter priceParameter = command.CreateParameter();
            priceParameter.ParameterName = "@Price";
            priceParameter.Value = obj.Price;
            command.Parameters.Add(priceParameter);

            IDataParameter quantityParameter = command.CreateParameter();
            quantityParameter.ParameterName = "@ImageUrl";
            quantityParameter.Value = obj.ImageUrl;
            command.Parameters.Add(quantityParameter);

            IDataParameter ImageUrlParameter = command.CreateParameter();
            ImageUrlParameter.ParameterName = "@Quantity";
            ImageUrlParameter.Value = obj.Quantity;
            command.Parameters.Add(ImageUrlParameter);

            IDataParameter descriptionParameter = command.CreateParameter();
            descriptionParameter.ParameterName = "@Description";
            descriptionParameter.Value = obj.Description;
            command.Parameters.Add(descriptionParameter);

            connection.Open();

            int ret = command.ExecuteNonQuery();

            connection.Close();

            return ret;
        }

        public DataTable GetProductById(int id)
        {
            IDbConnection connection = new SqlConnection(connectionString);

            IDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Product WHERE ProductId = @id";

            IDataParameter idParameter = command.CreateParameter();
            idParameter.ParameterName = "@id";
            idParameter.Value = id;
            command.Parameters.Add(idParameter);

            SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)command);

            DataTable table = new DataTable();
            connection.Open();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
