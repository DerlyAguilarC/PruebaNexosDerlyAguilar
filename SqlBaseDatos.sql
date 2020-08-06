create database [NexosPruebaTecnica]
USE [NexosPruebaTecnica]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/8/2020 17:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 6/8/2020 17:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](max) NULL,
	[Especialidad] [nvarchar](max) NULL,
	[NumeroCredencial] [nvarchar](max) NULL,
	[HospitalTrabajo] [nvarchar](max) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctoresPacientes]    Script Date: 6/8/2020 17:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctoresPacientes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdDoctor] [bigint] NOT NULL,
	[IdPaciente] [bigint] NOT NULL,
 CONSTRAINT [PK_DoctoresPacientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 6/8/2020 17:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreCompleto] [nvarchar](max) NULL,
	[NumeroSeguroSocial] [nvarchar](max) NULL,
	[CodigoPostal] [nvarchar](max) NULL,
	[TelefonoContacto] [nvarchar](max) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoctoresPacientes]  WITH CHECK ADD  CONSTRAINT [FK_DoctoresPacientes_Doctor_IdDoctor] FOREIGN KEY([IdDoctor])
REFERENCES [dbo].[Doctor] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoctoresPacientes] CHECK CONSTRAINT [FK_DoctoresPacientes_Doctor_IdDoctor]
GO
ALTER TABLE [dbo].[DoctoresPacientes]  WITH CHECK ADD  CONSTRAINT [FK_DoctoresPacientes_Paciente_IdPaciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DoctoresPacientes] CHECK CONSTRAINT [FK_DoctoresPacientes_Paciente_IdPaciente]
GO
