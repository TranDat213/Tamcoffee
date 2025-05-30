using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamCoffee.Models;
using TamCoffee.Models.Server;

namespace TamCoffee.Dao
{
    public class HoaDonDao
    {
        HoaDonTam hdtam = new HoaDonTam();
        private static TAMCOFFEEContext _context;
        public HoaDonDao()
        {
            _context = new TAMCOFFEEContext();
        }
        public List<Donhang> GetAllHoaDon()
        {
            try
            {
                return _context.Donhangs
                       .Include(d => d.MaTkNavigation)
                       .Include(d => d.MaPtttNavigation)
                       .Include(d => d.MaTrangThaiDhNavigation)
                       .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách hóa đơn!");
            }
        }
        public bool AddHoaDon(Donhang hoadon)
        {
            try
            {
                _context.Donhangs.Add(hoadon);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm hóa đơn: {ex.Message}");
            }
        }
        public bool AddChiTiethoaDon(Donhang donhang, Chitiethoadon chitiet)
        {
            try
            {
                // Thêm chi tiết hóa đơn vào hóa đơn
                donhang.Chitiethoadons.Add(chitiet);
                // Cập nhật hóa đơn
                _context.Donhangs.Update(donhang);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm chi tiết hóa đơn: {ex.Message}");
            }
        }
        public bool DeleteHoaDon(int mahd)
        {
            try
            {
                var hoadon = _context.Donhangs.FirstOrDefault(h => h.MaDonHang == mahd);
                if (hoadon != null)
                {
                    _context.Donhangs.Remove(hoadon);
                    return _context.SaveChanges() > 0;
                }
                else
                {
                    throw new Exception("Hóa đơn không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa hóa đơn: {ex.Message}");
            }
        }
        public List<Donhang> TimDonHangTheoNgay(DateTime ngay)
        {
            try
            {
                return _context.Donhangs
                               .Where(d => d.NgayLapHoaDon.Date == ngay.Date)
                               .Include(d => d.MaTkNavigation) // nếu cần thông tin tài khoản
                               .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm đơn hàng theo ngày: {ex.Message}");
            }
        }
        public List<Donhang> TimDonHangTheoTK(int matk)
        {
            try
            {
                return _context.Donhangs
                               .Where(d => d.MaTk == matk)
                               .Include(d => d.MaTkNavigation) // nếu cần thông tin tài khoản
                               .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm đơn hàng theo mã tài khoản: {ex.Message}");
            }
        }



        //public Donhang LuuHDTVaoDatabase(List<Chitiethoadon> chittiets, int chiphikhac=0, int maTk = 1, int maPtt = 1, int matt = 1)
        //{
        //    try
        //    {
        //        Console.WriteLine($"Đang lưu {chittiets.Count} chi tiết vào database");
        //        Donhang dh = new Donhang
        //        {
        //            NgayLapHoaDon = DateTime.Now,
        //            Chitiethoadons = new List<Chitiethoadon>(),
        //            ChiPhiKhac = chiphikhac,
        //            MaTk = maTk,
        //            MaPttt = maPtt,
        //            MaTrangThaiDh = matt

        //        };
        //        _context.Donhangs.Add(dh);
        //        _context.SaveChanges() ;
        //        Console.WriteLine($"Đã tạo hóa đơn mới với mã: {dh.MaDonHang}");
        //        foreach (var ct in chittiets)
        //        {
        //            var newChitiet = new Chitiethoadon(ct.MaSanPham, dh.MaDonHang, ct.SoLuong);

        //            _context.Chitiethoadons.Add(newChitiet);
        //            Console.WriteLine($"Đã thêm chi tiết: SP={ct.MaSanPham}, SL={ct.SoLuong}");
        //        }
        //        _context.SaveChanges();
        //        Console.WriteLine("Đã lưu tất cả chi tiết hóa đơn.");

        //        // Đảm bảo tất cả dữ liệu được load đầy đủ từ database
        //        _context.ChangeTracker.Clear(); // Xóa đối tượng đang theo dõi để tải lại từ đầu

        //        // Tải lại đơn hàng đầy đủ từ database
        //        var completeOrder = _context.Donhangs
        //            .Include(d => d.MaTkNavigation)
        //            .Include(d => d.MaPtttNavigation)
        //            .Include(d => d.MaTrangThaiDhNavigation)
        //            .Include(d => d.Chitiethoadons)
        //            .ThenInclude(ct => ct.MaSanPhamNavigation)
        //            .FirstOrDefault(d => d.MaDonHang == dh.MaDonHang);

        //        if (completeOrder != null)
        //        {
        //            Console.WriteLine($"Đã tải lại hóa đơn {completeOrder.MaDonHang} với {completeOrder.Chitiethoadons.Count} chi tiết.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Không tìm thấy hóa đơn vừa tạo khi tải lại!");
        //        }
        //        return completeOrder?? dh;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
        //    }
        //}

        public Donhang LuuHDTVaoDatabase(List<Chitiethoadon> chittiets, int chiphikhac = 0, int maTk = 1, int maPtt = 1, int matt = 1)
        {
            try
            {
                Console.WriteLine($"HoaDonDao: Bắt đầu lưu {chittiets.Count} chi tiết hóa đơn vào database.");

                // Kiểm tra xem có chi tiết hóa đơn không
                if (chittiets == null || chittiets.Count == 0)
                {
                    throw new Exception("Không có chi tiết hóa đơn để lưu!");
                }

                // Tạo hóa đơn mới
                Donhang dh = new Donhang
                {
                    NgayLapHoaDon = DateTime.Now,
                    Chitiethoadons = new List<Chitiethoadon>(), // Khởi tạo danh sách rỗng
                    ChiPhiKhac = chiphikhac,
                    MaTk = maTk,
                    MaPttt = maPtt,
                    MaTrangThaiDh = matt
                };

                // Thêm hóa đơn vào context và lưu để có mã đơn hàng
                _context.Donhangs.Add(dh);
                int result1 = _context.SaveChanges();
                Console.WriteLine($"HoaDonDao: Đã tạo hóa đơn mới với mã: {dh.MaDonHang}, kết quả lưu: {result1}");

                // Tạo và thêm các chi tiết hóa đơn
                List<Chitiethoadon> newChiTiets = new List<Chitiethoadon>();
                foreach (var ct in chittiets)
                {
                    // Tạo chi tiết mới thay vì dùng chi tiết hiện có
                    var newChiTiet = new Chitiethoadon
                    {
                        MaSanPham = ct.MaSanPham,
                        MaDonHang = dh.MaDonHang,
                        SoLuong = ct.SoLuong
                    };

                    newChiTiets.Add(newChiTiet);
                    dh.Chitiethoadons.Add(newChiTiet); // Thêm vào danh sách của đơn hàng
                    _context.Chitiethoadons.Add(newChiTiet); // Thêm vào DbContext
                   
                }

                // Lưu tất cả chi tiết vào database
                int result2 = _context.SaveChanges();
                //Console.WriteLine($"HoaDonDao: Đã lưu {result2} chi tiết hóa đơn vào database.");

                // Đếm trực tiếp số lượng chi tiết để kiểm tra
                var countCheck = _context.Chitiethoadons.Count(c => c.MaDonHang == dh.MaDonHang);
                //Console.WriteLine($"HoaDonDao: Kiểm tra - Số lượng chi tiết của đơn hàng {dh.MaDonHang} trong DB: {countCheck}");

                if (countCheck != chittiets.Count)
                {
                    Console.WriteLine("HoaDonDao: CẢNH BÁO - Số lượng chi tiết không khớp với số lượng đã thêm!");
                }

                // Đảm bảo tất cả dữ liệu được load đầy đủ từ database
                _context.ChangeTracker.Clear(); // Xóa đối tượng đang theo dõi để tải lại từ đầu

                // Tải lại đơn hàng đầy đủ từ database với AsNoTracking để tránh xung đột
                var completeOrder = _context.Donhangs
                    .AsNoTracking()
                    .Include(d => d.MaTkNavigation)
                    .Include(d => d.MaPtttNavigation)
                    .Include(d => d.MaTrangThaiDhNavigation)
                    .Include(d => d.Chitiethoadons)
                    .ThenInclude(ct => ct.MaSanPhamNavigation)
                    .FirstOrDefault(d => d.MaDonHang == dh.MaDonHang);

                if (completeOrder != null)
                {
                    int detailCount = completeOrder.Chitiethoadons?.Count ?? 0;
                    //Console.WriteLine($"HoaDonDao: Đã tải lại hóa đơn {completeOrder.MaDonHang} với {detailCount} chi tiết.");

                    // Tải lại chi tiết hóa đơn để đảm bảo dữ liệu đầy đủ
                    if (countCheck > 0)
                    {
                        //Console.WriteLine("HoaDonDao: Tải trực tiếp chi tiết hóa đơn từ database...");
                        // Truy vấn trực tiếp vào bảng chi tiết
                        var details = _context.Chitiethoadons
                            .AsNoTracking()
                            .Where(c => c.MaDonHang == dh.MaDonHang)
                            .ToList();

                        //Console.WriteLine($"HoaDonDao: Đã tải trực tiếp {details.Count} chi tiết.");
                        completeOrder.Chitiethoadons = details;
                    }
                }
                else
                {
                    Console.WriteLine("HoaDonDao: Không tìm thấy hóa đơn vừa tạo khi tải lại!");
                    // Trả về đối tượng đơn hàng gốc nếu không tìm thấy
                    return dh;
                }

                return completeOrder;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"HoaDonDao Exception: {ex.Message}\n{ex.StackTrace}");
                throw new Exception($"Lỗi khi lưu hóa đơn vào database: {ex.Message}");
            }
        }
    }
    }
