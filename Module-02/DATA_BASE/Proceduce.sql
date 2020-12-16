USE Student;
GO
CREATE PROC GetStudents 
AS
BEGIN
	SELECT * FROM Student;
END
EXEC GetStudents;


USE Stores;
GO
CREATE PROC GetCategories
AS
BEGIN
	SELECT * FROM Category;
END
EXEC GetCategories;