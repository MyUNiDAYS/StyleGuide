<p align="center">
  <img src="../assets/UNiDAYS_Logo.png" />
</p>
<br/>

# UNiDAYS LESS Coding Style Guide

* [General](#General)
* [T-SQL](#T-SQL)
* [PL/pgSQL](#PL/pgSQL)

## General

* Never mention database names in a query because they may not be the same across our platforms
* Capitalise keywords and function names
* Qualify table names with schema name
* Each field and part of statement should be on its own line
* Indent for readability

```sql
UPDATE
    [schema].[Table]
SET
    [FieldOne] = 'Thing'
    ,[FieldTwo] = GETDATE()
WHERE
    [Name] = 'name'
    AND [Description] = 'description'
```

* Id fields should be named `[Id]`, never `[TableNameId]` or `[TableName_Id]`

```sql
ALTER TABLE [schema].[Thing] ADD [Id] UNIQUEIDENTIFIER NOT NULL
```

* Queries should not be written in an idempotent way
* We run our queries in order through the UNiDAYS Updater
* We want queries to fail if the database is in such a state that the query can't be run

## T-SQL

* Casing:
  * Database name = UpperCamelCase
  * Schema = lower case
  * Table = UpperCamelCase
  * Field = UpperCamelCase
* Names (field, table, schema) should be wrapped in `[]`

```sql
SELECT
    [FieldOne]
    ,[FieldTwo]
FROM
    [schema].[Table]
```

* Data types capitalised

```sql
ALTER TABLE [schema].[Thing] ADD [NewField] INT NOT NULL
```

* Id field should be of type `uniqueidentifier`

```sql
ALTER TABLE [schema].[Thing] ADD [Id] UNIQUEIDENTIFIER NOT NULL
```

## PL/pgSQL

* Casing:
  * Database name = snake_case
  * Schema = snake_case
  * Table = snake_case
  * Field = snake_case
* Every statement should end with a semi-colon

```sql
SELECT
    field_one
    ,field_two
FROM
    schema_name.table_name;
```

* Id field should be of type `uuid`

```sql
ALTER TABLE schema_name.table_name ADD id uuid NOT NULL;
```

* Timestamp fields should be `timestamp` so we don't include the time zone

```sql
ALTER TABLE schema_name.table_name ADD occurred_on timestamp NOT NULL;
```

* If we don't need to store the time, the `date` datatype should be used

```sql
ALTER TABLE schema_name.table_name ADD birthday date NOT NULL;
```

* Data types should be specified in lower-case

```sql
ALTER TABLE schema_name.table_name ADD id uuid NOT NULL;
```
