using Dapper;
using System.Collections.Generic;
using System.Data;

namespace WebApp.Models
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<Category> GetCategories()
        {
            string sql = "SELECT * FROM Category";
            return connection.Query<Category>(sql);
        }
    }
}
