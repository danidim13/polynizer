USE DB_INTELLECT
/*Devuelve en @cantidad el numero de tokens restantes de un usuario*/
GO
CREATE PROCEDURE TokensRestantes @correo correo_t, @cantidad int output
AS BEGIN
	DECLARE @comprados int, @usados int

	SELECT @comprados=sum(c.NumTokens)
	FROM Compra as c
	WHERE c.Correo=@correo

	SELECT @usados=count(*)
	FROM Procesa as p
	WHERE p.CorreoUsuario=@correo

	set @cantidad = @comprados - @usados

RETURN
END