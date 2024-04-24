using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Lop
{
    public class TaiKhoan : Account
    {
        public TaiKhoan(KhachHang kh, double tien) : base("TAI KHOAN KHONG KY HAN", kh, tien)
        {
            this.khachHang.MaKH = this.soTK;
        }

        public TaiKhoan(): base("", null, 0.0) { }
    }
}
