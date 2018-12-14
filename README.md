# Active Directory Update

A small C# windows forms utility to take data from a Microsoft SQL Server Table and update the user record in Active Directory. 


## Updatable Fields

The application can update the following active directory fields 

* Firstname
* Initials 
* Lastname
* Display Name
* Description
* Office
* Telephone number
* Other Telephone number
* Email 

The data source requires the sAMAccountname, if it is not present the row will be skipped, this is used to locate the user record as part of the DirectorySearcher, disabled accounts
are excluded, however they can be included by removing `(!userAccountControl:1.2.840.113556.1.4.803:=2)` from the `search.filter` in the `UpdateActiveDirectory` method. 

## Setup 

The application contains the T-SQL code required to create the base table for the data source, however it is provided below for reference

`CREATE TABLE ADUpdateSource
(
ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
sAMAccountName varchar(200),
Firstname varchar(100),
Initials varchar(100),
LastName varchar(100),
DisplayName varchar(100),
Description varchar(100),
Office varchar(100),
TelephoneNumber varchar(100),
OtherTelephoneNumber varchar(100),
Email varchar(500)
)`

### Example Table

The application xpects a table like the one below to be present in the source, it will use the username from this table to search the active directory enviroment, if the user is found the
Telephone number will be updated.

| ID  | sAMAccountName  | Firstname | Initials | LastName | DisplayName | Description | Office | TelephoneNumber | OtherTelephoneNumber | Email 
|---|---|---|---|---|---|---|---|---|---|---|
| 1  | BloggsJ  | Joe  | D | Bloggs | Bloggs, Joe | Description Example | Office 3 | 11111 123456 | 07121345 | joe.bloggs@example.com |