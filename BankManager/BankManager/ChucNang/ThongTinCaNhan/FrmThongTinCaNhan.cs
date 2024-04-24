using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManager.Lop;

namespace BankManager.ChucNang.ThongTinCaNhan
{
    public partial class FrmThongTinCaNhan : Form
    {
        private TaiKhoan tkDN = Global.getTaiKhoanDangNhap();

        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            NguyenHongKhang_07_lblSTK.Text = tkDN.SoTK + " mật khẩu: "+ tkDN.Password;
            NguyenHongKhang_07_lblTien.Text = ""+tkDN.SoTien;
            NguyenHongKhang_07_lblQue.Text = tkDN.KhachHang.QueQuan;
            NguyenHongKhang_07_lblCCCD.Text = tkDN.KhachHang.SoCCCD;
            NguyenHongKhang_07_lblSDT.Text = tkDN.KhachHang.Sdt;
            NguyenHongKhang_07_lblTen.Text = tkDN.KhachHang.HoTen;
            NguyenHongKhang_07_lblGT.Text = tkDN.KhachHang.GioiTinh;
            NguyenHongKhang_07_lblNS.Text = tkDN.KhachHang.NgaySinh;
        
        }
    }
}
