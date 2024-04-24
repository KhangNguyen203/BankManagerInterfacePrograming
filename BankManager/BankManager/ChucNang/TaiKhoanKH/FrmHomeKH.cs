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
using BankManager.ChucNang.TaiKhoanKH;

namespace BankManager.ChucNang.TaiKhoanKyHan
{
    public partial class FrmHomeKH : Form
    {
        private TaiKhoan tkdn = Global.getTaiKhoanDangNhap();

        public FrmHomeKH()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            NguyenHongKhang_07_lblTen.Text = this.tkdn.KhachHang.HoTen;
            NguyenHongKhang_07_lblSoTK.Text = this.tkdn.SoTK;
            NguyenHongKhang_07_lblSoDu.Text = this.tkdn.SoTien + "";
        }

        private void NguyenHongKhang_07_btnMo_Click(object sender, EventArgs e)
        {
            FrmMoKH frmMoKH = new FrmMoKH();
            this.Hide();
            frmMoKH.ShowDialog();
        }

        private void NguyenHongKhang_07_btnTroLai_Click(object sender, EventArgs e)
        {
            FrmHomeUser frmHomeU = new FrmHomeUser();
            this.Hide();
            frmHomeU.ShowDialog();
        }

        private void NguyenHongKhang_07_btnDS_Click(object sender, EventArgs e)
        {
            FrmDSTaiKhoanKH frmDSTKKH = new FrmDSTaiKhoanKH();
            this.Hide();
            frmDSTKKH.ShowDialog();
        }

        private void NguyenHongKhang_07_btnNap_Click(object sender, EventArgs e)
        {
            FrmNapTienKH frmNap = new FrmNapTienKH();
            this.Hide();
            frmNap.ShowDialog();
        }

        private void NguyenHongKhang_07_btnRut_Click(object sender, EventArgs e)
        {
            FrmRutTienKH frmRut = new FrmRutTienKH();
            this.Hide();
            frmRut.ShowDialog();
        }
    }
}
