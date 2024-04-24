using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Lop
{
    class QuanLyKhachHang
    {
        private List<KhachHang> ds;

        public QuanLyKhachHang()
        {
            this.ds = new List<KhachHang>();
        }

        public void ThemKhachHang(params KhachHang[] kh)
        {
            this.ds.AddRange(kh);
        }

        //public bool IsKhachHangDaCo(string cccd)
        //{
        //    foreach (KhachHang khachHang in ds)
        //    {
        //        if (khachHang.SoCCCD.Equals(cccd))
        //            return true;
        //    }
        //    return false;
        //}

        //public void XuatDSKhachHang()
        //{
        //    foreach (KhachHang kh in ds)
        //    {
        //        Console.WriteLine($"{kh}\n* Hoat dong: {kh.IsActive}\n* * * * * * * * * * * * * * * * * *");
        //    }
        //}

        //public KhachHang DangNhap(string username, string password)
        //{
        //    foreach (KhachHang kh in this.ds)
        //    {
        //        if (kh.Sdt != null && kh.Password != null && kh.Sdt.Equals(username) && kh.Password.Equals(password))
        //        {
        //            return kh;
        //        }
        //    }
        //    return null;
        //}

        //public KhachHang LayKhachHang(string ten, string stk)
        //{
        //    foreach (KhachHang kh in ds)
        //    {
        //        if (kh.MaKH.Equals(stk) && kh.HoTen.Equals(ten))
        //            return kh;
        //    }
        //    return null;
        //}

        //public KhachHang LayKhachHang(string cccd)
        //{
        //    foreach (KhachHang kh in ds)
        //    {
        //        if (kh.SoCCCD.Equals(cccd))
        //            return kh;
        //    }
        //    return null;
        //}

        //public bool IsSDTTonTai(string sdt)
        //{
        //    foreach (KhachHang kh in ds)
        //    {
        //        if (kh.Sdt.Equals(sdt))
        //            return true;
        //    }
        //    return false;
        //}

        // Getter, Setter
        public List<KhachHang> Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
    }
}
