USE [master]
GO
/****** Object:  Database [desk_rna]    Script Date: 8.01.2018 12:11:29 ******/
CREATE DATABASE [desk_rna]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'desk_rna', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\desk_rna.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'desk_rna_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\desk_rna_log.ldf' , SIZE = 5184KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [desk_rna] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [desk_rna].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [desk_rna] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [desk_rna] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [desk_rna] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [desk_rna] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [desk_rna] SET ARITHABORT OFF 
GO
ALTER DATABASE [desk_rna] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [desk_rna] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [desk_rna] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [desk_rna] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [desk_rna] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [desk_rna] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [desk_rna] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [desk_rna] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [desk_rna] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [desk_rna] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [desk_rna] SET  DISABLE_BROKER 
GO
ALTER DATABASE [desk_rna] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [desk_rna] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [desk_rna] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [desk_rna] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [desk_rna] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [desk_rna] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [desk_rna] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [desk_rna] SET RECOVERY FULL 
GO
ALTER DATABASE [desk_rna] SET  MULTI_USER 
GO
ALTER DATABASE [desk_rna] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [desk_rna] SET DB_CHAINING OFF 
GO
ALTER DATABASE [desk_rna] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [desk_rna] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'desk_rna', N'ON'
GO
USE [desk_rna]
GO
/****** Object:  Table [dbo].[Banks]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[bank_name] [int] NULL,
	[auth_name] [nvarchar](max) NULL,
	[iban_number] [nvarchar](max) NULL,
	[pos] [int] NULL,
 CONSTRAINT [PK_Banks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Brands]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[name] [nvarchar](max) NULL,
	[sef] [nvarchar](max) NULL,
	[text] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[categories]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[name] [nvarchar](max) NULL,
	[sef] [nvarchar](max) NULL,
	[text] [nvarchar](max) NULL,
	[plu] [int] NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Companies]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[tax_number] [nvarchar](max) NULL,
	[tax_office] [nvarchar](max) NULL,
	[phone] [int] NULL,
	[adress] [nvarchar](max) NULL,
	[auth_name] [nvarchar](max) NULL,
	[auth_phone] [int] NULL,
	[tax_rate] [int] NULL,
	[tax_rate_is_inc] [int] NULL,
	[sale_print] [int] NULL,
	[barcode_paper_width] [nvarchar](50) NULL,
	[barcode_paper_height] [nvarchar](50) NULL,
	[sales_screen] [int] NULL,
	[reg_date] [date] NULL,
	[licence_end_date] [date] NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Current_Details]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Current_Details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[current_id] [int] NULL,
	[type] [int] NULL,
	[text] [nvarchar](max) NULL,
	[reg_date] [nvarchar](max) NULL,
	[expiry_date] [nvarchar](max) NULL,
	[price] [decimal](19, 2) NULL,
 CONSTRAINT [PK_Current_Details] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Currenties]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currenties](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [nvarchar](max) NULL,
	[email] [nvarchar](50) NULL,
	[adress] [nvarchar](max) NULL,
	[tax_office] [nvarchar](50) NULL,
	[tax_number] [nvarchar](50) NULL,
	[current_type] [int] NULL,
	[point_card_number] [int] NULL,
	[auth_name] [nvarchar](50) NULL,
	[auth_gsm] [nvarchar](50) NULL,
	[risk_limit] [decimal](19, 2) NULL,
	[sms_notification] [int] NULL,
	[bakiye] [decimal](19, 2) NULL,
	[reg_date] [date] NULL,
 CONSTRAINT [PK_Currenties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Features]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Features](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Features] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[name] [nvarchar](max) NULL,
	[sef] [nvarchar](max) NULL,
	[stock_code] [nvarchar](max) NULL,
	[shelf_number] [nvarchar](max) NULL,
	[current] [int] NULL,
	[text] [nvarchar](max) NULL,
	[stock] [decimal](10, 4) NULL,
	[brand_id] [int] NULL,
	[category_id] [int] NULL,
	[risk_limit] [decimal](10, 4) NULL,
	[barcode_number] [nvarchar](max) NULL,
	[purchase_price] [decimal](19, 4) NULL,
	[sale_price] [decimal](19, 4) NULL,
	[third_price] [decimal](19, 4) NULL,
	[features] [nvarchar](max) NULL,
	[product_İmage] [image] NULL,
	[unit] [int] NULL,
	[registertime] [date] NULL,
	[updatetime] [date] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[auth_name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[salt] [nvarchar](50) NULL,
	[password] [int] NULL,
	[token] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[adress] [nvarchar](50) NULL,
	[status] [int] NULL,
	[is_admin] [int] NULL,
	[store_admin] [int] NULL,
	[notification] [int] NULL,
	[confirmation] [int] NULL,
	[rank] [int] NULL,
	[licence_start_date] [date] NULL,
	[licence_end_date] [date] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 8.01.2018 12:11:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NULL,
	[name] [nvarchar](max) NULL,
	[auth_name] [nvarchar](max) NULL,
	[auth_phone] [nvarchar](max) NULL,
	[adress] [nvarchar](max) NULL,
	[reg_date] [date] NULL,
 CONSTRAINT [PK_warehouses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [desk_rna] SET  READ_WRITE 
GO
