/*
Script: create_database.sql
Author: Juan Onofre
Jira: https://juanzin.atlassian.net/browse/BLUE-54
Branch: https://github.com/juanzin/genMar/tree/FT/BLUE-54-SQL
Date: 2026-03-22
Purpose: contigency.
Dependencies: none
*/
IF DB_ID('company') IS NOT NULL
    drop database company;
ELSE
    PRINT 'The database does not exists';