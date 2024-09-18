create database BTL_MoHaMed_10121210
go

use BTL_MoHaMed_10121210
go

create table account
(
	username varchar(50) not null primary key,
	pass varchar(50) not null,

)
go

create table accountIn4
(	
	idAccount int identity (1,1) not null primary key,
	username varchar(50) not null,
	displayname nvarchar(100) not null default N'Cụ Mết',
	email nvarchar(100) not null,
	sdt varchar(10) not null,
	diaChi nvarchar(150) not null,
	type int not null default 0 --1:admin; 0:staff
	foreign key (username) references account(username),

)
go




create proc proc_getaccbyusername 
@uname varchar(50)
as
begin
	select * from account 
	where account.username=@uname
end
go

create proc proc_gettttkbyusername
@uname varchar(50)
as
begin
	select * from accountIn4
	where accountIn4.username = @uname
	
end
go


CREATE proc proc_Create_account
(
    @username VARCHAR(50),
    @pass VARCHAR(50)
)
AS
BEGIN
    -- Thêm thông tin vào bảng "account"
    INSERT INTO account (username, pass)
    VALUES (@username, @pass);
END
go



CREATE proc proc_Create_accountIn4
(
    @username VARCHAR(50),
    @displayname NVARCHAR(100),
    @email NVARCHAR(100),
    @sdt VARCHAR(10),
    @diaChi NVARCHAR(150),
    @type INT
)
AS
BEGIN
	--IF EXISTS (SELECT 1 FROM account WHERE username = @username)
	--	BEGIN
 --   -- Dữ liệu tồn tại
	---- Thêm thông tin vào bảng "accountIn4" với thông tin từ các tham số đầu vào
	--		INSERT INTO accountIn4 (username, displayname, email, sdt, diaChi, type)
	--		VALUES (@username, @displayname, @email, @sdt, @diaChi, @type);
	--	END
	--ELSE
	--	BEGIN
 --   -- Dữ liệu không tồn tại
	--		INSERT INTO accountIn4 (username, displayname, email, sdt, diaChi, type)
	--		VALUES (@username, @displayname, @email, @sdt, @diaChi, @type);
	--	END
			INSERT INTO accountIn4 (username, displayname, email, sdt, diaChi, type)
			VALUES (@username, @displayname, @email, @sdt, @diaChi, @type);
END

go


create proc proc_UpdateAcc
    @username VARCHAR(50),
    @pass VARCHAR(50)
as
begin
	update account
	set
	pass= @pass
	where account.username = @username
end
go


create proc proc_UpdateAccIn4

    @username VARCHAR(50),
    @displayname NVARCHAR(100),
    @email NVARCHAR(100),
    @sdt VARCHAR(10),
    @diaChi NVARCHAR(150),
    @type INT
as
begin
	update accountIn4
	set
	username = @username,
	displayname = @displayname,
	email = @email,
	sdt = @sdt,
	diaChi = @diaChi,
	type= @type
	where accountIn4.username = @username
end
go

select * from account
select * from accountIn4




create table NV
(
	idNV int identity (1,1) not null primary key,
	tenNV nvarchar(100) not null,
	diaChi nvarchar(100) not null,
	sdt varchar(10) not null,
)
go

insert into NV
values(N'Nhân viên 1',N'HY',N'123123442')
insert into NV
values(N'Nhân viên 2',N'HY',N'123123442')
insert into NV
values(N'Nhân viên 3',N'HY',N'123123442')
insert into NV
values(N'Nhân viên 4',N'HY',N'123123442')
insert into NV
values(N'Long',N'HN',N'123123442')
insert into NV
values(N'Nhân viên 6',N'HN',N'123123442')
insert into NV
values(N'Nhân viên 7',N'HN',N'123123442')
insert into NV
values(N'Nhân viên 8',N'HN',N'123123442')
insert into NV
values(N'Nhân viên 9',N'HN',N'123123442')
insert into NV
values(N'Nhân viên 10',N'HN',N'123123442')
go

create proc proc_GetAllNV
as
begin 
	select*from NV
end

create proc proc_GetNV
@str nvarchar(max)
as
begin
	select * from NV
	where 
	CAST(NV.idNV as nvarchar(max))= @str 
	or cast(NV.tenNV as nvarchar(MAx)) = @str
	or cast(NV.diaChi as nvarchar(max)) = @str
	or cast(NV.sdt as nvarchar(max)) = @str
