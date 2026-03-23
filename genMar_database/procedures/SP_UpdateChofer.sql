CREATE PROCEDURE SP_Update_Chofer(
	@IdChofer INT,
	@NuevaDisponibilidad BIT
)
AS BEGIN
	UPDATE Chofer 
	SET Disponibilidad = @NuevaDisponibilidad
	WHERE Id = @IdChofer;
END

--execution
EXEC SP_Update_Chofer 2, 1;