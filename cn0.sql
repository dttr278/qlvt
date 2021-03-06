USE [master]
GO
/****** Object:  Database [QLVT_DATHANG]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE DATABASE [QLVT_DATHANG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLVT_DATHANG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLVT_DATHANG.mdf' , SIZE = 30912KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLVT_DATHANG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLVT_DATHANG_log.ldf' , SIZE = 43968KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLVT_DATHANG] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLVT_DATHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLVT_DATHANG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLVT_DATHANG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLVT_DATHANG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLVT_DATHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [QLVT_DATHANG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLVT_DATHANG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET RECOVERY FULL 
GO
ALTER DATABASE [QLVT_DATHANG] SET  MULTI_USER 
GO
ALTER DATABASE [QLVT_DATHANG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLVT_DATHANG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLVT_DATHANG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLVT_DATHANG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLVT_DATHANG] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLVT_DATHANG', N'ON'
GO
USE [QLVT_DATHANG]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_1172220E26264934B5EFB409823B7DD4]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE ROLE [MSmerge_1172220E26264934B5EFB409823B7DD4]
GO
/****** Object:  DatabaseRole [MSmerge_0E44F96BDD6141E3BD20315C6555047E]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE ROLE [MSmerge_0E44F96BDD6141E3BD20315C6555047E]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_1172220E26264934B5EFB409823B7DD4]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_0E44F96BDD6141E3BD20315C6555047E]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE SCHEMA [MSmerge_PAL_role]
GO
/****** Object:  Table [dbo].[ChiNhanh]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiNhanh](
	[MACN] [nchar](10) NOT NULL,
	[ChiNhanh] [nvarchar](100) NOT NULL,
	[DIACHI] [nvarchar](100) NOT NULL,
	[SoDT] [nvarchar](15) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_1E03AC7E99FF45718ED0CF0908B94802]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_ChiNhanh] PRIMARY KEY CLUSTERED 
(
	[MACN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_ChiNhanh] UNIQUE NONCLUSTERED 
(
	[ChiNhanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTDDH]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDDH](
	[MasoDDH] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2D31302F100A4438A44A73C239D21582]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTDDH] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MAPN] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A629BE7A700B42E0A00BE0139C6CBBCC]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPX]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPX](
	[MAPX] [nchar](8) NOT NULL,
	[MAVT] [nchar](4) NOT NULL,
	[SOLUONG] [int] NOT NULL,
	[DONGIA] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2A773ABCEAB149D6B31DDB8B5AD3B210]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CTPX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC,
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MasoDDH] [nchar](8) NOT NULL CONSTRAINT [DF_DatHang_MasoDDH]  DEFAULT (getdate()),
	[NGAY] [date] NOT NULL CONSTRAINT [DF_DatHang_NGAY]  DEFAULT (getdate()),
	[NhaCC] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_85CDBA8D1AD44067921F50D4E007329C]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MAKHO] [nchar](4) NOT NULL,
	[TENKHO] [nvarchar](30) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[MACN] [nchar](10) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_7DEB7A18C4A643CD9441A77C2FADD0AB]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MAKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENKHO] UNIQUE NONCLUSTERED 
(
	[TENKHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [int] NOT NULL,
	[HO] [nvarchar](40) NULL,
	[TEN] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [datetime] NULL,
	[LUONG] [float] NULL,
	[MACN] [nchar](10) NULL,
	[TrangThaiXoa] [int] NULL CONSTRAINT [DF_NhanVien_TrangThaiXoa]  DEFAULT ((0)),
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E114EAAAF6DB4094A51C85B2B77F31BC]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MAPN] [nchar](8) NOT NULL CONSTRAINT [DF_PhieuNhap_MAPN]  DEFAULT (getdate()),
	[NGAY] [date] NOT NULL CONSTRAINT [DF_PhieuNhap_NGAY]  DEFAULT (getdate()),
	[MasoDDH] [nchar](8) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_AD2767CE6298409298FCC12C467D6446]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_MaSoDDH] UNIQUE NONCLUSTERED 
(
	[MasoDDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MAPX] [nchar](8) NOT NULL,
	[NGAY] [date] NOT NULL CONSTRAINT [DF_PX_NGAY]  DEFAULT (getdate()),
	[HOTENKH] [nvarchar](100) NOT NULL,
	[MANV] [int] NOT NULL,
	[MAKHO] [nchar](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2D64F99F97414871AB9C2845D3EEECD4]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_PX] PRIMARY KEY CLUSTERED 
(
	[MAPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vattu]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vattu](
	[MAVT] [nchar](4) NOT NULL,
	[TENVT] [nvarchar](30) NOT NULL,
	[DVT] [nvarchar](15) NOT NULL,
	[SOLUONGTON] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F041AD9D84114CE79EBF3810BC50FFEC]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MAVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_TENVT] UNIQUE NONCLUSTERED 
(
	[TENVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[V_CN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CN]
AS
SELECT        sub.subscriber_server, pub.description
FROM            dbo.sysmergepublications AS pub INNER JOIN
                         dbo.sysmergesubscriptions AS sub ON pub.pubid = sub.pubid AND pub.publisher <> sub.subscriber_server

GO
/****** Object:  View [dbo].[V_INFO_CN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_INFO_CN]
AS
SELECT        dbo.ChiNhanh.*
FROM            dbo.ChiNhanh

GO
/****** Object:  View [dbo].[V_NV]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_NV]
AS
SELECT        MANV, HO + ' ' + TEN AS HOTEN, DIACHI, NGAYSINH, LUONG, MACN
FROM            dbo.NhanVien
WHERE        (TrangThaiXoa = 0)

GO
/****** Object:  Index [MSmerge_index_245575913]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_245575913] ON [dbo].[ChiNhanh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_485576768]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_485576768] ON [dbo].[CTDDH]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_597577167]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_597577167] ON [dbo].[CTPN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_565577053]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_565577053] ON [dbo].[CTPX]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_421576540]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_421576540] ON [dbo].[DatHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_373576369]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_373576369] ON [dbo].[Kho]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_341576255]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_341576255] ON [dbo].[NhanVien]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_517576882]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_517576882] ON [dbo].[PhieuNhap]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_453576654]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_453576654] ON [dbo].[PhieuXuat]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_293576084]    Script Date: 12/22/2018 1:41:09 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_293576084] ON [dbo].[Vattu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_DatHang]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [FK_CTDDH_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [FK_CTDDH_VatTu]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_PhieuNhap] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PhieuNhap] ([MAPN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_PhieuNhap]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPN_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CTPN_VatTu]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_PX] FOREIGN KEY([MAPX])
REFERENCES [dbo].[PhieuXuat] ([MAPX])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_PX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [FK_CTPX_VatTu] FOREIGN KEY([MAVT])
REFERENCES [dbo].[Vattu] ([MAVT])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [FK_CTPX_VatTu]
GO
ALTER TABLE [dbo].[DatHang]  WITH NOCHECK ADD  CONSTRAINT [FK_DatHang_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH NOCHECK ADD  CONSTRAINT [FK_Kho_Kho] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Kho]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChiNhanh] FOREIGN KEY([MACN])
REFERENCES [dbo].[ChiNhanh] ([MACN])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChiNhanh]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_DatHang] FOREIGN KEY([MasoDDH])
REFERENCES [dbo].[DatHang] ([MasoDDH])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DatHang]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH NOCHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH NOCHECK ADD  CONSTRAINT [FK_PX_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
ON UPDATE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PX_NhanVien]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIA] CHECK NOT FOR REPLICATION (([DONGIA]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_DONGIA]
GO
ALTER TABLE [dbo].[CTDDH]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONG] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTDDH] CHECK CONSTRAINT [CK_SOLUONG]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPN] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_DONGIACTPN]
GO
ALTER TABLE [dbo].[CTPN]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPN] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [CK_SOLUONGCTPN]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_DONGIACTPX] CHECK NOT FOR REPLICATION (([DONGIA]>=(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_DONGIACTPX]
GO
ALTER TABLE [dbo].[CTPX]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGCTPX] CHECK NOT FOR REPLICATION (([SOLUONG]>(0)))
GO
ALTER TABLE [dbo].[CTPX] CHECK CONSTRAINT [CK_SOLUONGCTPX]
GO
ALTER TABLE [dbo].[NhanVien]  WITH NOCHECK ADD  CONSTRAINT [CK_LUONG] CHECK NOT FOR REPLICATION (([LUONG]>=(4000000)))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_LUONG]
GO
ALTER TABLE [dbo].[Vattu]  WITH NOCHECK ADD  CONSTRAINT [CK_SOLUONGTON] CHECK NOT FOR REPLICATION (([SOLUONGTON]>=(0)))
GO
ALTER TABLE [dbo].[Vattu] CHECK CONSTRAINT [CK_SOLUONGTON]
GO
/****** Object:  StoredProcedure [dbo].[SP_CAPNHAT_TON]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CAPNHAT_TON]
AS
BEGIN
	SET XACT_ABORT ON 
	 --SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN  DISTRIBUTED  TRANSACTION
	SELECT *,ROW_NUMBER() OVER(ORDER BY MAVT ASC) AS Row# INTO #vt FROM dbo.Vattu
	DECLARE @i INT,@l INT
	SET @i=1
	--SELECT * FROM #vt
	SELECT TOP(1) @l=Row# FROM #vt ORDER BY Row# DESC
	--SELECT @l
	DECLARE @nhap INT,@nhap1 int,@xuat INT,@xuat1 int,@mavt NCHAR(4),@sl INT
	WHILE(@i<=@l)
	BEGIN
		SELECT @mavt=MAVT FROM #vt WHERE Row#=@i

		SELECT @nhap=SUM(SOLUONG) FROM dbo.CTPN WHERE MAVT=@mavt 
		SELECT @nhap1=SUM(SOLUONG) FROM LINK_QLVT.QLVT_DATHANG.dbo.CTPN WHERE MAVT=@mavt 

		SELECT @xuat=SUM(SOLUONG) FROM dbo.CTPX WHERE MAVT=@mavt
		SELECT @xuat1=SUM(SOLUONG) FROM LINK_QLVT.QLVT_DATHANG.dbo.CTPX WHERE MAVT=@mavt

		IF(ISNULL(@nhap,1)=1)
			SET @nhap=0
		IF(ISNULL(@xuat,1)=1)
			SET @xuat=0

		IF(ISNULL(@nhap1,1)=1)
			SET @nhap1=0
		IF(ISNULL(@xuat1,1)=1)
			SET @xuat1=0

		SET @sl=@nhap+@nhap1-(@xuat+@xuat1);

		UPDATE dbo.Vattu SET SOLUONGTON= @sl WHERE MAVT=@mavt
		UPDATE LINK_QLVT.QLVT_DATHANG.dbo.Vattu SET SOLUONGTON= @sl WHERE MAVT=@mavt
		
		SET @i=@i+1
	END
	COMMIT TRAN
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMANV]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECKMANV] @manv INT,@return INT OUTPUT 
as
BEGIN
	SET @return=0
	IF @manv IN (SELECT manv FROM dbo.NhanVien) 
		or @manv IN (SELECT manv FROM LINK_QLVT.QLVT_DATHANG.dbo.NhanVien)
		BEGIN
			SET @return=1
			RETURN 1
		END	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DDH_CHUA_NHAP]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DDH_CHUA_NHAP]
AS
BEGIN
	SELECT temp.MasoDDH,temp.NGAY,temp.NhaCC,temp.HOTEN,TENVT,temp.SOLUONG,temp.DONGIA from
	(SELECT CTDDH.MasoDDH,dhnv.NGAY,dhnv.NhaCC,dhnv.HOTEN,MAVT,SOLUONG,DONGIA from
	(SELECT dh.MasoDDH,dh.NGAY,dh.NhaCC,HOTEN=HO+' '+TEN from
	(SELECT	* FROM dbo.DatHang WHERE MasoDDH NOT IN (SELECT MasoDDH FROM dbo.PhieuNhap)) AS dh
	JOIN dbo.NhanVien on dh.MANV =dbo.NhanVien.MANV) AS dhnv JOIN dbo.CTDDH ON CTDDH.MasoDDH = dhnv.MasoDDH) AS temp
	JOIN dbo.Vattu on temp.MAVT=dbo.Vattu.MAVT
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DHNV]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DHNV] @manv int,@start nvarchar(20),@end nvarchar(20)
AS
BEGIN
	IF 1=0 
		SET FMTONLY OFF
	--phiếu nhập
	SELECT * INTO #pn FROM dbo.PhieuNhap WHERE MANV=@manv AND NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT NGAY,#pn.MAPN,MANV,MAVT,MAKHO,SOLUONG,DONGIA,THANHTIEN=SOLUONG*DONGIA  INTO #pn1 FROM #pn JOIN dbo.CTPN ON CTPN.MAPN = #pn.MAPN
	SELECT NGAY,MAPN,MANV,TENVT,MAKHO,SOLUONG,DONGIA,THANHTIEN INTO #pn2 FROM #pn1 JOIN dbo.Vattu ON Vattu.MAVT = #pn1.MAVT
	SELECT NGAY,MAPN,MANV,TENVT,TENKHO,SOLUONG,DONGIA,THANHTIEN INTO #pn3 FROM #pn2 LEFT JOIN dbo.Kho ON Kho.MAKHO = #pn2.MAKHO
	SELECT CAST(MONTH(NGAY)AS NVARCHAR)+'-'+CAST(YEAR(NGAY)AS NVARCHAR)AS THANG,NGAY,MAPN AS MAPHIEU,HOTEN=HO+' '+TEN,TENVT,TENKHO,SOLUONG,DONGIA,THANHTIEN INTO #kq FROM #pn3 JOIN dbo.NhanVien ON NhanVien.MANV = #pn3.MANV

	--phiếu xuat
	SELECT * INTO #px FROM dbo.PhieuXuat WHERE MANV=@manv AND NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT NGAY,#px.MAPX,MANV,MAVT,MAKHO,SOLUONG,DONGIA,THANHTIEN=SOLUONG*DONGIA  INTO #pX1 FROM #pX JOIN dbo.CTPX ON CTPX.MAPX = #px.MAPX
	SELECT NGAY,MAPX,MANV,TENVT,MAKHO,SOLUONG,DONGIA,THANHTIEN INTO #px2 FROM #px1 JOIN dbo.Vattu ON Vattu.MAVT = #px1.MAVT
	SELECT NGAY,MAPX,MANV,TENVT,TENKHO,SOLUONG,DONGIA,THANHTIEN INTO #px3 FROM #px2 LEFT JOIN dbo.Kho ON Kho.MAKHO = #px2.MAKHO
	SELECT CAST(MONTH(NGAY)AS NVARCHAR)+'-'+CAST(YEAR(NGAY)AS NVARCHAR)AS THANG,NGAY,MAPX AS MAPHIEU,HOTEN=HO+' '+TEN,TENVT,TENKHO,SOLUONG,DONGIA,THANHTIEN INTO #kq1 FROM #px3 JOIN dbo.NhanVien ON NhanVien.MANV = #px3.MANV

	INSERT INTO #kq SELECT * FROM #kq1
	SELECT * FROM #kq ORDER BY NGAY
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GETLOGIN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GETLOGIN] @manv NVARCHAR(20)
AS BEGIN
   	SELECT loginname  FROM sys.sysusers,master.sys.syslogins
		WHERE sys.sysusers.name=@manv AND sys.sysusers.sid=master.sys.syslogins.sid
   END
GO
/****** Object:  StoredProcedure [dbo].[SP_INFOLOGIN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INFOLOGIN] @lgname NVARCHAR(100)
AS
BEGIN
	--DECLARE @manv INT
	--SELECT name AS manv,groupuid INTO #t1 FROM sys.sysusers,sys.sysmembers
	--	WHERE sid=(SUSER_SID(@lgname)) AND uid=memberuid
	--SELECT manv,name AS ROLE INTO #t2 FROM #t1,sys.sysusers WHERE #t1.groupuid=uid
	--SELECT NhanVien.MANV,HOTEN=HO+TEN,ROLE FROM #t2 ,dbo.NhanVien WHERE #t2.manv=dbo.NhanVien.MANV

	DECLARE @TENUSER NVARCHAR(50)
	SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@lgname)
 
	 SELECT USERNAME = @TENUSER, 
	  HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),
	   TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										  WHERE NAME=@TENUSER))


END

GO
/****** Object:  StoredProcedure [dbo].[SP_SLVT]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SLVT] @mavt NCHAR(4),@sl int
AS
BEGIN
	 SET XACT_ABORT ON 
  --SET TRAN ISOLATION LEVEL SNAPSHOT
	BEGIN DISTRIBUTED TRANSACTION;
	UPDATE dbo.Vattu SET SOLUONGTON = SOLUONGTON+@sl WHERE MAVT = @mavt
	UPDATE LINK_QLVT.QLVT_DATHANG.dbo.Vattu SET SOLUONGTON= SOLUONGTON+@sl WHERE MAVT = @mavt
	COMMIT TRAN
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50),
	@return INT OUTPUT
AS
BEGIN
  SET @return=0
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLVT_DATHANG'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
  	 SET @return=1
     RETURN 1
  END
	 

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
	   SET @return=2
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'CONGTY' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'CHINHANH'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'USER'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_THNX]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THNX] @start nvarchar(20),@end nvarchar(20)
AS
BEGIN
	IF 1=0 
		SET FMTONLY OFF
	SELECT NGAY,MAPN INTO #pn FROM dbo.PhieuNhap WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT NGAY, sum(SOLUONG*DONGIA)AS NHAP INTO #ctpn FROM #pn JOIN dbo.CTPN ON CTPN.MAPN = #pn.MAPN GROUP BY NGAY

	SELECT NGAY,MAPX INTO #px FROM dbo.PhieuXuat WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT NGAY, sum(SOLUONG*DONGIA)AS XUAT INTO #ctpx FROM #px JOIN dbo.CTPX ON dbo.CTPX.MAPX = #px.MAPX GROUP BY NGAY

	SELECT IIF(#ctpn.NGAY IS NULL,#ctpx.NGAY,#ctpn.NGAY)AS NGAY,IIF(NHAP IS NULL,0,NHAP)AS NHAP,IIF(XUAT IS NULL,0,XUAT)AS XUAT  FROM #ctpn FULL JOIN #ctpx ON #ctpx.NGAY = #ctpn.NGAY
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_TKPN]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TKPN] @start NVARCHAR(20),@end NVARCHAR(20),@ct int
AS
BEGIN
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END

	SELECT * INTO #pn  FROM dbo.PhieuNhap WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT MAVT,CAST(Month(#pn.NGAY) as varchar) + '-' + cast(YEAR(#pn.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp
	FROM #pn JOIN dbo.CTPN on CTPN.MAPN=#pn.MAPN  
	GROUP BY MAVT,CAST(Month(#pn.NGAY) as varchar) + '-' + cast(YEAR(#pn.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq FROM #temp JOIN dbo.Vattu ON Vattu.MAVT = #temp.MAVT
	
	IF(@ct=0)
	BEGIN
		SELECT * FROM #kq
	END
	ELSE
	BEGIN
	
	SELECT * INTO #pn1  FROM LINK_QLVT.QLVT_DATHANG.dbo.PhieuNhap WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT MAVT,CAST(Month(#pn1.NGAY) as varchar) + '-' + cast(YEAR(#pn1.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp1
	FROM #pn1 JOIN LINK_QLVT.QLVT_DATHANG.dbo.CTPN AS ct on ct.MAPN=#pn1.MAPN  
	GROUP BY MAVT,CAST(Month(#pn1.NGAY) as varchar) + '-' + cast(YEAR(#pn1.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq1 FROM #temp1 JOIN dbo.Vattu ON Vattu.MAVT = #temp1.MAVT

	INSERT INTO #kq1 SELECT * FROM #kq
	SELECT NGAY,TENVT,SUM(TONGSL) AS TONGSL,SUM(TONGGIA) as TONGGIA FROM #kq1 GROUP BY TENVT,NGAY
	END
    
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TKPX]    Script Date: 12/22/2018 1:41:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_TKPX] @start NVARCHAR(20),@end NVARCHAR(20),@ct int
AS
BEGIN
	IF 1=0 BEGIN
		SET FMTONLY OFF
	END
	SELECT * INTO #px  FROM dbo.PhieuXuat WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)

	SELECT MAVT,CAST(Month(#px.NGAY) as varchar) + '-' + cast(YEAR(#px.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp
	FROM #px JOIN dbo.CTPX ON dbo.CTPX.MAPX =#px.MAPX  
	GROUP BY MAVT,CAST(Month(#px.NGAY) as varchar) + '-' + cast(YEAR(#px.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq FROM #temp JOIN dbo.Vattu ON Vattu.MAVT = #temp.MAVT

	IF(@ct=0)
	BEGIN
		SELECT * FROM #kq
	END
	ELSE
	BEGIN
	
	SELECT * INTO #px1  FROM LINK_QLVT.QLVT_DATHANG.dbo.PhieuXuat WHERE NGAY BETWEEN CONVERT(DATETIME,@start,103) AND CONVERT(DATETIME,@end,103)
	SELECT MAVT,CAST(Month(#px1.NGAY) as varchar) + '-' + cast(YEAR(#px1.NGAY) as varchar) AS NGAY,SUM(SOLUONG) AS TONGSL,SUM(DONGIA) AS TONGGIA
	INTO #temp1
	FROM #px1 JOIN LINK_QLVT.QLVT_DATHANG.dbo.CTPX AS ct on ct.MAPX=#px1.MAPX
	GROUP BY MAVT,CAST(Month(#px1.NGAY) as varchar) + '-' + cast(YEAR(#px1.NGAY) as varchar) 

	SELECT NGAY,TENVT,TONGSL,TONGGIA INTO #kq1 FROM #temp1 JOIN dbo.Vattu ON Vattu.MAVT = #temp1.MAVT

	INSERT INTO #kq1 SELECT * FROM #kq
	SELECT NGAY,TENVT,SUM(TONGSL) AS TONGSL,SUM(TONGGIA) as TONGGIA FROM #kq1 GROUP BY TENVT,NGAY
	END
    
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "pub"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 321
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "sub"
            Begin Extent = 
               Top = 6
               Left = 359
               Bottom = 136
               Right = 609
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ChiNhanh"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INFO_CN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_INFO_CN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NhanVien"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NV'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_NV'
GO
USE [master]
GO
ALTER DATABASE [QLVT_DATHANG] SET  READ_WRITE 
GO
