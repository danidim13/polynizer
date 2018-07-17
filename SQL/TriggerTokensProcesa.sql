USE DB_INTELLECT

GO
CREATE TRIGGER RestriccionTokensProcesar
ON Procesa INSTEAD OF INSERT
AS
DECLARE @correo correo_t,
		@id INT,
		@fechaR DATE,
		@version VARCHAR(10);
SELECT @correo = i.CorreoUsuario,
	   @id = i.IDCancion,
	   @fechaR = i.FechaRedimido,
	   @version = i.VersionProcesado
FROM INSERTED i;

DECLARE @tokensRestantes INT;
EXEC TokensRestantes @correo, @tokensRestantes output;
IF (@tokensRestantes > 0) BEGIN
	INSERT INTO Procesa
	VALUES (@correo, @id, @fechaR, @version);
END ELSE BEGIN
PRINT('No tiene tokens disponibles para procesar esta canción')
END;

--Prueba
INSERT INTO Procesa
VALUES ('marco.venegas98@hotmail.com', 3, '20180715', '0.0.1')


