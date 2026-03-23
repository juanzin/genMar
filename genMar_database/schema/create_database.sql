
IF DB_ID('company') IS NULL
    create database company;
ELSE
    PRINT 'The database already exists';