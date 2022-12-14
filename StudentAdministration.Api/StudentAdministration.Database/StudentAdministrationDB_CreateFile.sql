USE [master]
GO
/****** Object:  Database [StudentAdministrationDB]    Script Date: 8/18/2022 9:00:05 AM ******/
CREATE DATABASE [StudentAdministrationDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentAdministrationDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StudentAdministrationDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StudentAdministrationDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\StudentAdministrationDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentAdministrationDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentAdministrationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentAdministrationDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentAdministrationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentAdministrationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StudentAdministrationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentAdministrationDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StudentAdministrationDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET RECOVERY FULL 
GO
ALTER DATABASE [StudentAdministrationDB] SET  MULTI_USER 
GO
ALTER DATABASE [StudentAdministrationDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentAdministrationDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentAdministrationDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentAdministrationDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentAdministrationDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentAdministrationDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StudentAdministrationDB', N'ON'
GO
ALTER DATABASE [StudentAdministrationDB] SET QUERY_STORE = OFF
GO
USE [StudentAdministrationDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/18/2022 9:00:06 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 8/18/2022 9:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[PersonalNumber] [nvarchar](11) NOT NULL,
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentStudieEnrolls]    Script Date: 8/18/2022 9:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentStudieEnrolls](
	[Id] [uniqueidentifier] NOT NULL,
	[ProgramId] [uniqueidentifier] NOT NULL,
	[EnrollYear] [int] NOT NULL,
	[StudentId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_StudentStudieEnrolls] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudiesPrograms]    Script Date: 8/18/2022 9:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudiesPrograms](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL,
 CONSTRAINT [PK_StudiesPrograms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudiesSubject]    Script Date: 8/18/2022 9:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudiesSubject](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL,
	[StudiesProgramId] [uniqueidentifier] NULL,
	[StudiesSubSubjectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_StudiesSubject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudiesSubSubject]    Script Date: 8/18/2022 9:00:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudiesSubSubject](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Credits] [int] NOT NULL,
	[StudiesProgramId] [uniqueidentifier] NULL,
	[StudiesSubSubjectId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_StudiesSubSubject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816102015_testDB', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816103004_testDB2', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220816103144_testDB3', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220818055226_UpdateDB', N'6.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220818055336_UpdateDB2', N'6.0.8')
GO
INSERT [dbo].[Student] ([PersonalNumber], [Id], [Name], [LastName]) VALUES (N'12345678911', N'75fe6a75-8682-44ea-819c-013a0713b6a8', N'Test', N'Testing')
INSERT [dbo].[Student] ([PersonalNumber], [Id], [Name], [LastName]) VALUES (N'12345678910', N'3bd69ac7-6e6d-40ed-bd9c-df2222cc83c2', N'Audrius', N'Bukis')
GO
INSERT [dbo].[StudentStudieEnrolls] ([Id], [ProgramId], [EnrollYear], [StudentId]) VALUES (N'6c6a63fc-4c63-4d58-944e-525a8e1f8f7b', N'43637e0e-3e86-4537-888f-5f482247b18b', 2022, N'3bd69ac7-6e6d-40ed-bd9c-df2222cc83c2')
INSERT [dbo].[StudentStudieEnrolls] ([Id], [ProgramId], [EnrollYear], [StudentId]) VALUES (N'580d314d-53ad-4f7f-8dcf-69702cbd8537', N'de06dbce-2052-4784-adf4-e2f613cd7aa8', 2021, N'3bd69ac7-6e6d-40ed-bd9c-df2222cc83c2')
INSERT [dbo].[StudentStudieEnrolls] ([Id], [ProgramId], [EnrollYear], [StudentId]) VALUES (N'1d7efccf-b42d-429a-8470-dcea14fd61ff', N'43637e0e-3e86-4537-888f-5f482247b18b', 2022, N'75fe6a75-8682-44ea-819c-013a0713b6a8')
GO
INSERT [dbo].[StudiesPrograms] ([Id], [Name], [Credits]) VALUES (N'43637e0e-3e86-4537-888f-5f482247b18b', N'.NET - .NET Core', 40)
INSERT [dbo].[StudiesPrograms] ([Id], [Name], [Credits]) VALUES (N'de06dbce-2052-4784-adf4-e2f613cd7aa8', N'SD - Software development', 20)
GO
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'dc69f5c9-9a54-4e46-aa72-011152171a93', N'C# advance level 1', 5, NULL, N'ce03ec66-98c4-448a-8831-8380eb21eeee')
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'232e9be4-aa41-4901-8537-24e47e4fd8b9', N'IDS-Introduction to DataStruct', 5, N'de06dbce-2052-4784-adf4-e2f613cd7aa8', NULL)
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'e17cf4a7-7cd0-49ee-8c83-32a441a71306', N'PIC-Programming in C#', 5, NULL, N'77dffe8e-6ec0-4328-a353-5a040682c8ac')
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'86fe64b4-37cb-48db-9471-5330b9d06fd3', N'IP-Introduction to programming', 5, N'de06dbce-2052-4784-adf4-e2f613cd7aa8', NULL)
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'd76832f4-5cd0-43c0-956d-621c489a6b6d', N'PIJ-Programming in JAVA', 5, NULL, N'77dffe8e-6ec0-4328-a353-5a040682c8ac')
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'f9550f14-6151-4d64-ba3a-686d1e637b07', N'C# advance level 2', 5, NULL, N'ce03ec66-98c4-448a-8831-8380eb21eeee')
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'0883cf8a-09a7-46b5-896f-699e60bd1fa4', N'C# Basic level 2', 5, N'43637e0e-3e86-4537-888f-5f482247b18b', NULL)
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'91727f88-5b1c-40e1-80e2-7d279eb357e7', N'.Net programming level 1', 5, NULL, N'b817318e-b950-48be-aee0-68d0ade4f2d6')
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'8613730f-6534-4a2f-aa75-9a05d4f3fd21', N'C# basic level1', 5, N'43637e0e-3e86-4537-888f-5f482247b18b', NULL)
INSERT [dbo].[StudiesSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'f0d8e4f9-0594-4ab7-8170-a3c86c4a57e6', N'.Net programming level 2', 5, NULL, N'b817318e-b950-48be-aee0-68d0ade4f2d6')
GO
INSERT [dbo].[StudiesSubSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'77dffe8e-6ec0-4328-a353-5a040682c8ac', N'OPP-Object Orientated Prog', 10, N'de06dbce-2052-4784-adf4-e2f613cd7aa8', NULL)
INSERT [dbo].[StudiesSubSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'b817318e-b950-48be-aee0-68d0ade4f2d6', N'.Net programming', 10, NULL, N'ce03ec66-98c4-448a-8831-8380eb21eeee')
INSERT [dbo].[StudiesSubSubject] ([Id], [Name], [Credits], [StudiesProgramId], [StudiesSubSubjectId]) VALUES (N'ce03ec66-98c4-448a-8831-8380eb21eeee', N'C# Advance', 20, N'43637e0e-3e86-4537-888f-5f482247b18b', NULL)
GO
/****** Object:  Index [IX_StudentStudieEnrolls_ProgramId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudentStudieEnrolls_ProgramId] ON [dbo].[StudentStudieEnrolls]
(
	[ProgramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudentStudieEnrolls_StudentId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudentStudieEnrolls_StudentId] ON [dbo].[StudentStudieEnrolls]
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudiesSubject_StudiesProgramId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudiesSubject_StudiesProgramId] ON [dbo].[StudiesSubject]
(
	[StudiesProgramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudiesSubject_StudiesSubSubjectId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudiesSubject_StudiesSubSubjectId] ON [dbo].[StudiesSubject]
(
	[StudiesSubSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudiesSubSubject_StudiesProgramId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudiesSubSubject_StudiesProgramId] ON [dbo].[StudiesSubSubject]
(
	[StudiesProgramId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_StudiesSubSubject_StudiesSubSubjectId]    Script Date: 8/18/2022 9:00:06 AM ******/
