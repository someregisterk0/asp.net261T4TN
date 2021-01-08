using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    abstract class BaseRepository
    {
        protected static readonly string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        protected void Add(IDbCommand command, Parameter parameter)
        {
            IDataParameter dataParameter = command.CreateParameter();
            dataParameter.Value = parameter.Value;
            dataParameter.ParameterName = parameter.Name;
            dataParameter.Direction = parameter.ParameterDirection;
            dataParameter.DbType = parameter.DbType;
            command.Parameters.Add(dataParameter);
        }

        protected void Add(IDbCommand command, Parameter[] parameters)
        {
            foreach (Parameter parameter in parameters)
            {
                Add(command, parameter);
            }
        }

        protected int Save(string sql, Parameter parameter, CommandType commandType = CommandType.StoredProcedure)
        {
            /*
            IDbConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = commandType;
                    Add(command, parameter);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null & connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            */

            return Save(sql, new Parameter[] { parameter }, CommandType.Text);
        }


        protected int Save(string sql, Parameter[] parameters, CommandType commandType = CommandType.StoredProcedure)
        {
            IDbConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.CommandType = commandType;
                    Add(command, parameters);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null & connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
