-- Tạo cơ sở dữ liệu
CREATE DATABASE Stores;
GO
USE Stores;
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

CREATE PROC CountCustomer
AS
BEGIN
	SELECT COUNT(*) FROM sales.Customer;
END
GO

EXEC CountCustomer;
GO

SELECT * FROM sales.Customer ORDER BY CustomerId
OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY;
GO

CREATE PROC GetCustomers(
	@PageIndex INT,
	@PageSize INT
)
AS
BEGIN
	SELECT * FROM sales.Customer ORDER BY CustomerId
	OFFSET (@PageIndex - 1) * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY;
END
GO

EXEC GetCustomers @PageIndex = 1, @PageSize = 20;
GO
EXEC GetCustomers @PageIndex = 2, @PageSize = 20;
GO
EXEC GetCustomers @PageIndex = 3, @PageSize = 20;
GO

CREATE PROC SearchCustomer(
	@Q NVARCHAR(32)
)
AS
BEGIN
	SELECT * FROM sales.Customer WHERE FirstName LIKE @Q
		OR LastName LIKE @Q OR Street LIKE @Q OR Email LIKE @Q OR Phone LIKE @Q;
END
GO

CREATE PROC SearchCustomer2(
	@Q NVARCHAR(32),
	@City VARCHAR(64)
)
AS
BEGIN
	SELECT * FROM sales.Customer 
	WHERE 
	(FirstName LIKE @Q OR LastName LIKE @Q OR Street LIKE @Q OR Email LIKE @Q OR Phone LIKE @Q)
	AND City = @City;
END
GO

--EXEC SearchCustomer 'bra%';
GO

-- Tất cả các khách hàng bắt đầu bằng chữ d
SELECT * FROM sales.Customer WHERE FirstName LIKE 'd%';
-- Tất cả các khách hàng kết thúc bằng chữ ra
SELECT * FROM sales.Customer WHERE FirstName LIKE '%ra';
SELECT * FROM sales.Customer WHERE FirstName LIKE '%bra%';
GO

CREATE PROC SearchAndPaginationCustomer(
	@Q VARCHAR(32),
	@PageIndex INT,
	@PageSize INT,
	@Total INT OUTPUT
)
AS
BEGIN
	SELECT * FROM sales.Customer WHERE FirstName LIKE @Q ORDER BY CustomerId
		OFFSET (@PageIndex - 1) * @PageSize ROWS FETCH NEXT @PageSize ROWS ONLY;
	SELECT @Total = COUNT(*) FROM sales.Customer WHERE FirstName LIKE @Q;
END
GO


CREATE PROC GetCities(
	@State VARCHAR(32) = NULL
)
AS
BEGIN
	SELECT DISTINCT City FROM sales.Customer
		WHERE @State IS NULL OR State = @State;
END
GO

SELECT DISTINCT City FROM sales.Customer WHERE State = 'NY'
SELECT DISTINCT City FROM sales.Customer WHERE State = 'CA'
SELECT DISTINCT City FROM sales.Customer WHERE State = 'TX'



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


----------------------------------------------------------------------------------------
-- Movie Rating

CREATE TABLE Rating(
	UserId INT NOT NULL,
	MovieId INT NOT NULL,
	Rating TINYINT NOT NULL,
	Timestamp INT NOT NULL
);
GO

CREATE PROC AddRating
(
	@UserId INT,
	@MovieId INT,
	@Rating TINYINT,
	@Timestamp INT
)
AS
BEGIN
	INSERT INTO Rating (UserId, MovieId, Rating, Timestamp) 
		VALUES (@UserId, @MovieId, @Rating, @Timestamp);
END
GO
--TRUNCATE TABLE Rating;


CREATE TABLE Movie(
	MovieId INT NOT NULL,
	Title VARCHAR(256) NOT NULL,
	Genres VARCHAR(256) NOT NULL
);
GO
--TRUNCATE TABLE Movie;

--------------------------------------------------------------------
-- TABLE Menu
CREATE TABLE MenuItem(
	MenuItemId VARCHAR(32) NOT NULL PRIMARY KEY,
	MenuItemName NVARCHAR(64) NOT NULL,
	FormName VARCHAR(32),
	ParentId VARCHAR(32) REFERENCES MenuItem(MenuItemId)
);
GO

INSERT INTO MenuItem (MenuItemId, MenuItemName, FormName, ParentId) VALUES 
	('System', 'System', NULL, NULL),
	('Manage', 'Manage', NULL, NULL),
	('Category', 'Category', 'FormCategory', 'Manage'),
	('Product', 'Product', 'FormProduct', 'Manage');
GO

CREATE PROC AddMenuItem(
	@Id VARCHAR(32) ,
	@Name NVARCHAR(64),
	@FormName VARCHAR(32) = NULL,
	@ParentId VARCHAR(32) = NULL
)
AS
BEGIN
	INSERT INTO MenuItem (MenuItemId, MenuItemName, FormName, ParentId) VALUES
		(@Id, @Name, @FormName, @ParentId)
END

SELECT * FROM MenuItem

