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
    }
}
