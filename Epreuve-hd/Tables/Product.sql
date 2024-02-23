CREATE TABLE [dbo].[Product]
(
	[Id_Product] INT IDENTITY NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Price] DECIMAL(10,2) NOT NULL,
	[EcologicalCriteriaEcoScore] VARCHAR(1) NOT NULL,

	[CategoryName] NVARCHAR(64) NOT NULL,
	
	CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryName]) REFERENCES [Category]([CategoryName]),

	CONSTRAINT CheckValeurEcoScore CHECK (EcologicalCriteriaEcoScore IN ('A', 'B', 'C', 'D','E'))
	
)
