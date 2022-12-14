USE [master]
GO
/****** Object:  Database [ETRA]    Script Date: 26/12/2022 22:18:16 ******/
CREATE DATABASE [ETRA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ETRA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ETRA3\MSSQL\DATA\ETRA.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ETRA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ETRA3\MSSQL\DATA\ETRA_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ETRA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ETRA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ETRA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ETRA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ETRA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ETRA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ETRA] SET ARITHABORT OFF 
GO
ALTER DATABASE [ETRA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ETRA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ETRA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ETRA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ETRA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ETRA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ETRA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ETRA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ETRA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ETRA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ETRA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ETRA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ETRA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ETRA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ETRA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ETRA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ETRA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ETRA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ETRA] SET  MULTI_USER 
GO
ALTER DATABASE [ETRA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ETRA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ETRA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ETRA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ETRA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ETRA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ETRA] SET QUERY_STORE = OFF
GO
USE [ETRA]
GO
/****** Object:  Table [dbo].[Aviso]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aviso](
	[id_aviso] [int] IDENTITY(1,1) NOT NULL,
	[id_tipoAviso] [int] NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[fechaCarga] [date] NOT NULL,
	[fechaOcurrencia] [date] NOT NULL,
	[fechaNotificacion] [date] NOT NULL,
	[fechaUltimaNotificacion] [date] NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Aviso] PRIMARY KEY CLUSTERED 
(
	[id_aviso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AvisoXColaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvisoXColaborador](
	[legajoColaborador] [int] NOT NULL,
	[id_aviso] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colaborador](
	[legajo] [int] IDENTITY(10000,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[mail] [nvarchar](50) NULL,
	[idDireccion] [int] NOT NULL,
	[fechaNacimiento] [date] NULL,
	[fechaIngreso] [datetime] NOT NULL,
	[borradoLogico] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL,
	[sexo] [nvarchar](50) NULL,
	[nroContacto] [nvarchar](50) NULL,
	[nroEmergencia] [nvarchar](50) NULL,
	[obraSocial] [nvarchar](50) NULL,
	[legajoResponsable] [int] NULL,
	[fechaBaja] [date] NULL,
 CONSTRAINT [PK_Colaborador] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColaboradorMultimedia]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColaboradorMultimedia](
	[id_colaboradorMultimedia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[documento] [varbinary](max) NULL,
	[extension] [nvarchar](100) NULL,
	[id_tipoMultimedia] [int] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
	[id_evento] [int] NOT NULL,
 CONSTRAINT [PK__Colabora__EADFB8D4ECC56A28] PRIMARY KEY CLUSTERED 
(
	[id_colaboradorMultimedia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaColaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaColaborador](
	[numeroCuenta] [int] IDENTITY(10000000,1) NOT NULL,
	[saldoAdeudado] [float] NOT NULL,
	[borradoLogico] [int] NOT NULL,
	[SaldoMaximo] [int] NOT NULL,
 CONSTRAINT [PK_CuentaColaborador] PRIMARY KEY CLUSTERED 
(
	[numeroCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dia]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dia](
	[id_dia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Dia] PRIMARY KEY CLUSTERED 
(
	[id_dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[id_direccion] [int] IDENTITY(1,1) NOT NULL,
	[nombreCalle] [nvarchar](50) NOT NULL,
	[numeroCalle] [int] NOT NULL,
	[esEdificio] [int] NOT NULL,
	[piso] [int] NULL,
	[departamento] [nvarchar](50) NULL,
	[localidad] [nvarchar](50) NULL,
	[provincia] [nvarchar](50) NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[id_direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoColaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoColaborador](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_EstadoColaborador] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
	[id_tipoEvento] [int] NULL,
	[borradoLogico] [int] NOT NULL,
	[monto] [float] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliarColaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliarColaborador](
	[idFamiliar] [int] IDENTITY(1,1) NOT NULL,
	[tipoFamiliar] [int] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[nombreFamiliar] [nvarchar](50) NOT NULL,
	[apellidoFamiliar] [nvarchar](50) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_FamiliarColaborador] PRIMARY KEY CLUSTERED 
(
	[idFamiliar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formulario]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formulario](
	[id_Formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_Formulario] PRIMARY KEY CLUSTERED 
(
	[id_Formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialCargo]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialCargo](
	[id_historialCargo] [int] IDENTITY(1,1) NOT NULL,
	[id_cargo] [int] NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_HistorialCargo] PRIMARY KEY CLUSTERED 
(
	[id_historialCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialEstado]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialEstado](
	[id_historialEstado] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaFin] [datetime] NULL,
	[id_estado] [int] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_HistorialEstado] PRIMARY KEY CLUSTERED 
(
	[id_historialEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialEvento]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialEvento](
	[id_hitorialEvento] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaFin] [datetime] NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_HistorialEvento] PRIMARY KEY CLUSTERED 
(
	[id_hitorialEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialSalario]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialSalario](
	[id_historialSalario] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NULL,
	[id_salario] [int] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_HistorialSalario] PRIMARY KEY CLUSTERED 
(
	[id_historialSalario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorarioDiaTrabajo]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorarioDiaTrabajo](
	[id_horario] [int] IDENTITY(1,1) NOT NULL,
	[id_dia] [int] NOT NULL,
	[horaInicio] [time](7) NOT NULL,
	[horaFin] [time](7) NOT NULL,
 CONSTRAINT [PK_HorarioDiaTrabajo] PRIMARY KEY CLUSTERED 
(
	[id_horario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovimientosCuentaColaborador]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientosCuentaColaborador](
	[idHistorialCuenta] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaFin] [datetime] NULL,
	[legajoColaborador] [int] NOT NULL,
	[nroCuenta] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
	[tipoMovimiento] [int] NOT NULL,
	[montoMoviento] [float] NOT NULL,
	[descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_HistorialCuentaColaborador] PRIMARY KEY CLUSTERED 
(
	[idHistorialCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilXFormulario]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilXFormulario](
	[id_perfil] [int] NOT NULL,
	[id_formulario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salario]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salario](
	[id_salario] [int] IDENTITY(1,1) NOT NULL,
	[monto] [float] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Salario] PRIMARY KEY CLUSTERED 
(
	[id_salario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAviso]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAviso](
	[id_tipoAviso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_TipoAviso] PRIMARY KEY CLUSTERED 
(
	[id_tipoAviso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEvento](
	[id_tipoEvento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[id_tipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoFamiliar]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoFamiliar](
	[idTipoFamiliar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoFamiliar] PRIMARY KEY CLUSTERED 
(
	[idTipoFamiliar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMovimiento]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMovimiento](
	[id_tipoMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_TipoMovimiento] PRIMARY KEY CLUSTERED 
(
	[id_tipoMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMultimedia]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMultimedia](
	[id_tipoMultimedia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_TipoMultimedia] PRIMARY KEY CLUSTERED 
(
	[id_tipoMultimedia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 26/12/2022 22:18:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[mail] [nvarchar](50) NOT NULL,
	[contraseña] [nvarchar](50) NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[borradoLogico] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aviso]  WITH CHECK ADD  CONSTRAINT [FK_Aviso_TipoAviso] FOREIGN KEY([id_tipoAviso])
REFERENCES [dbo].[TipoAviso] ([id_tipoAviso])
GO
ALTER TABLE [dbo].[Aviso] CHECK CONSTRAINT [FK_Aviso_TipoAviso]
GO
ALTER TABLE [dbo].[AvisoXColaborador]  WITH CHECK ADD  CONSTRAINT [FK_AvisoXColaborador_Aviso] FOREIGN KEY([id_aviso])
REFERENCES [dbo].[Aviso] ([id_aviso])
GO
ALTER TABLE [dbo].[AvisoXColaborador] CHECK CONSTRAINT [FK_AvisoXColaborador_Aviso]
GO
ALTER TABLE [dbo].[AvisoXColaborador]  WITH CHECK ADD  CONSTRAINT [FK_AvisoXColaborador_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[AvisoXColaborador] CHECK CONSTRAINT [FK_AvisoXColaborador_Colaborador]
GO
ALTER TABLE [dbo].[Colaborador]  WITH CHECK ADD  CONSTRAINT [FK_Colaborador_Colaborador] FOREIGN KEY([legajoResponsable])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[Colaborador] CHECK CONSTRAINT [FK_Colaborador_Colaborador]
GO
ALTER TABLE [dbo].[ColaboradorMultimedia]  WITH CHECK ADD  CONSTRAINT [FK_ColaboradorMultimedia_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[ColaboradorMultimedia] CHECK CONSTRAINT [FK_ColaboradorMultimedia_Colaborador]
GO
ALTER TABLE [dbo].[ColaboradorMultimedia]  WITH CHECK ADD  CONSTRAINT [FK_ColaboradorMultimedia_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[ColaboradorMultimedia] CHECK CONSTRAINT [FK_ColaboradorMultimedia_Evento]
GO
ALTER TABLE [dbo].[ColaboradorMultimedia]  WITH CHECK ADD  CONSTRAINT [FK_ColaboradorMultimedia_TipoMultimedia] FOREIGN KEY([id_tipoMultimedia])
REFERENCES [dbo].[TipoMultimedia] ([id_tipoMultimedia])
GO
ALTER TABLE [dbo].[ColaboradorMultimedia] CHECK CONSTRAINT [FK_ColaboradorMultimedia_TipoMultimedia]
GO
ALTER TABLE [dbo].[FamiliarColaborador]  WITH CHECK ADD  CONSTRAINT [FK_FamiliarColaborador_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[FamiliarColaborador] CHECK CONSTRAINT [FK_FamiliarColaborador_Colaborador]
GO
ALTER TABLE [dbo].[FamiliarColaborador]  WITH CHECK ADD  CONSTRAINT [FK_FamiliarColaborador_TipoFamiliar] FOREIGN KEY([tipoFamiliar])
REFERENCES [dbo].[TipoFamiliar] ([idTipoFamiliar])
GO
ALTER TABLE [dbo].[FamiliarColaborador] CHECK CONSTRAINT [FK_FamiliarColaborador_TipoFamiliar]
GO
ALTER TABLE [dbo].[HistorialCargo]  WITH CHECK ADD  CONSTRAINT [FK_HistorialCargo_Cargo] FOREIGN KEY([id_cargo])
REFERENCES [dbo].[Cargo] ([id_cargo])
GO
ALTER TABLE [dbo].[HistorialCargo] CHECK CONSTRAINT [FK_HistorialCargo_Cargo]
GO
ALTER TABLE [dbo].[HistorialCargo]  WITH CHECK ADD  CONSTRAINT [FK_HistorialCargo_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[HistorialCargo] CHECK CONSTRAINT [FK_HistorialCargo_Colaborador]
GO
ALTER TABLE [dbo].[HistorialEstado]  WITH CHECK ADD  CONSTRAINT [FK_HistorialEstado_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[HistorialEstado] CHECK CONSTRAINT [FK_HistorialEstado_Colaborador]
GO
ALTER TABLE [dbo].[HistorialEstado]  WITH CHECK ADD  CONSTRAINT [FK_HistorialEstado_EstadoColaborador] FOREIGN KEY([id_estado])
REFERENCES [dbo].[EstadoColaborador] ([id_estado])
GO
ALTER TABLE [dbo].[HistorialEstado] CHECK CONSTRAINT [FK_HistorialEstado_EstadoColaborador]
GO
ALTER TABLE [dbo].[HistorialEvento]  WITH CHECK ADD  CONSTRAINT [FK_HistorialEvento_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[HistorialEvento] CHECK CONSTRAINT [FK_HistorialEvento_Colaborador]
GO
ALTER TABLE [dbo].[HistorialEvento]  WITH CHECK ADD  CONSTRAINT [FK_HistorialEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[HistorialEvento] CHECK CONSTRAINT [FK_HistorialEvento_Evento]
GO
ALTER TABLE [dbo].[HistorialSalario]  WITH CHECK ADD  CONSTRAINT [FK_HistorialSalario_Colaborador1] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[HistorialSalario] CHECK CONSTRAINT [FK_HistorialSalario_Colaborador1]
GO
ALTER TABLE [dbo].[HistorialSalario]  WITH CHECK ADD  CONSTRAINT [FK_HistorialSalario_Salario1] FOREIGN KEY([id_salario])
REFERENCES [dbo].[Salario] ([id_salario])
GO
ALTER TABLE [dbo].[HistorialSalario] CHECK CONSTRAINT [FK_HistorialSalario_Salario1]
GO
ALTER TABLE [dbo].[HorarioDiaTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_HorarioDiaTrabajo_Dia] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Dia] ([id_dia])
GO
ALTER TABLE [dbo].[HorarioDiaTrabajo] CHECK CONSTRAINT [FK_HorarioDiaTrabajo_Dia]
GO
ALTER TABLE [dbo].[MovimientosCuentaColaborador]  WITH CHECK ADD  CONSTRAINT [FK_HistorialCuentaColaborador_TipoMovimiento] FOREIGN KEY([tipoMovimiento])
REFERENCES [dbo].[TipoMovimiento] ([id_tipoMovimiento])
GO
ALTER TABLE [dbo].[MovimientosCuentaColaborador] CHECK CONSTRAINT [FK_HistorialCuentaColaborador_TipoMovimiento]
GO
ALTER TABLE [dbo].[PerfilXFormulario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilXFormulario_Formulario] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formulario] ([id_Formulario])
GO
ALTER TABLE [dbo].[PerfilXFormulario] CHECK CONSTRAINT [FK_PerfilXFormulario_Formulario]
GO
ALTER TABLE [dbo].[PerfilXFormulario]  WITH CHECK ADD  CONSTRAINT [FK_PerfilXFormulario_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[PerfilXFormulario] CHECK CONSTRAINT [FK_PerfilXFormulario_Perfil]
GO
ALTER TABLE [dbo].[TipoAviso]  WITH CHECK ADD  CONSTRAINT [FK_TipoAviso_TipoAviso] FOREIGN KEY([id_tipoAviso])
REFERENCES [dbo].[TipoAviso] ([id_tipoAviso])
GO
ALTER TABLE [dbo].[TipoAviso] CHECK CONSTRAINT [FK_TipoAviso_TipoAviso]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
USE [master]
GO
ALTER DATABASE [ETRA] SET  READ_WRITE 
GO
