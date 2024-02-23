CREATE TABLE [dbo].[Cart]
(
	[Id_Cart] INT IDENTITY NOT NULL PRIMARY KEY,
	[Id_Order] INT  NOT NULL,
	[Id_Product] INT  NOT NULL,
	[Quantity] INT NOT NULL,

	
	CONSTRAINT [FK_Cart_Order] FOREIGN KEY ([Id_Order]) REFERENCES [Order]([Id_Order]),
	
	CONSTRAINT [FK_Cart_Product] FOREIGN KEY ([Id_Product]) REFERENCES [Product]([Id_Product]),

)
