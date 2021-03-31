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


CREATE PROC GetProductsPagination(
	@Index INT,
	@Size INT,
	@Total INT OUT
)
AS
BEGIN
	SELECT * FROM Product ORDER BY ProductId OFFSET @Index ROWS FETCH NEXT @Size ROW ONLY;
	SELECT @Total = COUNT(*) FROM Product;
END
GO

DECLARE @t INT;
EXEC GetProductsPagination @Index = 0 , @Size = 10, @Total = @t OUT;
PRINT @t;
GO

--GetProductsByCategory theo phân trang
CREATE PROC GetProductsByCategory(
	@Id SMALLINT,
	@Index INT,
	@Size INT,
	@Total INT OUT
)
AS
BEGIN
	SELECT * FROM Product WHERE CategoryId = @Id 
		ORDER BY ProductId OFFSET @Index ROWS FETCH NEXT @Size ROW ONLY;
	SELECT @Total = COUNT(*) FROM Product WHERE CategoryId = @Id;
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

-- Chạy insert tỉnh thành vào trước rồi mới thêm cột WardId
--Thêm cột AccountId vào bảng Invoice
ALTER TABLE Invoice ADD AccountId UNIQUEIDENTIFIER REFERENCES Account(AccountId);
GO
ALTER TABLE Invoice Add WardId CHAR(5) REFERENCES Ward(WardId);
GO

CREATE PROC AddInvoice(
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


CREATE PROC SearchProducts (
	@Q VARCHAR(32)
)
AS
BEGIN
	SELECT * FROM Product WHERE ProductName LIKE @Q;
END
GO


CREATE PROC StatisticCategories
AS
BEGIN
	SELECT CategoryName AS Name, COUNT(*) AS Total FROM Category JOIN Product 
		ON Category.CategoryId = Product.CategoryId
		GROUP BY CategoryName;
END






select * from Invoice
