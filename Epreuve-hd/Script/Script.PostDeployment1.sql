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


--DECLARE @today DATE = CONVERT(DATE,GETDATE());
--DECLARE @now TIME = CONVERT(TIME,GETDATE());
--DECLARE @next_time TIME = DATEADD(MINUTE,128,@now);

--EXEC SP_Diffusion_Insert @today, @now, 'French', NULL, 2, 1;
--EXEC SP_Diffusion_Insert @today, @now, 'Original', 'French', 3, 4;
--EXEC SP_Diffusion_Insert @today, @now, 'French', NULL, 1, 2;
--EXEC SP_Diffusion_Insert @today, @next_time, 'Original', 'French', 2, 3;

--/////////

--INSERT INTO professor VALUES (1, 'zidda', 'pietro', 1020, 402, 'pzidda', '2004-12-11', 1900);
--INSERT INTO professor VALUES (2, 'decrop', 'alain', 1120, 403, 'adecrop', '2003-05-09', 1950);
--INSERT INTO professor VALUES (3, 'giot', 'pierre', 1310, 404, 'pgiot', '2002-12-21', 2100);
--INSERT INTO professor VALUES (4, 'lecourt', 'christelle', 1310, 406, 'clecourt', '2003-05-07', 1750);
--INSERT INTO professor VALUES (5, 'scheppens', 'georges', 1020, 410, 'gscheppens', '1986-10-09', 2450);
--INSERT INTO professor VALUES (6, 'louveaux', 'francois', 1110, 407, 'flouveaux', '1990-05-07', 2200);