CREATE PROCEDURE [dbo].[SP_Product_GetByEcoscore]
	@ecologicalcriteriaecoscore VARCHAR(1)  
AS

	SELECT [Id_Product],
	       [Name],
	       [Description],
	       [Price],
	       [EcologicalCriteriaEcoScore],
	       [CategoryName]
		FROM [Product]
		WHERE [EcologicalCriteriaEcoScore]= @ecologicalcriteriaecoscore
