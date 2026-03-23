-- INSERT TO CAMION
BEGIN TRANSACTION
BEGIN TRY

	INSERT INTO Camion (Tipo, Matricula, Modelo, Marca, Disponibilidad, Kilometraje, UrlFoto) 
	VALUES(100, 'MX001', 2020, 'Toyota', 1, 950.5, 'https://www.photos.com/camion1.png'),
		(200, 'MX002', 2010, 'Chevrolet', 0, 10, 'https://www.photos.com/camion2.png'),
		(100, 'MX003', 2000, 'Volswagen', 1, 40, 'https://www.photos.com/camion3.png'),
		(100, 'MX015', 2025, 'Mercedes', 1, 50000, 'https://www.photos.com/camion4.png'),
		(300, 'MX021', 2026, 'Mercedes', 0, 7000, 'https://www.photos.com/camion5.png')
	
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
	THROW;
END CATCH;
GO