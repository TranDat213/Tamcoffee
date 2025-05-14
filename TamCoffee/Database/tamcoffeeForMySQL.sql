-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1:3306
-- Thời gian đã tạo: Th5 11, 2025 lúc 10:52 AM
-- Phiên bản máy phục vụ: 9.1.0
-- Phiên bản PHP: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `tamcoffee`
--
CREATE DATABASE IF NOT EXISTS `tamcoffee` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `tamcoffee`;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chitiethoadon`
--

DROP TABLE IF EXISTS `chitiethoadon`;
CREATE TABLE IF NOT EXISTS `chitiethoadon` (
  `MaSanPham` int NOT NULL,
  `MaDonHang` int NOT NULL,
  `SoLuong` int NOT NULL,
  PRIMARY KEY (`MaSanPham`,`MaDonHang`),
  KEY `MaDonHang` (`MaDonHang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `chitiethoadon`
--

INSERT INTO `chitiethoadon` (`MaSanPham`, `MaDonHang`, `SoLuong`) VALUES
(1, 1, 2),
(2, 1, 3),
(3, 2, 5);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chucvu`
--

DROP TABLE IF EXISTS `chucvu`;
CREATE TABLE IF NOT EXISTS `chucvu` (
  `MaChucVu` int NOT NULL AUTO_INCREMENT,
  `TenChucVu` varchar(255) NOT NULL,
  PRIMARY KEY (`MaChucVu`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `chucvu`
--

INSERT INTO `chucvu` (`MaChucVu`, `TenChucVu`) VALUES
(1, 'Nhân Viên Tạp Vụ'),
(2, 'Nhân Viên Bảo Vệ'),
(3, 'Nhân Viên Bán Hàng'),
(4, 'Nhân Viên Phục Vụ'),
(5, 'Nhân Viên Pha Chế'),
(6, 'Trưởng Ca'),
(7, 'Quản Lý Cửa Hàng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `donhang`
--

DROP TABLE IF EXISTS `donhang`;
CREATE TABLE IF NOT EXISTS `donhang` (
  `MaDonHang` int NOT NULL AUTO_INCREMENT,
  `NgayLapHoaDon` datetime NOT NULL,
  `ChiPhiKhac` float NOT NULL DEFAULT '0',
  `MaTK` int DEFAULT NULL,
  `MaPTTT` int DEFAULT NULL,
  `MaTrangThaiDH` int DEFAULT NULL,
  PRIMARY KEY (`MaDonHang`),
  KEY `MaTK` (`MaTK`),
  KEY `MaPTTT` (`MaPTTT`),
  KEY `MaTrangThaiDH` (`MaTrangThaiDH`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `donhang`
--

INSERT INTO `donhang` (`MaDonHang`, `NgayLapHoaDon`, `ChiPhiKhac`, `MaTK`, `MaPTTT`, `MaTrangThaiDH`) VALUES
(1, '2025-04-01 00:00:00', 5000, 1, 2, 1),
(2, '2025-04-02 00:00:00', 6000, 2, 1, 2),
(3, '2025-04-03 00:00:00', 7000, 1, 1, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaisanpham`
--

