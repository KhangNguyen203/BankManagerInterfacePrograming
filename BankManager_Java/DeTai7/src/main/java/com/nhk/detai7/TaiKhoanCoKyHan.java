/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.time.LocalDate;

/**
 *
 * @author 84355
 */
public class TaiKhoanCoKyHan extends Account {
    private LocalDate ngayDaoHan;
    private KyHan kyHan;
    private TaiKhoan tk; 

    public TaiKhoanCoKyHan(KhachHang user, KyHan kyHan, double tien, TaiKhoan tk) {
        super("TAI KHOAN CO KY HAN", user, tien);
        this.kyHan = kyHan;
        this.ngayDaoHan = this.kyHan.tinhDaoHan(this.ngayTao);
        this.tk = tk;
    }

    @Override
    public double tinhLai() {
        return this.getKyHan().tinhTienLai(this.getSoTien());
    }

    @Override
    public boolean isDaoHan() {
        return LocalDate.now().equals(this.getNgayDaoHan());
    }

    @Override
    public String toString() {
        return String.format("%s\n" +
                "*  Ky han: %s\n" +
                "*  Ngay tao: %s\n" +
                "*  Ngay dao han: %s\n" +
                "* * * * * * * * * * * * * * * * * *\n"+ 
                "*  Tai Khoan nguon: %s\n" +
                "* * * * * * * * * * * * * * * * * *",
                super.toString(), this.kyHan, this.ngayTao, this.ngayDaoHan, this.tk.soTK);
    }

    // ======Getter, Setter============
    /**
     * @return the ngayDaoHan
     */
    public LocalDate getNgayDaoHan() {
        return ngayDaoHan;
    }

    /**
     * @param ngayDaoHan the ngayDaoHan to set
     */
    public void setNgayDaoHan(LocalDate ngayDaoHan) {
        this.ngayDaoHan = ngayDaoHan;
    }

    /**
     * @return the kyHan
     */
    public KyHan getKyHan() {
        return kyHan;
    }

    /**
     * @param kyHan the kyHan to set
     */
    public void setKyHan(KyHan kyHan) {
        this.kyHan = kyHan;
    }

    /**
     * @return the tk
     */
    public TaiKhoan getTk() {
        return tk;
    }

    /**
     * @param tk the tk to set
     */
    public void setTk(TaiKhoan tk) {
        this.tk = tk;
    }
}
