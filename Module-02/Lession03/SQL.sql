--Tạo cơ sở dữ liệu
CREATE DATABASE Store;
GO
USE Store;
GO
--Tạo bảng
CREATE TABLE Category(
	CategoryId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CategoryName NVARCHAR(64) NOT NULL
);
GO
--Thêm dữ liệu
INSERT INTO Category (CategoryName) VALUES	('Mouse');
GO
INSERT INTO Category (CategoryName) VALUES 
	('Keyboard'), ('HDD'), ('RAM');
GO
--Truy vấn dữ liệu
SELECT * FROM Category;
GO


CREATE TABLE Student(
	StudentId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Fullname NVARCHAR(64) NOT NULL,
	Email VARCHAR(128) NOT NULL,
	DateOfBirth DATE NOT NULL,
	PlaceOfBirth NVARCHAR(32) NOT NULL,
	Address NVARCHAR(128) NOT NULL,
	Phone VARCHAR(16) NOT NULL,
	Gender BIT NOT NULL
);
INSERT INTO Student (Fullname, Email, DateOfBirth, PlaceOfBirth, Address, Phone, Gender) VALUES
	('Thanh', 'thanh@gmail.com', '2000/3/7', 'HCM', 'HCM', '2394872', 1),
	('Thien', 'thien@gmail.com', '2000/3/7', 'Vung Tau', 'Vung Tau', '2394872', 1),
	('Binh', 'binh@gmail.com', '2000/3/7', 'Be Tre', 'Ben Tre', '2394872', 0);
GO
CREATE PROC GetStudents
AS
	SELECT * FROM Student;
GO
EXEC GetStudents;
GO

--TINYINT
CREATE PROC AddStudent(
	@Fullname NVARCHAR(64),
	@Email VARCHAR(128),
	@DateOfBirth DATE,
	@PlaceOfBirth NVARCHAR(32),
	@Address NVARCHAR(128),
	@Phone VARCHAR(16),
	@Gender BIT
)
AS
	INSERT INTO Student (Fullname, Email, DateOfBirth, PlaceOfBirth, Address, Phone, Gender)
		VALUES (@Fullname, @Email, @DateOfBirth, @PlaceOfBirth, @Address, @Phone, @Gender);
GO

EXEC AddStudent 'thai binh', 'thaibinh@gmail.com', '1977/1/4', 'hcm', 'hcm', '2342424', 1;
GO




CREATE PROC DeleteStudent(@Id INT)
AS
	DELETE FROM Student WHERE StudentId = @Id;
GO

GO
CREATE TABLE Product(
	ProductId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
	CategoryId INT NOT NULL REFERENCES Category(CategoryId),
	PrdocutName NVARCHAR(64) NOT NULL,
	Price INT NOT NULL,
	Quantity SMALLINT NOT NULL,
	ImageUrl VARCHAR(64),
	Description NVARCHAR(MAX)
)
GO