end

create proc proc_CreateNV
@tenNV nvarchar(100),
@diaChi nvarchar(100),
@sdt varchar(10)
as
begin
	insert into NV(tenNV,diaChi,sdt)
	values(@tenNv,@diaChi,@sdt)
end

create proc proc_UpdateNV
@idNV int,
@tenNV nvarchar(100),
@diaChi nvarchar(100),
@sdt varchar(10)
as
begin
	update NV
	set
	tenNV = @tenNV,
	diaChi = @diaChi,
	sdt= @sdt
	where NV.idNV = @idNV
end


create proc proc_DeleteNV
@idNV int
as
begin
	delete from NV
	where NV.idNV = @idNV
end




create table loaiSP
(
	idLoai int identity(1,1) not null primary key,
	tenLoai varchar(10) not null,
	moTa nvarchar(100) not null
)
go
	--XM  : xe máy                     LX  : Lốp xe
	--AO  : dàn nhựa                   PGS : Phuộc
	--DL  : Đèn led                    MB  : Mâm bánh
	--BCL : Bi cầu led                 GX  : Gương
	--BL  : Bi Lazer                   XN  : Xin nhan
	--YX  : Yên xe                     CP  : Cùm côn, tay phanh
	--SPK : Sản phẩm khác
insert into loaiSP(tenLoai, moTa)
values(N'XM', N'Xe máy')
insert into loaiSP(tenLoai, moTa)
values(N'AO', N'Dàn áo')
insert into loaiSP(tenLoai, moTa)
values(N'DL', N'Đèn led')
insert into loaiSP(tenLoai, moTa)
values(N'BCL', N'BCL')
insert into loaiSP(tenLoai, moTa)
values(N'BL', N'Bi Lazer')
insert into loaiSP(tenLoai, moTa)
values(N'YX', N'Yên xe')
insert into loaiSP(tenLoai, moTa)
values(N'LX', N'Lốp xe')
insert into loaiSP(tenLoai, moTa)
values(N'MB', N'Mâm bánh')
insert into loaiSP(tenLoai, moTa)
values(N'GX', N'Gương xe')
insert into loaiSP(tenLoai, moTa)
values(N'PGS', N'Phuộc, Giảm xóc')
insert into loaiSP(tenLoai, moTa)
values(N'Xn', N'Xin nhan')
insert into loaiSP(tenLoai, moTa)
values(N'CP', N'Cùm côn, tay phanh')
insert into loaiSP(tenLoai, moTa)
values(N'SPK', N'Linh tinh')
go


create proc proc_getallloaisp
as
begin
	select* from loaiSP
end

create proc proc_getloaisp
@str nvarchar(max)
as
begin
	select * from loaiSP
	where 
	cast(loaiSP.idLoai as nvarchar(max))=@str
	or cast(loaiSP.tenLoai as nvarchar(max))=@str
	or cast(loaiSP.moTa as nvarchar(max))=@str
end


create proc proc_CreateloaiSP
@tenLoai varchar(10),
@moTa nvarchar(100)
as
begin
	insert into loaiSP(tenLoai, moTa)
	values(@tenLoai, @moTa)
end


create proc proc_UpdateloaiSP
@idLoai int,
@tenLoai varchar(10),
@moTa nvarchar(100)
as
begin
	update loaiSP
	set
	loaiSP.tenLoai = @tenLoai,
	loaiSP.moTa = @moTa
	where loaiSP.idLoai = @idLoai
end



create proc proc_DeleteloaiSP
@idLoai int
as
begin
	delete from loaiSP
	where loaiSP.idLoai = @idLoai
end


create table SP
(
	idSP int identity(1,1) not null primary key,
	tenSP nvarchar(100) not null,
	soLuong int not null,
	giaNhap float not null,
	giaBan float not null,
	idLoai int not null, 
	foreign key (idLoai) references loaiSP(idLoai)
)
go

create proc proc_GetAllSP
as
begin
	select * from SP
end


create proc proc_GetSP
@str nvarchar(max)
as
begin 
	select * from SP
	where 
	CAST(SP.idSP as nvarchar(max))= @str 
	or cast(SP.tenSP as nvarchar(max)) = @str
	or cast(SP.soLuong as nvarchar(max)) = @str
	or cast(SP.giaNhap as nvarchar(max)) = @str
	or cast(SP.giaBan as nvarchar(max)) = @str
	or cast(SP.idLoai as nvarchar(max)) = @str

