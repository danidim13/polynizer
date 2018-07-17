USE DB_INTELLECT

GO
CREATE PROCEDURE FiltrarPorMetadato
	@llave VARCHAR(10),
	@val   VARCHAR(400)
AS
	DECLARE @losIds TABLE(ID INT); --Tabla para insertar el id de las canciones en las que coincide el metadato
	INSERT INTO @losIds
	SELECT M.IDCancion
	FROM Metadato M
	WHERE M.Llave = @llave AND M.Valor = @val;

	DECLARE @titulos TABLE(Titulo VARCHAR (400));
	DECLARE @currId INT;

	DECLARE cur CURSOR FOR
	SELECT ID FROM @losIds;

	OPEN cur
	FETCH NEXT FROM cur INTO @currId;

	WHILE @@FETCH_STATUS = 0 BEGIN
		INSERT INTO @titulos
		SELECT M.Valor
		FROM Metadato M
		WHERE M.Llave = 'title' AND M.IDCancion = @currId;
		FETCH NEXT FROM cur INTO @currId;
	END

	SELECT *
	FROM @titulos
GO

--Pruebas
EXEC FiltrarPorMetadato 'artist', 'Psy';
EXEC FiltrarPorMetadato 'genre', 'K-pop';
EXEC FiltrarPorMetadato 'title', 'Gentleman'