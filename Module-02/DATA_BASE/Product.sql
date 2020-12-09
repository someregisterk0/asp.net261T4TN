CREATE DATABASE Stores;
GO
USE Stores;
GO


-- Tạo bảng
CREATE TABLE Category(
	CategoryId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CategoryName NVARCHAR(64) NOT NULL
);
GO

CREATE TABLE Product(
	ProductId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CategoryId INT NOT NULL REFERENCES Category(CategoryId),
	ProductName NVARCHAR(64) NOT NULL,
	Price INT NOT NULL,
	Quantity SMALLINT NOT NULL,
	ImageUrl VARCHAR(64),
	Description NVARCHAR(MAX)
);
GO

-- Nhập data
INSERT INTO Category(CategoryName) VALUES('Laptop');
GO
INSERT INTO Category(CategoryName) VALUES
	('HDD'), ('RAM'), ('Keyboard');
GO

INSERT INTO Product(CategoryId, ProductName, Price, Quantity, ImageUrl, Description)
	VALUES (1, 'AMD 5900X', 1000, 87, NULL, NULL),
			(1, 'RX 6700', 5400, 189, NULL, NULL)
GO

