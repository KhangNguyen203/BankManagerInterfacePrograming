using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManager.Lop;

namespace BankManager.Lop
{
    public class QuanLyTaiKhoan
    {
        private List<Account> ds;

        public QuanLyTaiKhoan()
        {
            this.ds = new List<Account>();
        }

        public void ThemAccount(params Account[] ac)
        {
            this.ds.AddRange(ac);
        }

        public TaiKhoan layTKTheoSTK(string soTK) {
            foreach (Account ac in this.ds) {
                if (ac is TaiKhoan && ac.SoTK.Equals(soTK))
                    return (TaiKhoan)ac;
            }
            return null; 
        }

        public TaiKhoan DangNhap(string username, string password)
        {
            foreach (Account tk in this.ds)
            {
                if (tk is TaiKhoan) {
                    if (tk.KhachHang.Sdt != null && tk.Password != null && tk.KhachHang.Sdt.Equals(username) && tk.Password.Equals(password))
                    {
                        return (TaiKhoan)tk;
                    }
                }
            }
            return null;
        }

        public void ChuyenKhoan(TaiKhoan tkGui, TaiKhoan tkNhan, int tien) {
            tkGui.SoTien -= tien;
            tkNhan.SoTien += tien;
        }

        public string DoiMK(TaiKhoan tk, string mkc, string mkm) {
            foreach(Account ac in this.ds){
                if (ac.SoTK.Equals(tk.SoTK)) {
                    if (ac.Password.Equals(mkc))
                    {
                        ac.Password = mkm;

                        return "Đổi mật khẩu thành công, MK mới là: " + ac.Password;
                    }
                    else
                        return "Mật khẩu không đúng";
                }else
                    return "Không tìm thấy tài khoản";
            }

            return "";
        }

        public List<Account> layDSTKKyHanTheoSTK(string stk){
            List<Account> list = new List<Account>();

            foreach (Account tk in this.ds) {
                if (tk is TaiKhoanCoKyHan) {
                    TaiKhoanCoKyHan tkkh = (TaiKhoanCoKyHan)tk;
                    if(tkkh.TaiKhoan.SoTK.Equals(stk))
                        list.Add(tk);
                }
            }
            return list;
        }

        public Account layTKKyHanTheoSTK(string stk)
        {
            Account ac = null;

            foreach (Account tk in this.ds)
            {
                if (tk.SoTK.Equals(stk)) {
                    ac = tk;
                }
            }
            return ac;
        }

    }
}
