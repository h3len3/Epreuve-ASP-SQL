CREATE TABLE [dbo].[Media]
(

	[Id_Media] INT IDENTITY NOT NULL PRIMARY KEY,
	[Nom] NVARCHAR(64) NOT NULL,
	[Type] NVARCHAR(64) NULL,
	[Url] NVARCHAR(256) NOT NULL,

	[Id_Product] INT  NOT NULL,

	CONSTRAINT [FK_Media_Product] FOREIGN KEY ([Id_Product]) REFERENCES [Product]([Id_Product]),



)
