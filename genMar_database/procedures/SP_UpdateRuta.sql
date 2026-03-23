/*
Script: SP_Update_Ruta.sql
Author: Juan Onofre
Jira: https://juanzin.atlassian.net/browse/BLUE-54
Branch: https://github.com/juanzin/genMar/tree/FT/BLUE-54-SQL
Date: 2026-03-22
Purpose: update dates.
Dependencies: none
*/

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