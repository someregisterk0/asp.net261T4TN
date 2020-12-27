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

CREATE PROC GetStudentById(@Id INT)
AS
	SELECT * FROM Student WHERE StudentId = @Id;
GO

CREATE PROC EditStudent(
	@Id INT,
	@Fullname NVARCHAR(64),
	@Email VARCHAR(128),
	@DateOfBirth DATE,
	@PlaceOfBirth NVARCHAR(32),
	@Address NVARCHAR(128),
	@Phone VARCHAR(16),
	@Gender BIT
)
AS
	UPDATE Student SET Fullname = @Fullname, Email = @Email, 
	DateOfBirth = @DateOfBirth, PlaceOfBirth =@PlaceOfBirth,
	Address = @Address, Phone = @Phone, Gender = @Gender WHERE StudentId = @Id;
GO
	




CREATE PROC DeleteStudent(@Id INT)
AS
	DELETE FROM Student WHERE StudentId = @Id;
GO


--DROP TABLE Product;
GO
CREATE TABLE Product(
	ProductId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY ,
	CategoryId INT NOT NULL REFERENCES Category(CategoryId),
	ProductName NVARCHAR(64) NOT NULL,
	Price INT NOT NULL,
	Quantity SMALLINT NOT NULL,
	ImageUrl VARCHAR(64),
	Description NVARCHAR(MAX)
)
GO
select * from Product;
--Them cot vao trong bang product
ALTER TABLE Product ADD ImageFile VARBINARY(MAX);
--ALTER TABLE Product ADD ImageFile IMAGE;





INSERT INTO Product (CategoryId, ProductName, Price, Quantity, ImageUrl, Description) VALUES
	(1, 'Chuot may tinh 1', 30000, 3, NULL, NULL);
GO


--DROP TABLE Account;
GO
CREATE TABLE Account(
	AccountId UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	Username VARCHAR(32) NOT NULL UNIQUE,
	Password VARCHAR(16) NOT NULL,
	Email VARCHAR(128) NOT NULL
);

select * from Account;

GO
INSERT INTO Account(Username, Password, Email) 
	VALUES('thanh', '123', 'thanh@gmail.com');
	
--delete from Account;--')

--thien');delete from Account;--


select * from Product;

ALTER TABLE Product DROP COLUMN ImageFile;

select * from Account where Username = 'thanh' or 1=1--' and Password = '123'

SELECT * FROM Account WHERE Username = 'thanh' or 1=1--' AND Password = 'asdfasdf';

GO
CREATE TABLE Member(
	MemberId UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	Username VARCHAR(32) NOT NULL UNIQUE,
	Password VARBINARY(64) NOT NULL,
	Email VARCHAR(128) NOT NULL
);
GO
--RETURN
CREATE PROC AddMember(
	@Username VARCHAR(32),
	@Password VARCHAR(16),
	@Email VARCHAR(128)
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Member WHERE Username = @Username)
	BEGIN
		INSERT INTO Member(Username, Password, Email) VALUES (@Username, HASHBYTES('SHA2_512', @Username + '@?!%^' + @Password), @Email);
		RETURN 1;
	END
	RETURN 0;
END
GO
SELECT * FROM Member;
GO



GO
CREATE PROC SignIn(
	@Username VARCHAR(32),
	@Password VARCHAR(16)
)AS
BEGIN
	IF EXISTS(SELECT * FROM Member WHERE Username = @Username)
	BEGIN
		SELECT * FROM Member WHERE Username = @Username AND Password = HASHBYTES('SHA2_512', @Username+ '@?!%^' + @Password);
		RETURN 1;
	END
	RETURN 0;
END
GO
SELECT * FROM Member;

GO
CREATE PROC AddMember2(
	@Username VARCHAR(32),
	@Password VARBINARY(64),
	@Email VARCHAR(128)
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Member WHERE Username = @Username)
	BEGIN
		INSERT INTO Member(Username, Password, Email) VALUES (@Username, @Password, @Email);
		RETURN 1;
	END
	RETURN 0;
END
GO

CREATE PROC SignIn2(
	@Username VARCHAR(32),
	@Password VARBINARY(64)
)AS
BEGIN
	IF EXISTS(SELECT * FROM Member WHERE Username = @Username)
	BEGIN
		SELECT * FROM Member WHERE Username = @Username AND Password = @Password;
		RETURN 1;
	END
	RETURN 0;
END
GO
SELECT * FROM Member;