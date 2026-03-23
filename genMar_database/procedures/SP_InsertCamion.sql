CREATE PROCEDURE SP_insert_camion
	@Tipo INT,
	@Matricula VARCHAR(50),
	@Modelo INT,
	@Marca VARCHAR(50),
	@Disponibilidad BIT,
	@Kilometraje FLOAT,
	@UrlFoto VARCHAR(100)
AS
BEGIN
	INSERT INTO Camion(Tipo, Matricula, Modelo, Marca, Disponibilidad, Kilometraje, UrlFoto)
	VALUES(@Tipo, @Matricula, @Modelo, @Marca, @Disponibilidad, @Kilometraje, @UrlFoto)

	--SELECT @@IDENTITY AS nuevoCamion; --avoid to use @@IDENTITY
	SELECT SCOPE_IDENTITY() AS nuevoCamion;
END;

-- procedure execution
EXEC SP_insert_camion 100, 'MX020', 1998, 'ABS', 1, 4000, 'https://www.photos.com/camionABS2.png';


--NOTES
/*
- @@IDENTITY can be affected by triggers. If your insert fires a trigger that inserts into another table with an identity, you might get that value instead.

- Safer alternatives:
- SCOPE_IDENTITY() → returns the last identity value generated in the same scope (ignores triggers).
- IDENT_CURRENT('Camion') → returns the last identity value generated for a specific table, regardless of session or scope.

Example:

INSERT INTO Camion (Tipo, Matricula, Modelo, Marca, Disponibilidad, Kilometraje, UrlFoto)
VALUES (100, 'MX001', 2020, 'Toyota', 1, 950.5, 'https://www.photos.com/camion1.png');

SELECT SCOPE_IDENTITY() AS nuevoCamion;

This will give you the IdCamion of the row you just inserted, safely.
*/