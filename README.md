# Active Directory Update

A small C# windows forms utility to take data from a pre-defined SQL Server and pre-defined SQL Table and update the user record in Active Directory

### Example Table

The application xpects a table like the one below to be present in the source, it will use the username from this table to search the active directory enviroment, if the user is found the
Telephone number will be updated.

| ID  | Username  | Telephone |
|---|---|---|
| 1  | BloggsJ  | 123  |
| 2  | DoeJ  | 456  |
| 3  | DaviesW  | 765  |