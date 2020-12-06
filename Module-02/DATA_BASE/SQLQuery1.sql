-- Tạo cơ sở dữ liệu
CREATE DATABASE Stores;
GO
USE Stores;
GO

-- Tạo Bảng
CREATE TABLE Category(
	CategoryId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CategoryName NVARCHAR(64) NOT NULL
);
GO

-- Nhập dữ liệu
INSERT INTO Category(CategoryName) VALUES('Laptop');
GO
INSERT INTO Category(CategoryName) VALUES
	('HDD'), ('RAM'), ('Keyboard');
GO

-- Truy vấn dữ liệu
SELECT * FROM Category;

-- Tạo Proceduce
CREATE PROC GetCategories
AS
BEGIN
	SELECT * FROM Category;
END

EXEC GetCategories;