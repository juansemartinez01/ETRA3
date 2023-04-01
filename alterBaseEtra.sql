/****** Object:  Table [dbo].[Escolaridad]    Script Date: 20/3/2023 10:42:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escolaridad](
        [id] [int] IDENTITY(1,1) NOT NULL,
        [nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Escolaridad] PRIMARY KEY CLUSTERED
(
        [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [dni] [int] NOT NULL;
ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [idDireccion] [int] NOT NULL;
ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [escolaridad] [int] NULL
ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [obraSocial] [varchar](50) NULL
ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [trabaja] [int] NULL
ALTER TABLE [dbo].[FamiliarColaborador] 
ADD [aportes] [int] NULL
/*Inicializador TipoFamiliar*/
DELETE FROM TipoFamiliar where 1=1
INSERT INTO TipoFamiliar VALUES ('Padre/Madre')
INSERT INTO TipoFamiliar VALUES ('Hijo/a')
INSERT INTO TipoFamiliar VALUES ('Pareja')
INSERT INTO TipoFamiliar VALUES ('Esposo/a')
INSERT INTO TipoFamiliar VALUES ('Otro')

/*Inicializador Escolaridad*/
INSERT INTO Escolaridad VALUES ('Jardin')
INSERT INTO Escolaridad VALUES ('Primario')
INSERT INTO Escolaridad VALUES ('Secundario')
INSERT INTO Escolaridad VALUES ('Universitario')
INSERT INTO Escolaridad VALUES ('Otro')