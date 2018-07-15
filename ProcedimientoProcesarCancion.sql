use DB_INTELLECT
GO
create procedure ProcesarCancion
	@usuario varchar(50),
	@isLink	bit,
	@version varchar(10),
	@mp3Fingerprint binary(32),
	@urlLink nvarchar(2083),
	@error int output,
	@idCancion int output
as
begin
begin TRY
	if @isLink=1 begin
		-- Primero ver si ya existe la cancion
		select @idCancion=l.IDCancion
		from Link as l
		where l.URL=@urlLink

		-- En caso de que no insertarla
		if @@ROWCOUNT=0 begin
			select @idCancion=(max(ID)+1)
			from Cancion

			insert into Cancion
			values (@idCancion)

			insert into Link
			values	(@idCancion, @urlLink)
		end

	end else begin
		-- Primero ver si ya existe la cancion
		select @idCancion=m.IDCancion
		from Mp3 as m
		where m.FingerPrint=@mp3Fingerprint
		
		-- En caso de que no, insertarla
		if @@ROWCOUNT=0 begin
			select @idCancion=(max(ID)+1)
			from Cancion

			insert into Cancion
			values (@idCancion)

			insert into MP3
			values	(@idCancion, @mp3Fingerprint)
		end
				
	end

		-- Agregar la tupla en procesa
	insert into Procesa
	values (@usuario,@idCancion,CONVERT(date, GETDATE()),@version)


	set @error=0
end TRY
begin CATCH
	set @error=ERROR_NUMBER()
end CATCH
return
end
GO

/*
select * from Procesa
select * from MP3
select * from Cancion as c left outer join Metadato as m on c.ID=m.IDCancion
where Llave='title' or Llave is null

declare @tokens int
exec TokensRestantes 'danidiaza@gmail.com', @tokens output
print @tokens

declare @errocode int
declare @id int
exec ProcesarCancion 'danidiaza@gmail.com', 0, '0.0.1', 0x39C24B3476F3C5955BB9D803A2DEE5709311F752D6FEC796ECF4F1D8994FACDD, '', @errocode output, @id output
print 'Error:';print @errocode
print 'Nuevo id:';print @id
*/