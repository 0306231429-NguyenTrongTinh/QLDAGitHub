-- Tạo cơ sở dữ liệu
CREATE DATABASE QL_STMN;
GO
USE QL_STMN;

-- 1. Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(25) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(25) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    SoDienThoai VARCHAR(15) UNIQUE,
    ChucVu NVARCHAR(50)  NOT NULL CHECK (ChucVu IN (N'Admin', N'Nhân viên', N'Quản lý')) ,
    Luong DECIMAL(18,2)  CHECK (Luong >= 0),
	TrangThai NVARCHAR(25)NOT NULL DEFAULT N'Đang làm' CHECK (TrangThai IN (N'Đang làm', N'Nghỉ'))
);

-- 2. Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(25) NOT NULL PRIMARY KEY,
    HoTen NVARCHAR(25) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
	DiaChi NVARCHAR(100),
    SDT VARCHAR(15) UNIQUE NOT NULL,
	LoaiKhachHang NVARCHAR(25) NOT NULL CHECK (LoaiKhachHang IN (N'Mới', N'Thành Viên')),
    DiemTichLuy INT DEFAULT 0
);


-- 3. Bảng Loại Sản Phẩm
CREATE TABLE LoaiSanPham (
    MaLoai VARCHAR(25) PRIMARY KEY,
    TenLoai NVARCHAR(50) NOT NULL,
	TrangThai INT DEFAULT 1
);

-- 4. Bảng Nhà Cung Cấp
CREATE TABLE NhaCungCap (
    MaNhaCungCap VARCHAR(25) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(50) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    DiaChi NVARCHAR(100),
	TrangThai INT DEFAULT 1
);

-- 5. Bảng Sản Phẩm
CREATE TABLE SanPham (
    MaSanPham VARCHAR(25) NOT NULL PRIMARY KEY,
    TenSanPham NVARCHAR(100) NOT NULL,
    MaLoai VARCHAR(25) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0),
    DonViTinh NVARCHAR(50),
    MaNCC VARCHAR(25) NOT NULL,
    NgayHetHan DATE NULL,
	TrangThai NVARCHAR(25)NOT NULL DEFAULT N'Còn hàng' CHECK (TrangThai IN (N'Còn hàng', N'Hết hàng',N'Ngưng Bán')),
    FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNhaCungCap)
	
);

-- 6. Bảng Hóa Đơn
CREATE TABLE HoaDon (
    MaHoaDon VARCHAR(25) PRIMARY KEY,
    NgayLap DATETIME DEFAULT GETDATE(),
    MaNhanVien VARCHAR(25) NOT NULL,
    MaKhachHang VARCHAR(25) NOT NULL,
    TongTien DECIMAL(18,2) DEFAULT 0,
	HinhThuc NVARCHAR(25)NOT NULL DEFAULT N'Tiền mặt' CHECK (HinhThuc IN (N'Tiền mặt', N'Trực tuyến')),
    TrangThai NVARCHAR(25)NOT NULL DEFAULT N'Chưa thanh toán'CHECK (TrangThai IN (N'Chưa thanh toán', N'Đã thanh toán')),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);


-- 7. Bảng Chi Tiết Hóa Đơn
CREATE TABLE ChiTietHoaDon (
    MaHoaDon VARCHAR(25) NOT NULL,
    MaSanPham VARCHAR(25) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    ThanhTien AS (SoLuong * DonGia) PERSISTED, 
	PRIMARY KEY (MaHoaDon, MaSanPham),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);



-- 8. Bảng Nhập Hàng
CREATE TABLE NhapHang (
    MaPhieuNhap VARCHAR(25) PRIMARY KEY,
    NgayNhap DATETIME DEFAULT GETDATE(),
    MaNhanVien VARCHAR(25) NOT NULL,
    MaNhaCungCap VARCHAR(25) NOT NULL,
    TongTien DECIMAL(18,2) DEFAULT 0,
	TrangThai NVARCHAR(25)NOT NULL DEFAULT N'Đang chờ' CHECK (TrangThai IN (N'Đã nhập', N'Đang chờ')),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
);


