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

        // GetProduct để phân trang, Pagination
        public IEnumerable<Product> GetProducts(int index, int size, out int total)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Index", index, dbType: DbType.Int32);
            parameters.Add("@Size", size, dbType: DbType.Int32);
            parameters.Add("@Total", dbType: DbType.Int32, direction: ParameterDirection.Output);
            IEnumerable<Product> list = connection.Query<Product>("GetProductsPagination", parameters, commandType: CommandType.StoredProcedure);
            total = parameters.Get<int>("@Total");
            return list;
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

        public IEnumerable<Product> GetProductsByCategory(short id, int index, int size, out int total)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int16);
            parameters.Add("@Index", index, dbType: DbType.Int32);
            parameters.Add("@Size", size, dbType: DbType.Int32);
            parameters.Add("@Total", dbType: DbType.Int32, direction: ParameterDirection.Output);
            IEnumerable<Product> list = connection.Query<Product>("GetProductsByCategory", parameters, commandType: CommandType.StoredProcedure);
            total = parameters.Get<int>("@Total");
            return list;
        }

        public Product GetProduct(short id)
        {
            string sql = "SELECT * FROM Product WHERE ProductId = @Id";
            return connection.QuerySingle<Product>(sql, new { Id = id });
        }

        public Dictionary<short,List<Product>> KeyValuePairs()
        {
            IEnumerable<Product> products = GetProducts();
            Dictionary<short, List<Product>> dict = new Dictionary<short, List<Product>>();
            foreach (Product item  in products)
            {
                short key = item.CategoryId;
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<Product>();
                }
                dict[key].Add(item);
            }
            return dict;
        }
    }
}
