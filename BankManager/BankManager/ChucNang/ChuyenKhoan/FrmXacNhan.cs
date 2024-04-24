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

namespace BankManager.ChucNang.ChuyenKhoan
{
    public partial class FrmXacNhan : Form
    {
        private string tien;
        private TaiKhoan tk;
        private TaiKhoan tkDN = Global.getTaiKhoanDangNhap();

        public string Tien {
            get { return this.tien; }
            set { this.tien = value; }
        }

        public TaiKhoan TK {
            get { return this.tk; }
            set { this.tk = value; }
        }

        public FrmXacNhan()
        {
            InitializeComponent();
        }

        private void FrmXacNhan_Load(object sender, EventArgs e)
        {
            label_SoTK.Text = tk.SoTK;
            label_KH.Text = tk.KhachHang.HoTen;
            label_Tien.Text = this.tien;
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            Global.QLTK().ChuyenKhoan(tkDN, tk, int.Parse(this.tien));

            MessageBox.Show("Chuyển khoản thành công.");

            FrmHomeUser frmHomeUser = new FrmHomeUser();
            this.Hide();
            frmHomeUser.ShowDialog();
        }
    }
}
