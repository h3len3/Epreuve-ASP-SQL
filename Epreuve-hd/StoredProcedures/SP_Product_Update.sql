CREATE PROCEDURE [dbo].[SP_Product_Update]
	@id_product INT,
	@name NVARCHAR(64),
	@description NVARCHAR(MAX),
	@price DECIMAL(10,2),
	@ecologicalcriteriaecoscore VARCHAR(1),
	@categoryname NVARCHAR(64)
AS
	UPDATE [Product] 
		SET [Name] = @name ,
			[Description] = @description ,
			[Price] = @price ,
			[EcologicalCriteriaEcoScore] = @ecologicalcriteriaecoscore,
			[CategoryName] = @categoryname
		WHERE [Id_Product] = @id_product


	