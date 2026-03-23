
IF DB_ID('test') IS NULL
    create database company;
ELSE
    PRINT 'The database already exists';