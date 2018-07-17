USE DB_INTELLECT
GO 
CREATE PROCEDURE CantidadMetadatosCancion @IDCancion int, @Cantidad int output
as
select @Cantidad = count (*)
from Metadato M
where M.IDCancion = @IDCancion