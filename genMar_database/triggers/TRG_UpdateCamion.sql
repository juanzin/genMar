CREATE TRIGGER TRG_after_update_camion
ON Camion
AFTER UPDATE
AS
BEGIN
	INSERT INTO ChangeLogCamion(idCamion, Actionn, ChangedAt)
	SELECT ins.Id, 'Updated', GETDATE()
	FROM inserted as ins
END;