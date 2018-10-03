create database QL_TTTH
use QL_TTTH

create table KHOAHOC
(
	MAKH char(10) not null,
	TENKH nvarchar(30),
	GIATIEN int,
	constraint pK_KHOAHOC primary key (MAKH),
)

create table GIAOVIEN
(
	MAGV char(10) not null,
	TENGV nvarchar(30),
	DT int,
	DIACHI nvarchar(50),
	EMAIL nvarchar(50),
	LUONG int,
	constraint pK_GIAVIEN primary key (MAGV),
)

create table LOPHOC
(
	MALOP char(10) not null,
	TENLOP nvarchar(30),
	SISO int,
	LICHHOC datetime,
	MAGV char(10) not null,
	MAKH char(10) not null,
	constraint pK_LOPHOC primary key (MALOP),
	constraint FK_LOPHOC_KHOAHOC foreign key (MAKH) references KHOAHOC(MAKH),
	constraint FK_LOPHOC_GIAOVIEN foreign key (MAGV) references GIAOVIEN(MAGV)
)
create table TAIKHOAN
(
	MATK char(10) not null,
	TENTK nvarchar(50),
	PASS nvarchar(50),
	constraint pK_TAIKHOAN primary key (MATK)
)
create table NHANVIEN
(
	MANV char(10) not null,
	TENNV nvarchar(30),
	CHUCVU nvarchar(50),
	LUONG int,
	MATK char(10) not null,
	constraint pK_NHANVIEN primary key (MANV),
	constraint FK_NHANVIEN_TAIKHOAN foreign key (MATK) references TAIKHOAN(MATK)
)

create table HOCVIEN
(
	MAHV char(10) not null,
	TENHV nvarchar(30),
	SDT int,
	DIACHI nvarchar(50),
	HOCPHI int,
	MALOP char(10) not null
	constraint pK_HOCVIEN primary key (MAHV),
	constraint FK_HOCVIEN_LOPHOC foreign key (MALOP) references LOPHOC(MALOP)
)	

create table KETQUA
(
	MAHV char(10) not null,
	MAKH char(10) not null,
	DIEM int,
	GHICHU nvarchar(50),
	constraint pK_KETQUA primary key (MAHV, MAKH),
	constraint FK_KETQUA_HOCVIEN foreign key (MAHV) references HOCVIEN(MAHV),
	constraint FK_KETQUA_KHOAHOC foreign key (MAKH) references KHOAHOC(MAKH)
)	