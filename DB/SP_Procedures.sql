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


CREATE OR ALTER PROCEDURE SP_Insert_Photographer
	@Name VARCHAR(100),
	@Materno VARCHAR(100),
	@Paterno VARCHAR(100),	
	@Username VARCHAR(100),
	@Password VARCHAR(100),
	@Instagram  VARCHAR(200),
	@Facebook VARCHAR(200),
	@Email VARCHAR(200),
	@Biography VARCHAR(200),
	@Type_User INT
AS
BEGIN
	INSERT INTO Photographers(Name, Materno, Paterno, Username, Password,Instagram, Facebook, Email, Biography, Type_User)
	VALUES(@Name, @Materno, @Paterno, @Username, @Password, @Instagram, @Facebook, @Email, @Biography, @Type_User)
END 
GO

CREATE OR ALTER PROCEDURE SP_Update_Photographer
	@Id INT,
	@Name VARCHAR(100),
	@Materno VARCHAR(100),
	@Paterno VARCHAR(100),	
	@Username VARCHAR(100),
	@Password VARCHAR(100),
	@Instagram  VARCHAR(200),
	@Facebook VARCHAR(200),
	@Email VARCHAR(200),
	@Biography VARCHAR(200),
	@Type_User INT
AS
BEGIN
	UPDATE Photographers
	SET
	Name = @Name,
	Materno = @Materno,
	Paterno = @Paterno,	
	Username = @Username,
	Password = @Password,
	Instagram = @Instagram,
	Facebook = @Facebook,
	Email = @Email,
	Biography = @Biography,
	Type_User = @Type_User
	WHERE Id = @Id
END 
GO


----EXECUTION
--getters
EXEC Get_All_Photos;
EXEC Get_All_Categories;

--setters
EXEC SP_Insert_Photographer 'Irving', 'Lopez', 'Martinez', 'Irving', 'memelas', 'https://www.instagram.com/kualtzin_photo/', 'https://www.facebook.com/', 'irvg@hotmail.com', 'soy chido', 1;
EXEC SP_Update_Photographer 1, 'Irving', 'Lopez', 'Martinez', 'Mexican', 'montania', 'https://www.instagram.com/kualtzin_photo/', 'https://www.facebook.com/', 'irvg@hotmail.com', 'soy buen fotografo', 1;

--deletes


--updates