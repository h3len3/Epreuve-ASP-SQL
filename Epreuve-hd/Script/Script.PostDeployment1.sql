/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

insert into [Category]
    values  ('Vaisselle'),
            ('Vêtement');
go


EXEC SP_Product_Insert 'Assiette', 'Assiette en bois - plate - grande taille', 9, 'A', 'Vaisselle';
EXEC SP_Product_Insert 'Assiette', 'Assiette en bois - creuse - grande taille', 11, 'A', 'Vaisselle';
EXEC SP_Product_Insert 'Bol', 'Bol en inox', 6, 'B', 'Vaisselle';
EXEC SP_Product_Insert 'Echarpe', 'Echarpe 100% laine - bleue - longueur 60 cm', 25.80, 'A', 'Vêtement';
EXEC SP_Product_Insert 'Echarpe', 'Echarpe 100% laine - rouge - longueur 80 cm', 25.80, 'A', 'Vêtement';

