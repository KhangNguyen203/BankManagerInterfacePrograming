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
using BankManager.ChucNang.ChuyenKhoan;

namespace BankManager.ChucNang
{
    public partial class FrmChuyenKhoan : Form
    {
        private TaiKhoan tkDN = Global.getTaiKhoanDangNhap();

        public FrmChuyenKhoan()
        {
            InitializeComponent();
        }

        private void FrmChuyenKhoan_Load(object sender, EventArgs e)
        {
        }

        private void button_TiepTuc_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = Global.QLTK().layTKTheoSTK(TextBox_SoTK.Text);
            if (tk == null)
            {
                label_Loi.Text = "Số tài khoản không hợp lệ!";
            }
            else {
                if (int.Parse(textBox_Tien.Text) < 2000) {
                    label_Loi.Text = "Số tiền tối thiểu là 2.000VNĐ!";
                    return;
                }

                if ((tkDN.SoTien - int.Parse(textBox_Tien.Text)) < 0)
                {
                    label_Loi.Text = "Số tiền trong tài khoản không đủ!";
                    return;
                }

                FrmXacNhan frmXacNhan = new FrmXacNhan();
      
                frmXacNhan.TK = tk;
                frmXacNhan.Tien = textBox_Tien.Text;

                this.Hide();
                frmXacNhan.ShowDialog();
            }
        }
    }
}
