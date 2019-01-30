CREATE PROCEDURE [dbo].[Users_Update]
    @Id UNIQUEIDENTIFIER,
    @FirstName NVARCHAR(128),
    @LastName NVARCHAR(128),
    @Email NVARCHAR(128)
AS
    UPDATE Users
    SET
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email
    WHERE Id = @Id
