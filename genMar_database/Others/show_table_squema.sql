USE company;

SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES;


/* A table schema in SQL Server is essentially the logical container or namespace that organizes database objects (like tables, views, stored procedures). 
   It helps group and manage objects, control permissions, and avoid name conflicts.

🔹 Key Points about Schemas
• 	Default schema: If you don’t specify one, SQL Server uses  (database owner).
• 	Ownership & security: Schemas allow you to assign permissions at the schema level instead of per table.
• 	Organization: You can group related tables under different schemas (e.g., , ).
• 	Uniqueness: Two tables can have the same name if they’re in different schemas (e.g.,  and ).


IMPORTANT:
In short: a schema is like a folder inside your database that helps organize and secure your tables.
*/