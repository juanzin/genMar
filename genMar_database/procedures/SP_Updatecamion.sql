CREATE PROCEDURE SP_update_camion(
	@idCamion INT,
	@NuevaDisponibilidad BIT
)
AS BEGIN
	UPDATE Camion
	SET Disponibilidad = @NuevaDisponibilidad
	WHERE Id = @idCamion;

END


--execution
EXEC SP_update_camion 8, 0;