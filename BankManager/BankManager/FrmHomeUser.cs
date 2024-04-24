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
using BankManager.ChucNang;
using BankManager.ChucNang.RutTien;
using BankManager.ChucNang.ThongTinCaNhan;
using BankManager.ChucNang.NewFolder1.DoiMatKhau;
using BankManager.ChucNang.TaiKhoanKyHan;

namespace BankManager
{
    public partial class FrmHomeUser : Form
    {
        private TaiKhoan tkDN = Global.getTaiKhoanDangNhap();

        public FrmHomeUser()
        {
            InitializeComponent();
        }

        private void FrmHomeUser_Load(object sender, EventArgs e)
        {
            label_KHDN.Text = tkDN.KhachHang.HoTen;
            label_SoTK.Text = tkDN.SoTK;
            label_SoDu.Text = ""+tkDN.SoTien;
        }

        private void button_ChuyenKhoan_Click(object sender, EventArgs e)
        {
            FrmChuyenKhoan frmChuyenKhoan = new FrmChuyenKhoan();
            this.Hide();
            frmChuyenKhoan.ShowDialog();
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            Global.setTaiKhoanDangNhap(null);

            this.Hide();
            frmHome.ShowDialog();
        }

        private void button_NapTien_Click(object sender, EventArgs e)
        {
            FrmNapTien frmNapTien = new FrmNapTien();
            this.Hide();
            frmNapTien.ShowDialog();
        }

        private void button_RutTien_Click(object sender, EventArgs e)
        {
            FrmRutTien frmRutTien = new FrmRutTien();
            this.Hide();
            frmRutTien.ShowDialog();
        }

        private void button_DoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromDoiMK frmDoiMK = new FromDoiMK();
            frmDoiMK.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmThongTinCaNhan frmTTCN = new FrmThongTinCaNhan();
            frmTTCN.ShowDialog();
        }

        private void NguyenHongKhang_07_btnTKKH_Click(object sender, EventArgs e)
        {
            FrmHomeKH frmHomeKH = new FrmHomeKH();
            this.Hide();
            frmHomeKH.ShowDialog();
        }
    }
}
