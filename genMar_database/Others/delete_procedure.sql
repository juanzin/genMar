IF OBJECT_ID('SP_Delete_Camion', 'P') IS NOT NULL
    DROP PROCEDURE SP_Delete_Camion;
ELSE
    PRINT 'Procedure does not exists'