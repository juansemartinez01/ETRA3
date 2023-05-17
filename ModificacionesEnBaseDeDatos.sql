CREATE TABLE Sucursal (
    codigoSucursal INT PRIMARY KEY,
    nombre VARCHAR(255),
    direccion INT,
    FOREIGN KEY (direccion) REFERENCES Direccion(id_direccion)
);

USE [ETRA]
GO

/****** Object:  Table [dbo].[Colaborador]    Script Date: 17/5/2023 12:36:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [ETRA]
GO

ALTER TABLE [dbo].[Colaborador]
ADD [codigoSucursal] [int] NULL
GO

ALTER TABLE [dbo].[Colaborador]
ADD CONSTRAINT [FK_Colaborador_Sucursal] FOREIGN KEY ([codigoSucursal])
REFERENCES [dbo].[Sucursal] ([codigoSucursal])
GO



CREATE TABLE AREA (
  idArea INT PRIMARY KEY,
  nombre VARCHAR(255)
);

CREATE TABLE Vestimenta (
  legajoColaborador INT PRIMARY KEY,
  sucursal INT,
  area INT,
  pantalon INT,
  buzo VARCHAR(255),
  remera VARCHAR(255),
  calzado VARCHAR(255),
  FOREIGN KEY (sucursal) REFERENCES Sucursal(codigoSucursal),
  FOREIGN KEY (area) REFERENCES Area(idArea)
);


INSERT INTO Sucursal VALUES (1,'Cordoba',1)

INSERT INTO AREA VALUES (1,'Deposito')
INSERT INTO AREA VALUES (2,'Venta')
INSERT INTO AREA VALUES (3,'Sucursal')

