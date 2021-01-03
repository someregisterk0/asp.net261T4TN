using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WinApp
{
    class MenuItemRepository : BaseRepository
    {
        public List<MenuItem> GetMenuItems()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM MenuItem";
                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        Dictionary<string, List<MenuItem>> dict = new Dictionary<string, List<MenuItem>>();
                        List<MenuItem> list = new List<MenuItem>();
                        while(reader.Read())
                        {
                            MenuItem obj = new MenuItem
                            {
                                Id = (string)reader["MenuItemId"],
                                Name = (string)reader["MenuItemName"],
                                FormName = reader["FormName"] != DBNull.Value ? (string)reader["FormName"] : null
                            };
                            if(reader["ParentId"] == DBNull.Value)
                            {
                                list.Add(obj);
                            }
                            else
                            {
                                string k = (string)reader["ParentId"];
                                if(!dict.ContainsKey(k))
                                {
                                    dict.Add(k, new List<MenuItem>());
                                }
                                dict[k].Add(obj);
                            }
                        }
                        foreach (MenuItem item in list)
                        {
                            if (dict.ContainsKey(item.Id))
                            {
                                item.Children = dict[item.Id];
                            }
                        }
                        return list;
                    }
                }
            }
        }

        public List<MenuItem> GetParents()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM MenuItem WHERE ParentId IS NULL";
                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<MenuItem> list = new List<MenuItem>();
                        while (reader.Read())
                        {
                            MenuItem obj = new MenuItem
                            {
                                Id = (string)reader["MenuItemId"],
                                Name = (string)reader["MenuItemName"],
                                FormName = reader["FormName"] != DBNull.Value ? (string)reader["FormName"] : null
                            };
                            list.Add(obj);
                        }
                        return list;
                    }
                }
            }
        }

        public List<MenuItem> GetAllMenuItem()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM MenuItem";
                    connection.Open();

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        List<MenuItem> list = new List<MenuItem>();
                        while (reader.Read())
                        {
                            MenuItem obj = new MenuItem
                            {
                                Id = (string)reader["MenuItemId"],
                                Name = (string)reader["MenuItemName"],
                                FormName = reader["FormName"] != DBNull.Value ? (string)reader["FormName"] : null,
                                ParentId = reader["ParentId"] != DBNull.Value ? (string)reader["ParentId"] : null
                            };
                            list.Add(obj);
                        }
                        return list;
                    }
                }
            }
        }



        public int AddMenuItem(MenuItem obj)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "AddMenuItem";
                    command.CommandType = CommandType.StoredProcedure;

                    IDataParameter idParameter = command.CreateParameter();
                    idParameter.ParameterName = "@Id";
                    idParameter.Value = obj.Id;
                    command.Parameters.Add(idParameter);

                    IDataParameter nameParameter = command.CreateParameter();
                    nameParameter.ParameterName = "@Name";
                    nameParameter.Value = obj.Name;
                    command.Parameters.Add(nameParameter);

                    IDataParameter formNameParameter = command.CreateParameter();
                    formNameParameter.ParameterName = "@FormName";
                    formNameParameter.Value = obj.FormName;
                    command.Parameters.Add(formNameParameter);

                    IDataParameter parentIdParameter = command.CreateParameter();
                    parentIdParameter.ParameterName = "@ParentId";
                    parentIdParameter.Value = obj.ParentId;
                    command.Parameters.Add(parentIdParameter);

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
