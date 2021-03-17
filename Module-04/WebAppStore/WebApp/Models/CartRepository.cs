using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace WebApp.Models
{
    public class CartRepository : BaseRepository
    {
        public CartRepository(IDbConnection connection) : base(connection)
        {
        }

        public IEnumerable<Cart> GetCarts(Guid id)
        {
            string sql = "SELECT Cart.*, ProductName, UnitOfPrice, ImageUrl FROM Cart JOIN Product ON Cart.ProductId = Product.ProductId WHERE CartId = @Id";
            return connection.Query<Cart>(sql, new { Id = id });
        }

        public int Add(Cart obj)
        {
            //string sql = "INSERT INTO Cart(CartId, ProductId, Quantity) VALUES (@CartId, @ProductId, @Quantity)";
            //return connection.Execute(sql, obj);

            string sql = "AddCart";
            return connection.Execute(sql, new { @CartId = obj.CartId, @ProductId = obj.ProductId, @Quantity = obj.Quantity }, commandType: CommandType.StoredProcedure);
        }

        public int Delete(Guid cartId, int productId)
        {
            string sql = "DELETE FROM Cart WHERE CartId = @CartId AND ProductId = @ProductId";
            return connection.Execute(sql, new { CartId = cartId, ProductId = productId });
        }

        public int Update(Cart obj)
        {
            string sql = "UPDATE Cart SET Quantity = @Quantity WHERE CartId = @CartId AND ProductId = @ProductId";
            return connection.Execute(sql, new { CartId = obj.CartId, ProductId = obj.ProductId, Quantity = obj.Quantity });
        }
    }
}
