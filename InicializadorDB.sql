USE [ETRA]
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
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio,borradoLogico) VALUES ('Balcarce',540,0,0)
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio,borradoLogico) VALUES ('Chacabuco',359,0,0)
INSERT into Direccion (nombreCalle,numeroCalle,esEdificio,piso,departamento,localidad,provincia,borradoLogico) VALUES ('Manuel Puebla',2262,1,13,'A','Cordoba capital','Cordoba',0)

SELECT * FROM Direccion

/*Inicializador de la tabla Colaborador*/
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Francisco','Paez','elXeneize@hotmail.edu.ar',1,'10-10-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',NULL)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Juan Sebastian','Martinez','lanus@hotmail.edu.ar',2,'02-02-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Carlos','Gardel','riverPlate@hotmail.edu.ar',3,'04-04-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Pepe','Argento','AzulYOro@hotmail.edu.ar',1,'07-06-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Lionel','Messi','elXeneize@hotmail.edu.ar',1,'01-01-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Pipo','Martinez','lanus@hotmail.edu.ar',2,'02-02-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Tato','Gardel','riverPlate@hotmail.edu.ar',3,'04-04-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)
INSERT into Colaborador (nombre,apellido,mail,idDireccion,fechaNacimiento,fechaIngreso,borradoLogico,dni,CUIT,sexo,nroContacto,nroEmergencia,obraSocial,legajoResponsable) VALUES ('Rodolfo','Argento','AzulYOro@hotmail.edu.ar',1,'07-06-2001',GETDATE(),0,42892322,'23-42892322-8','M','3584291952','3584291952','OSDE',10000)

SELECT * FROM Colaborador

/*Inicializador de la tabla Perfil*/
INSERT into Perfil (nombre,borradoLogico) VALUES ('ADMINISTRADOR',0)
INSERT into Perfil (nombre,borradoLogico) VALUES ('COLABORADOR',0)

SELECT * FROM Perfil

/*Inicializador de la tabla Usuario*/
INSERT into Usuario (id_perfil,mail,contraseña,legajoColaborador,borradoLogico) VALUES (1,'admin@admin.com','1234',10000,0)
INSERT into Usuario (id_perfil,mail,contraseña,legajoColaborador,borradoLogico) VALUES (1,'admin@admin.com','4567',10001,0)
INSERT into Usuario (id_perfil,mail,contraseña,legajoColaborador,borradoLogico) VALUES (1,'admin@admin.com','765',10002,0)
INSERT into Usuario (id_perfil,mail,contraseña,legajoColaborador,borradoLogico) VALUES (1,'admin@admin.com','1919',10003,0)


SELECT * FROM Usuario




/*Inicializador de la tabla EstadoColaborador*/
INSERT into EstadoColaborador (nombre,descripcion,borradoLogico) VALUES ('Activo','El colaborador trabajando activamente',0)
INSERT into EstadoColaborador (nombre,descripcion,borradoLogico) VALUES ('Inactivo','El colaborador no esta trabajando',0)
INSERT into EstadoColaborador (nombre,descripcion,borradoLogico) VALUES ('De vacaciones','El colaborador se tomo vacaciones',0)

SELECT * FROM EstadoColaborador

/*Inicializador de la tabla TipoEvento*/
INSERT into TipoEvento (nombre,borradoLogico) VALUES ('Bienvenida',0)
INSERT into TipoEvento (nombre,borradoLogico) VALUES ('Tardanza',0)
INSERT into TipoEvento (nombre,borradoLogico) VALUES ('Salud',0)
INSERT into TipoEvento (nombre,borradoLogico) VALUES ('Tomar el dia',0)
INSERT INTO TipoEvento VALUES ('Pago Sueldo',0)
INSERT into TipoEvento (nombre,borradoLogico) VALUES ('Otro',0)
INSERT INTO TipoEvento VALUES ('Feriado',0)
INSERT INTO TipoEvento VALUES ('Anticipo a descontar',0)

SELECT * FROM EstadoColaborador

/*Inicializador de la tabla Evento*/
INSERT into Evento (descripcion,id_tipoEvento,borradoLogico) VALUES ('Francisco llega 20 minutos tarde',1,0)
INSERT into Evento (descripcion,id_tipoEvento,borradoLogico) VALUES ('Juan tiene que ir al medico',2,0)
INSERT into Evento (descripcion,id_tipoEvento,borradoLogico) VALUES ('Pepe tiene un accidente laboral',2,0)
INSERT into Evento (descripcion,id_tipoEvento,borradoLogico) VALUES ('Carlos no usa el equipo de seguridad',3,0)

SELECT * FROM Evento

/*Inicializador de la tabla TipoMultimedia*/

