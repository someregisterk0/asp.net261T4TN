using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Core
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(IDbConnection connection) : base(connection)
        {
        }

        public int Add(Category obj)
        {
            string sql = "INSERT INTO Category VALUES (@Name)";
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@Name", obj.Name);
            return Save(sql, parameter);
        }

        public List<Category> GetCategories()
        {
            /*using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Category";
                using (IDataReader reader = command.ExecuteReader())
                {
                    List<Category> list = new List<Category>();
                    while (reader.Read())
                    {
                        list.Add(Fetch(reader));
                    }
                    return list;
                }
            }*/
            string sql = "SELECT * FROM Category";
            return FetchAll(sql);
        }

        public Category GetCategoryById(short id)
        {
            /*using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Category WHERE CategoryId = @Id";

                IDbDataParameter parameter = command.CreateParameter();
                parameter.Value = id;
                parameter.ParameterName = "@Id";
                command.Parameters.Add(parameter);

                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Fetch(reader);
                    }
                    return null;
                }
            }*/
            string sql = "SELECT * FROM Category WHERE CategoryId = @Id";
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@Id", id);
            return FetchOne(sql, parameter);
        }

        protected override Category Fetch(IDataReader reader)
        {
            return new Category
            {
                Id = (short)reader["CategoryId"],
                Name = (string)reader["CategoryName"]
            };
        }
    }
}
