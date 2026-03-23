CREATE PROCEDURE SP_Update_Ruta
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

--execution
EXEC SP_Update_Ruta 7, '2026-03-01 06:00:00', '2026-03-02 03:20:00';