use DB_INTELLECT

/*Devuelve en el entero @Cantidad la cantidad de canciones procesadas relacionadas al correo del usuario*/
GO
CREATE PROCEDURE CantidadCancionesProcesadasUsuario @Correo varchar(50), @Cantidad int output
as
select @Cantidad = count (*)
from Procesa P
where P.CorreoUsuario =  @Correo 
GO