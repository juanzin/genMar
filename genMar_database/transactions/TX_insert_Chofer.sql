--INSERT TO CHOFER
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO Chofer(Nombre, ApellidoPaterno, ApellidoMaterno, Licencia, Telefono, Disponibilidad) 
	VALUES('Mr Lobo', 'lopez', 'perez', 'LS-P021', '2221245689', 1),
		('Peter', 'Martinez', 'Gomez', 'LS-P022', '5511245665', 0),
		('Wilson', 'Black', 'Hernandez', 'LS-P023', '7734567897', 1),
		('Tibu', 'Marson', 'Atson', 'LS-P024', '3236547897', 0),
		('Rambo', 'Martin', 'Katzenbach', 'LS-P025', '9867132544', 1)

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