USE DB_INTELLECT
create type correo_t	from varchar(50)	not null;
create type nompais_t	from nvarchar(45)	not null;



	  		

create table Pais
	( Nombre		nompais_t		not null,
	  Primary key(Nombre)
	)

-- Pais default = null
-- admin y pwd
create table Usuario
	( Correo		correo_t		not null,
	  Nombre		varchar(15)		not null,
	  Apellido		varchar(15)		not null,
	  FechaNac		date			not null,
	  FechaIni		date			not null,
	  NombrePais	nompais_t		null,
	  PasswordHash  binary(64)		not null,
	  Superuser		bit				default 0		not null,
	  Primary key(Correo),
	  Foreign key(NombrePais) References Pais(Nombre)
	)


-- Referencias para el ID
--https://stackoverflow.com/questions/427180/how-to-create-a-guid-uuid-using-the-iphone-sdk
--https://developer.apple.com/documentation/foundation/nsuuid
-- on update cascade fk correo
create table Dispositivo
	( UUID				uniqueidentifier	not null,
	  CorreoUsuario		correo_t			not null,
	  Primary key(UUID),
	  Foreign key(CorreoUsuario) References Usuario(correo) on update cascade on delete cascade
	)
	   

CREATE TABLE Cancion
	( ID int not null
	  constraint PKCancion
		primary key (ID)
	);
	  
CREATE TABLE MP3
	( IDCancion int not null,
	  FingerPrint varchar(10) not null, 
	  constraint PKMP3
		primary key (IDCancion),
	  constraint FKIDCancionMP3
		foreign key (IDCancion) references Cancion (ID)  
			on delete cascade
	 );

CREATE TABLE Link
	( IDCancion int not null,
	  URL nvarchar (2083) not null,
	  /*ToDo MatrizDatos*/
	  constraint PKlink
		primary key (IDCancion),
	  constraint FKIDCancionLink
		foreign key (IDCancion) references Cancion (ID)
			on delete cascade
	);

--https://support.microsoft.com/en-us/help/208427/maximum-url-length-is-2-083-characters-in-internet-explorer

CREATE TABLE Metadato
	( IDCancion int not null FOREIGN KEY REFERENCES Cancion (ID) on delete cascade,
	  Llave varchar(10) not null,
	  Valor varchar(400),
	  Primary Key (IDCancion, Llave)
	);
--https://es.answers.yahoo.com/question/index?qid=20100328161617AASDMa3

CREATE TABLE Procesa
	( CorreoUsuario correo_t not null FOREIGN KEY REFERENCES Usuario (Correo) ON UPDATE CASCADE,
	  IDCancion int not null FOREIGN KEY REFERENCES Cancion (ID) ON DELETE NO ACTION,
	  FechaRedimido date,
	  VersionProcesado varchar(10),
	  PRIMARY KEY (CorreoUsuario, IDCancion)			
	);
	
CREATE TABLE Compra (
Correo varchar(50) not null,
Fecha date not null,
Hora time not null,
NumTokens int not null
	Check (NumTokens > 0) ,
PrecioToken float not null
	Check (PrecioToken > 0),

Primary key (Correo, Fecha, Hora),
Foreign key (Correo) references Usuario(Correo)
on update cascade on delete cascade,

);


/*Conexión de Interfaz con la base de datos*/
/*Salt para el uso de contraseñas*/
Alter table Usuario ADD salt uniqueidentifier


/****************************/
/********** Reset ***********/
/****************************/
/*
Drop Procedure TokensRestantes
Drop Procedure CantidadCancionesProcesadasUsuario
Drop Table Compra
Drop Table Procesa
Drop Table Metadato
Drop Table Link
Drop Table MP3
Drop Table Cancion
Drop Table Dispositivo
Drop Table Usuario
Drop Table Pais
Drop type nompais_t
Drop type correo_t
*/

