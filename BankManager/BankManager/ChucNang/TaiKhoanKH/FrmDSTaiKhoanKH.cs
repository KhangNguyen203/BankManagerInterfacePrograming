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
    public partial class FrmDSTaiKhoanKH : Form
    {
        private TaiKhoan tkdn = Global.getTaiKhoanDangNhap();

        public FrmDSTaiKhoanKH()
        {
            InitializeComponent();
        }

        private void FrmDSTaiKhoanKH_Load(object sender, EventArgs e)
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
            NguyenHongKhang_07_listView.Columns.Add("Số dư", 70);
            NguyenHongKhang_07_listView.Columns.Add("Kỳ hạn", 70);
            NguyenHongKhang_07_listView.Columns.Add("Ngày đáo hạn", 80);

            // Hiển thị dữ liệu trong ListView
            foreach (TaiKhoanCoKyHan tk in ds)
            {
                ListViewItem item = new ListViewItem(so+"");
                item.SubItems.Add(tk.SoTK);
                item.SubItems.Add(tk.SoTien+"VNĐ");
                item.SubItems.Add(tk.KyHan);
                item.SubItems.Add(tk.NgayDaoHan.ToString("dd/MM/yyyy"));
                NguyenHongKhang_07_listView.Items.Add(item);
                so++;
            }

            // Đăng ký sự kiện SelectedIndexChanged cho ListView
            NguyenHongKhang_07_listView.SelectedIndexChanged += NguyenHongKhang_07_listView_SelectedIndexChanged;
        }

        private void NguyenHongKhang_07_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng được chọn không
            if (NguyenHongKhang_07_listView.SelectedItems.Count > 0)
            {
                // Lấy hàng được chọn
                ListViewItem selectedItem = NguyenHongKhang_07_listView.SelectedItems[0];

                // Lấy giá trị từ các cột của hàng được chọn
                string soTK = selectedItem.SubItems[1].Text;
                string soDu = selectedItem.SubItems[2].Text;
                string kyHan = selectedItem.SubItems[3].Text;
                string ngayDaoHan = selectedItem.SubItems[4].Text;

                // Thực hiện xử lý tương ứng với hàng được chọn, ví dụ:
                // Hiển thị thông tin chi tiết của tài khoản kỳ hạn
                MessageBox.Show($"Số tài khoản: {soTK}\nSố dư: {soDu}\nKỳ hạn: {kyHan}\nNgày đáo hạn: {ngayDaoHan}");
            }
        }

        private void NguyenHongKhang_07_btnTroLai_Click(object sender, EventArgs e)
        {
            FrmHomeKH frmHomeKH = new FrmHomeKH();
            this.Hide();
            frmHomeKH.ShowDialog();
        }
    }
}
