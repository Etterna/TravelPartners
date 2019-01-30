CREATE PROCEDURE [dbo].[Users_Create]
    @Id UNIQUEIDENTIFIER,
    @FirstName NVARCHAR(128),
    @LastName NVARCHAR(128),
    @Email NVARCHAR(128)
AS
    INSERT INTO Users
    (
        Id,
        FirstName,
        LastName,
        Email
    )
    VALUES 
    (
        @Id,
        @FirstName,
        @LastName,
        @Email
    )
