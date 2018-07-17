use DB_INTELLECT;

GO
CREATE PROCEDURE dbo.SafeLogin @CorreoLogin correo_t, @pwdHash binary(64), @enDB bit=0 OUTPUT
AS
BEGIN
SET NOCOUNT ON
DECLARE @usuario correo_t
IF EXISTS (SELECT TOP 1	Correo FROM [dbo].[Usuario] WHERE Correo=@CorreoLogin) BEGIN
	SET @usuario=(SELECT Correo FROM [dbo].[Usuario] WHERE Correo=@CorreoLogin AND PasswordHash=@pwdHash)
	IF(@usuario IS NULL)
		SET @enDB=0
	ELSE
		SET @enDB=1
	END
ELSE
	SET @enDB=0
END
GO


go
create procedure getSalt @CorreoLogin correo_t, @salt uniqueidentifier output
as begin
	select @salt=salt from Usuario
	where Correo=@CorreoLogin

	if @salt is null begin
		set @salt='00000000-0000-0000-0000-000000000000'
	end
end
go

GO
CREATE PROCEDURE superUser @CorreoLogin correo_t, @supUser bit = 0 OUTPUT
AS
BEGIN
SET NOCOUNT ON
IF EXISTS (SELECT TOP 1 Correo FROM Usuario WHERE Correo = @CorreoLogin AND Superuser = 1) BEGIN
	SET @supUser = 1
	END
	ELSE BEGIN
	SET @supUser = 0
	END
END
