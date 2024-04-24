/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import com.nhk.bosung.Config;

/**
 *
 * @author 84355
 */
public class QuanLyTaiKhoan {

    private List<Account> ds;

    public QuanLyTaiKhoan() {
        this.ds = new ArrayList<>();
    }

    public void themTaiKhoan(Account... tk) {
        this.ds.addAll(Arrays.asList(tk));
    }

    public void xoaTaiKhoan(Account tk) {
        this.ds.remove(tk);
    }

    public void xoaTaiKhoan(String stk) {
        List<Account> accountsToRemove = new ArrayList<>();

        for (Account tk : this.ds) {
            if (tk instanceof TaiKhoan && tk.soTK.equals(stk)) {
                TaiKhoan tkk = (TaiKhoan) tk;

                tkk.user.setActive(false);
                tkk.xoaDanhSachBienDong();
                accountsToRemove.add(tkk);

            } else if (tk instanceof TaiKhoanCoKyHan) {
                TaiKhoanCoKyHan tkkh = (TaiKhoanCoKyHan) tk;
                if (tkkh.getTk().soTK.equals(stk))
                    accountsToRemove.add(tkkh);
            }
        }

        this.ds.removeAll(accountsToRemove);
    }

    // tinh lai suat theo STK
    public void tinhLaiTheoSTK(String stk) {
        Account kh = this.ds.stream().filter(a -> a.soTK.equals(stk)).findFirst().get();

        System.out.printf("So du = %.0fVND\n", kh.soTien);
        System.out.printf("Tien lai (1 Thang) = %.0fVND\n", kh.tinhLai());
    }

    public TaiKhoan layTaiKhoanTheoSTK(String soTK) {
        for (Account tk : this.ds) {
            if (tk instanceof TaiKhoan && tk.getSoTK().equals(soTK)) {
                return (TaiKhoan) tk;
            }
        }
        return null;
    }

    public Account layAccountTheoSTKvaKHDN(String soTK, KhachHang khDN) {
        for (Account tk : this.ds) {
            if (tk.getSoTK().equals(soTK) && tk.user.getSoCCCD().equals(khDN.getSoCCCD())) {
                return tk;
            }
        }
        return null;
    }

    public TaiKhoanCoKyHan layTaiKhoanKyHanTheoSTK(String soTK) {
        for (Account tk : this.ds) {
            if (tk instanceof TaiKhoanCoKyHan && tk.getSoTK().equals(soTK)) {
                return (TaiKhoanCoKyHan) tk;
            }
        }
        return null;
    }

    public void XuatTatCaTaiKhoan() {
        this.ds.forEach(a -> {
            System.out.println(a);
        });
    }

    public List<TaiKhoanCoKyHan> layDanhSachTaiKhoanKyHanTheoCCCD(String cccd) {
        List<TaiKhoanCoKyHan> ds1 = new ArrayList<>();
        for (Account tk : this.ds)
            if (tk instanceof TaiKhoanCoKyHan && tk.user.getSoCCCD().equals(cccd))
                ds1.add((TaiKhoanCoKyHan) tk);

        return ds1;
    }

    /**
     * Lấy DS tài khoản (kỳ hạn và không kỳ hạn) - Theo mã khách hàng
     * 
     * @param maKH: mã khách hàng
     * @return: DS tài khoản
     */
    public List<Account> layDanhSachTaiKhoan(String maKH) {
        List<Account> ds2 = new ArrayList<>();
        for (Account tk : this.ds)
            if (tk.user.getMaKH().equals(maKH))
                ds2.add(tk);
        return ds2;
    }

    /**
     * Lấy danh sách khách hàng không kỳ hạn
     * 
     * @return
     */
    public List<TaiKhoan> layDanhSachTaiKhoan() {
        List<TaiKhoan> ds3 = new ArrayList<>();
        for (Account tk : this.ds)
            if (tk instanceof TaiKhoan)
                ds3.add((TaiKhoan) tk);
        return ds3;
    }

    public void hienThongTinTheoMaKhachHang(String maKH) {
        TaiKhoan tk = layTaiKhoanTheoSTK(maKH);

        if (tk == null) {
            System.out.println("**Tai khoan khong ton tai!");
            return;
        }

        String tien = Config.format.format(tk.soTien);

        System.out.printf("\n* * * * Thong tin khach hang * * * *\n"
                + "*  STK: %s\n"
                + "*  So du: %s\n"
                + "*  Ho Ten: %s\n"
                + "*  Gioi Tinh: %s\n"
                + "*  Ngay Sinh: %s\n"
                + "*  Que Quan: %s\n"
                + "*  So Dien Thoai: %s\n"
                + "*  So CCCD: %s\n"
                + "*  Password: %s\n"
                + "* * * * * * * * * * * * * * * * * * *\n",
                tk.soTK, tien, tk.user.getHoTen(), tk.user.getGioiTinh(), tk.user.getNgaySinh(),
                tk.user.getQueQuan(), tk.user.getSdt(), tk.user.getSoCCCD(), tk.user.getPassword());

    }

    public void sapXepTaiKhoanGiamDanTheoSoDu() {
        this.ds.sort((tk1, tk2) -> {
            double d1 = tk1.getSoTien();
            double d2 = tk2.getSoTien();
            return -(d1 > d2 ? 1 : (d1 < d2 ? -1 : 0));
        });
    }

    // ========Getter, Setter=========

}
