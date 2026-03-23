IF OBJECT_ID('TRG_Update_Chofer', 'TR') IS NOT NULL
    DROP TRIGGER TRG_Update_Chofer;
ELSE
    PRINT 'Trigger does not exists'