USE Store
GO

CREATE TABLE Cart (
	CartId UNIQUEIDENTIFIER NOT NULL,
	ProductId INT NOT NULL REFERENCES Product(ProductId),
	Quantity SMALLINT NOT NULL,
	CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
	PRIMARY KEY(CartId, ProductId)
);
GO

CREATE PROC GetProducts
AS
BEGIN
	SELECT * FROM Product
END
GO


CREATE PROC AddCart (
	@CartId UNIQUEIDENTIFIER, 
	@ProductId INT, 
	@Quantity SMALLINT
)
AS
BEGIN
	IF EXISTS(SELECT * FROM Cart WHERE CartId = @CartId AND ProductId = @ProductId)
		UPDATE Cart SET Quantity += @Quantity WHERE CartId = @CartId AND ProductId = @ProductId
	ELSE
		INSERT INTO Cart(CartId, ProductId, Quantity) VALUES (@CartId, @ProductId, @Quantity)
END
GO

select * from Cart
delete from Cart
SELECT Cart.*, ProductName, UnitOfPrice, ImageUrl FROM Cart JOIN Product ON Cart.ProductId = Product.ProductId WHERE CardId = @Id