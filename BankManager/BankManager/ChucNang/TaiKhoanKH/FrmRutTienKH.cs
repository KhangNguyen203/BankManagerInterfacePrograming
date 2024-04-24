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
using System.Text.RegularExpressions;


namespace BankManager.ChucNang.TaiKhoanKH
{
    public partial class FrmRutTienKH : Form
    {
        private TaiKhoan tkdn = Global.getTaiKhoanDangNhap();

        public FrmRutTienKH()
        {
            InitializeComponent();
        }

        private void FrmRutTienKH_Load(object sender, EventArgs e)
        {
            int so = 1;
            NguyenHongKhang_07_lblTen.Text = this.tkdn.KhachHang.HoTen;
            NguyenHongKhang_07_lblSoTK.Text = this.tkdn.SoTK;
            NguyenHongKhang_07_lblSoDu.Text = this.tkdn.SoTien + "";

            //Lấy danh sách tài khoản kỳ hạn 
            List<Account> ds = Global.QLTK().layDSTKKyHanTheoSTK(tkdn.SoTK);


            // Đặt cấu hình cho ListView
            NguyenHongKhang_07_listView.View = View.Details;
            NguyenHongKhang_07_listView.FullRowSelect = true;

            // Tạo các cột cho ListView
            NguyenHongKhang_07_listView.Columns.Add("STT", 50);
            NguyenHongKhang_07_listView.Columns.Add("Số tài khoản", 100);
            NguyenHongKhang_07_listView.Columns.Add("Kỳ hạn", 70);
            NguyenHongKhang_07_listView.Columns.Add("Ngày đáo hạn", 80);

            // Hiển thị dữ liệu trong ListView
            foreach (TaiKhoanCoKyHan tk in ds)
            {
                ListViewItem item = new ListViewItem(so + "");
                item.SubItems.Add(tk.SoTK);
                item.SubItems.Add(tk.KyHan);
                item.SubItems.Add(tk.NgayDaoHan.ToString("dd/MM/yyyy"));
                NguyenHongKhang_07_listView.Items.Add(item);
                so++;
            }

            NguyenHongKhang_07_listView.SelectedIndexChanged += NguyenHongKhang_07_listView_SelectedIndexChanged;
        }

        private void NguyenHongKhang_07_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (NguyenHongKhang_07_listView.SelectedItems.Count > 0)
            {
                // Lấy hàng được chọn
                ListViewItem selectedItem = NguyenHongKhang_07_listView.SelectedItems[0];

                // Lấy giá trị từ các cột của hàng được chọn và gán 
                string soTK = selectedItem.SubItems[1].Text;
                NguyenHongKhang_07_txtSTK.Text = soTK;
            }
        }

        private void NguyenHongKhang_07_btnRut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NguyenHongKhang_07_txtSTK.Text) || string.IsNullOrWhiteSpace(NguyenHongKhang_07_txtTien.Text))
                NguyenHongKhang_07_lblLoi.Text = "Vui lòng điền đầy đủ dữ liệu!";
            else
            {
                //tìm tài khoản KH và gán vào biến tk
                TaiKhoanCoKyHan tk = (TaiKhoanCoKyHan)Global.QLTK().layTKKyHanTheoSTK(NguyenHongKhang_07_txtSTK.Text);

                if (tk == null)
                    NguyenHongKhang_07_lblLoi.Text = "Số tài khoản không tồn tại!";
                else
                {
                    if (Regex.IsMatch(NguyenHongKhang_07_txtTien.Text, "[a-zA-Z]"))
                    {
                        NguyenHongKhang_07_lblLoi.Text = "Vui lòng nhập số tiền!";
                        return;
                    }

                    if (tk.NgayDaoHan != DateTime.Today)
                        MessageBox.Show("Tài khoản chưa đến ngày đáo hạn!");
                    else {
                        //Tài khoản đang trong ngày đáo hạn
                        tk.SoTien -= int.Parse(NguyenHongKhang_07_txtTien.Text);
                        tkdn.SoTien += int.Parse(NguyenHongKhang_07_txtTien.Text);
                        MessageBox.Show(string.Format("Bạn đã rút {0}VNĐ từ tài khoản {1}", NguyenHongKhang_07_txtTien.Text, NguyenHongKhang_07_txtSTK.Text));
                        chuyenTrang();
                    }
                }
            }
        }

        private void NguyenHongKhang_07_btnTroLai_Click(object sender, EventArgs e)
        {
            chuyenTrang();
        }

        private void chuyenTrang()
        {
            FrmHomeKH frmHomeKH = new FrmHomeKH();
            this.Hide();
            frmHomeKH.ShowDialog();
        }
    }
}
