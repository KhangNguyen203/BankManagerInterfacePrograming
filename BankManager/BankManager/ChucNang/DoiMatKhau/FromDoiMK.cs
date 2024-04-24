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


namespace BankManager.ChucNang.NewFolder1.DoiMatKhau
{
    public partial class FromDoiMK : Form
    {
        private TaiKhoan tkDN = Global.getTaiKhoanDangNhap();
        private QuanLyTaiKhoan qltk = Global.QLTK(); 

        public FromDoiMK()
        {
            InitializeComponent();
        }
      
        private void NguyenHongKhang_07_btnDoiMK_Click(object sender, EventArgs e)
        {
            string mkCu = NguyenHongKhang_07_txtMKCu.Text;
            string mkMoi = NguyenHongKhang_07_txtMKMoi.Text;
            string xnMK = NguyenHongKhang_07_txtXNMK.Text;

            if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(xnMK))
            {
                MessageBox.Show("Không được để trống các trường!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mkMoi.Equals(xnMK) == false)
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else {
                    string tb = this.qltk.DoiMK(this.tkDN, mkCu, mkMoi);
                    MessageBox.Show(tb);

                    FrmHomeUser frmUS = new FrmHomeUser();
                    this.Hide();
                    frmUS.ShowDialog();
                }
            }
        }
    }
}
