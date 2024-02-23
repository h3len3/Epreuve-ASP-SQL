CREATE PROCEDURE [dbo].[SP_Product_GetAll]
	
AS
	SELECT [Id_Product],
	       [Name],
	       [Description],
	       [Price],
	       [EcologicalCriteriaEcoScore],
	       [CategoryName]
	      
		FROM [Product]


	        
