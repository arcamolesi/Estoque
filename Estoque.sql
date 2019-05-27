USE [master]
GO
/****** Object:  Database [ESTOQUE2019]    Script Date: 27/05/2019 15:56:52 ******/
CREATE DATABASE [ESTOQUE2019]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ESTOQUE2019', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ESTOQUE2019.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ESTOQUE2019_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ESTOQUE2019_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ESTOQUE2019] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ESTOQUE2019].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ESTOQUE2019] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET ARITHABORT OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ESTOQUE2019] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ESTOQUE2019] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ESTOQUE2019] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ESTOQUE2019] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ESTOQUE2019] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ESTOQUE2019] SET  MULTI_USER 
GO
ALTER DATABASE [ESTOQUE2019] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ESTOQUE2019] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ESTOQUE2019] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ESTOQUE2019] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ESTOQUE2019] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ESTOQUE2019] SET QUERY_STORE = OFF
GO
USE [ESTOQUE2019]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ESTOQUE2019]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 27/05/2019 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](35) NULL,
	[aniversario] [datetime] NULL,
	[telefone] [varchar](35) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemVenda]    Script Date: 27/05/2019 15:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[venda] [int] NULL,
	[produto] [int] NULL,
	[quantidade] [float] NULL,
	[valor] [float] NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 27/05/2019 15:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](35) NULL,
	[quantidade] [float] NULL,
	[valor] [float] NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 27/05/2019 15:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NULL,
	[cliente] [int] NULL,
 CONSTRAINT [PK_Vendas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id], [nome], [aniversario], [telefone]) VALUES (2, N'Alisson', CAST(N'1988-06-23T00:00:00.000' AS DateTime), N'4453-3332')
INSERT [dbo].[Clientes] ([id], [nome], [aniversario], [telefone]) VALUES (3, N'Anelise', CAST(N'1990-08-15T00:00:00.000' AS DateTime), N'3434-4444')
INSERT [dbo].[Clientes] ([id], [nome], [aniversario], [telefone]) VALUES (4, N'Begosso', CAST(N'1970-04-12T00:00:00.000' AS DateTime), N'3341-7070')
INSERT [dbo].[Clientes] ([id], [nome], [aniversario], [telefone]) VALUES (5, N'Alex', CAST(N'1971-11-10T00:00:00.000' AS DateTime), N'2343-2343')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[ItemVenda] ON 

INSERT [dbo].[ItemVenda] ([id], [venda], [produto], [quantidade], [valor]) VALUES (2, 1, 2, 10, 2)
INSERT [dbo].[ItemVenda] ([id], [venda], [produto], [quantidade], [valor]) VALUES (3, 1, 3, 15, 3)
INSERT [dbo].[ItemVenda] ([id], [venda], [produto], [quantidade], [valor]) VALUES (4, 2, 5, 12, 2)
INSERT [dbo].[ItemVenda] ([id], [venda], [produto], [quantidade], [valor]) VALUES (5, 2, 6, 23, 5)
SET IDENTITY_INSERT [dbo].[ItemVenda] OFF
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (2, N'Arroz', 10, 15)
INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (3, N'Goiabasdfadswerwer', 12, 7.8000001907348633)
INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (5, N'Batana', 120, 2.559999942779541)
INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (6, N'Kiwi', 14, 9.5)
INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (7, N'Cerveja', 100, 6.5)
INSERT [dbo].[Produtos] ([id], [descricao], [quantidade], [valor]) VALUES (9, N'Morango', 34, 8.4499998092651367)
SET IDENTITY_INSERT [dbo].[Produtos] OFF
SET IDENTITY_INSERT [dbo].[Vendas] ON 

INSERT [dbo].[Vendas] ([id], [data], [cliente]) VALUES (1, CAST(N'2019-05-25T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Vendas] ([id], [data], [cliente]) VALUES (2, CAST(N'2019-05-25T00:00:00.000' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Vendas] OFF
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Produtos] FOREIGN KEY([produto])
REFERENCES [dbo].[Produtos] ([id])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Produtos]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Vendas] FOREIGN KEY([venda])
REFERENCES [dbo].[Vendas] ([id])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Vendas]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([cliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Clientes]
GO
USE [master]
GO
ALTER DATABASE [ESTOQUE2019] SET  READ_WRITE 
GO
