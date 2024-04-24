using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Lop
{
    public class Account
    {
        private static int dem = 1;
        protected string soTK;
        protected double soTien;
        protected string loaiTK;
        protected DateTime ngayTao;
        protected KhachHang khachHang;
        private string password;


        public Account(string loai, KhachHang kh, double tien) {
            this.loaiTK = loai;
            this.khachHang = kh;
            this.soTien = tien;

            DateTime now = DateTime.Now;
            soTK = string.Format("{0:D2}{1:D2}{2:D4}{3:D2}", now.Day, now.Month, now.Year, dem++);
            ngayTao = DateTime.Today;

            this.password = TaoMatKhauNgauNhien(6);
        }

        public static string TaoMatKhauNgauNhien(int length)
        {
            string digits = "0123456789";
            StringBuilder password = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(digits.Length);
                char digit = digits[index];
                password.Append(digit);
            }

            return password.ToString();
        }


        //Getter Setter
        public string SoTK {
            get { return this.soTK; }
            set { this.soTK = value; }
        }
        public double SoTien
        {
            get { return this.soTien; }
            set { this.soTien = value; }
        }

        public string LoaiTK
        {
            get { return this.loaiTK; }
            set { this.loaiTK = value; }
        }

        public DateTime NgayTao
        {
            get { return this.ngayTao; }
            set { this.ngayTao = value; }
        }

        public KhachHang KhachHang
        {
            get { return this.khachHang; }
            set { this.khachHang = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
