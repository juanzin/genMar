USE photography;
GO

---get all photos
CREATE OR ALTER PROCEDURE Get_All_Photos
AS
BEGIN
	SELECT * FROM Photos;
END
GO

--get all categories
CREATE OR ALTER PROCEDURE Get_All_Categories
AS 
BEGIN
	SELECT * FROM Categories;
END
GO





----EXECUTION
--getters
EXEC Get_All_Photos;
EXEC Get_All_Categories;

--setters


--deletes


--updates