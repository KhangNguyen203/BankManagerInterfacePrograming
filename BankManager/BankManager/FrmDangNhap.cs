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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }   

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            //TaiKhoan tkdn = qltk.DangNhap(TextBox_UserName.Text, TextBox_Password.Text);
            TaiKhoan tkdn = Global.QLTK().DangNhap(TextBox_UserName.Text, TextBox_Password.Text);


            if (tkdn == null)
            {
                TextBox_UserName.Text = "";
                TextBox_Password.Text = "";

                label4.Text = "Thông tin đăng nhập không hợp lệ!!";
            }
            else
            {
                TextBox_UserName.Text = "";
                TextBox_Password.Text = "";

                label4.Text = "Đăng nhập thành công";

                Global.setTaiKhoanDangNhap(tkdn); 

                FrmHomeUser frmHomeUser = new FrmHomeUser();
                this.Hide();
                frmHomeUser.ShowDialog();
            }
        }
    }
}
