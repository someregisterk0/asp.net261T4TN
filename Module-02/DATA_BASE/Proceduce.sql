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

CREATE PROC GetStudentById(@Id INT)
AS
BEGIN
	SELECT * FROM Student WHERE StudentId = @Id;
END
GO

EXEC GetStudentById 1;

CREATE PROC EditStudent(
	@Id INT,
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
	UPDATE Student SET
		FullName = @FullName,
		Email = @Email,
		DateOfBirth = @DateOfBirth,
		PlaceOfBirth = @PlaceOfBirth,
		Address = @Address,
		Phone = @Phone,
		Gender = @Gender
	WHERE StudentId = @Id;
END
GO