end


create proc proc_CreateSP
@tenSP nvarchar(100),
@soLuong int, 
@giaNhap float, 
@giaBan float,
@idLoai int
as
begin
	insert into SP(tenSP,soLuong,giaNhap,giaBan,idLoai)
	values(@tenSP,@soLuong,@giaNhap,@giaBan,@idLoai)
end

create proc proc_UpdateSP
@idSP int,
@tenSP nvarchar(100),
@soLuong int, 
@giaNhap float, 
@giaBan float,
@idLoai int
as
begin
	update SP
	set
	tenSP=@tenSP,
	soLuong=@soLuong,
	giaNhap=@giaNhap,
	giaBan=@giaBan,
	idLoai=@idLoai
	where idSP=@idSP
end


create proc proc_DeleteSP
@idSP int
as
begin
	delete from SP
	where SP.idSP=@idSP
end


insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Exciter 150', 0, 42000000, 45900000, 1)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Exciter 155', 0, 45500000, 51300000, 1)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Winner X V2', 0, 36500000, 3900000, 1)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Dán nhựa nhám Exciter 150 2019', 0, 850000, 1200000, 2)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Đèn Led zinfat', 0, 350000, 479000, 3)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Bi gầm M10', 0, 1700000, 2100000, 4)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'KUS 4TH Mini lens ', 0, 2800000, 3500000, 5)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Yên Solo X1r', 0, 350000, 400000, 6)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Michelin 140_80', 0, 500000, 560000, 7)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'MonoShock Olinn',0 , 1000000, 1999000, 10)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Mâm 3 đao', 0, 350000, 500000, 8)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Gương gù X1R', 0, 15000, 45000, 9)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Xin nhan Spirit', 0, 57000, 80000, 11)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Cùm phanh côn RaccingBoy', 0, 3500000, 4790000, 12)
insert into SP (tenSP, soLuong, giaNhap, giaBan, idLoai)
values(N'Ốc ti tan 7 màu', 0, 15000, 20000, 13)
go

create table KH
(
	idKH int identity(1,1) not null primary key,
	tenKH nvarchar(100) not null default N'Thượng đế',
	diachi nvarchar(100) not null default N'Trống',
	sdt varchar(10) not null default N'Trống',
)
go

insert into KH(tenKH, diachi, sdt)
values(N'Khách hàng số 1', N'HY','123123123')
insert into KH(tenKH, diachi, sdt)
values(N'Khách hàng số 2', N'HY','123321321')
insert into KH(tenKH, diachi, sdt)
values(N'Khách hàng số 3', N'HY','123245453')
insert into KH(tenKH, diachi, sdt)
values(N'Khách hàng số 4', N'HY','123145353')
go


create proc proc_getallkh
as
begin
	select * from KH
end


create proc proc_getkh
@str nvarchar(max)
as
begin
	select* from KH
	where 
		cast(KH.idKH as nvarchar(max))=@str
		or cast(KH.tenKH as nvarchar(max))=@str
		or cast(KH.diachi as nvarchar(max))=@str
		or cast(KH.sdt as nvarchar(max))=@str

end



Create proc proc_CreateKH
@tenKH nvarchar(100),
@diachi nvarchar(100),
@sdt varchar(10)
as
begin
	insert into KH(tenKH,diachi,sdt)
	values (@tenKH,@diachi,@sdt)
end



Create proc proc_UpdateKH
@idKH int,
@tenKH nvarchar(100),
@diachi nvarchar(100),
@sdt varchar(10)
as
begin
	update KH
	set
	kh.tenKH = @tenKH,
	kh.diachi = @diachi,
	kh.sdt = @sdt
	where kh.idKH = @idKH
end

create proc proc_DeleteKH
@idKH int
as
begin
	delete from KH
	where kh.idKH = idKH
end


create table HDB
(
	idHDB int identity(1,1) not null primary key,
	idKH int not null ,
	idNV int not null ,
	tongTien float not null,
	thoiGianB datetime not null
	foreign key (idKH) references KH(idKH),
	foreign key (idNV) references NV(idNV),
)
go


create table chitietHDB
(
	idChiTietHDB int identity(1,1) not null primary key,
	idHDB int not null,
	idSP int not null,
	soLuong int not null,
	giaBan float not null,
	thanhTien float not null,
	foreign key (idHDB) references HDB(idHDB),
	foreign key (idSP) references SP(idSP),
)
go

