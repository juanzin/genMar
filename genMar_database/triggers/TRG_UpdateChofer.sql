CREATE TRIGGER TRG_Update_Chofer
ON Chofer
AFTER UPDATE
AS BEGIN
	INSERT INTO ChangeLogChofer(IdChofer,Actionn, ChangedAt) 
	SELECT ins.Id, 'Updated', GETDATE()
	FROM inserted as ins
END