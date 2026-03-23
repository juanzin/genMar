CREATE PROCEDURE SP_Insert_chofer(
	@Nombre VARCHAR(100),
	@ApellidoPaterno VARCHAR(100),
	@ApellidoMaterno VARCHAR(100),
	@Licencia VARCHAR(50),
	@Telefono VARCHAR(20),
	@Disponibilidad BIT
)
AS
BEGIN
	INSERT INTO Chofer(Nombre, ApellidoPaterno, ApellidoMaterno, Licencia, Telefono, Disponibilidad)
	VALUES(@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Licencia, @Telefono, @Disponibilidad)

	SELECT SCOPE_IDENTITY() AS newChofer
END;


---execution

EXEC SP_Insert_chofer 'Pepe', 'Lucas', 'Gomez', 'LS-P020', '8811245800', 1;


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

