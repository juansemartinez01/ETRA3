USE [master]
GO
/****** Object:  Database [ETRA]    Script Date: 5/8/2022 09:32:03 ******/
CREATE DATABASE [ETRA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ETRA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ETRA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ETRA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ETRA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Colaborador]    Script Date: 5/8/2022 09:32:03 ******/
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
 CONSTRAINT [PK_Colaborador] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColaboradorMultimedia]    Script Date: 5/8/2022 09:32:03 ******/
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
 CONSTRAINT [PK__Colabora__EADFB8D4ECC56A28] PRIMARY KEY CLUSTERED 
(
	[id_colaboradorMultimedia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dia]    Script Date: 5/8/2022 09:32:03 ******/
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
/****** Object:  Table [dbo].[Direccion]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[id_direccion] [int] IDENTITY(1,1) NOT NULL,
	[nombreCalle] [nchar](50) NOT NULL,
	[numeroCalle] [int] NOT NULL,
	[esEdificio] [int] NOT NULL,
	[piso] [int] NULL,
	[departamento] [nchar](10) NULL,
	[localidad] [nchar](50) NULL,
	[provincia] [nchar](50) NULL,
 CONSTRAINT [PK_Direccion] PRIMARY KEY CLUSTERED 
(
	[id_direccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoColaborador]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoColaborador](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_EstadoColaborador] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
	[id_tipoEvento] [int] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formulario]    Script Date: 5/8/2022 09:32:03 ******/
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
/****** Object:  Table [dbo].[HistorialCargo]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialCargo](
	[id_historialCargo] [int] IDENTITY(1,1) NOT NULL,
	[id_cargo] [int] NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NULL,
 CONSTRAINT [PK_HistorialCargo] PRIMARY KEY CLUSTERED 
(
	[id_historialCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialEstado]    Script Date: 5/8/2022 09:32:03 ******/
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
 CONSTRAINT [PK_HistorialEstado] PRIMARY KEY CLUSTERED 
(
	[id_historialEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialEvento]    Script Date: 5/8/2022 09:32:03 ******/
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
 CONSTRAINT [PK_HistorialEvento] PRIMARY KEY CLUSTERED 
(
	[id_hitorialEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistorialSalario]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialSalario](
	[id_historialSalario] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [datetime] NOT NULL,
	[fechaFin] [datetime] NULL,
	[id_salario] [int] NOT NULL,
	[legajoColaborador] [int] NOT NULL,
 CONSTRAINT [PK_HistorialSalario] PRIMARY KEY CLUSTERED 
(
	[id_historialSalario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorarioDiaTrabajo]    Script Date: 5/8/2022 09:32:03 ******/
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
/****** Object:  Table [dbo].[Perfil]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilXFormulario]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilXFormulario](
	[id_perfil] [int] NOT NULL,
	[id_formulario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salario]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salario](
	[id_salario] [int] IDENTITY(1,1) NOT NULL,
	[monto] [float] NOT NULL,
 CONSTRAINT [PK_Salario] PRIMARY KEY CLUSTERED 
(
	[id_salario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoEvento](
	[id_tipoEvento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[id_tipoEvento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMultimedia]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMultimedia](
	[id_tipoMultimedia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](50) NOT NULL,
 CONSTRAINT [PK_TipoMultimedia] PRIMARY KEY CLUSTERED 
(
	[id_tipoMultimedia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/8/2022 09:32:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[legajoColaborador] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[nombre] [nchar](50) NOT NULL,
	[contraseña] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Colaborador]  WITH CHECK ADD  CONSTRAINT [FK_Colaborador_Direccion] FOREIGN KEY([idDireccion])
REFERENCES [dbo].[Direccion] ([id_direccion])
GO
ALTER TABLE [dbo].[Colaborador] CHECK CONSTRAINT [FK_Colaborador_Direccion]
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
ALTER TABLE [dbo].[HistorialSalario]  WITH CHECK ADD  CONSTRAINT [FK_HistorialSalario_Colaborador] FOREIGN KEY([id_historialSalario])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[HistorialSalario] CHECK CONSTRAINT [FK_HistorialSalario_Colaborador]
GO
ALTER TABLE [dbo].[HistorialSalario]  WITH CHECK ADD  CONSTRAINT [FK_HistorialSalario_Salario] FOREIGN KEY([id_historialSalario])
REFERENCES [dbo].[Salario] ([id_salario])
GO
ALTER TABLE [dbo].[HistorialSalario] CHECK CONSTRAINT [FK_HistorialSalario_Salario]
GO
ALTER TABLE [dbo].[HorarioDiaTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_HorarioDiaTrabajo_Dia] FOREIGN KEY([id_horario])
REFERENCES [dbo].[Dia] ([id_dia])
GO
ALTER TABLE [dbo].[HorarioDiaTrabajo] CHECK CONSTRAINT [FK_HorarioDiaTrabajo_Dia]
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
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Colaborador] FOREIGN KEY([legajoColaborador])
REFERENCES [dbo].[Colaborador] ([legajo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Colaborador]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
USE [master]
GO
ALTER DATABASE [ETRA] SET  READ_WRITE 
GO
