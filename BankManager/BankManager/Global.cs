using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManager.Lop;

namespace BankManager
{
    class Global
    {
        private static QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
        private static QuanLyKhachHang qlkh = new QuanLyKhachHang();
        private static TaiKhoan taiKhoanDangNhap; 

        public static QuanLyKhachHang QLKH() {
            return qlkh;
        }
        public static QuanLyTaiKhoan QLTK() {
            return qltk;
        }
        public static TaiKhoan getTaiKhoanDangNhap() {
            return taiKhoanDangNhap;
        }
        public static void setTaiKhoanDangNhap(TaiKhoan tk)
        {
            taiKhoanDangNhap = tk;
        }
    }
}
