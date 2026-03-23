CREATE PROCEDURE SP_Delete_Camion(
	@IdCamion INT
)
AS BEGIN
	DELETE FROM Ruta
	WHERE IdCamion = @IdCamion;

	DELETE
	FROM Camion
	WHERE Id = @IdCamion
END


--Execution
EXEC SP_Delete_Camion 10;