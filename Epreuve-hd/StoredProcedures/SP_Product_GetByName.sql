CREATE PROCEDURE [dbo].[SP_Product_GetByName]
	@name NVARCHAR(64) 
AS

	SELECT [Id_Product],
	       [Name],
	       [Description],
	       [Price],
	       [EcologicalCriteriaEcoScore],
	       [CategoryName]
		FROM [Product]
		WHERE [Name] = @name

