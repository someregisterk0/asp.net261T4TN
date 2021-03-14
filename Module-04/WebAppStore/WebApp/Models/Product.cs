using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public short CategoryId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public string ImageUrl { get; set; }
        public int UnitOfPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
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
