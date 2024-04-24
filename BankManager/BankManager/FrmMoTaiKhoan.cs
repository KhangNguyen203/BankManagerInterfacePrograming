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

namespace BankManager
{
    public partial class FrmMoTaiKhoan : Form
    {
        public FrmMoTaiKhoan()
        {
            InitializeComponent();
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            int tien; 

            if (string.IsNullOrWhiteSpace(textBox_HoTen.Text) ||
                string.IsNullOrWhiteSpace(textBox_GioiTinh.Text) ||
                string.IsNullOrWhiteSpace(textBox_NgaySinh.Text) ||
                string.IsNullOrWhiteSpace(textBox_QueQuan.Text) ||
                string.IsNullOrWhiteSpace(textBox_SDT.Text) ||
                string.IsNullOrWhiteSpace(textBox_CCCD.Text) ||
                string.IsNullOrWhiteSpace(textBox_Tien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!int.TryParse(textBox_Tien.Text, out tien))
            {
                label_Note.Text = "Số tiền nhập vào không hợp lệ!";
                return;
            }
            label_Note.Text = "";

            if (tien < 50000)
            {
                label_Note.Text = "Số tiền nhập vào không hợp lệ!";
                return;
            }
            label_Note.Text = "";

            KhachHang kh = new KhachHang();

            kh.HoTen = textBox_HoTen.Text;
            kh.GioiTinh = textBox_GioiTinh.Text;
            kh.NgaySinh = textBox_NgaySinh.Text;
            kh.QueQuan = textBox_QueQuan.Text;
            kh.Sdt = textBox_SDT.Text;
            kh.SoCCCD = textBox_CCCD.Text;
            kh.Active = true;

            TaiKhoan tk = new TaiKhoan(kh, tien);
            tk.Password = TaiKhoan.TaoMatKhauNgauNhien(6);

            Global.QLKH().ThemKhachHang(kh);
            Global.QLTK().ThemAccount(tk);

            FrmSuccessRegister frmSuccessRegister = new FrmSuccessRegister();
            frmSuccessRegister.TK = tk;

            this.Hide();
            frmSuccessRegister.ShowDialog();
        }

        private void label_DangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            this.Hide();
            frmDangNhap.ShowDialog();
        }
    }
}
