/*Inicializador de la tabla Dia*/
INSERT into Dia (nombre) VALUES ('Lunes')
INSERT into Dia (nombre) VALUES ('Martes')
INSERT into Dia (nombre) VALUES ('Miercoles')
INSERT into Dia (nombre) VALUES ('Jueves')
INSERT into Dia (nombre) VALUES ('Viernes')
INSERT into Dia (nombre) VALUES ('Sabado')
INSERT into Dia (nombre) VALUES ('Domingo')

SELECT * FROM Dia
/*Inicializador de la tabla Direccion*/
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio) VALUES ('Balcarce',540,0)
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio) VALUES ('Chacabuco',359,0)
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio,piso,departamento,localidad,provincia) VALUES ('Manuel Puebla',2262,1,13,'A','Cordoba capital','Cordoba')

SELECT * FROM Direccion

/*Inicializador de la tabla Colaborador*/
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Francisco','Paez','elXeneize@hotmail.edu.ar',1,'01-01-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Juan Sebastian','Martinez','lanus@hotmail.edu.ar',2,'02-02-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Carlos','Gardel','riverPlate@hotmail.edu.ar',3,'04-04-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Pepe','Argento','AzulYOro@hotmail.edu.ar',1,'07-06-2001',GETDATE())

SELECT * FROM Colaborador

/*Inicializador de la tabla Perfil*/
INSERT into Perfil (nombre) VALUES ('ADMINISTRADOR')

SELECT * FROM Perfil

/*Inicializador de la tabla Usuario*/
INSERT into Usuario (legajoColaborador,id_perfil,nombre,contraseña) VALUES (10000,1,'Admin','1234')
INSERT into Usuario (legajoColaborador,id_perfil,nombre,contraseña) VALUES (10001,1,'Juan','4567')
INSERT into Usuario (legajoColaborador,id_perfil,nombre,contraseña) VALUES (10002,1,'Gardo','765')
INSERT into Usuario (legajoColaborador,id_perfil,nombre,contraseña) VALUES (10003,1,'Pepito','1919')


SELECT * FROM Usuario




/*Inicializador de la tabla EstadoColaborador*/
INSERT into EstadoColaborador (nombre,descripcion) VALUES ('Activo','El colaborador trabajando activamente')
INSERT into EstadoColaborador (nombre,descripcion) VALUES ('Inactivo','El colaborador no esta trabajando')
INSERT into EstadoColaborador (nombre,descripcion) VALUES ('De vacaciones','El colaborador se tomo vacaciones')

SELECT * FROM EstadoColaborador

/*Inicializador de la tabla TipoEvento*/
INSERT into EstadoColaborador (nombre) VALUES ('Tardanza')
INSERT into EstadoColaborador (nombre) VALUES ('Salud')
INSERT into EstadoColaborador (nombre) VALUES ('Tomar el dia')
INSERT into EstadoColaborador (nombre) VALUES ('Otro')

SELECT * FROM EstadoColaborador

/*Inicializador de la tabla Evento*/
INSERT into Evento (descripcion,id_tipoEvento) VALUES ('Francisco llega 20 minutos tarde',1)
INSERT into Evento (descripcion,id_tipoEvento) VALUES ('Juan tiene que ir al medico',2)
INSERT into Evento (descripcion,id_tipoEvento) VALUES ('Pepe tiene un accidente laboral',2)
INSERT into Evento (descripcion,id_tipoEvento) VALUES ('Carlos no usa el equipo de seguridad',3)

SELECT * FROM Evento



