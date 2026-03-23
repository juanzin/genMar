
/*
Script: create_database.sql
Author: Juan Onofre
Jira: https://juanzin.atlassian.net/browse/BLUE-54
Branch: https://github.com/juanzin/genMar/tree/FT/BLUE-54-SQL
Date: 2026-03-22
Purpose: create database company.
Dependencies: none
*/
IF DB_ID('company') IS NULL
    create database company;
ELSE
    PRINT 'The database already exists';