CREATE PROCEDURE [dbo].[SP_Product_Insert]
	@name NVARCHAR(64),
	@description NVARCHAR(MAX),
	@price DECIMAL(10,2),
	@ecologicalcriteriaecoscore VARCHAR(1),
	@categoryname NVARCHAR(64)
AS
	INSERT INTO [Product] ([Name],[Description],[Price],[EcologicalCriteriaEcoScore],[CategoryName])
		OUTPUT [inserted].[Id_Product]
		VALUES (@name,@description,@price,@ecologicalcriteriaecoscore, @categoryname)


	
	