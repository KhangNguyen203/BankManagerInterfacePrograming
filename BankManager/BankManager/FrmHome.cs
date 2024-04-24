using System;
using System.Windows.Forms;
using BankManager.Lop;
using BankManager.ChucNang;

namespace BankManager
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            KhachHang kh1 = new KhachHang("Nguyen Hong Khang", "nam", "20/03/2002", "Binh Phuoc", "0123", "123");
            KhachHang kh2 = new KhachHang("Thu Phuong", "nu", "01/01/2002", "Binh Phuoc", "0124", "124");
            KhachHang kh3 = new KhachHang("Tran A", "nu", "01/01/2002", "Ho Chi Minh", "0125", "125");


            Account tk1 = new TaiKhoan(kh1, 2500000);
            tk1.Password = "123456";
            Account tk2 = new TaiKhoan(kh2, 3000000);
            tk2.Password = "123456";
            Account tk3 = new TaiKhoan(kh3, 3500000);

            TaiKhoanCoKyHan tkkh1 = new TaiKhoanCoKyHan(500000, "1thang", (TaiKhoan)tk1);
            TaiKhoanCoKyHan tkkh2 = new TaiKhoanCoKyHan(200000, "6thang", (TaiKhoan)tk1);
            //set ngày đáo hạn của tkkh2 là hôm nay
            tkkh2.NgayDaoHan = DateTime.Today;

            Global.QLTK().ThemAccount(tk1, tk2, tk3, tkkh1, tkkh2);
            Global.QLKH().ThemKhachHang(kh1, kh2, kh3);
        }

        private void button_MoTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMoTaiKhoan frmMTK = new FrmMoTaiKhoan();
            frmMTK.ShowDialog();

            //this.Show();
        }

        private void button_DichVu_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDN = new FrmDangNhap();
            this.Hide();
            frmDN.ShowDialog();
            //this.Show();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã sử dụng ứng dụng của chúng tôi");
            Application.Exit();
        }
    }
}