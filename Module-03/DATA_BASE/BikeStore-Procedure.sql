
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