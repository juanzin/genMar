CREATE PROCEDURE SP_Delete_chofer(
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


--execution
EXEC SP_Delete_chofer 8;