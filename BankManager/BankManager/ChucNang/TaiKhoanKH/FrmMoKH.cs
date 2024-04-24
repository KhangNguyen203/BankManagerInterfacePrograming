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
using BankManager.ChucNang.TaiKhoanKyHan;

namespace BankManager.ChucNang.TaiKhoanKH
{
    public partial class FrmMoKH : Form
    {
        private TaiKhoan tkdn = Global.getTaiKhoanDangNhap();
        private TaiKhoanCoKyHan tk;

        public FrmMoKH()
        {
            InitializeComponent();
        }

        private void FrmMoKH_Load(object sender, EventArgs e)
        {
            NguyenHongKhang_07_lblTen.Text = this.tkdn.KhachHang.HoTen;
            NguyenHongKhang_07_lblSoTK.Text = this.tkdn.SoTK;
            NguyenHongKhang_07_lblSoDu.Text = this.tkdn.SoTien + "";
        }

        private void NguyenHongKhang_07_btnDY_Click(object sender, EventArgs e)
        {
            string tien = NguyenHongKhang_07_txtTien.Text;
            bool containsLetters = tien.Any(char.IsLetter);

            if (string.IsNullOrEmpty(tien))
                NguyenHongKhang_07_lblLoi.Text = "Không được để trống!";
            else
                if (containsLetters)
                NguyenHongKhang_07_lblLoi.Text = "Vui lòng nhập số!";
            else
                if (int.Parse(tien) < 100000)
                NguyenHongKhang_07_lblLoi.Text = "Vui lòng nhập số tiền lớn hơn 100.000VNĐ!";
            else
                if (int.Parse(tien) > this.tkdn.SoTien)
                NguyenHongKhang_07_lblLoi.Text = "Số dư không đủ!";
            else {
                //Kiểm tra có click vào các radioButton không
                if (!NguyenHongKhang_07_rBtn1tuan.Checked && !NguyenHongKhang_07_rBtn1thang.Checked && !NguyenHongKhang_07_rBtn6thang.Checked && !NguyenHongKhang_07_rBtn1nam.Checked)
                    NguyenHongKhang_07_lblLoi2.Text = "Vui lòng chọn kỳ hạn!";
                else
                {
                    if (NguyenHongKhang_07_rBtn1tuan.Checked) {
                        this.tk = new TaiKhoanCoKyHan(int.Parse(tien), "1tuan", this.tkdn);
                        Global.QLTK().ThemAccount(this.tk);
                    }
                    if (NguyenHongKhang_07_rBtn1thang.Checked) {
                        this.tk = new TaiKhoanCoKyHan(int.Parse(tien), "1thang", this.tkdn);
                        Global.QLTK().ThemAccount(this.tk);
                    }
                    if (NguyenHongKhang_07_rBtn6thang.Checked) {
                        this.tk = new TaiKhoanCoKyHan(int.Parse(tien), "6thang", this.tkdn);
                        Global.QLTK().ThemAccount(this.tk);
                    }
                    if (NguyenHongKhang_07_rBtn1nam.Checked) {
                        this.tk = new TaiKhoanCoKyHan(int.Parse(tien), "1nam", this.tkdn);
                        Global.QLTK().ThemAccount(this.tk);
                    }

                    thongbao(this.tk);
                    HomeComBack();

                    //DialogResult result = MessageBox.Show("Bạn có chắc chắn không ?", "Xác nhận", MessageBoxButtons.YesNo);
                    //if (result == DialogResult.Yes)
                    //{
                    //    thongbao(this.tk);
                    //    HomeComBack();
                    //}
                }
            }
        }

        private void thongbao(TaiKhoanCoKyHan tk) {
            string hien = "Số tài khoản: " + tk.SoTK;
            hien += "\nLoại TK: Tài khoản kỳ hạn";
            hien += "\nSố dư (VNĐ): " + tk.SoTien;
            hien += "\nKhách hàng: " + tk.KhachHang.HoTen;
            hien += "\nKỳ hạn: " + tk.KyHan;
            hien += "\nNgày Đáo hạn: " + tk.NgayDaoHan.ToString("dd/MM/yyyy");

            MessageBox.Show(hien, "Mở tài khoản thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NguyenHongKhang_07_btnTroLai_Click(object sender, EventArgs e)
        {
            HomeComBack();
        }

        private void HomeComBack() {
            FrmHomeKH frmHomeKH = new FrmHomeKH();
            this.Hide();
            frmHomeKH.ShowDialog();
        }
    }
}
