CREATE PROCEDURE [dbo].[SP_Product_GetById]
	@id_product INT
AS

	SELECT [Id_Product],
	       [Name],
	       [Description],
	       [Price],
	       [EcologicalCriteriaEcoScore],
	       [CategoryName]
		FROM [Product]
		WHERE [Id_Product] = @id_product