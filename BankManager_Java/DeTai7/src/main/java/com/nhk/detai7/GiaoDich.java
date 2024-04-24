package com.nhk.detai7;

import java.time.LocalDate;

import com.nhk.bosung.Config;

public class GiaoDich {
    private static int dem = 1;
    private String maGiaoDich;
    private LoaiGiaoDich loaiGD;
    private double soTienGiaoDich;
    private String noiDung;
    private LocalDate ngayTao;
    private TaiKhoan tk;

    public GiaoDich(LoaiGiaoDich loai, double soTienGiaoDich, String noiDung, TaiKhoan tk) {
        this.maGiaoDich = taoID();
        this.loaiGD = loai;
        this.soTienGiaoDich = soTienGiaoDich;
        this.noiDung = noiDung;
        this.ngayTao = LocalDate.now();
        this.tk = tk;
        this.tk.addFuctuation(this);
    }

    private String taoID() {
        String formattedID = String.format("%06d", dem);
        dem++;
        return formattedID;
    }

    @Override
    public String toString() {
        String tien = Config.format.format( this.soTienGiaoDich);
        return String.format("\nMa giao dich: %s - Thoi gian: %s \n\t- Loai: %s - Noi Dung: %s - So tien: %s\n", 
                                    this.maGiaoDich, this.ngayTao, this.loaiGD.show(), this.noiDung,tien);
    }
    
    
    
//===========Getter Setter===========

    /**
     * @return the giaoDichID
     */
    public String getGiaoDichID() {
        return maGiaoDich;
    }

    /**
     * @param giaoDichID the giaoDichID to set
     */
    public void setGiaoDichID(String giaoDichID) {
        this.maGiaoDich = giaoDichID;
    }

    /**
     * @return the soTienGiaoDich
     */
    public double getSoTienGiaoDich() {
        return soTienGiaoDich;
    }

    /**
     * @param soTienGiaoDich the soTienGiaoDich to set
     */
    public void setSoTienGiaoDich(double soTienGiaoDich) {
        this.soTienGiaoDich = soTienGiaoDich;
    }

    /**
     * @return the noiDung
     */
    public String getNoiDung() {
        return noiDung;
    }

    /**
     * @param noiDung the noiDung to set
     */
    public void setNoiDung(String noiDung) {
        this.noiDung = noiDung;
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
