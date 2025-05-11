using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matkhau;

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public TaiKhoan(string tenTaiKhoan,string matkhau ) {
            this.TenTaiKhoan= tenTaiKhoan;
            this.Matkhau= matkhau;
        }
    }
}
