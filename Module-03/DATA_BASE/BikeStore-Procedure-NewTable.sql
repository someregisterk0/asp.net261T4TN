
CREATE PROC AddBrand(
	@Id SMALLINT = NULL,
	@Name VARCHAR(64)
)
AS
BEGIN
	IF @Id IS NULL
		INSERT INTO production.Brand(BrandName) VALUES (@Name);
	ELSE
		UPDATE production.Brand SET BrandName = @Name WHERE BrandId = @Id;
END
GO


ALTER PROC GetProducts(
	@Index INT,
	@Size INT,
	@Total INT OUT
)
AS
BEGIN
	SELECT P.*, B.BrandName, C.CategoryName FROM production.Product AS P 
		JOIN production.Brand AS B ON P.BrandId = B.BrandId
		JOIN production.Category AS C ON P.CategoryId = C.CategoryId
		ORDER BY P.ProductId
		OFFSET @Index ROWS FETCH NEXT @Size ROWS ONLY;

		SELECT @Total = COUNT(*) FROM production.Product;
END
GO


CREATE PROC GetProductsNotTotal(
	@Index INT,
	@Size INT
)
AS
BEGIN
	SELECT P.*, B.BrandName, C.CategoryName FROM production.Product AS P 
		JOIN production.Brand AS B ON P.BrandId = B.BrandId
		JOIN production.Category AS C ON P.CategoryId = C.CategoryId
		ORDER BY P.ProductId
		OFFSET @Index ROWS FETCH NEXT @Size ROWS ONLY;
END
GO

-- q = query
CREATE PROC SearchProducts(
	@Q VARCHAR(32),
	@Index INT,
	@Size INT,
	@Total INT OUT
)
AS
BEGIN
	SELECT P.*, B.BrandName, C.CategoryName FROM production.Product AS P 
		JOIN production.Brand AS B ON P.BrandId = B.BrandId
		JOIN production.Category AS C ON P.CategoryId = C.CategoryId
		WHERE ProductName LIKE @Q
		ORDER BY P.ProductId
		OFFSET @Index ROWS FETCH NEXT @Size ROWS ONLY;

		SELECT @Total = COUNT(*) FROM production.Product WHERE ProductName LIKE @Q;
END
GO


CREATE PROC AddProduct(
	@Name VARCHAR (256),
	@BrandId SMALLINT,
	@CategoryId SMALLINT,
	@ModelYear SMALLINT,
	@Price DECIMAL (10, 2)
)
AS
BEGIN
	INSERT INTO production.Product (ProductName, BrandId, CategoryId, ModelYear, Price)
		VALUES(@Name, @BrandId, @CategoryId, @ModelYear, @Price)
END
GO


CREATE PROC EditProduct(
	@Id INT,
	@Name VARCHAR (256),
	@BrandId SMALLINT,
	@CategoryId SMALLINT,
	@ModelYear SMALLINT,
	@Price DECIMAL (10, 2)
)
AS
BEGIN
	UPDATE production.Product 
		SET ProductName = @Name, 
			BrandId = @BrandId, 
			CategoryId = @CategoryId,
			ModelYear = @ModelYear, 
			Price = @Price
		WHERE ProductId = @Id
END
GO

--- ### New Talbe ### ---

drop table Member;
drop table memberinrole;

CREATE TABLE Member (
	MemberId UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	Username VARCHAR(32) NOT NULL UNIQUE,
	Password VARBINARY(64) NOT NULL,
	Email VARCHAR(64) NOT NULL,
	Gender TINYINT NOT NULL
);
GO

CREATE TABLE Role (
	RoleId UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	RoleName VARCHAR(16) NOT NULL UNIQUE
);
GO

CREATE TABLE MemberInRole (
	MemberId UNIQUEIDENTIFIER NOT NULL REFERENCES Member(MemberId),
	RoleId UNIQUEIDENTIFIER NOT NULL REFERENCES Role(RoleId),
	IsDeleted BIT NOT NULL DEFAULT 0,
	PRIMARY KEY(MemberId, RoleId)
);
GO

--- ### Store Procedure ### ---
CREATE PROC AddMember(
	@Username VARCHAR(32),
	@Password VARBINARY(64),
	@Email VARCHAR(64),
	@Gender TINYINT
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Member WHERE Username = @Username)
	BEGIN
		INSERT INTO Member (Username, Password, Email, Gender)
			VALUES (@Username, @Password, @Email, @Gender)
		RETURN 1
	END
	RETURN 0
END
GO

SELECT * FROM Member
GO
CREATE PROC AddRole(
	@Name VARCHAR(16)
)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Role WHERE RoleName = @Name)
	BEGIN
		INSERT INTO Role (RoleName)
			VALUES (@Name)
		RETURN 1
	END
	RETURN 0
END
GO

SELECT * FROM Role;
GO

CREATE PROC GetMemberById(
	@Id UNIQUEIDENTIFIER
)
AS
BEGIN
	SELECT * FROM Member WHERE MemberId = @Id
END
GO

CREATE PROC AddMemberInRole(
	@MemberId UNIQUEIDENTIFIER,
	@RoleId UNIQUEIDENTIFIER
)
AS
BEGIN
	IF EXISTS(SELECT * FROM MemberInRole WHERE MemberId = @MemberId AND RoleId = @RoleId)
		UPDATE MemberInRole SET IsDeleted = ~IsDeleted WHERE MemberId = @MemberId AND RoleId = @RoleId
	ELSE
		INSERT INTO MemberInRole(MemberId, RoleId)
			VALUES(@MemberId, @RoleId);
END
GO


DECLARE @MemberId UNIQUEIDENTIFIER = 'CE527DE3-36BE-49C2-A1F5-1DF9644F0F7E';
SELECT Role.*, CAST(IIF(MemberId IS NULL, 0, 1) AS BIT) AS Checked
	FROM MemberInRole RIGHT JOIN Role ON MemberInRole.RoleId = Role.RoleId AND MemberId = @MemberId;
GO

CREATE PROC GetRolesByMember(@MemberId UNIQUEIDENTIFIER)
AS
BEGIN
	SELECT Role.*, CAST(IIF(MemberId IS NULL, 0, 1) AS BIT) AS Checked
	FROM MemberInRole RIGHT JOIN Role ON MemberInRole.RoleId = Role.RoleId AND MemberId = @MemberId
	AND IsDeleted = 0
END
GO

EXEC GetRolesByMember @MemberId = '313A9172-43E2-4B76-B813-7864245137CE';
GO


CREATE PROC SignIn(
	@Usr VARCHAR(32),
	@Pwd VARBINARY(64)
)
AS
BEGIN
	SELECT * FROM Member WHERE Username = @Usr AND Password = @Pwd;
END
GO