CREATE NONCLUSTERED INDEX [IX_StudiesSubSubject_StudiesSubSubjectId] ON [dbo].[StudiesSubSubject]
(
	[StudiesSubSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Student] ADD  DEFAULT (N'') FOR [PersonalNumber]
GO
ALTER TABLE [dbo].[StudentStudieEnrolls] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [StudentId]
GO
ALTER TABLE [dbo].[StudentStudieEnrolls]  WITH CHECK ADD  CONSTRAINT [FK_StudentStudieEnrolls_Student_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentStudieEnrolls] CHECK CONSTRAINT [FK_StudentStudieEnrolls_Student_StudentId]
GO
ALTER TABLE [dbo].[StudentStudieEnrolls]  WITH CHECK ADD  CONSTRAINT [FK_StudentStudieEnrolls_StudiesPrograms_ProgramId] FOREIGN KEY([ProgramId])
REFERENCES [dbo].[StudiesPrograms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentStudieEnrolls] CHECK CONSTRAINT [FK_StudentStudieEnrolls_StudiesPrograms_ProgramId]
GO
ALTER TABLE [dbo].[StudiesSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudiesSubject_StudiesPrograms_StudiesProgramId] FOREIGN KEY([StudiesProgramId])
REFERENCES [dbo].[StudiesPrograms] ([Id])
GO
ALTER TABLE [dbo].[StudiesSubject] CHECK CONSTRAINT [FK_StudiesSubject_StudiesPrograms_StudiesProgramId]
GO
ALTER TABLE [dbo].[StudiesSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudiesSubject_StudiesSubSubject_StudiesSubSubjectId] FOREIGN KEY([StudiesSubSubjectId])
REFERENCES [dbo].[StudiesSubSubject] ([Id])
GO
ALTER TABLE [dbo].[StudiesSubject] CHECK CONSTRAINT [FK_StudiesSubject_StudiesSubSubject_StudiesSubSubjectId]
GO
ALTER TABLE [dbo].[StudiesSubSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudiesSubSubject_StudiesPrograms_StudiesProgramId] FOREIGN KEY([StudiesProgramId])
REFERENCES [dbo].[StudiesPrograms] ([Id])
GO
ALTER TABLE [dbo].[StudiesSubSubject] CHECK CONSTRAINT [FK_StudiesSubSubject_StudiesPrograms_StudiesProgramId]
GO
ALTER TABLE [dbo].[StudiesSubSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudiesSubSubject_StudiesSubSubject_StudiesSubSubjectId] FOREIGN KEY([StudiesSubSubjectId])
REFERENCES [dbo].[StudiesSubSubject] ([Id])
GO
ALTER TABLE [dbo].[StudiesSubSubject] CHECK CONSTRAINT [FK_StudiesSubSubject_StudiesSubSubject_StudiesSubSubjectId]
GO
USE [master]
GO
ALTER DATABASE [StudentAdministrationDB] SET  READ_WRITE 
GO
