USE company;

-- INSERT TO CAMION
BEGIN TRANSACTION
BEGIN TRY

	INSERT INTO Camion (Tipo, Matricula, Modelo, Marca, Disponibilidad, Kilometraje, UrlFoto) 
	VALUES(100, 'MX001', 2020, 'Toyota', 1, 950.5, 'https://www.photos.com/camion1.png'),
		(200, 'MX002', 2010, 'Chevrolet', 0, 10, 'https://www.photos.com/camion2.png'),
		(100, 'MX003', 2000, 'Volswagen', 1, 40, 'https://www.photos.com/camion3.png'),
		(100, 'MX004', 2025, 'Mercedes', 1, 50000, 'https://www.photos.com/camion4.png'),
		(300, 'MX005', 2026, 'Mercedes', 0, 7000, 'https://www.photos.com/camion5.png')
	
	COMMIT TRANSACTION;
END TRY 
BEGIN CATCH 
	IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION;

	PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR(10));
    PRINT 'Error Severity: ' + CAST(ERROR_SEVERITY() AS VARCHAR(10));
    PRINT 'Error State: ' + CAST(ERROR_STATE() AS VARCHAR(10));
    PRINT 'Error Line: ' + CAST(ERROR_LINE() AS VARCHAR(10));
    PRINT 'Error Message: ' + ERROR_MESSAGE();
	--THROW;
END CATCH;
GO


--INSERT TO CHOFER
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO Chofer(Nombre, ApellidoPaterno, ApellidoMaterno, Licencia, Telefono, Disponibilidad) 
	VALUES('Mr Lobo', 'lopez', 'perez', 'LS-P001', '2221245689', 1),
		('Peter', 'Martinez', 'Gomez', 'LS-P002', '5511245665', 0),
		('Wilson', 'Black', 'Hernandez', 'LS-P003', '7734567897', 1),
		('Tibu', 'Marson', 'Atson', 'LS-P004', '3236547897', 0),
		('Rambo', 'Martin', 'Katzenbach', 'LS-P005', '9867132544', 1)

	COMMIT TRANSACTION;
END TRY 
BEGIN CATCH
	IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION;
	PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR(10));
    PRINT 'Error Severity: ' + CAST(ERROR_SEVERITY() AS VARCHAR(10));
    PRINT 'Error State: ' + CAST(ERROR_STATE() AS VARCHAR(10));
    PRINT 'Error Line: ' + CAST(ERROR_LINE() AS VARCHAR(10));
    PRINT 'Error Message: ' + ERROR_MESSAGE();
	--THROW;
END CATCH;
GO

--INSERT TO RUTA
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO Ruta(Origen, Destino, FechaSalida, FechaLlegada, FechaRegistro, ATiempo, Distancia, IdCamion, IdChofer) 
	VALUES 
	('Puebla', 'Cd MX', '2026-03-22 08:30:00', '2026-03-22 11:30:00', '2026-03-21 10:00:00', 1, 150, 2, 3),
	('Veracruz', 'Jalisco', '2026-02-10 06:00:00', '2026-02-11 03:20:00', '2026-02-08 10:00:00', 1, 850, 1, 4),
	('Puebla', 'Yucatan', '2026-01-10 05:00:00', '2026-01-13 15:00:00', '2026-01-05 12:00:00', 1, 1000, 3, 5),
	('Toluca', 'Oaxaca', '2026-03-10 08:30:00', '2026-03-11 11:30:00', '2026-03-03 10:00:00', 1, 500, 5, 2),
	('Queretaro', 'Monterrey', '2026-02-01 08:30:00', '2026-02-04 11:30:00', '2026-01-28 10:00:00', 1, 400, 4, 5),
	('Morelos', 'Cd MX', '2026-03-18 08:30:00', '2026-03-19 11:30:00', '2026-03-17 10:00:00', 1, 100, 1, 2)
	COMMIT TRANSACTION;
END TRY 
BEGIN CATCH 
	IF @@TRANCOUNT > 0
		ROLLBACK TRANSACTION;

	PRINT 'Error Number: ' + CAST(ERROR_NUMBER() AS VARCHAR(10));
    PRINT 'Error Severity: ' + CAST(ERROR_SEVERITY() AS VARCHAR(10));
    PRINT 'Error State: ' + CAST(ERROR_STATE() AS VARCHAR(10));
    PRINT 'Error Line: ' + CAST(ERROR_LINE() AS VARCHAR(10));
    PRINT 'Error Message: ' + ERROR_MESSAGE();
	--THROW;
END CATCH
GO