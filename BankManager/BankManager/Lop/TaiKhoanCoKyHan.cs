using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Lop
{
    class TaiKhoanCoKyHan : TaiKhoan
    {
        private DateTime ngayDaoHan;
        private string kyHan;
        private TaiKhoan tk;

        public TaiKhoanCoKyHan(double tien, string KH, TaiKhoan tk) : base()
        {
            this.LoaiTK = "TAI KHOAN KY HAN";
            this.kyHan = KH;
            this.tk = tk;
            this.KhachHang = tk.KhachHang;
            this.SoTien = tien;
            this.ngayDaoHan = tinhDaoHan(this.kyHan);
        }

        public DateTime tinhDaoHan(string kyhan) {
            if (kyhan.Equals("1tuan"))
                return this.NgayTao.AddDays(7);
            if (kyhan.Equals("1thang"))
                return this.NgayTao.AddMonths(1);
            if (kyhan.Equals("6thang"))
                return this.NgayTao.AddMonths(6);
            if (kyhan.Equals("1nam"))
                return this.NgayTao.AddYears(1);

            return DateTime.MinValue;
        }


        public DateTime NgayDaoHan
        {
            get { return ngayDaoHan; }
            set { ngayDaoHan = value; }
        }

        public string KyHan
        {
            get { return kyHan; }
            set { kyHan = value; }
        }

        public TaiKhoan TaiKhoan
        {
            get { return tk; }
            set { tk = value; }
        }

        public override string ToString()
        {
            string hien = "Số tài khoản: " + this.SoTK;
            hien += "\n   Khách hàng: " + this.KhachHang.HoTen;
            hien += "\n   Số dư: " + this.SoTien;
            hien += "\n   Kỳ hạn: " + this.kyHan;
            hien += "\n   Ngày đáo hạn: " + this.NgayDaoHan.ToString("dd/MM/yyyy");
            hien += "\n";

            return hien;
        }
    }
}
