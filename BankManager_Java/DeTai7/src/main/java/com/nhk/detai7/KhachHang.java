/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import com.nhk.bosung.Config;
import java.util.Random;

/**
 *
 * @author 84355
 */
public class KhachHang {
    private String maKH;
    private String hoTen;
    private String gioiTinh;
    private String ngaySinh;
    private String queQuan;
    private String sdt;
    private String soCCCD;
    private String password;
    private boolean active;

    public KhachHang(String hoTen, String gioiTinh, String ngaySinh, String queQuan, String sdt, String soCCCD) {
        this.hoTen = hoTen;
        this.gioiTinh = gioiTinh;
        this.ngaySinh = ngaySinh;
        this.queQuan = queQuan;
        this.sdt = sdt;
        this.soCCCD = soCCCD;
        this.password = taoMatKhauNgauNhien(6);
        active = true;
    }

    public KhachHang() {
        // active = true;
    }

    public void nhapKhachHang() {
        System.out.print("Ho & ten: ");
        Config.sc.nextLine();
        this.hoTen = Config.sc.nextLine();
        System.out.print("Gioi tinh: ");
        this.gioiTinh = Config.sc.nextLine();
        System.out.print("Ngay sinh (dd/MM/yyyy): ");
        this.ngaySinh = Config.sc.nextLine();
        System.out.print("Que quan: ");
        this.queQuan = Config.sc.nextLine();
        System.out.print("So dien thoai: ");
        this.sdt = Config.sc.nextLine();
        System.out.print("So CCCD: ");
        this.setSoCCCD(Config.sc.nextLine());
        this.password = taoMatKhauNgauNhien(6);
    }

    @Override
    public String toString() {
        return String.format("\n* * * * Thong tin khach hang  * * * *\n" +
                "*  STK: %s\n" +
                "*  Khach hang: %s\n" +
                "*  So dien thoai: %s\n" +
                "*  So CCCD: %s\n" +
                "*  Gioi tinh: %s\n" +
                "*  Ngay sinh: %s\n" +
                "*  Que quan: %s\n" +
                "* * * * * * * * * * * * * * * * * * * \n",
                this.maKH, this.hoTen, this.sdt, this.soCCCD, this.gioiTinh, this.ngaySinh, this.queQuan);
    }

    /**
     *
     * @param length: số kí tự muốn tạo mật khẩu
     * @retur 6 số ngẫu nhiên
     */
    public static String taoMatKhauNgauNhien(int length) {
        // Chuỗi chứa các ký tự số
        String digits = "0123456789";
        StringBuilder password = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < length; i++) {
            // Lấy ngẫu nhiên một chữ số từ chuỗi digits
            int index = random.nextInt(digits.length());
            char digit = digits.charAt(index);
            password.append(digit);
        }

        return password.toString();
    }

    // ========Getter Setter==========
    /**
     * @return the hoTen
     */
    public String getHoTen() {
        return hoTen;
    }

    /**
     * @param hoTen the hoTen to set
     */
    public void setHoTen(String hoTen) {
        this.hoTen = hoTen;
    }

    /**
     * @return the gioiTinh
     */
    public String getGioiTinh() {
        return gioiTinh;
    }

    /**
     * @param gioiTinh the gioiTinh to set
     */
    public void setGioiTinh(String gioiTinh) {
        this.gioiTinh = gioiTinh;
    }

    /**
     * @return the ngaySinh
     */
    public String getNgaySinh() {
        return ngaySinh;
    }

    /**
     * @param ngaySinh the ngaySinh to set
     */
    public void setNgaySinh(String ngaySinh) {
        this.ngaySinh = ngaySinh;
    }

    /**
     * @return the queQuan
     */
    public String getQueQuan() {
        return queQuan;
    }

    /**
     * @param queQuan the queQuan to set
     */
    public void setQueQuan(String queQuan) {
        this.queQuan = queQuan;
    }

    /**
     * @return the soCCCD
     */
    public String getSoCCCD() {
        return soCCCD;
    }

    /**
     * @param soCCCD the soCCCD to set
     */
    public void setSoCCCD(String soCCCD) {
        this.soCCCD = soCCCD;
    }

    /**
     * @return the password
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param password the password to set
     */
    public void setPassword(String password) {
        this.password = password;
    }

    /**
     * @return the sdt
     */
    public String getSdt() {
        return sdt;
    }

    /**
     * @param sdt the sdt to set
     */
    public void setSdt(String sdt) {
        this.sdt = sdt;
    }

    /**
     * @return the maKH
     */
    public String getMaKH() {
        return maKH;
    }

    /**
     * @param maKH the maKH to set
     */
    public void setMaKH(String maKH) {
        this.maKH = maKH;
    }

    /**
     * @return the active
     */
    public boolean isActive() {
        return active;
    }

    /**
     * @param active the active to set
     */
    public void setActive(boolean active) {
        this.active = active;
    }
    
}
