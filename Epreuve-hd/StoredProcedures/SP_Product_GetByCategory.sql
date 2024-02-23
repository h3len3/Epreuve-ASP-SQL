CREATE PROCEDURE [dbo].[SP_Product_GetByCategory]
	@categoryname NVARCHAR(64) 
AS

	SELECT [Id_Product],
	       [Name],
	       [Description],
	       [Price],
	       [EcologicalCriteriaEcoScore],
	       [CategoryName]
		FROM [Product]
		WHERE [CategoryName] = @categoryname