create proc proc_GetAllhdb
as
begin
	select * from HDB
end
go

create proc proc_GetHDB
@str nvarchar(max)
as
begin
	select * from HDB where 
			cast(HDB.idHDB as nvarchar(max))=@str
		or cast(HDB.idKH as nvarchar(max))=@str
		or cast(HDB.idNV as nvarchar(max))=@str
		or cast(HDB.tongTien as nvarchar(max))=@str
		or cast(HDB.thoiGianB as nvarchar(max))=@str

end
go

create proc proc_GetCTHDB
@idHDB int
as
begin
	select * from chitietHDB where chitietHDB.idHDB = @idHDB
end
go

create proc proc_CreateHDB
@idKH int,
@idNV int,
@tongTien float,
@thoiGianB datetime
as
begin
	insert into HDB(idKH, idNV, tongTien, thoiGianB)
	values(@idKH, @idNV, @tongTien, @thoiGianB)
end
go

create proc proc_CreateCTHDB
@idHDB int,
@idSP int,
@soLuong int,
@giaBan float,
@thanhTien float
as
begin
	IF EXISTS (SELECT 1 FROM HDB WHERE HDB.idHDB = @idHDB)
		BEGIN
    -- Dữ liệu tồn tại
	-- Thêm thông tin vào bảng "accountIn4" với thông tin từ các tham số đầu vào
			INSERT INTO chitietHDB(idHDB, idSP, soLuong, giaBan, thanhTien )
			VALUES (@idHDB, @idSP, @soLuong, @giaBan, @thanhTien);
		END
	ELSE
		BEGIN
    -- Dữ liệu không tồn tại
			SELECT 'Error' AS Result, 'HDB record not found' AS ErrorMessage;
		END
end
go

create proc proc_UpdateHDB
@idHDB int,
@idKH int,
@idNV int,
@tongTien float,
@thoiGianB float
as
begin
	update HDB
	set
	HDB.idKH = @idKH,
	HDB.idNV = @idNV,
	HDB.tongTien = @tongTien,
	HDB.thoiGianB = @thoiGianB
	where HDB.idHDB = @idHDB
end
go


create proc proc_UpdateCTHDB
@idChiTietHDB int,
@idHDB int,
@idSP int,
@soLuong int,
@giaBan float,
@thanhTien float

as
begin
	update chitietHDB
	set
	chitietHDB.idHDB = @idHDB,
	chitietHDB.idSP = @idSP,
	chitietHDB.soLuong = @soLuong,
	chitietHDB.giaBan = @giaBan,
	chitietHDB.thanhTien = @thanhTien
	where chitietHDB.idChiTietHDB = @idChiTietHDB
end
go


create proc proc_DeleteHDB
@idHDB int
as
begin
	delete from HDB
	where HDB.idHDB=@idHDB
end
go

create proc proc_DeleteCTHDB
@idCTHDB int
as
begin
	delete from chitietHDB
	where chitietHDB.idChiTietHDB=@idCTHDB
end
go

create table NCC
(
	idNCC int identity(1,1) not null primary key,
	tenNCC nvarchar(100) not null,
	diaChi nvarchar(100) not null,
	sdt varchar(10) not null,
)
go

insert into NCC(tenNCC, diaChi, sdt)
values(N'Honbaba', N'HY',N'123123123')
insert into NCC(tenNCC, diaChi, sdt)
values(N'Yamama', N'HY',N'123423123')
insert into NCC(tenNCC, diaChi, sdt)
values(N'MambaShaKy', N'HY',N'123423443')
insert into NCC(tenNCC, diaChi, sdt)
values(N'HacLyDaViSon', N'HY',N'123735123')
go



create proc proc_getallncc
as
begin
	select * from NCC
end


create proc proc_getncc
@str nvarchar(max)
as
begin
	select* from NCC
	where 
		cast(NCC.idNCC as nvarchar(max))=@str
		or cast(NCC.tenNCC as nvarchar(max))=@str
		or cast(NCC.diaChi as nvarchar(max))=@str
		or cast(NCC.sdt as nvarchar(max))=@str

end



Create proc proc_CreateNCC
@tenNCC nvarchar(100),
@diaChi nvarchar(100),
@sdt varchar(10)
as
begin
	insert into NCC(tenNCC,diaChi,sdt)
	values (@tenNCC,@diaChi,@sdt)
