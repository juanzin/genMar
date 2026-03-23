CREATE PROCEDURE SP_Delete_Ruta(
	@IdRuta INT
)
AS
BEGIN
	DELETE
	FROM Ruta
	WHERE Id = @IdRuta;
END

--execution
EXEC SP_Delete_Ruta 15;