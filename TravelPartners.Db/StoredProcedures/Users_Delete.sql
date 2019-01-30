CREATE PROCEDURE [dbo].[Users_Delete]
    @userId UNIQUEIDENTIFIER
AS
    DELETE FROM Users
    WHERE Id = @userId