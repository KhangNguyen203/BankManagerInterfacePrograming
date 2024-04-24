using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager.ChucNang.RutTien
{
    public partial class FrmRutTien : Form
    {
        public FrmRutTien()
        {
            InitializeComponent();
        }


        private void button_NapTien_Click(object sender, EventArgs e)
        {
            int tien;
            bool isNumeric = int.TryParse(TextBox_Tien.Text, out tien);

            if (isNumeric)
            {
                if (tien < 50000)
                {
                    label_Loi.Text = "Nạp ít nhất 50.000VNĐ!";
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Global.getTaiKhoanDangNhap().SoTien -= tien;
                    MessageBox.Show("Rút tiền thành công.");

                    FrmHomeUser frmHomeUser = new FrmHomeUser();
                    this.Hide();
                    frmHomeUser.ShowDialog();
                }
            }
            else
            {
                label_Loi.Text = "Vui lòng nhập số!";
            }
        }
    }
}