end



Create proc proc_UpdateNCC
@idNCC int,
@tenNCC nvarchar(100),
@diaChi nvarchar(100),
@sdt varchar(10)
as
begin
	update NCC
	set
	NCC.tenNCC = @tenNCC,
	NCC.diaChi = @diaChi,
	NCC.sdt = @sdt
	where NCC.idNCC = @idNCC
end

create proc proc_DeleteNCC
@idNCC int
as
begin
	delete from NCC
	where NCC.idNCC = idNCC
end




create table HDN
(
	idHDN int identity(1,1) not null primary key,
	idNCC int not null ,
	idNV int not null ,
	tongTien float not null,
	thoiGianN datetime not null
	foreign key (idNCC) references NCC(idNCC),
	foreign key (idNV) references NV(idNV),
)
go


create table chitietHDN
(
	idChiTietHDN int identity(1,1) not null primary key,
	idHDN int not null,
	idSP int not null,
	soLuong int not null,
	giaNhap float not null,
	thanhTien float not null,
	foreign key (idHDN) references HDN(idHDN),
	foreign key (idSP) references SP(idSP),
)
go




create proc proc_GetAllhdn
as
begin
	select * from HDN
end
go

create proc proc_GetHDN
@str nvarchar(max)
as
begin
	select * from HDN where 
			cast(HDN.idHDN as nvarchar(max))=@str
		or cast(HDN.idNCC as nvarchar(max))=@str
		or cast(HDN.idNV as nvarchar(max))=@str
		or cast(HDN.tongTien as nvarchar(max))=@str
		or cast(HDN.thoiGianN as nvarchar(max))=@str

end
go

create proc proc_GetCTHDN
@idHDN int
as
begin
	select * from chitietHDN where chitietHDN.idHDN = @idHDN
end
go

create proc proc_CreateHDN
@idNCC int,
@idNV int,
@tongTien float,
@thoiGianN datetime
as
begin
	insert into HDN(idNCC, idNV, tongTien, thoiGianN)
	values(@idNCC, @idNV, @tongTien, @thoiGianN)
end
go

create proc proc_CreateCTHDN
@idHDN int,
@idSP int,
@soLuong int,
@giaNhap float,
@thanhTien float
as
begin
	IF EXISTS (SELECT 1 FROM HDN WHERE HDN.idHDN = @idHDN)
		BEGIN
    -- Dữ liệu tồn tại
	-- Thêm thông tin vào bảng "accountIn4" với thông tin từ các tham số đầu vào
			INSERT INTO chitietHDN(idHDN, idSP, soLuong, giaNhap, thanhTien )
			VALUES (@idHDN, @idSP, @soLuong, @giaNhap, @thanhTien);
		END
	ELSE
		BEGIN
    -- Dữ liệu không tồn tại
			SELECT 'Error' AS Result, 'HDB record not found' AS ErrorMessage;
		END
end
go

create proc proc_UpdateHDN
@idHDN int,
@idNCC int,
@idNV int,
@tongTien float,
@thoiGianN float
as
begin
	update HDN
	set
	HDN.idNCC = @idNCC,
	HDN.idNV = @idNV,
	HDN.tongTien = @tongTien,
	HDN.thoiGianN = @thoiGianN
	where HDN.idHDN = @idHDN
end
go


create proc proc_UpdateCTHDN
@idChiTietHDN int,
@idHDN int,
@idSP int,
@soLuong int,
@giaNhap float,
@thanhTien float

as
begin
	update chitietHDN
	set
	chitietHDN.idHDN = @idHDN,
	chitietHDN.idSP = @idSP,
	chitietHDN.soLuong = @soLuong,
	chitietHDN.giaNhap = @giaNhap,
	chitietHDN.thanhTien = @thanhTien
	where chitietHDN.idChiTietHDN = @idChiTietHDN
end
go


create proc proc_DeleteHDN
@idHDN int
as
begin
	delete from HDN
	where HDN.idHDN=@idHDN
end
go

create proc proc_DeleteCTHDN
@idCTHDN int
as
begin
	delete from chitietHDN
	where chitietHDN.idChiTietHDN=@idCTHDN
end
go






insert into account
values
(
	N'admin1',	N'admin1'
)


insert into accountIn4
values
(
	N'admin1',
	N'LongChoiNonnnnnnn',
	N'longchoinon@gmail.com',
	N'0999999999',
	N'HY',
	1
)


