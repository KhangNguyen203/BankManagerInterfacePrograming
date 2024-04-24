using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.Lop
{
    public class KhachHang
    {
        private string maKH;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string queQuan;
        private string sdt;
        private string soCCCD;
        private bool active;

        public KhachHang(string hoTen, string gioiTinh, string ngaySinh, string queQuan, string sdt, string soCCCD)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.queQuan = queQuan;
            this.sdt = sdt;
            this.soCCCD = soCCCD;
            active = true;
        }

        public KhachHang()
        {
            
        }

        //Getter Setter
        public string HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }

        public string NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }

        public string QueQuan
        {
            get { return this.queQuan; }
            set { this.queQuan = value; }
        }

        public string SoCCCD
        {
            get { return this.soCCCD; }
            set { this.soCCCD = value; }
        }

        public string Sdt
        {
            get { return this.sdt; }
            set { this.sdt = value; }
        }

        public string MaKH
        {
            get { return this.maKH; }
            set { this.maKH = value; }
        }

        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
    }
}
