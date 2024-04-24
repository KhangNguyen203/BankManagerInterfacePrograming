package com.nhk.detai7;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 84355
 */
public class QuanLyKhachHang {
    private List<KhachHang> ds;

    public QuanLyKhachHang() {
        this.ds = new ArrayList<>();
    }

    public void themKhachHang(KhachHang... kh) {
        this.ds.addAll(Arrays.asList(kh));
    }

    public boolean isKhachHangDaCo(String cccd) {
        for (KhachHang khachHang : ds) {
            if (khachHang.getSoCCCD().equals(cccd))
                return true;
        }
        return false;
    }

    public void XuatDSKhachHang() {
        this.ds.forEach(s -> {
            System.out.printf("%s" +
                    "* Hoat dong: %s\n" +
                    "* * * * * * * * * * * * * * * * * *\n", s, s.isActive());
        });
    }

    public KhachHang dangNhap(String username, String password) {
        for (KhachHang kh : this.ds) {
            if (kh.getMaKH().equals(username) && kh.getPassword().equals(password) && kh.isActive() == true ||
                    kh.getSdt().equals(username) && kh.getPassword().equals(password) && kh.isActive() == true) {
                return kh;
            }
        }
        return null;
    }

    public KhachHang layKhachHang(String ten, String stk) {
        for (KhachHang kh : ds) {
            if (kh.getMaKH().equals(stk) && kh.getHoTen().equals(ten))
                return kh;
        }
        return null;
    }

    public KhachHang layKhachHang(String cccd) {
        for (KhachHang kh : ds) {
            if (kh.getSoCCCD().equals(cccd))
                return kh;
        }
        return null;
    }

    public boolean isSDTTonTai(String sdt) {
        for (KhachHang kh : ds) {
            if (kh.getSdt().equals(sdt))
                return true;
        }
        return false;
    }

    // ===========Getter, Setter===============
    /**
     * @return the ds
     */
    public List<KhachHang> getDs() {
        return ds;
    }

    /**
     * @param ds the ds to set
     */
    public void setDs(List<KhachHang> ds) {
        this.ds = ds;
    }
}
