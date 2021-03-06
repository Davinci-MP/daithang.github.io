USE [master]
GO
/****** Object:  Database [BanGameBanQuyen]    Script Date: 5/28/2022 2:22:44 PM ******/
CREATE DATABASE [BanGameBanQuyen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BanGameBanQuyen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BanGameBanQuyen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BanGameBanQuyen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BanGameBanQuyen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BanGameBanQuyen] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BanGameBanQuyen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BanGameBanQuyen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET ARITHABORT OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BanGameBanQuyen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BanGameBanQuyen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BanGameBanQuyen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BanGameBanQuyen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BanGameBanQuyen] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BanGameBanQuyen] SET  MULTI_USER 
GO
ALTER DATABASE [BanGameBanQuyen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BanGameBanQuyen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BanGameBanQuyen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BanGameBanQuyen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BanGameBanQuyen] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BanGameBanQuyen] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BanGameBanQuyen] SET QUERY_STORE = OFF
GO
USE [BanGameBanQuyen]
GO
/****** Object:  Table [dbo].[AccountAdmin]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountAdmin](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](100) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [varchar](24) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[CreateDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaCTDH] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
	[Ngaygiao] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSP]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSP](
	[MaDM] [int] IDENTITY(1,1) NOT NULL,
	[TenDM] [nvarchar](200) NOT NULL,
	[AnhDM] [nvarchar](max) NULL,
	[MoTaDM] [nvarchar](500) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayTao] [date] NOT NULL,
	[TrangThaiHuyDon] [bit] NOT NULL,
	[ThanhToan] [bit] NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[Note] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](200) NOT NULL,
	[Diachi] [nvarchar](500) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[CreateDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/28/2022 2:22:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaDM] [int] NULL,
	[TenSP] [nvarchar](200) NOT NULL,
	[AnhSP] [nvarchar](max) NOT NULL,
	[VideoSP] [nvarchar](max) NULL,
	[GiaSP] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[BestSeller] [bit] NOT NULL,
	[CreateDate] [date] NOT NULL,
	[NgaySua] [date] NOT NULL,
	[MotaSP] [nvarchar](max) NOT NULL,
	[LinkDownGame] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountAdmin] ON 

INSERT [dbo].[AccountAdmin] ([AccountID], [TaiKhoan], [MatKhau], [Phone], [Email], [FullName], [CreateDate]) VALUES (1, N'datnguyen', N'123456', 99999999, N'dat09@gmail.com', N'Nguyễn Thành Đạt', CAST(N'2022-05-27' AS Date))
SET IDENTITY_INSERT [dbo].[AccountAdmin] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMucSP] ON 

INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (1, N'Mạo Hiểm', NULL, N'Game Thể Loại Mạo Hiểm', 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (2, N'Hành Động', NULL, N'Game Thể Loại Hành Động', 1)
SET IDENTITY_INSERT [dbo].[DanhMucSP] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Diachi], [Ngaysinh], [Phone], [Email], [CreateDate]) VALUES (1, N'Nguyễn Thành Đạt', N'Hưng Yên', CAST(N'2001-10-09' AS Date), 34635555, N'dat09@gmail.com', CAST(N'2022-05-11' AS Date))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [MaDM], [TenSP], [AnhSP], [VideoSP], [GiaSP], [TrangThai], [BestSeller], [CreateDate], [NgaySua], [MotaSP], [LinkDownGame]) VALUES (6, 2, N'Arcade Games', N'https://demo.w3layouts.com/demos_new/template_demo/20-12-2019/adventure_gaming-demo_Free/984350899/web/images/t2.jpg', NULL, 120000, 1, 1, CAST(N'2022-05-27' AS Date), CAST(N'2022-05-27' AS Date), N'Arcade Games', NULL)
INSERT [dbo].[SanPham] ([MaSP], [MaDM], [TenSP], [AnhSP], [VideoSP], [GiaSP], [TrangThai], [BestSeller], [CreateDate], [NgaySua], [MotaSP], [LinkDownGame]) VALUES (7, 1, N'Action Games', N'https://demo.w3layouts.com/demos_new/template_demo/20-12-2019/adventure_gaming-demo_Free/984350899/web/images/t1.jpg', NULL, 200000, 1, 1, CAST(N'2022-05-27' AS Date), CAST(N'2022-05-27' AS Date), N'Arcade Games', N'https://demo.w3layouts.com/demos_new/template_demo/20-12-2019/adventure_gaming-demo_Free/984350899/web/images/t2.jpg')
INSERT [dbo].[SanPham] ([MaSP], [MaDM], [TenSP], [AnhSP], [VideoSP], [GiaSP], [TrangThai], [BestSeller], [CreateDate], [NgaySua], [MotaSP], [LinkDownGame]) VALUES (8, 1, N'Call Of Duty', N'http://127.0.0.1:5500/images/gl7.jpg', NULL, 100000, 1, 1, CAST(N'2022-05-28' AS Date), CAST(N'2022-05-28' AS Date), N'Call Of Duty', N'http://127.0.0.1:5500/images/gl7.jpg')
INSERT [dbo].[SanPham] ([MaSP], [MaDM], [TenSP], [AnhSP], [VideoSP], [GiaSP], [TrangThai], [BestSeller], [CreateDate], [NgaySua], [MotaSP], [LinkDownGame]) VALUES (9, 1, N'Arcade Games', N'http://127.0.0.1:5500/images/t3.jpg', NULL, 120000, 1, 1, CAST(N'2022-05-28' AS Date), CAST(N'2022-05-28' AS Date), N'Arcade Games', N'http://127.0.0.1:5500/images/gl7.jpg')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaDM])
REFERENCES [dbo].[DanhMucSP] ([MaDM])
GO
USE [master]
GO
ALTER DATABASE [BanGameBanQuyen] SET  READ_WRITE 
GO
