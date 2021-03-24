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

--Thêm cột AccountId vào bảng Invoice
ALTER TABLE Invoice ADD AccountId UNIQUEIDENTIFIER REFERENCES Account(AccountId);
GO

ALTER PROC AddInvoice(
	@CartId UNIQUEIDENTIFIER,
	@AccountId UNIQUEIDENTIFIER = NULL,
	@Fullname NVARCHAR(64),
	@Email VARCHAR(64),
	@Phone VARCHAR(16),
	@WardId CHAR(5),
	@Address NVARCHAR(128)
)
AS
BEGIN
	--InvoiceId lấy từ (chính là) CartId
	--DECLARE @InvoiceId UNIQUEIDENTIFIER = NEWID();
	INSERT Invoice(InvoiceId, AccountId, Fullname, Email, Phone, WardId, Address) VALUES
		(@CartId, @AccountId, @Fullname, @Email, @Phone, @WardId, @Address);
	INSERT InvoiceDetail(InvoiceId, ProductId, UnitOfPrice, Quantity)
		SELECT @CartId, Cart.ProductId, UnitOfPrice, Quantity
		FROM Cart JOIN Product ON Cart.ProductId = Product.ProductId
		WHERE CartId = @CartId;
	DELETE FROM Cart WHERE CartId = @CartId;
END
GO

ALTER TABLE Invoice Add WardId CHAR(5) REFERENCES Ward(WardId);
GO

select * from Invoice
