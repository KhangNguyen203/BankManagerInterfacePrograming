/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.time.LocalDate;
import java.util.Calendar;
import java.util.GregorianCalendar;

import com.nhk.bosung.Config;

/**
 *
 * @author 84355
 */
public abstract class Account {

    private static int dem = 1;
    protected String soTK;
    protected double soTien;
    protected String loaiTK;
    protected LocalDate ngayTao;
    protected KhachHang user;

    {
        GregorianCalendar g = new GregorianCalendar();
        this.setSoTK(String.format("%02d%02d%d%04d", g.get(Calendar.DAY_OF_MONTH), g.get(Calendar.MONTH) + 1,
                g.get(Calendar.YEAR), dem++));

        this.ngayTao = LocalDate.now();
    }

    public Account(String loai, KhachHang user, double tien) {
        this.loaiTK = loai;
        this.user = user;
        this.soTien = tien;
    }

    @Override
    public String toString() {
        String tien = Config.format.format(this.soTien);
        return String.format("\n* * * * Thong tin Tai Khoan * * * *\n" +
                "*  %s\n" +
                "*  STK: %s\n" +
                "*  So du: %s\n" +
                "*  Khach hang: %s\n" +
                "*  So dien thoai: %s\n" +
                "*  So CCCD: %s\n" +
                "*  Ngay sinh: %s\n" +
                "* * * * * * * * * * * * * * * * *", this.getLoaiTK(), this.soTK, tien, this.user.getHoTen(), this.user.getSdt(), this.user.getSoCCCD(), this.user.getNgaySinh());
    }

    public void rutTien(double tien) {
        if (isDaoHan() && tien <= this.soTien) {
            this.soTien -= tien;
        } else {
            System.out.println("So tien trong tai khoan khong du!!");
        }
    }

    public void nopTien(double tien) {
        if (isDaoHan()) {
            this.soTien += tien;
        }
    }

    public abstract double tinhLai();

    protected abstract boolean isDaoHan();

    //======Getter, Setter==========
    /**
     * @return the soTK
     */
    public String getSoTK() {
        return this.soTK;
    }

    /**
     * @param soTK the soTK to set
     */
    public void setSoTK(String soTK) {
        this.soTK = soTK;
    }

    /**
     * @return the soTien
     */
    public double getSoTien() {
        return soTien;
    }

    /**
     * @param soTien the soTien to set
     */
    public void setSoTien(double soTien) {
        this.soTien = soTien;
    }

    /**
     * @return the ngayTao
     */
    public LocalDate getNgayTao() {
        return ngayTao;
    }

    /**
     * @param ngayTao the ngayTao to set
     */
    public void setNgayTao(LocalDate ngayTao) {
        this.ngayTao = ngayTao;
    }

    /**
     * @return the user
     */
    public KhachHang getUser() {
        return user;
    }

    /**
     * @param user the user to set
     */
    public void setUser(KhachHang user) {
        this.user = user;
    }

    /**
     * @return the loaiTK
     */
    public String getLoaiTK() {
        return loaiTK;
    }

    /**
     * @param loaiTK the loaiTK to set
     */
    public void setLoaiTK(String loaiTK) {
        this.loaiTK = loaiTK;
    }
    
}
