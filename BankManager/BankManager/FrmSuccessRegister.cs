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
    public partial class FrmSuccessRegister : Form
    {
        private TaiKhoan tk;

        public FrmSuccessRegister()
        {
            InitializeComponent();
        }


        public TaiKhoan TK
        {
            get { return this.tk; }
            set { this.tk = value; }
        }


        private void FrmSuccessRegister_Load(object sender, EventArgs e)
        {
            label_KH.Text = tk.KhachHang.HoTen;
            label_SoTK.Text = tk.SoTK;
            label_SDT.Text = tk.KhachHang.Sdt;
            label_DC.Text = tk.KhachHang.QueQuan;
            label_MK.Text = tk.Password;
            label_NT.Text = "" + tk.NgayTao;
            label_Tien.Text = "" + tk.SoTien;
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }
    }
}
