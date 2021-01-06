USE master;
--DROP DATABASE BikeStore;
CREATE DATABASE BikeStore;
GO
USE BikeStore;
GO
-- create schemas
CREATE SCHEMA production;
GO

CREATE SCHEMA sales;
GO

-- create tables
CREATE TABLE production.Category (
	CategoryId SMALLINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	CategoryName VARCHAR (64) NOT NULL
);
GO
CREATE TABLE production.Brand (
	BrandId SMALLINT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	BrandName VARCHAR (64) NOT NULL
);
GO
CREATE TABLE production.Product (
	ProductId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	ProductName VARCHAR (256) NOT NULL,
	BrandId SMALLINT NOT NULL,
	CategoryId SMALLINT NOT NULL,
	ModelYear SMALLINT NOT NULL,
	Price DECIMAL (10, 2) NOT NULL,
	FOREIGN KEY (CategoryId) REFERENCES production.Category (CategoryId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (BrandId) REFERENCES production.Brand (BrandId) ON DELETE CASCADE ON UPDATE CASCADE
);
GO
CREATE PROC GetProducts
AS
	SELECT P.*, B.BrandName, C.CategoryName FROM production.Product AS P 
		JOIN production.Brand AS B ON P.BrandId = B.BrandId
		JOIN production.Category AS C ON P.CategoryId = C.CategoryId
GO
--EXEC GetProducts;

CREATE TABLE sales.Customer (
	CustomerId INT IDENTITY (1, 1) PRIMARY KEY,
	FirstName VARCHAR (64) NOT NULL,
	LastName VARCHAR (128) NOT NULL,
	Phone VARCHAR (16),
	Email VARCHAR (256) NOT NULL,
	Street VARCHAR (256),
	City VARCHAR (64),
	State VARCHAR (32),
	ZipCode VARCHAR (8)
);
GO
--DROP TABLE sales.Store;
CREATE TABLE sales.Store (
	StoreId SMALLINT IDENTITY (1, 1) PRIMARY KEY,
	StoreName VARCHAR (128) NOT NULL,
	Phone VARCHAR (16),
	Email VARCHAR (256),
	Street VARCHAR (256),
	City VARCHAR (128),
	State VARCHAR (32),
	ZipCode VARCHAR (8)
);
GO
CREATE TABLE sales.Staff (
	StaffId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	FirstName VARCHAR (64) NOT NULL,
	LastName VARCHAR (64) NOT NULL,
	Email VARCHAR (256) NOT NULL UNIQUE,
	Phone VARCHAR (16),
	active TINYINT NOT NULL,
	StoreId SMALLINT NOT NULL,
	ManagerId INT,
	FOREIGN KEY (StoreId) REFERENCES sales.Store (StoreId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ManagerId) REFERENCES sales.Staff (StaffId) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
CREATE TABLE sales.[Order] (
	OrderId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY,
	CustomerId INT,
	OrderStatus TINYINT NOT NULL,
	-- Order status: 1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed
	OrderDate DATE NOT NULL,
	RequiredDate DATE NOT NULL,
	ShippedDate DATE,
	StoreId SMALLINT NOT NULL,
	StaffId INT NOT NULL,
	FOREIGN KEY (CustomerId) REFERENCES sales.Customer (CustomerId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (StoreId) REFERENCES sales.Store (StoreId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (StaffId) REFERENCES sales.Staff (StaffId) ON DELETE NO ACTION ON UPDATE NO ACTION
);
GO
CREATE TABLE sales.OrderItem (
	OrderId INT NOT NULL,
	ItemId INT NOT NULL,
	ProductId INT NOT NULL,
	Quantity SMALLINT NOT NULL,
	Price DECIMAL (10, 2) NOT NULL,
	discount DECIMAL (4, 2) NOT NULL DEFAULT 0,
	PRIMARY KEY (OrderId, ItemId),
	FOREIGN KEY (OrderId) REFERENCES sales.[Order] (OrderId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ProductId) REFERENCES production.Product (ProductId) ON DELETE CASCADE ON UPDATE CASCADE
);
GO
--DROP TABLE production.Stock
CREATE TABLE production.Stock (
	StoreId SMALLINT NOT NULL,
	ProductId INT NOT NULL,
	Quantity SMALLINT NOT NULL,
	PRIMARY KEY (StoreId, ProductId),
	FOREIGN KEY (StoreId) REFERENCES sales.Store (StoreId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ProductId) REFERENCES production.Product (ProductId) ON DELETE CASCADE ON UPDATE CASCADE
);
GO