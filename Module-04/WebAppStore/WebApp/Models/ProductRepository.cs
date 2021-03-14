using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<Product> GetProducts()
        {
            return connection.Query<Product>("GetProducts", commandType: CommandType.StoredProcedure);
        }

        //Lấy sản phẩm liên quan
        public IEnumerable<Product> GetProductsRelation(short categoryId, int productId)
        {
            string sql = "SELECT TOP 6 * FROM Product WHERE CategoryId = @CategoryId AND ProductId <> @ProductId ORDER BY NEWID()";
            return connection.Query<Product>(sql, new { CategoryId = categoryId, ProductId = productId });
        }

        public IEnumerable<Product> GetProductsByCategory(short id)
        {
            string sql = "SELECT * FROM Product WHERE CategoryId = @Id";
            return connection.Query<Product>(sql, new { Id = id });
        }

        public Product GetProduct(short id)
        {
            string sql = "SELECT * FROM Product WHERE ProductId = @Id";
            return connection.QuerySingle<Product>(sql, new { Id = id });
        }
    }
}
