GO
CREATE TRIGGER RestriccionDispositivos
ON DISPOSITIVO INSTEAD OF INSERT
AS
DECLARE @id UNIQUEIDENTIFIER,
		@correo VARCHAR(50);
SELECT  @id = i.UUID,
		@correo = i.CorreoUsuario
FROM INSERTED i;

IF ((SELECT COUNT(*)
	FROM Dispositivo D
	WHERE D.CorreoUsuario = @correo) < 2)
BEGIN
	INSERT INTO Dispositivo
	VALUES(@id, @correo);
END ELSE
BEGIN
PRINT('No puede tener más de 2 dispositivos')
END;