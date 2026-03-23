/*
Script: SP_Procedures.sql
Author: Juan Onofre
Jira: https://juanzin.atlassian.net/browse/BLUE-54
Branch: https://github.com/juanzin/genMar/tree/FT/BLUE-54-SQL
Date: 2026-03-22
Purpose: update dates.
Dependencies: none
*/

--Update table Ruta
CREATE OR ALTER PROCEDURE SP_Update_Ruta
    @IdRuta INT,
    @NuevaFechaSalida DATETIME,
    @NuevaFechaLlegada DATETIME
AS
BEGIN
    UPDATE Ruta
    SET FechaSalida = @NuevaFechaSalida,
        FechaLlegada = @NuevaFechaLlegada
    WHERE Id = @IdRuta;
END;
GO

--Update table Chofer
CREATE OR ALTER PROCEDURE SP_Update_Chofer(
	@IdChofer INT,
	@NuevaDisponibilidad BIT
)
AS BEGIN
	UPDATE Chofer 
	SET Disponibilidad = @NuevaDisponibilidad
	WHERE Id = @IdChofer;
END
GO;

--Update table Camion
CREATE OR ALTER PROCEDURE SP_update_camion(
	@idCamion INT,
	@NuevaDisponibilidad BIT
)
AS BEGIN
	UPDATE Camion
	SET Disponibilidad = @NuevaDisponibilidad
	WHERE Id = @idCamion;

END
GO;

--Insert ruta
CREATE OR ALTER PROCEDURE SP_insert_ruta(
	@Origen VARCHAR(200),
	@Destino VARCHAR(200),
	@FechaSalida DATETIME,
	@FechaLlegada DATETIME,
	@FechaRegistro DATETIME,
	@ATiempo BIT,
	@Distancia FLOAT,
	@IdCamion INT,
	@IdChofer INT
)
AS
BEGIN
	INSERT INTO Ruta(Origen, Destino, FechaSalida, FechaLlegada, FechaRegistro, ATiempo, Distancia, IdCamion, IdChofer)
	VALUES(@Origen, @Destino, @FechaSalida, @FechaLlegada, @FechaRegistro, @ATiempo, @Distancia, @IdCamion, @IdChofer)

	SELECT SCOPE_IDENTITY() AS newRuta
END

--Insert chofer
CREATE OR ALTER PROCEDURE SP_Insert_chofer(
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

--Insert camion
CREATE OR ALTER PROCEDURE SP_insert_camion
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

--Delete ruta
CREATE OR ALTER PROCEDURE SP_Delete_Ruta(
	@IdRuta INT
)
AS
BEGIN
	DELETE
	FROM Ruta
	WHERE Id = @IdRuta;
END

--Delete chofer
CREATE OR ALTER PROCEDURE SP_Delete_chofer(
	@IdChofer INT
)
AS BEGIN
  DELETE 
  FROM Ruta
  WHERE IdChofer = @IdChofer

  DELETE 
  FROM Chofer
  WHERE Id = @IdChofer
END

--Delete camion
CREATE OR ALTER PROCEDURE SP_Delete_Camion(
	@IdCamion INT
)
AS BEGIN
	DELETE FROM Ruta
	WHERE IdCamion = @IdCamion;

	DELETE
	FROM Camion
	WHERE Id = @IdCamion
END

--execution
EXEC SP_Update_Ruta 7, '2026-03-01 06:00:00', '2026-03-02 03:20:00';
EXEC SP_Update_Chofer 2, 1;
EXEC SP_update_camion 8, 0;
EXEC SP_insert_ruta 'Colima', 'Tamaulipas', '2026-01-15 08:30:00', '2026-01-26 11:30:00', '2026-01-20 10:00:00', 1, 930, 4, 2
EXEC SP_Insert_chofer 'Pepe', 'Lucas', 'Gomez', 'LS-P020', '8811245800', 1;
EXEC SP_insert_camion 100, 'MX020', 1998, 'ABS', 1, 4000, 'https://www.photos.com/camionABS2.png';
EXEC SP_Delete_Ruta 15;
EXEC SP_Delete_chofer 8;
EXEC SP_Delete_Camion 10;



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