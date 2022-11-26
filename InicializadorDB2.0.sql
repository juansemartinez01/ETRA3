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


SELECT * FROM Direccion

/*Inicializador de la tabla Colaborador*/


SELECT * FROM Colaborador

/*Inicializador de la tabla Perfil*/
INSERT into Perfil (nombre,borradoLogico) VALUES ('ADMINISTRADOR',0)
INSERT into Perfil (nombre,borradoLogico) VALUES ('COLABORADOR',0)

SELECT * FROM Perfil





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

SELECT * FROM EstadoColaborador

/*Inicializador de la tabla Evento*/


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



SELECT * FROM HistorialCargo

/*Inicializador de la tabla Salario*/



SELECT * FROM Salario

/*Inicializador de la tabla HistorialSalario*/


SELECT * FROM HistorialSalario

/*Inicializador de la tabla HistorialEvento*/



SELECT * FROM HistorialEvento


/*Inicializador de la tabla HistorialEstado*/


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




/*Inicializador movimientos*/

SELECT * FROM MovimientosCuentaColaborador



/*Inicializador tipos de avisos*/
INSERT INTO TipoAviso VALUES ('Aviso a Admins',0)
INSERT INTO TipoAviso VALUES ('Carga de Cumpleaños',0)
INSERT INTO TipoAviso VALUES ('Cumpleaños',0)
INSERT INTO TipoAviso VALUES ('Deuda Cuenta corriente',0)
INSERT INTO TipoAviso VALUES ('Otro',0)

/*Inicializador tipos de avisos*/

INSERT INTO Aviso VALUES (1,'Aviso a administradores', GETDATE(),GETDATE(),GETDATE(),null,0)
INSERT INTO Aviso VALUES (2,'Carga de cumpleaños', GETDATE(),GETDATE(),GETDATE(),null,0)


/*Inicializador de los colaboradores*/


INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Barrio norte gama',276,0,0)
INSERT INTO Colaborador VALUES ('Agustina Micaela','Troncoso schneider','agustina.troncoso18@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('2000-07-12 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2019-11-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,42730936,27427309369,NULL,3512009616,3516334146,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (203000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Agustina Micaela Troncoso schneider.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (11,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-60900.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Quito',520,0,0)
INSERT INTO Colaborador VALUES ('Emilce Ailen','Schneider','emilceschneider@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('2001-08-02 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2021-04-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,43342269,23433422694,NULL,3435440401,3516334219,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (90000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Emilce Ailen Schneider.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (11,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-27000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Raimundo Meabe ',426,0,0)
INSERT INTO Colaborador VALUES ('Alberto Martin ','Pereyra ','pereyramartin.etra@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1977-12-15 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2020-02-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,26089687,20260896874,NULL,3517010597,3516533077,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (400000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Alberto Martin  Pereyra .',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (6,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-120000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Aldao ',216,0,0)
INSERT INTO Colaborador VALUES ('Diego Sergio ','Sequier ','diegosequier17@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1986-05-22 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2019-10-23 00:00:00' as datetime), 'yyyy - MM - dd'),0,31945846,20319458469,NULL,3512041725,3515590981,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (170000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Diego Sergio  Sequier .',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (6,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-51000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Diaz de Solis',1377,0,0)
INSERT INTO Colaborador VALUES ('Agustin','Perez','agustinperezlog@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1992-08-01 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2020-01-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,36358202,20363582029,NULL,3513818130,3516299178,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (172000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Agustin Perez.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (9,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-51600.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('MZA 3 lote 25 ',25,0,0)
INSERT INTO Colaborador VALUES ('Carla Soledad','Soto','carla_soto21@hotmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1986-12-24 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-05-16 00:00:00' as datetime), 'yyyy - MM - dd'),0,32623631,23326236314,NULL,156362540,157300416,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (107000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Carla Soledad Soto.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-32100.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Los piquillines',167,0,0)
INSERT INTO Colaborador VALUES ('Elias','Simbron','simbroneliasmarcelo@gmaail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('2022-11-22 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-11-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,23684867,2023684867,NULL,3512451874,4701339,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (120000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Elias Simbron.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (5,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-36000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Los Andes ',524,0,0)
INSERT INTO Colaborador VALUES ('Lisandro Esteban ','Ramayo ','lisanros@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1979-12-18 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2021-02-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,27620828,20276208285,NULL,3541600407,3541595875,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (120000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Lisandro Esteban  Ramayo .',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (6,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-36000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Juan b justo ',4174,0,0)
INSERT INTO Colaborador VALUES ('Gustavo Ariel ','Rodríguez Malanczuk ','malanczuk1986@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1986-08-28 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-06-07 00:00:00' as datetime), 'yyyy - MM - dd'),0,32458256,20324582569,NULL,3512620318,3516823089,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (100000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Gustavo Ariel  Rodríguez Malanczuk .',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (7,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-30000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Damaso centeno ',3844,0,0)
INSERT INTO Colaborador VALUES ('Enzo','Rivadeneira','rivadeneirajavier97@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1997-05-02 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2021-07-13 00:00:00' as datetime), 'yyyy - MM - dd'),0,40401447,20404014472,NULL,3512432949,3512555286,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (126000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Enzo Rivadeneira.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-37800.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('José morelos',7455,0,0)
INSERT INTO Colaborador VALUES ('Leandro','Imas','leandro_imas@hotmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1991-10-21 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-08-10 00:00:00' as datetime), 'yyyy - MM - dd'),0,36141632,20361416326,NULL,3543634160,3543634160,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (140000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Leandro Imas.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (6,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-42000.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Leopoldo marechal ',181,0,0)
INSERT INTO Colaborador VALUES ('Nicolas Nahuel','Chavez','nico.chavez181@outlook.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1999-02-12 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2021-03-27 00:00:00' as datetime), 'yyyy - MM - dd'),0,42894359,20428943598,NULL,3516557282,3515183861,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (147000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Nicolas Nahuel Chavez.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-44100.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Tucuman ',2016,0,0)
INSERT INTO Colaborador VALUES ('Facundo Agustin','Ludueña','faculudu1299@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1999-06-11 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2015-02-01 00:00:00' as datetime), 'yyyy - MM - dd'),0,41887586,20418875861,NULL,3571681230,3571557671,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (105000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Facundo Agustin Ludueña.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (8,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31500.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('José Morelos ',7455,0,0)
INSERT INTO Colaborador VALUES ('Julián ','Imas','juli_imass@hotmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1995-03-09 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-11-04 00:00:00' as datetime), 'yyyy - MM - dd'),0,38984275,20389842754,NULL,3513496082,3543634160,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (105000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Julián  Imas.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (4,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31500.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Lagunilla',4363,0,0)
INSERT INTO Colaborador VALUES ('Antonio','Alemany','antonioetra20@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1979-01-16 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2020-06-27 00:00:00' as datetime), 'yyyy - MM - dd'),0,27076784,20270767843,NULL,3516110235,3516742056,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (203000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Antonio Alemany.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (1,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-60900.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Ituzaingo ',750,0,0)
INSERT INTO Colaborador VALUES ('Sergio Gabriel ','Cuggino','Sergiogabrielcuggino@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1998-07-13 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-09-23 00:00:00' as datetime), 'yyyy - MM - dd'),0,41034004,24410340042,NULL,3533417725,3533419742,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (58000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Sergio Gabriel  Cuggino.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (12,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-17400.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Estados Unidos ',4991,0,0)
INSERT INTO Colaborador VALUES ('Leonardo Rogelio ','Moyano','leyo32leyo32@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1985-05-25 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-07-20 00:00:00' as datetime), 'yyyy - MM - dd'),0,31667377,20316673776,NULL,3517623210,3517623209,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (105000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Leonardo Rogelio  Moyano.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (3,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31500.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Pasaje alejo villegas',368,0,0)
INSERT INTO Colaborador VALUES ('Facundo Daniel','Aparicio','apariciofacundo97@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1997-07-04 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-10-12 00:00:00' as datetime), 'yyyy - MM - dd'),0,40520406,20405204062,NULL,3517578996,3515178601,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (105000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Facundo Daniel Aparicio.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (10,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31500.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Teniente Raul Goubat ',5573,0,0)
INSERT INTO Colaborador VALUES ('Maximiliano Ezequiel','Di Lelle','dilellemaxi13@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('2002-10-13 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-11-02 00:00:00' as datetime), 'yyyy - MM - dd'),0,44272713,23442727139,NULL,3515950872,3515950872,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (105000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Maximiliano Ezequiel Di Lelle.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (10,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31500.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Félix Frías',890,0,0)
INSERT INTO Colaborador VALUES ('Joaquín','Previgliano','joacoprevigliano@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1999-07-20 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-07-27 00:00:00' as datetime), 'yyyy - MM - dd'),0,41993391,20419933911,NULL,3518015146,3513843846,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (56000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Joaquín Previgliano.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (12,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-16800.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Jose melian',2927,0,0)
INSERT INTO Colaborador VALUES ('Jordan Xavier','Oviedo','oviedojordan648@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1998-06-14 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2021-07-15 00:00:00' as datetime), 'yyyy - MM - dd'),0,42640146,20426401461,NULL,3515744033,3517336683,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (117000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Jordan Xavier Oviedo.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (10,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-35100.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Lisandro de la torre',1878,0,0)
INSERT INTO Colaborador VALUES ('Hernan Gabriel','Guardia','xgroxox@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1997-05-07 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-03-31 00:00:00' as datetime), 'yyyy - MM - dd'),0,40518537,20405185378,NULL,3515924919,3513450255,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (104000.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Hernan Gabriel Guardia.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (4,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-31200.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
/*
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Angel Gallardo ',2055,0,0)
INSERT INTO Colaborador VALUES ('David Emanuel ','Gonzalez ','daemagonzalez@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('1986-12-05 00:00:00' as datetime), 'yyyy - MM - dd'),Format(Cast('2022-01-17 00:00:00' as datetime), 'yyyy - MM - dd'),0,32624005,20326240053,NULL,3516081648,'No especifica','No especifica',NULL,NULL)
INSERT INTO Salario VALUES (110530.0,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a David Emanuel  Gonzalez .',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (7,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-33159.0)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio, borradoLogico) VALUES ('Alejandra pizarnick',3596,0,0)
INSERT INTO Colaborador VALUES ('Rosa Beatriz','Avila','kukinacab@gmail.com',(SELECT MAX(id_direccion) FROM Direccion),Format(Cast('12/7/0074' as datetime), 'yyyy - MM - dd'),Format(Cast('10/3/0022' as datetime), 'yyyy - MM - dd'),0,24391619,23243916194,NULL,3513540079,35161683377097400,'No especifica',NULL,NULL)
INSERT INTO Salario VALUES (70974.4,0)
INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,(SELECT MAX(id_salario) FROM Salario),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO Evento VALUES ('Bienvenido/a Rosa Beatriz Avila.',1,0)
INSERT INTO HistorialEvento VALUES ((SELECT MAX(id_evento) FROM Evento),GETDATE(),GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO HistorialCargo VALUES (2,GETDATE(),NULL,(SELECT MAX(legajo) FROM Colaborador),0)
INSERT INTO CuentaColaborador VALUES (0,0,-21292.319999999996)
INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),(SELECT MAX(legajo) FROM Colaborador), (SELECT MAX(numeroCuenta) FROM CuentaColaborador),0,3,0)
INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,1,(SELECT MAX(legajo) FROM Colaborador),0)
*/

/*Inicializador de la tabla Usuario*/
INSERT into Usuario (id_perfil,mail,contraseña,legajoColaborador,borradoLogico) VALUES (1,'admin@admin.com','1234',10000,0)

SELECT * FROM Usuario


