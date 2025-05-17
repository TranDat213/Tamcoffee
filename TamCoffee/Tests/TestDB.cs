using Microsoft.EntityFrameworkCore;
using TamCoffee.Dao;
using TamCoffee.Models;
using TamCoffee.Models.Server;
namespace TamCoffee.Tests
{
    public class testDB
    {
        public static void showInfo()
        {
            //Update<OutputType> Exe</ OutputType > => console


            using TAMCOFFEEContext dbcontext = new TAMCOFFEEContext();
            //Console.WriteLine("CSDL: " + dbcontext.Database.GetDbConnection().Database);
            MessageBox.Show($"{dbcontext.Database.GetDbConnection().Database}");
        }
        public static void joinSanphamLoaisanpham(int MaSanPham)
        {
            using TAMCOFFEEContext dbcontext = new TAMCOFFEEContext();
            var sanpham = (from sp in dbcontext.Sanphams
                           join lsp in dbcontext.Loaisanphams on sp.MaLoaiSanPham equals lsp.MaLoaiSanPham
                           where sp.MaSanPham == MaSanPham
                           select new { sp, lsp }).FirstOrDefault();
            if (sanpham != null)
            {
                MessageBox.Show(sanpham.sp.printinfo());
                MessageBox.Show(sanpham.lsp.printinfo());
            }
        }
        public static async Task readTnSanpham()
        {
            using TAMCOFFEEContext dbcontext = new TAMCOFFEEContext();
            var sanpham = await dbcontext.Sanphams
                                 .Where(sp => sp.MaSanPham == 1)
                                 .FirstOrDefaultAsync();
            if (sanpham != null)
            {
                sanpham.printinfo();
                sanpham.TenSanPham = "Bánh mì";
                Console.Write($" so dong cap nhat {dbcontext.SaveChanges()})");
                MessageBox.Show(sanpham.printinfo());
            }
        }

        public static void readLoaiSP()
        {
            LoaiSanPhamDao ls = new LoaiSanPhamDao();
            foreach (var loai in ls.LayTatCaLoai())
            {
                string message = $"{loai.TenLoaiSanPham} (ID: {loai.MaLoaiSanPham})\n";
                message += "Danh sách sản phẩm:\n";

                if (loai.Sanphams.Any())
                    message += string.Join("\n", loai.Sanphams.Select(sp => $" - {sp.TenSanPham} -{sp.GiaSp} -{sp.MaLoaiSanPhamNavigation}"));
                else
                    message += " - (Không có sp)";

                MessageBox.Show(message);
            }
        }
        public static void deleteSP(int ma)
        {
            try
            {
                SanphamDao spd = new SanphamDao();
                spd.DeleteSanpham(ma);
                MessageBox.Show("Xoa thanh cong");
            }
            catch(Exception e)
            {
                MessageBox.Show($"{e.Message}");
            }
        }
    }
}