-- 9. Bảng Chi Tiết Nhập Hàng
CREATE TABLE ChiTietNhapHang (
    MaSanPham VARCHAR(25) NOT NULL,
    MaPhieuNhap VARCHAR(25) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    GiaNhap DECIMAL(18,2) NOT NULL CHECK (GiaNhap >= 0),
    ThanhTien AS (SoLuong * GiaNhap) PERSISTED, 
	PRIMARY KEY (MaPhieuNhap, MaSanPham),
    FOREIGN KEY (MaPhieuNhap) REFERENCES NhapHang(MaPhieuNhap),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- 10. Bảng Tài Khoản 
CREATE TABLE TaiKhoan (
    MaTK VARCHAR(25) PRIMARY KEY,  
    MaNhanVien VARCHAR(25) NOT NULL,
    TenDangNhap NVARCHAR(50) NOT NULL UNIQUE, 
    MatKhau NVARCHAR(255) NOT NULL, 
    Quyen NVARCHAR(50) CHECK (Quyen IN ('Admin', 'NhanVien','QuanLy')),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

-- 11. Bảng Kho Hàng
CREATE TABLE KhoHang (
    MaSanPham VARCHAR(25) PRIMARY KEY,
    SoLuongTon INT DEFAULT 0 CHECK (SoLuongTon >= 0),
    SoLuongNhap INT DEFAULT 0 CHECK (SoLuongNhap >= 0),
    GiaNhap DECIMAL(18,2) CHECK (GiaNhap >= 0),
    GiaBan DECIMAL(18,2) CHECK (GiaBan >= 0),
    NgayCapNhat DATETIME DEFAULT GETDATE(),
    GhiChu NVARCHAR(255),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);







-- Chèn dữ liệu vào bảng Nhân Viên

INSERT INTO NhanVien VALUES
('NV001', N'Nguyễn Văn A', '1990-05-20', N'Nam', '0987654321', N'Admin', 15000000, N'Đang làm'),
('NV002', N'Trần Thị B', '1995-08-10', N'Nữ', '0912345678', N'Nhân viên', 8000000, N'Đang làm'),
('NV003', N'Lê Văn V', '1999-07-31', N'Nam', '0306231440', N'Quản lý', 1500000, N'Đang làm'),
('NV004', N'Hồ Quang Dũng', '1992-03-21', N'Nam', '0901112233', N'Nhân viên', 9000000, N'Nghỉ'),
('NV005', N'Phạm Ngọc Trinh', '1989-11-30', N'Nữ', '0933445566', N'Quản lý', 12000000, N'Đang làm'),
('NV006', N'Đỗ Mạnh Hùng', '1996-06-17', N'Nam', '0977554321', N'Nhân viên', 7500000, N'Nghỉ'),
('NV007', N'Ngô Phương Nhi', '1994-12-02', N'Nữ', '0966332211', N'Admin', 13500000, N'Đang làm'),
('NV008', N'Trịnh Văn K', '1988-01-14', N'Nam', '0988123411', N'Nhân viên', 8700000, N'Nghỉ'),
('NV009', N'Lê Thị Hoa', '1997-05-09', N'Nữ', '0911987654', N'Nhân viên', 7600000, N'Đang làm'),
('NV010', N'Nguyễn Đình Lộc', '1990-07-21', N'Nam', '0902123456', N'Admin', 14500000, N'Nghỉ'),
('NV011', N'Vũ Bảo', '1991-09-10', N'Nam', '0933123123', N'Nhân viên', 8000000, N'Đang làm'),
('NV012', N'Lê Kim', '1995-08-22', N'Nữ', '0944123444', N'Nhân viên', 7900000, N'Đang làm'),
('NV013', N'Trần Văn Vinh', '1992-10-03', N'Nam', '0979988776', N'Quản lý', 11000000, N'Nghỉ'),
('NV014', N'Phạm Thu Hằng', '1993-03-29', N'Nữ', '0955778822', N'Nhân viên', 7200000, N'Đang làm'),
('NV015', N'Huỳnh Đức Bảo', '1990-12-01', N'Nam', '0905667889', N'Admin', 15500000, N'Đang làm');



-- Chèn dữ liệu vào bảng Khách Hàng

INSERT INTO KhachHang VALUES
('KH001', N'Lê Văn C','2000-05-20',N'Nam',N'Hà Nội', '0905123456',N'Mới', 100),
('KH002', N'Phạm Thị D','1998-07-10',N'Nữ', N'TP.HCM','0934567890',N'Thành Viên', 200),
('KH003', N'Đặng Minh Tuấn','1991-02-15',N'Nam', N'Hà Nội', '0903012345',N'Mới', 50),
('KH004', N'Phan Thị Lan','1993-06-12',N'Nữ', N'TP.HCM', '0904023456',N'Thành Viên', 150),
('KH005', N'Lưu Hồng Hà','1995-09-20',N'Nữ', N'Đà Nẵng', '0905034567',N'Mới', 30),
('KH006', N'Bùi Văn Hùng','1990-10-01',N'Nam', N'Cần Thơ', '0906045678',N'Thành Viên', 70),
('KH007', N'Lê Quốc Cường','1989-12-22',N'Nam', N'Hải Phòng', '0907056789',N'Thành Viên', 120),
('KH008', N'Trần Thị Huyền','1994-03-17',N'Nữ', N'Quảng Ninh', '0908067890',N'Mới', 10),
('KH009', N'Nguyễn Văn Nam','1996-04-14',N'Nam', N'Huế', '0909078901',N'Mới', 0),
('KH010', N'Hoàng Ngọc Mai','1992-07-19',N'Nữ', N'Nghệ An', '0910089012',N'Thành Viên', 180),
('KH011', N'Lê Minh Trí','1997-08-11',N'Nam', N'Tây Ninh', '0911090123',N'Mới', 25),
('KH012', N'Phạm Thị Yến','1998-11-25',N'Nữ', N'Lâm Đồng', '0912101234',N'Mới', 5),
('KH013', N'Đỗ Văn Long','1988-01-05',N'Nam', N'Bình Dương', '0913112345',N'Thành Viên', 230),
('KH014', N'Ngô Hữu Thắng','1991-05-09',N'Nam', N'Bến Tre', '0914123456',N'Mới', 40),
('KH015', N'Trịnh Thị Thúy','1993-09-30',N'Nữ', N'Nam Định', '0915134567',N'Thành Viên', 190);



-- Chèn dữ liệu vào bảng Loại Sản Phẩm

INSERT INTO LoaiSanPham VALUES
('LSP001', N'Bánh kẹo', 1),
('LSP002', N'Nước giải khát', 1),
('LSP003', N'Gia dụng', 1),
('LSP004', N'Thực phẩm khô', 1),
('LSP005', N'Đồ uống có ga', 1),
('LSP006', N'Đồ uống không ga', 1),
('LSP007', N'Sữa và sản phẩm từ sữa', 1),
('LSP008', N'Bánh mì & ngũ cốc', 1),
('LSP009', N'Gia vị & nước chấm', 1),
('LSP010', N'Hóa mỹ phẩm', 1),
('LSP011', N'Sản phẩm chăm sóc cá nhân', 1),
('LSP012', N'Thực phẩm đông lạnh', 1),
('LSP013', N'Rau củ quả tươi', 1),
('LSP014', N'Thực phẩm chế biến sẵn', 1),
('LSP015', N'Dụng cụ gia đình', 1);


-- Chèn dữ liệu vào bảng Nhà Cung Cấp

INSERT INTO NhaCungCap VALUES
('NCC001', N'Công ty ABC', '0911222333', N'Hà Nội', 1),
('NCC002', N'Công ty XYZ', '0988777666', N'TP.HCM', 1),
('NCC003', N'Công ty Thực Phẩm Xanh', '0933001122', N'Bình Dương', 1),
('NCC004', N'Tập đoàn Nước Giải Khát VinDrink', '0933112233', N'Nghệ An', 1),
('NCC005', N'CT TNHH Sữa Mộc Châu', '0933223344', N'Sơn La', 1),
('NCC006', N'Công ty Mỹ phẩm Hoa Mai', '0933334455', N'Quảng Nam', 1),
('NCC007', N'Công ty Gia Dụng ABC', '0933445566', N'Hải Dương', 1),
('NCC008', N'Đại lý Bánh Kẹo Hải Hà', '0933556677', N'Hà Nam', 1),
('NCC009', N'CT TNHH Thực Phẩm Vinh Hạnh', '0933667788', N'Thanh Hóa', 1),
('NCC010', N'Nhà phân phối Sản phẩm Chăm sóc Cá Nhân', '0933778899', N'Phú Thọ', 1),
('NCC011', N'Đại lý Rau Quả Xanh', '0933889900', N'Đà Lạt', 1),
('NCC012', N'Công ty TNHH Nước Mắm Nam Ngư', '0933990011', N'Phan Thiết', 1),
('NCC013', N'Cty CP Đồ Gia Dụng Thiên Hòa', '0934001122', N'Cần Thơ', 1),
('NCC014', N'Công ty TNHH Bia Sài Gòn', '0934112233', N'TP.HCM', 1),
('NCC015', N'CT CP Đường và Bánh Kẹo Miền Tây', '0934223344', N'An Giang', 1);


-- Chèn dữ liệu vào bảng Sản Phẩm
INSERT INTO SanPham VALUES
('SP001', N'Bánh Oreo', 'LSP001', 25000, 100, N'Hộp', 'NCC001', '2025-12-31', N'Còn hàng'),
('SP002', N'Coca Cola', 'LSP002', 10000, 200, N'Chai', 'NCC002', '2025-06-30', N'Còn hàng'),
('SP003', N'Milo hộp', 'LSP002', 12000, 150, N'Hộp', 'NCC004', '2025-12-01', N'Còn hàng'),
('SP004', N'Nước cam ép Twister', 'LSP006', 15000, 120, N'Chai', 'NCC004', '2025-11-15', N'Còn hàng'),
('SP005', N'Sữa tươi TH True Milk', 'LSP007', 25000, 80, N'Hộp', 'NCC005', '2025-12-25', N'Còn hàng'),
('SP006', N'Bánh mì sandwich', 'LSP008', 18000, 100, N'Túi', 'NCC003', '2025-04-30', N'Còn hàng'),
('SP007', N'Nước mắm Nam Ngư', 'LSP009', 22000, 60, N'Chai', 'NCC012', '2026-01-15', N'Còn hàng'),
('SP008', N'Dầu gội Clear', 'LSP010', 95000, 70, N'Chai', 'NCC006', '2026-12-31', N'Còn hàng'),
('SP009', N'Kem đánh răng P/S', 'LSP011', 18000, 90, N'Tuýp', 'NCC010', '2027-01-01', N'Còn hàng'),
('SP010', N'Xà phòng Lifebuoy', 'LSP010', 12000, 110, N'Bánh', 'NCC006', '2026-05-01', N'Còn hàng'),
('SP011', N'Sữa chua Vinamilk', 'LSP007', 6000, 200, N'Hũ', 'NCC005', '2025-06-30', N'Còn hàng'),
('SP012', N'Rau cải ngọt', 'LSP013', 15000, 50, N'Kg', 'NCC011', NULL, N'Ngưng Bán'),
('SP013', N'Cá viên đông lạnh', 'LSP012', 45000, 40, N'Gói', 'NCC009', '2025-09-30', N'Ngưng Bán'),
('SP014', N'Coca chai lớn', 'LSP005', 18000, 0, N'Chai', 'NCC002', '2025-12-01', N'Hết hàng'),
('SP015', N'Bột giặt Omo', 'LSP010', 125000, 45, N'Túi', 'NCC013', '2027-03-01', N'Ngưng Bán');



-- Chèn dữ liệu vào bảng Hóa Đơn

INSERT INTO HoaDon VALUES
('HD001', '2025-03-29', 'NV001', 'KH001', 50000, N'Tiền mặt', N'Đã thanh toán'),
('HD002', '2025-01-12', 'NV002', 'KH002', 80000, N'Trực tuyến', N'Chưa thanh toán'),
('HD003', '2025-04-01', 'NV001', 'KH003', 95000, N'Tiền mặt', N'Đã thanh toán'),
('HD004', '2025-08-15', 'NV002', 'KH004', 56000, N'Trực tuyến', N'Chưa thanh toán'),
('HD005', '2025-05-21', 'NV003', 'KH005', 120000, N'Tiền mặt', N'Đã thanh toán'),
('HD006', '2025-06-09', 'NV001', 'KH006', 40000, N'Trực tuyến', N'Đã thanh toán'),
('HD007', '2025-11-03', 'NV002', 'KH007', 150000, N'Tiền mặt', N'Chưa thanh toán'),
('HD008', '2025-02-10', 'NV003', 'KH008', 87000, N'Trực tuyến', N'Đã thanh toán'),
('HD009', '2025-04-07', 'NV001', 'KH009', 65000, N'Tiền mặt', N'Đã thanh toán'),
('HD010', '2025-01-19', 'NV002', 'KH010', 74000, N'Trực tuyến', N'Chưa thanh toán'),
('HD011', '2025-07-17', 'NV003', 'KH011', 132000, N'Tiền mặt', N'Đã thanh toán'),
('HD012', '2025-09-18', 'NV001', 'KH012', 41000, N'Trực tuyến', N'Đã thanh toán'),
('HD013', '2025-04-11', 'NV002', 'KH013', 21000, N'Tiền mặt', N'Chưa thanh toán'),
('HD014', '2025-12-18', 'NV003', 'KH014', 96000, N'Trực tuyến', N'Đã thanh toán'),
('HD015', '2025-04-12', 'NV001', 'KH015', 150000, N'Tiền mặt', N'Chưa thanh toán');




-- Chèn dữ liệu vào bảng Chi Tiết Hóa Đơn

INSERT INTO ChiTietHoaDon VALUES
('HD001', 'SP001', 2, 25000),
('HD001', 'SP002', 1, 10000),
('HD002', 'SP001', 3, 25000),
('HD002', 'SP002', 2, 10000),
('HD003', 'SP003', 2, 15000),
('HD004', 'SP004', 3, 12000),
('HD005', 'SP005', 5, 14000),
('HD006', 'SP006', 1, 20000),
('HD007', 'SP007', 4, 10000),
('HD008', 'SP008', 2, 12000),
('HD009', 'SP009', 3, 16000),
('HD010', 'SP010', 6, 14000),
('HD011', 'SP011', 2, 15000),
('HD012', 'SP012', 1, 11000),
('HD013', 'SP013', 3, 7000),
('HD014', 'SP014', 2, 18000),
('HD015', 'SP015', 2, 20000),
('HD015', 'SP002', 1, 10000),
('HD015', 'SP001', 1, 25000);



-- Chèn dữ liệu vào bảng Nhập Hàng

INSERT INTO NhapHang VALUES
('PN001', '2025-03-29', 'NV001', 'NCC001', 3300000, N'Đã nhập'),
('PN003', '2025-03-31', 'NV003', 'NCC001', 3060000, N'Đã nhập'),
('PN005', '2025-04-02', 'NV002', 'NCC001', 3440000, N'Đã nhập'),
('PN008', '2025-04-05', 'NV002', 'NCC002', 7500000, N'Đã nhập'),
('PN009', '2025-04-06', 'NV003', 'NCC001', 1870000, N'Đã nhập'),
('PN011', '2025-04-08', 'NV002', 'NCC001', 2300000, N'Đã nhập'),
('PN012', '2025-04-09', 'NV003', 'NCC002', 675000, N'Đã nhập'),
('PN015', '2025-04-12', 'NV003', 'NCC001', 540000, N'Đã nhập');



-- Chèn dữ liệu vào bảng Chi Tiết Nhập Hàng
INSERT INTO ChiTietNhapHang VALUES
('SP001', 'PN001', 100, 21000),
('SP002', 'PN001', 150, 8000),

('SP003', 'PN003', 150, 10000),
('SP004', 'PN003', 120, 13000),

('SP005', 'PN005', 80, 23000),
('SP006', 'PN005', 100, 16000),

('SP007', 'PN008', 60, 20000),
('SP008', 'PN008', 70, 90000),

('SP009', 'PN009', 90, 11000),
('SP010', 'PN009', 110, 8000),

('SP011', 'PN011', 100, 15000),
('SP012', 'PN011', 200, 4000),

('SP013', 'PN012', 50, 7000),
('SP014', 'PN012', 50, 6500),

('SP015', 'PN015', 45, 12000);



-- Chèn dữ liệu vào bảng Tài Khoản

INSERT INTO TaiKhoan VALUES
('TK001','NV001', N'admin', N'123456', N'Admin'),
('TK002','NV002', N'nhanvien1', N'password', N'NhanVien'),
('TK003','NV003', N'quanly', N'654321', N'QuanLy');

