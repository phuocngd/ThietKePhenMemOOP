USE [master]
GO
/****** Object:  Database [MyQLKS4]    Script Date: 24-May-19 7:59:02 PM ******/
CREATE DATABASE [MyQLKS4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyQLKS4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyQLKS4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyQLKS4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MyQLKS4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MyQLKS4] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyQLKS4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyQLKS4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyQLKS4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyQLKS4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyQLKS4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyQLKS4] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyQLKS4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyQLKS4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyQLKS4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyQLKS4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyQLKS4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyQLKS4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyQLKS4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyQLKS4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyQLKS4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyQLKS4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyQLKS4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyQLKS4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyQLKS4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyQLKS4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyQLKS4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyQLKS4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyQLKS4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyQLKS4] SET RECOVERY FULL 
GO
ALTER DATABASE [MyQLKS4] SET  MULTI_USER 
GO
ALTER DATABASE [MyQLKS4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyQLKS4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyQLKS4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyQLKS4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyQLKS4] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MyQLKS4', N'ON'
GO
ALTER DATABASE [MyQLKS4] SET QUERY_STORE = OFF
GO
USE [MyQLKS4]
GO
/****** Object:  UserDefinedFunction [dbo].[TuDongThemMa]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TuDongThemMa](@Type varchar(10))
returns varchar(10)
as
begin
declare @ID varchar(10)
	if(@Type = 'SER')
				begin
						IF ((SELECT COUNT(IDservice) FROM Servicess) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(IDservice, 3)) FROM Servicess
				end
	if(@Type = 'ROOM')
				begin
						IF ((SELECT COUNT(IDRoom) FROM Rooms) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(IDRoom, 3)) FROM Rooms
				end
	
SELECT @ID = CASE
WHEN @ID >= 0 and @ID < 9 THEN @Type+'00' + CONVERT(varchar, CONVERT(INT, @ID) + 1)
WHEN @ID >= 9 and @ID <99 THEN @Type+'0' + CONVERT(varchar, CONVERT(INT, @ID) + 1)
WHEN @ID >= 99 THEN @Type + CONVERT(varchar, CONVERT(INT, @ID) + 1)
END
			return @ID

end
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Username] [varchar](100) NOT NULL,
	[Passwordss] [varchar](100) NOT NULL,
	[TypeAccout] [nvarchar](100) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[IDBill] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[TongTien] [decimal](18, 2) NULL,
	[IDCustomer] [varchar](15) NULL,
	[NgayLap] [datetime] NULL,
	[NguoiLap] [nvarchar](200) NULL,
	[CMNDnglap] [varchar](15) NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills_Detail]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills_Detail](
	[IDBill] [decimal](18, 0) NOT NULL,
	[IDElements] [varchar](10) NULL,
	[Price] [decimal](18, 2) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerCMND] [varchar](15) NOT NULL,
	[HoTen] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [varchar](15) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerCMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeCMND] [varchar](15) NOT NULL,
	[HovaTen] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[Username] [varchar](100) NULL,
	[SDT] [varchar](15) NOT NULL,
	[Mail] [varchar](100) NULL,
	[LuongCanBan] [decimal](18, 2) NULL,
	[isPartTime] [bit] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeCMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[IDRoom] [varchar](10) NOT NULL,
	[Nameroom] [nvarchar](100) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Statuss] [varchar](2) NULL,
	[cmndKhach] [varchar](15) NULL,
	[hovaten] [nvarchar](100) NULL,
	[checkin] [datetime] NULL,
	[checkout] [datetime] NULL,
	[sdt] [varchar](15) NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[IDRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salarys]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salarys](
	[IDEmployee] [varchar](15) NOT NULL,
	[Luong] [decimal](18, 2) NULL,
	[Ngaythang] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicess]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicess](
	[IDservice] [varchar](10) NOT NULL,
	[Nameservice] [nvarchar](100) NOT NULL,
	[TypeService] [nvarchar](100) NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Servicess] PRIMARY KEY CLUSTERED 
(
	[IDservice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Rooms] ([IDRoom], [Nameroom], [Price], [Statuss], [cmndKhach], [hovaten], [checkin], [checkout], [sdt]) VALUES (N'ROOM001', N'a102', CAST(16000 AS Decimal(18, 0)), N'2', N'281212914', N'nguyenduy', CAST(N'1900-01-01T00:00:14.000' AS DateTime), CAST(N'1900-01-01T14:00:00.000' AS DateTime), N'0937536545')
ALTER TABLE [dbo].[Rooms] ADD  CONSTRAINT [DF_Rooms_IDRoom]  DEFAULT ([dbo].[TuDongThemMa]('ROOM')) FOR [IDRoom]
GO
ALTER TABLE [dbo].[Servicess] ADD  CONSTRAINT [DF_Servicess_IDservice]  DEFAULT ([dbo].[TuDongThemMa]('SER')) FOR [IDservice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Customers] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[Customers] ([CustomerCMND])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Customers]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Employees] FOREIGN KEY([CMNDnglap])
REFERENCES [dbo].[Employees] ([EmployeeCMND])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Employees]
GO
ALTER TABLE [dbo].[Bills_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Detail_Bills] FOREIGN KEY([IDBill])
REFERENCES [dbo].[Bills] ([IDBill])
GO
ALTER TABLE [dbo].[Bills_Detail] CHECK CONSTRAINT [FK_Bills_Detail_Bills]
GO
ALTER TABLE [dbo].[Bills_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Detail_Rooms] FOREIGN KEY([IDElements])
REFERENCES [dbo].[Rooms] ([IDRoom])
GO
ALTER TABLE [dbo].[Bills_Detail] CHECK CONSTRAINT [FK_Bills_Detail_Rooms]
GO
ALTER TABLE [dbo].[Bills_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Detail_Servicess] FOREIGN KEY([IDElements])
REFERENCES [dbo].[Servicess] ([IDservice])
GO
ALTER TABLE [dbo].[Bills_Detail] CHECK CONSTRAINT [FK_Bills_Detail_Servicess]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Accounts] FOREIGN KEY([Username])
REFERENCES [dbo].[Accounts] ([Username])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Accounts]
GO
ALTER TABLE [dbo].[Salarys]  WITH CHECK ADD  CONSTRAINT [FK_Salarys_Employees] FOREIGN KEY([IDEmployee])
REFERENCES [dbo].[Employees] ([EmployeeCMND])
GO
ALTER TABLE [dbo].[Salarys] CHECK CONSTRAINT [FK_Salarys_Employees]
GO
/****** Object:  StoredProcedure [dbo].[addAccounts]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addAccounts] 
	-- Add the parameters for the stored procedure here

@Username	varchar(100)	,
@Password	varchar(100)	,
@TypeAccout	nvarchar(100)	
AS
BEGIN
	insert into Salarys values(@Username,@Password,@TypeAccout)
end
GO
/****** Object:  StoredProcedure [dbo].[addBills]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addBills] 
	-- Add the parameters for the stored procedure here

@TongTien decimal(18, 2),
@IDCustomer varchar(15),
@NgayLap datetime,
@NguoiLap nvarchar(200),
@CMNDnglap varchar(15)

AS
BEGIN
	insert into Bills values(@TongTien,@IDCustomer,@NgayLap,@NguoiLap,@CMNDnglap)
end
GO
/****** Object:  StoredProcedure [dbo].[addBills_Detail]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addBills_Detail] 
	-- Add the parameters for the stored procedure here
@IDBill decimal(18, 0),
@IDElements varchar(10),
@Price decimal(18, 2),
@SoLuong int

AS
BEGIN
	insert into Bills_Detail values(@IDBill,@IDElements,@Price,@SoLuong)
end
GO
/****** Object:  StoredProcedure [dbo].[addCustomers]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addCustomers] 
	-- Add the parameters for the stored procedure here

@CustomerCMND varchar(15),
@HoTen nvarchar(200),
@NgaySinh date,
@SDT varchar(15)

AS
BEGIN
	insert into Customers values(@CustomerCMND,@HoTen,@NgaySinh,@SDT)
end
GO
/****** Object:  StoredProcedure [dbo].[addEmployees]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addEmployees] 
	-- Add the parameters for the stored procedure here

@EmployeeCMND varchar(15),
@HovaTen nvarchar(200),
@NgaySinh date,
@Username varchar(100),
@SDT varchar(15),
@Mail varchar(100),
@LuongCanBan decimal(18, 2),
@isPartTime bit

AS
BEGIN
	insert into Employees values(@EmployeeCMND,@HovaTen,@NgaySinh,@Username,@SDT,@Mail,@LuongCanBan,@isPartTime)
end
GO
/****** Object:  StoredProcedure [dbo].[addRooms]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addRooms] 
	-- Add the parameters for the stored procedure here
	@name nvarchar(100),
	@Price decimal(18, 0)

AS
BEGIN
	insert into Rooms values(default,@name,@Price,null,null,null,null,null,null)
end
GO
/****** Object:  StoredProcedure [dbo].[addSalarys]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addSalarys] 
	-- Add the parameters for the stored procedure here

@IDEmployee varchar(15),
@Luong decimal(18, 2),
@Ngaythang date

AS
BEGIN
	insert into Salarys values(@IDEmployee,@Luong,@Ngaythang)
end
GO
/****** Object:  StoredProcedure [dbo].[addServicess]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[addServicess] 
	-- Add the parameters for the stored procedure here

@Nameservice nvarchar(100),
@TypeService nvarchar(100),
@Price decimal(18, 2)

AS
BEGIN
	insert into Servicess values(default,@Nameservice,@TypeService,@Price)
end
GO
/****** Object:  StoredProcedure [dbo].[deleteAccounts]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteAccounts] 
   @Username	varchar(100)	

AS 
BEGIN 
DELETE
FROM   Accounts
WHERE Username=@Username
END
GO
/****** Object:  StoredProcedure [dbo].[deleteBills]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteBills] 
    @IDBill decimal(18, 0)
AS 
BEGIN 
DELETE
FROM   Bills
WHERE IDBill=@IDBill 
END
GO
/****** Object:  StoredProcedure [dbo].[deleteBills_Detail]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteBills_Detail] 
    @IDBill decimal(18,0),
	@IDElements varchar(10)
AS 
BEGIN 
DELETE
FROM   Bills_Detail
WHERE  IDBill = @IDBill and IDElements = @IDElements
END
GO
/****** Object:  StoredProcedure [dbo].[deleteCustomers]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteCustomers] 
    @CustomerCMND varchar(15)
AS 
BEGIN 
DELETE
FROM   Customers
WHERE  CustomerCMND = @CustomerCMND
END
GO
/****** Object:  StoredProcedure [dbo].[deleteEmployees]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteEmployees] 
    @EmployeeCMND varchar(15)
AS 
BEGIN 
DELETE
FROM   Employees
WHERE EmployeeCMND=@EmployeeCMND
END
GO
/****** Object:  StoredProcedure [dbo].[deleteRooms]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteRooms] 
    @IDRoom varchar(10)
AS 
BEGIN 
DELETE
FROM   Rooms
WHERE  IDRoom= @IDRoom
END
GO
/****** Object:  StoredProcedure [dbo].[deleteSalarys]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteSalarys] 
    @IDEmployee varchar(15),
	@Ngaythang date
AS 
BEGIN 
DELETE
FROM   Salarys
WHERE IDEmployee=@IDEmployee and Ngaythang=@Ngaythang 
END
GO
/****** Object:  StoredProcedure [dbo].[deleteServicess]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[deleteServicess] 
    @IDservice varchar(10)
AS 
BEGIN 
DELETE
FROM   Servicess
WHERE  IDservice = @IDservice
END
GO
/****** Object:  StoredProcedure [dbo].[getAllAccounts]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllAccounts] 
AS 
BEGIN 
	select * from Accounts
END
GO
/****** Object:  StoredProcedure [dbo].[getAllBills]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllBills] 
AS 
BEGIN 
	select * from Bills
END
GO
/****** Object:  StoredProcedure [dbo].[getAllBills_Detail]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllBills_Detail] 
AS 
BEGIN 
	select * from Bills_Detail
END
GO
/****** Object:  StoredProcedure [dbo].[getAllCustomers]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllCustomers] 
AS 
BEGIN 
	select * from Customers
END
GO
/****** Object:  StoredProcedure [dbo].[getAllEmployees]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllEmployees] 
AS 
BEGIN 
	select * from Employees
END
GO
/****** Object:  StoredProcedure [dbo].[getAllRooms]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllRooms] 
AS 
BEGIN 
	select * from Rooms
END
GO
/****** Object:  StoredProcedure [dbo].[getAllSalarys]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllSalarys] 
AS 
BEGIN 
	select * from Salarys
END
GO
/****** Object:  StoredProcedure [dbo].[getAllServicess]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[getAllServicess] 
AS 
BEGIN 
	select * from Servicess
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccounts]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateAccounts] 
	-- Add the parameters for the stored procedure here

@Username	varchar(100)	,
@Password	varchar(100)	,
@TypeAccout	nvarchar(100)	
		

AS
BEGIN
	update Accounts
	set Passwordss = @Password
	where Username=@Username
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBills]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateBills] 
	-- Add the parameters for the stored procedure here

@IDBill decimal(18, 0),
@TongTien decimal(18, 2),
@IDCustomer varchar(15),
@NgayLap datetime,
@NguoiLap nvarchar(200),
@CMNDnglap varchar(15)

AS
BEGIN
	update Bills
	set TongTien = @TongTien,IDCustomer = @IDCustomer, NgayLap = @NgayLap,NguoiLap=@NguoiLap,CMNDnglap = @CMNDnglap
	where IDBill=@IDBill 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBills_Detail]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateBills_Detail] 
	-- Add the parameters for the stored procedure here
@IDBill decimal(18, 0),
@IDElements varchar(10),
@Price decimal(18, 2),
@SoLuong int

AS
BEGIN
	update Bills_Detail
	set Price=@Price,SoLuong=@SoLuong
	where IDBill=@IDBill and IDElements = @IDElements
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomers]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateCustomers] 
	-- Add the parameters for the stored procedure here

@CustomerCMND varchar(15),
@HoTen nvarchar(200),
@NgaySinh date,
@SDT varchar(15)

AS
BEGIN
	update Customers
	set HoTen=@HoTen,NgaySinh= @NgaySinh,SDT=@SDT
	where CustomerCMND=@CustomerCMND 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployees]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateEmployees] 
	-- Add the parameters for the stored procedure here

@EmployeeCMND varchar(15),
@HovaTen nvarchar(200),
@NgaySinh date,
@Username varchar(100),
@SDT varchar(15),
@Mail varchar(100),
@LuongCanBan decimal(18, 2),
@isPartTime bit

AS
BEGIN
	update Employees
	set HovaTen = @HovaTen,NgaySinh = @NgaySinh, Username = @Username,SDT=@SDT,Mail = @Mail,LuongCanBan=@LuongCanBan,isPartTime=@isPartTime
	where EmployeeCMND=@EmployeeCMND 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateRooms]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateRooms] 
	-- Add the parameters for the stored procedure here
@IDRoom varchar(10),
@Name nvarchar(100),
@Price decimal(18, 0),
@Statuss varchar(2),
@cmndKhach varchar(15),
@hovaten nvarchar(100),
@checkin datetime,
@checkout datetime,
@sdt varchar(15)

AS
BEGIN
	update Rooms
	set Rooms.Nameroom=@name,Price=@Price,Statuss=@Statuss,cmndKhach=@cmndKhach,hovaten=@hovaten,checkin=@checkin,checkout=@checkout,sdt=@sdt
	where IDRoom=@IDRoom
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateSalarys]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateSalarys] 
	-- Add the parameters for the stored procedure here

@IDEmployee varchar(15),
@Luong decimal(18, 2),
@Ngaythang date

AS
BEGIN
	update Salarys
	set Luong = @Luong
	where IDEmployee=@IDEmployee and Ngaythang=@Ngaythang 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateServicess]    Script Date: 24-May-19 7:59:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[UpdateServicess] 
	-- Add the parameters for the stored procedure here
@IDservice varchar(10),
@Nameservice nvarchar(100),
@TypeService nvarchar(100),
@Price decimal(18, 2)

AS
BEGIN
	update Servicess
	set Nameservice=@Nameservice,TypeService= @TypeService,Price= @Price
	where IDservice=@IDservice 
END
GO
USE [master]
GO
ALTER DATABASE [MyQLKS4] SET  READ_WRITE 
GO
