CREATE PROCEDURE SP_insert_ruta(
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


--Execution
EXEC SP_insert_ruta 'Colima', 'Tamaulipas', '2026-01-15 08:30:00', '2026-01-26 11:30:00', '2026-01-20 10:00:00', 1, 930, 4, 2