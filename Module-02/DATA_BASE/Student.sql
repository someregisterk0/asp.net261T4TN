CREATE DATABASE Student;
GO
USE Student;
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

SELECT * FROM Student;