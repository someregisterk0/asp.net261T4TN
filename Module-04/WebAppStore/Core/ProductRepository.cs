using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(IDbConnection connection) : base(connection)
        {
        }

        public List<Product> GetProducts()
        {
            string sql = "SELECT * FROM Product";
            return FetchAll(sql);
        }

        public List<Product> GetProductsByCategoryId(short id)
        {
            string sql = "SELECT * FROM Product WHERE CategoryId = @Id";
            DynamicParameter parameter = new DynamicParameter();
            parameter.Add("@Id", id);
            return FetchAll(sql, parameter);
        }

        protected override Product Fetch(IDataReader reader)
        {
            return new Product
            {
                Id = (int)reader["ProductId"],
                CategoryId = (short)reader["CategoryId"],
                ProductCode = (string)reader["ProductCode"],
                ProductName = (string)reader["ProductName"],
                Unit = (string)reader["Unit"],
                Description = (string)reader["Description"],
                Specification = (string)reader["Specification"],
                ImageUrl = (string)reader["ImageUrl"],
                UnitOfPrice = (int)reader["UnitOfPrice"],
                CreatedDate = (DateTime)reader["CreatedDate"],
                UpdatedDate = (DateTime)reader["UpdatedDate"],
            };
        }
    }
}


/*
	ProductId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CategoryId SMALLINT NOT NULL REFERENCES Category(CategoryId),
	ProductCode VARCHAR(16) NOT NULL UNIQUE,
	ProductName NVARCHAR(128) NOT NULL,
	Unit NVARCHAR(32) NOT NULL,
	Description NVARCHAR(MAX),
	Specification NVARCHAR(MAX),
	ImageUrl VARCHAR(256) NOT NULL,
	UnitOfPrice INT NOT NULL,
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	UpdatedDate DATETIME
	*/
