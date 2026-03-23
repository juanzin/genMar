CREATE TRIGGER TRG_Update_Ruta
ON Ruta
AFTER UPDATE
AS BEGIN
	INSERT INTO ChangeLogRuta (IdRuta, Actionn, ChangedAt)
	SELECT ins.Id, 'Updated', GETDATE()
	FROM inserted as ins
END;