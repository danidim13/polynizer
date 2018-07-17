USE DB_INTELLECT
/*Procedimiento para agregar un usuario*/
GO
CREATE PROCEDURE AgregarUsuario  
@correo correo_t,	
@nombre varchar(15),
@apellido varchar(15),
@fechaNac date,
@fechaIni date,
@pais nompais_t,
@password NVARCHAR(50),
@superUser bit,
@resultado bit OUTPUT
AS BEGIN
    SET NOCOUNT ON
    DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY
        Insert into usuario (Correo, Nombre, Apellido,FechaNac, FechaIni, NombrePais ,PasswordHash,Superuser,salt)
        Values (@correo, @nombre, @apellido, @fechaNac, @fechaIni, @pais, HASHBYTES('SHA2_512', @password+CAST(@salt AS NVARCHAR(36))), @superUser, @salt)
        SET @resultado=1
    END TRY
    BEGIN CATCH
        SET @resultado=ERROR_MESSAGE()
    END CATCH
END