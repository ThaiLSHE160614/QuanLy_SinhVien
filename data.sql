use master
drop database if exists MyTest

create database MyTest;
go

USE [MyTest]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 11/8/2022 5:13:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSo] [int] NULL,
	[MaMH] [nchar](6) NULL,
	[Diem] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 11/8/2022 5:13:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nchar](6) NOT NULL,
	[TenKhoa] [nchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 11/8/2022 5:13:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[MaMH] [nchar](6) NOT NULL,
	[TenMH] [nchar](50) NULL,
	[SoTiet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/8/2022 5:13:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSo] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[MaKhoa] [nchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'001   ', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'002   ', 6)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'003   ', 7)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'004   ', 8)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'005   ', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'006   ', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'007   ', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'008   ', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (3, N'001   ', 9)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (5, N'005   ', 6)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1, N'001   ', 1)
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT  ', N'C??ng Ngh??? Th??ng Tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'KT    ', N'Kinh t???')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NN    ', N'Ng??n ng???')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'TKDH  ', N'Thi???t k??? ????? h???a')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'TT    ', N'B??o ch??')
GO
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'001   ', N'L???p tr??nh Window                                  ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'002   ', N'C?? s??? d??? li???u                                     ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'003   ', N'C???u tr??c d??? li???u                                  ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'004   ', N'K??? thu???t l???p tr??nh                                ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'005   ', N'????? h???a                                            ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'006   ', N'M???ng m??y t??nh                                     ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'007   ', N'L?? thuy???t ????? th???                                  ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'008   ', N'Ki???n tr??c m??y t??nh                                ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'009   ', N'X??c su???t th???ng k??                                 ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'010   ', N'To??n cao c???p                                      ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'011   ', N'Ti???ng Nh???t                                        ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'012   ', N'Ti???ng Anh                                         ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'013   ', N'Ti???ng Trung                                       ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'LAB   ', N'Java lab                                          ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'PRN   ', N'.NET v?? C#                                        ', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'TYPO  ', N'M??u n?????c                                          ', 30)
GO
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1, N'Nguy???n H?? Giang', CAST(N'1978-12-04' AS Date), 1, N'Hoang Hoa Th??m', 908496767, N'NN    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (2, N'L?? B???ch Y???n', CAST(N'1976-04-21' AS Date), 0, N'757 Pasteur', 9234455, N'KT    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (3, N'Ki???u Th??? Hu???', CAST(N'1970-02-01' AS Date), 0, N'2 Nguy???n V??n Linh', 5973345, N'KT    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (4, N'Phan Thanh Tu???n', CAST(N'1974-06-07' AS Date), 1, N'34 ???p B???c', 7896545, N'NN    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (5, N'L?? Ho??ng Trung', CAST(N'1975-12-04' AS Date), 1, N'21 Tr?????ng S??n', 9896432, N'CNTT  ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (6, N'Tr???n C??ng Minh', CAST(N'2002-04-01' AS Date), 1, N'Nh???n', 9685342, N'NN    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (7, N'Mai Vi???t H??ng', CAST(N'2002-04-20' AS Date), 1, N'Berlin', 963562002, N'TT    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (8, N'L?? S??? Th??i', CAST(N'2002-10-17' AS Date), 1, N'Tokyo', 397461220, N'CNTT  ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (9, N'V?? Ho??ng Anh', CAST(N'2002-08-15' AS Date), 1, N'L??ng H???', 9863254, N'NN    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (10, N'Nguy???n Trung Hi???u', CAST(N'2002-11-11' AS Date), 1, N'Long Bi??n', 6895342, N'NN    ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (12, N'A', CAST(N'2022-11-06' AS Date), 1, N'B', 0, N'CNTT  ')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (14, N'T??? ????nh Ti???n', CAST(N'1995-06-22' AS Date), 1, N'H??a L???c', 986543, N'CNTT  ')
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [MaMH_in_Mon] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Mon] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [MaMH_in_Mon]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [MaSo_in_SinhVien] FOREIGN KEY([MaSo])
REFERENCES [dbo].[SinhVien] ([MaSo])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [MaSo_in_SinhVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [MaKhoa_in_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [MaKhoa_in_Khoa]
GO