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

CREATE TABLE Student(
	StudentId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FullName NVARCHAR(64) NOT NULL,
	Email VARCHAR(128) NOT NULL,
	DateOfBirth DATE NOT NULL,
	PlaceOfBirth NVARCHAR(32) NOT NULL,
	Address NVARCHAR(128) NOT NULL,
	Phone VARCHAR(16) NOT NULL,
	Gender BIT NOT NULL
);
GO

INSERT INTO Student VALUES
	(N'Nguyễn Vân Trúc', 'Truc@gmail.com', '1996-03-02', N'Hồ Chí Minh', 
		N'21 Võ Văn Tần, Phường 6, Quận 3, Thành phố Hồ Chí Minh', '02839303031', 1),
	(N'Phan Mạnh Hùng', 'Hung@gmail.com', '1998-06-11', N'Hồ Chí Minh', 
		N'419/2m Phan Xích Long, Phường 3, Phú Nhuận, Thành phố Hồ Chí Minh', '0906806321', 0),
	(N'Hoàng Hương Viện', 'Vien@yahoo.com', '1997-11-25', N'Đà Nẵng', 
		N'07 Chế Lan Viên, Bắc Mỹ An, Ngũ Hành Sơn, Đà Nẵng', '0914845900', 0),
	(N'Huỳnh Công Tài', 'Tai@yahoo.com', '2000-07-03', N'Đà Nẵng', 
		N'198 Nguyễn Văn Linh, Dư Hàng Kênh, Lê Chân, Hải Phòng', '02253795688', 0),
	(N'Nguyễn Minh Trang', 'Trang@yahoo.com', '2001-07-15', N'Trà Vinh', 
		N'1 Phạm Thái Bường, Phường 3, Trà Vinh', '02253795688', 1);
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

CREATE PROC GetStudents 
AS
BEGIN
	SELECT * FROM Student;
END

EXEC GetStudents;

CREATE PROC AddStudent(
	@FullName NVARCHAR(64),
	@Email VARCHAR(128),
	@DateOfBirth DATE,
	@PlaceOfBirth NVARCHAR(32),
	@Address NVARCHAR(128),
	@Phone VARCHAR(16),
	@Gender BIT
)
AS
BEGIN
	INSERT INTO Student (FullName, Email, DateOfBirth, PlaceOfBirth, Address, Phone, Gender)
		VALUES (@FullName, @Email, @DateOfBirth, @PlaceOfBirth, @Address, @Phone, @Gender);
END
GO

EXEC AddStudent N'Nguyễn Thành Đăng', 'dang@gmail.com', '2001/1/12', N'Hồ Chí Minh', N'12 Trần Tạp, P7, Q.12, Hồ Chí Minh', '1231232', 1;

CREATE PROC DeleteStudent (@Id INT)
AS
BEGIN
	DELETE FROM Student WHERE StudentId = @Id;
END
GO

EXEC DeleteStudent 9;

SELECT * FROM Category