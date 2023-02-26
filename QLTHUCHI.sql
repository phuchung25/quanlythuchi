CREATE DATABASE QLYTHUCHI
USE QLYTHUCHI
GO
-- tạo bảng quản lý
CREATE TABLE QUANLY(
	username VARCHAR(20),
	password VARCHAR(20)
)
-- tạo bảng nhân viên
go

CREATE TABLE NHANVIEN(
	msnv VARCHAR(20) PRIMARY KEY NOT NULL,
	hoten NVARCHAR(50),
	gioitinh NVARCHAR(6),
	namsinh DATE,
	diachi NVARCHAR(50),
	hinh image,
	username VARCHAR(20),
	password VARCHAR(20)
)
-- tạo bảng phiếu thu
GO

CREATE TABLE PHIEUTHU(
maphieuthu int PRIMARY KEY,
nguoinoptien NVARCHAR(100),
ngaynop DATE,
diachi NVARCHAR(100),
sdt INT,
email NVARCHAR(100),
sotien INT,
lydo NVARCHAR(500),
msnv VARCHAR(20),

)
GO
CREATE TABLE PHIEUCHI(
maphieuchi int PRIMARY KEY,
nguoinhantien NVARCHAR(100),
ngaynhan DATE,
diachi NVARCHAR(100),
sdt INT,
email NVARCHAR(100),
sotien INT,
lydo NVARCHAR(500),
msnv VARCHAR(20),

)
GO

--tạo khóa
ALTER TABLE dbo.PHIEUTHU ADD FOREIGN KEY (msnv) REFERENCES nhanvien(msnv)
ALTER TABLE dbo.PHIEUCHI ADD FOREIGN KEY (msnv) REFERENCES nhanvien(msnv)




go
----- thêm giá trị vào bảng-----
INSERT INTO dbo.QUANLY
(
    username,
    password
)
VALUES
(   'admin', -- username - varchar(20)
    'admin'  -- password - varchar(20)
    )

INSERT INTO dbo.PHIEUTHU
(
    maphieuthu,
    nguoinoptien,
    ngaynop,
    diachi,
    sdt,
    email,
    sotien,
    lydo,
    msnv
)
VALUES
(   1,         -- maphieuthu - int
    N'hùng',       -- nguoinoptien - nvarchar(100)
    GETDATE(), -- ngaynop - date
    N'',       -- diachi - nvarchar(100)
    0,         -- sdt - int
    N'',       -- email - nvarchar(100)
    0,         -- sotien - int
    N'',       -- lydo - nvarchar(500)
    '001'         -- msnv - varchar(20)
    )
INSERT INTO dbo.NHANVIEN
(
    msnv,
    hoten,
    gioitinh,
    namsinh,
    diachi,
    hinh,
    username,
    password
)
VALUES
(   '001',        -- msnv - varchar(20)
    N'Nguyễn Phúc Hùng',       -- hoten - nvarchar(50)
    N'Nam',       -- gioitinh - nvarchar(6)
    GETDATE(), -- namsinh - date
    N'Vĩnh Yên, Vĩnh Phúc',       -- diachi - nvarchar(50)
    NULL,      -- hinh - image
    'hung',        -- username - varchar(20)
    '123456'         -- password - varchar(20)
    )

	INSERT INTO dbo.PHIEUCHI
	(
	    maphieuchi,
	    nguoinhantien,
	    ngaynhan,
	    diachi,
	    sdt,
	    email,
	    sotien,
	    lydo,
	    msnv
	)
	VALUES
	(   001,         -- maphieuchi - int
	    N'hùng',       -- nguoinhantien - nvarchar(100)
	    GETDATE(), -- ngaynhan - date
	    N'',       -- diachi - nvarchar(100)
	    0,         -- sdt - int
	    N'',       -- email - nvarchar(100)
	    0,         -- sotien - int
	    N'',       -- lydo - nvarchar(500)
	    '001'         -- msnv - varchar(20)
	    )
	--tìm kiếm thông tin
	--tạo mã tự động
	Select TOP 1 Cast(a.maphieuthu as int) From PHIEUTHU a Order by Cast(a.maphieuthu as int) DESC
	tìm theo mã phiếu
	SELECT * FROM dbo.PHIEUTHU WHERE maphieuthu =4
	-- tìm theo người nộp
	SELECT * FROM dbo.PHIEUTHU WHERE nguoinoptien
	--- tìm kiếm ngày nộp
	select * from phieuthu where ngaynop = '10/28/2022'
	-- tìm kiếm từ ngày đến ngày 
	SELECT maphieuchi,ngaynhan,nguoinhantien, sum(sotien) AS 'Tổng tiền' FROM dbo.PHIEUCHI WHERE ngaynhan BETWEEN '1996-10-05 00:00:00' AND '10/28/2022' GROUP BY maphieuchi,ngaynhan,nguoinhantien,sotien
	SELECT maphieuthu,nguoinoptien, ngaynop, sum(sotien)AS 'Tổng tiền' FROM PHIEUTHU WHERE ngaynop BETWEEN '10/6/2022' AND '10/26/2022' GROUP BY maphieuthu, ngaynop,nguoinoptien

	-- tính tổng tiền
	SELECT SUM(sotien) FROM dbo.PHIEUTHU WHERE ngaynop BETWEEN '10/6/2022' AND '10/26/2022'