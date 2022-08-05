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
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Lionel','Messi','elXeneize@hotmail.edu.ar',1,'01-01-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Pipo','Martinez','lanus@hotmail.edu.ar',2,'02-02-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Tato','Gardel','riverPlate@hotmail.edu.ar',3,'04-04-2001',GETDATE())
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso) VALUES ('Rodolfo','Argento','AzulYOro@hotmail.edu.ar',1,'07-06-2001',GETDATE())

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

/*Inicializador de la tabla TipoMultimedia*/

INSERT INTO TipoMultimedia VALUES ('Recibos de sueldo')
INSERT INTO TipoMultimedia VALUES ('Curriculum')
INSERT INTO TipoMultimedia VALUES ('Notas')
INSERT INTO TipoMultimedia VALUES ('Comprobantes medicos')
INSERT INTO TipoMultimedia VALUES ('Foto del colaborador')

/*Inicializador de la tabla Cargo*/

INSERT INTO Cargo VALUES ('Repartidor')
INSERT INTO Cargo VALUES ('Control stock')
INSERT INTO Cargo VALUES ('Supervisor')



/*Inicializador de la tabla HistorialCargo*/

INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10000)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10001)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10002)
INSERT INTO HistorialCargo VALUES (2,GETDATE(),NULL,10003)
INSERT INTO HistorialCargo VALUES (2,GETDATE(),NULL,10004)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10005)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10006)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10007)

SELECT * FROM HistorialCargo

/*Inicializador de la tabla Salario*/

INSERT INTO Salario VALUES (145000.34)
INSERT INTO Salario VALUES (70000.76)
INSERT INTO Salario VALUES (80900.44)
INSERT INTO Salario VALUES (90000.34)
INSERT INTO Salario VALUES (50897.54)
INSERT INTO Salario VALUES (98700.33)
INSERT INTO Salario VALUES (140000.4)
INSERT INTO Salario VALUES (14678.34)

SELECT * FROM Salario

/*Inicializador de la tabla HistorialSalario*/
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,1,10000)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,2,10001)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,3,10002)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,4,10003)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,5,10004)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,6,10005)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,7,10006)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,8,10007)

SELECT * FROM HistorialSalario