INSERT INTO TipoMultimedia VALUES ('Recibos de sueldo',0)
INSERT INTO TipoMultimedia VALUES ('Curriculum',0)
INSERT INTO TipoMultimedia VALUES ('Notas',0)
INSERT INTO TipoMultimedia VALUES ('Comprobantes medicos',0)
INSERT INTO TipoMultimedia VALUES ('Foto del colaborador',0)

/*Inicializador de la tabla Cargo*/

INSERT INTO Cargo VALUES ('Encargado',0)
INSERT INTO Cargo VALUES ('Maestranza',0)
INSERT INTO Cargo VALUES ('Chofer',0)
INSERT INTO Cargo VALUES ('Vendedor de mostrador',0)
INSERT INTO Cargo VALUES ('Mulero',0)
INSERT INTO Cargo VALUES ('Vendedor',0)
INSERT INTO Cargo VALUES ('Operario deposito',0)
INSERT INTO Cargo VALUES ('Atencion al publico en sucursal',0)
INSERT INTO Cargo VALUES ('Encargado logistica y deposito',0)
INSERT INTO Cargo VALUES ('Deposito',0)
INSERT INTO Cargo VALUES ('Administracion y comunicacion',0)
INSERT INTO Cargo VALUES ('Pasante',0)



/*Inicializador de la tabla HistorialCargo*/

INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10000,0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10001,0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,10002,0)
INSERT INTO HistorialCargo VALUES (2,GETDATE(),NULL,10003,0)
INSERT INTO HistorialCargo VALUES (2,GETDATE(),NULL,10004,0)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10005,0)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10006,0)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,10007,0)

SELECT * FROM HistorialCargo

/*Inicializador de la tabla Salario*/

INSERT INTO Salario VALUES (145000.34,0)
INSERT INTO Salario VALUES (70000.76,0)
INSERT INTO Salario VALUES (80900.44,0)
INSERT INTO Salario VALUES (90000.34,0)
INSERT INTO Salario VALUES (50897.54,0)
INSERT INTO Salario VALUES (98700.33,0)
INSERT INTO Salario VALUES (140000.4,0)
INSERT INTO Salario VALUES (14678.34,0)

SELECT * FROM Salario

/*Inicializador de la tabla HistorialSalario*/
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,1,10000,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,2,10001,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,3,10002,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,4,10003,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,5,10004,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,6,10005,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,7,10006,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,8,10007,0)

SELECT * FROM HistorialSalario

/*Inicializador de la tabla HistorialEvento*/

INSERT INTO HistorialEvento VALUES (1,GETDATE(),GETDATE(),GETDATE(),10000,0)
INSERT INTO HistorialEvento VALUES (2,GETDATE(),GETDATE(),GETDATE(),10001,0)
INSERT INTO HistorialEvento VALUES (3,GETDATE(),GETDATE(),GETDATE(),10002,0)
INSERT INTO HistorialEvento VALUES (4,GETDATE(),GETDATE(),GETDATE(),10003,0)

SELECT * FROM HistorialEvento


/*Inicializador de la tabla HistorialEstado*/
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10000,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10001,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10002,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10003,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10004,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10005,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10006,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,10007,0)

/*Inicializador TipoFamiliar*/

INSERT INTO TipoFamiliar VALUES ('Hijo del colaborador')
INSERT INTO TipoFamiliar VALUES ('Padre del colaborador')
INSERT INTO TipoFamiliar VALUES ('Pareja del colaborador')

/*Inicializador tipo Movimiento*/
INSERT INTO TipoMovimiento VALUES ('Pago',0)
INSERT INTO TipoMovimiento VALUES ('Prestamo',0)
INSERT INTO TipoMovimiento VALUES ('Creacion cuenta',0)

/*Inicializador Cuentas*/

SELECT * FROM CuentaColaborador


INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)
INSERT INTO CuentaColaborador VALUES (0,0,0)

/*Inicializador movimientos*/

SELECT * FROM MovimientosCuentaColaborador

INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10000,10000000,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10001,10000001,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10002,10000002,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10003,10000003,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10004,10000004,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10005,10000005,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10006,10000006,0,3,0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),10007,10000007,0,3,0)

/*Inicializador tipos de avisos*/
INSERT INTO TipoAviso VALUES ('Aviso a Admins',0)
INSERT INTO TipoAviso VALUES ('Carga de Cumpleaños',0)
INSERT INTO TipoAviso VALUES ('Cumpleaños',0)
INSERT INTO TipoAviso VALUES ('Deuda Cuenta corriente',0)
INSERT INTO TipoAviso VALUES ('Otro',0)

/*Inicializador tipos de avisos*/

INSERT INTO Aviso VALUES (1,'Aviso a administradores', GETDATE(),GETDATE(),GETDATE(),null,0)
INSERT INTO Aviso VALUES (2,'Carga de cumpleaños', GETDATE(),GETDATE(),GETDATE(),null,0)