DROP TABLE IF EXISTS `loaisanpham`;
CREATE TABLE IF NOT EXISTS `loaisanpham` (
  `MaLoaiSanPham` int NOT NULL AUTO_INCREMENT,
  `TenLoaiSanPham` varchar(255) NOT NULL,
  PRIMARY KEY (`MaLoaiSanPham`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `loaisanpham`
--

INSERT INTO `loaisanpham` (`MaLoaiSanPham`, `TenLoaiSanPham`) VALUES
(1, 'CÀ PHÊ'),
(2, 'FREEZE'),
(3, 'TRÀ'),
(4, 'CÀ PHÊ ĐẶC BIỆT'),
(5, 'KHÁC');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phuongthucthanhtoan`
--

DROP TABLE IF EXISTS `phuongthucthanhtoan`;
CREATE TABLE IF NOT EXISTS `phuongthucthanhtoan` (
  `MaPTTT` int NOT NULL AUTO_INCREMENT,
  `TenPhuongThuc` varchar(100) NOT NULL,
  PRIMARY KEY (`MaPTTT`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `phuongthucthanhtoan`
--

INSERT INTO `phuongthucthanhtoan` (`MaPTTT`, `TenPhuongThuc`) VALUES
(1, 'Tiền mặt'),
(2, 'Chuyển khoản');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `sanpham`
--

DROP TABLE IF EXISTS `sanpham`;
CREATE TABLE IF NOT EXISTS `sanpham` (
  `MaSanPham` int NOT NULL AUTO_INCREMENT,
  `TenSanPham` varchar(255) NOT NULL,
  `GiaSP` decimal(10,2) NOT NULL,
  `MaLoaiSanPham` int DEFAULT NULL,
  PRIMARY KEY (`MaSanPham`),
  KEY `MaLoaiSanPham` (`MaLoaiSanPham`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `sanpham`
--

INSERT INTO `sanpham` (`MaSanPham`, `TenSanPham`, `GiaSP`, `MaLoaiSanPham`) VALUES
(1, 'Bánh mì', 55000.00, 2),
(2, 'Classic Phin Freeze', 55000.00, 2),
(3, 'Freeze Trà Xanh', 55000.00, 2),
(4, 'Cookies & Cream', 55000.00, 2),
(5, 'Freeze Sô-cô-la', 55000.00, 2),
(6, 'Cold Brew Đào', 79000.00, 4),
(7, 'Cold Brew', 69000.00, 4),
(8, 'Bạc Xỉu Culi', 55000.00, 4),
(9, 'Phin Culi Sữa Đá', 55000.00, 4),
(10, 'Phin Culi Đen Đá', 49000.00, 4),
(11, 'Citrus coffee detonic', 49000.00, 4),
(12, 'Cold Brew Milk Foam', 79000.00, 4),
(13, 'Trà Thạch Đào', 45000.00, 3),
(14, 'Trà Thanh Đào', 45000.00, 3),
(15, 'Trà Sen Vàng (Củ Năng)', 45000.00, 3),
(16, 'Trà Thạch Chanh Leo', 45000.00, 3),
(17, 'Trà Thạch Chanh Dây', 45000.00, 3),
(18, 'Trà Thạch Cam', 45000.00, 3),
(19, 'Trà Thạch Chanh', 45000.00, 3),
(20, 'Trà Thạch Kiwi', 45000.00, 3),
(21, 'Trà Thạch Dưa Hấu', 45000.00, 3),
(22, 'Trà Thạch Nho', 45000.00, 3),
(23, 'Trà Thạch Dâu', 45000.00, 3),
(24, 'Trà Sen Vàng (Sen)', 45000.00, 3),
(25, 'Trà Xanh Đậu Đỏ', 45000.00, 3),
(26, 'Trà Thạch Vải', 45000.00, 3);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `taikhoan`
--

DROP TABLE IF EXISTS `taikhoan`;
CREATE TABLE IF NOT EXISTS `taikhoan` (
  `MaTK` int NOT NULL AUTO_INCREMENT,
  `HovaTen` varchar(255) NOT NULL,
  `TenTaiKhoan` varchar(255) NOT NULL,
  `MatKhau` varchar(255) NOT NULL,
  `GioiTinh` tinyint(1) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `MaChucVu` int DEFAULT NULL,
  PRIMARY KEY (`MaTK`),
  UNIQUE KEY `TenTaiKhoan` (`TenTaiKhoan`),
  UNIQUE KEY `UQ_TAIKHOAN_Email` (`Email`),
  KEY `MaChucVu` (`MaChucVu`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `taikhoan`
--

INSERT INTO `taikhoan` (`MaTK`, `HovaTen`, `TenTaiKhoan`, `MatKhau`, `GioiTinh`, `Email`, `MaChucVu`) VALUES
(1, 'ccvrcvrvcrfv', 'nguyenvfvf', '123456', 1, 'a@gmail.com', 1),
(2, 'Tvfvf', 'vfvfv', '123456', 0, 'b@gmail.com', 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `trangthaidonhang`
--

DROP TABLE IF EXISTS `trangthaidonhang`;
CREATE TABLE IF NOT EXISTS `trangthaidonhang` (
  `MaTrangThaiDH` int NOT NULL AUTO_INCREMENT,
  `TenTrangThai` varchar(50) NOT NULL,
  PRIMARY KEY (`MaTrangThaiDH`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Đang đổ dữ liệu cho bảng `trangthaidonhang`
--

INSERT INTO `trangthaidonhang` (`MaTrangThaiDH`, `TenTrangThai`) VALUES
(1, 'Chưa Thanh Toán'),
(2, 'Đã Thanh Toán');

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chitiethoadon`
--
ALTER TABLE `chitiethoadon`
  ADD CONSTRAINT `chitiethoadon_ibfk_1` FOREIGN KEY (`MaDonHang`) REFERENCES `donhang` (`MaDonHang`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `chitiethoadon_ibfk_2` FOREIGN KEY (`MaSanPham`) REFERENCES `sanpham` (`MaSanPham`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Các ràng buộc cho bảng `donhang`
--
ALTER TABLE `donhang`
  ADD CONSTRAINT `DONHANG_ibfk_1` FOREIGN KEY (`MaTK`) REFERENCES `taikhoan` (`MaTK`),
  ADD CONSTRAINT `DONHANG_ibfk_2` FOREIGN KEY (`MaPTTT`) REFERENCES `phuongthucthanhtoan` (`MaPTTT`),
  ADD CONSTRAINT `DONHANG_ibfk_3` FOREIGN KEY (`MaTrangThaiDH`) REFERENCES `trangthaidonhang` (`MaTrangThaiDH`);

--
-- Các ràng buộc cho bảng `sanpham`
--
ALTER TABLE `sanpham`
  ADD CONSTRAINT `sanpham_ibfk_1` FOREIGN KEY (`MaLoaiSanPham`) REFERENCES `loaisanpham` (`MaLoaiSanPham`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Các ràng buộc cho bảng `taikhoan`
--
ALTER TABLE `taikhoan`
  ADD CONSTRAINT `TAIKHOAN_ibfk_1` FOREIGN KEY (`MaChucVu`) REFERENCES `chucvu` (`MaChucVu`);
COMMIT;

DELIMITER $$

CREATE PROCEDURE GetSanphamsByLoaiSanPham(IN maLoaiSanPham INT)
BEGIN
    SELECT * 
    FROM Sanpham 
    WHERE MaLoaiSanPham = maLoaiSanPham;
END$$

DELIMITER ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
