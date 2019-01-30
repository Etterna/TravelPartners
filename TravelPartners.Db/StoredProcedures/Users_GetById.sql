CREATE PROCEDURE [dbo].[Users_GetById]
    @userId UNIQUEIDENTIFIER
AS
    SELECT *
    FROM Users
    WHERE Id = @userId
