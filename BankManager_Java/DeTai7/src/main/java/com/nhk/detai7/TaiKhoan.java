/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.util.ArrayList;
import java.util.List;

import com.nhk.bosung.Config;

/**
 *
 * @author 84355
 */
public class TaiKhoan extends Account implements Transferable<TaiKhoan>, FuctuationHistory {
    private List<GiaoDich> dsBD;

    public TaiKhoan(KhachHang u, double tien) {
        super("TAI KHOAN KHONG KY HAN", u, tien);
        this.user.setMaKH(this.soTK);
        dsBD = new ArrayList<>();
    }

    /**
     * Tính lãi mỗi năm (0.2%/năm)
     *
     * @return số tiền mỗi năm
     */
    @Override
    public double tinhLai() {
        return (this.soTien * 0.002);
    }

    @Override
    public boolean isDaoHan() {
        return true;
    }

    @Override
    public void chuyenKhoan(TaiKhoan tkNhan, double soTien) {
        // TODO Auto-generated method stub
        String tien = Config.format.format(soTien);
        if (this.soTien >= soTien && (this.soTien - soTien) >= 50000) {
            this.soTien -= soTien;
            tkNhan.soTien += soTien;

            System.out.printf("\n**Chuyen khoan thanh cong!\n   Toi STK: %s, nguoi nhan: %s, so tien: %s\n", tkNhan.getSoTK(),
                    tkNhan.user.getHoTen(), tien);
        } else {
            System.out.println("\n**So du khong du!");
        }
    }

    @Override
    public void addFuctuation(GiaoDich gd) {
        // TODO Auto-generated method stub
        this.dsBD.add(gd);
    }

    @Override
    public List<GiaoDich> getFuctuations() {
        // TODO Auto-generated method stub
        return this.dsBD;
    }
    
    /**
     * Xóa danh sách biến động số dư khi toàn khoảng bị xóa
     */
    public void xoaDanhSachBienDong(){
        this.dsBD.clear();
    }
}
