using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class ProductMapper : IRowMapper<Product>
    {
        public virtual Product MapRow(IDataReader reader)
        {
            return new Product
            {
                Id = (int)reader["ProductId"],
                CategoryId = (short)reader["CategoryId"],
                ProductCode = (string)reader["ProductCode"],
                ProductName = (string)reader["ProductName"],
                Unit = (string)reader["Unit"],
                ImageUrl = (string)reader["ImageUrl"],
                UnitOfPrice = (int)reader["UnitOfPrice"]
            };
        }
    }

    public class ProductExMapper : ProductMapper
    {
        public override Product MapRow(IDataReader reader)
        {
            Product obj = base.MapRow(reader);
            obj.Description = (string)reader["Description"];
            obj.Specification = (string)reader["Specification"];
            return obj;
        }
    }
}
