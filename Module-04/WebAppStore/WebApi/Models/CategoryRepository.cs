using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(IDbConnection connection) : base(connection)
        {
        }

        public int Add(Category obj)
        {
            string sql = "INSERT INTO Category(CategoryCode, CategoryName) VALUES(@Code, @Name)";
            return connection.Execute(sql, new { Code = obj.CategoryCode, Name = obj.CategoryName });
        }

        public int Edit(Category obj)
        {
            string sql = "UPDATE Category SET CategoryCode = @Code, CategoryName = @Name WHERE CategoryId = @Id";
            return connection.Execute(sql, new { Code = obj.CategoryCode, Name = obj.CategoryName, Id = obj.CategoryId });
        }

        public IEnumerable<Category> GetCategories()
        {
            string sql = "SELECT * FROM Category";
            return connection.Query<Category>(sql);
        }

        public int Delete(short id)
        {
            string sql = "DELETE FROM Category WHERE CategoryId = @Id";
            return connection.Execute(sql, new { Id = id });
        }

        public Category GetCategoryById(short id)
        {
            string sql = "SELECT * FROM Category WHERE CategoryId = @Id";
            return connection.QuerySingle<Category>(sql, new { Id = id });
        }
    }
}
