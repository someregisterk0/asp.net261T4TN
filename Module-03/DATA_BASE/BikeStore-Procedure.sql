
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


ALTER PROC GetProducts
AS
BEGIN
	SELECT P.*, B.BrandName, C.CategoryName FROM production.Product AS P JOIN production.Brand AS B 
		ON P.BrandId = B.BrandId
		JOIN production.Category AS C
		ON P.CategoryId = C.CategoryId;
END
GO