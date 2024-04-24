package com.nhk.bosung;

import com.nhk.detai7.KyHan;
import com.nhk.detai7.LoaiGiaoDich;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.util.List;

import com.nhk.detai7.GiaoDich;
import com.nhk.detai7.KhachHang;
import com.nhk.detai7.QuanLyTaiKhoan;
import com.nhk.detai7.TaiKhoan;
import com.nhk.detai7.TaiKhoanCoKyHan;

public class MenuUserSub {
    public static void subMenuUser(KhachHang khDN, TaiKhoan tk, QuanLyTaiKhoan dstk) {
        int chon;
        do {
            System.out.printf("\n\t******** TAI KHOAN KY HAN ********\n"
                    + " \t    STK: %s\n"
                    + " \t    Ho & ten: %s\n"
                    + "\t**********************************\n"
                    + "\t* 1. Mo Tai Khoan Ky Han         *\n"
                    + "\t* 2. Nap tien vao TK Ky Han      *\n"
                    + "\t* 3. Rut tien TK Ky Han          *\n"
                    + "\t* 4. Thoat!                      *\n"
                    + "\t**********************************\n"
                    + "Ban chon: ", khDN.getMaKH(), khDN.getHoTen());
            chon = Config.sc.nextInt();

            switch (chon) {
                case 1: {
                    // Mo Tai Khoan Co Ky Han
                    double tiengui;
                    do {
                        System.out.print("     Nhap so tien muon gui (>=100000): ");
                        tiengui = Config.sc.nextDouble();
                    } while (tiengui < 100000);

                    double tienconlai = tk.getSoTien() - tiengui;

                    if (tienconlai < 50000) {
                        System.out.print("\n**SO DU con lai < 50.000VNĐ!\n");
                    } else {
                        System.out.print("    Ky han: \n"
                                + "     1. 1 tuan \n"
                                + "     2. 1 thang \n"
                                + "     3. 6 thang \n"
                                + "     4. 1 nam\n"
                                + "Ban chon ky han: ");
                        int chonkyhan = Config.sc.nextInt();
                        TaiKhoanCoKyHan acc;
                        switch (chonkyhan) {
                            case 1: {
                                acc = new TaiKhoanCoKyHan(khDN, KyHan.MOT_TUAN, tiengui, tk);
                                dstk.themTaiKhoan(acc);
                                System.out.println("\n=== THONG TIN TAI KHOAN VUA TAO ===");
                                System.out.println(acc);
                                break;
                            }
                            case 2: {
                                acc = new TaiKhoanCoKyHan(khDN, KyHan.MOT_THANG, tiengui, tk);

                                dstk.themTaiKhoan(acc);
                                System.out.println("\n=== THONG TIN TAI KHOAN VUA TAO ===");
                                System.out.println(acc);
                                break;
                            }

                            case 3: {
                                acc = new TaiKhoanCoKyHan(khDN, KyHan.SAU_THANG, tiengui, tk);
                                dstk.themTaiKhoan(acc);
                                System.out.println("\n=== THONG TIN TAI KHOAN VUA TAO ===");
                                System.out.println(acc);
                                break;
                            }

                            case 4: {
                                acc = new TaiKhoanCoKyHan(khDN, KyHan.MOT_NAM, tiengui, tk);
                                dstk.themTaiKhoan(acc);
                                System.out.println("\n=== THONG TIN TAI KHOAN VUA TAO ===");
                                System.out.println(acc);
                                break;
                            }
                        }

                        tk.setSoTien(tienconlai);

                        // ==Tao giao dich
                        new GiaoDich(LoaiGiaoDich.Rut, tiengui, "Mo tai khoan ky han", tk);

                    }
                    break;
                }

                case 2: {
                    // Nap tien vao Tai Khoan co ky han
                    List<TaiKhoanCoKyHan> list = dstk.layDanhSachTaiKhoanKyHanTheoCCCD(khDN.getSoCCCD());

                    System.out.printf("\n====Danh sach tai khoan ky han cua: %s\n", khDN.getHoTen());

                    if (list.isEmpty()) {
                        System.out.println("\n**Chua co tai khoan ky han");
                        break;
                    }

                    list.forEach(s -> System.out.println(s));

                    Config.sc.nextLine();
                    System.out.print("Nhap STK muon nap tien: ");
                    String stkk = Config.sc.nextLine();

                    TaiKhoanCoKyHan tkKHH = dstk.layTaiKhoanKyHanTheoSTK(stkk);
                    if (tkKHH == null) {
                        System.out.println("\n**Khong tim thay tai khoan!!");
                        break;
                    }

                    if (tkKHH.isDaoHan()) {
                        while (true) {
                            double tiennap;
                            while (true) {
                                System.out.print("So tien muon nap (>= 100.000VNĐ): ");
                                tiennap = Config.sc.nextDouble();

                                if (tiennap >= 100000)
                                    break;
                            }

                            if (tiennap > tk.getSoTien() || (tk.getSoTien() - tiennap) < 50000) {
                                System.out.println("**So tien khong hop le hoac so du khong du!");
                            } else {
                                System.out.print("\nXac nhan (1.Dong y/2.Huy): ");
                                int chon3 = Config.sc.nextInt();

                                if (chon3 == 1) {
                                    tkKHH.nopTien(tiennap);
                                    tk.setSoTien(tk.getSoTien() - tiennap);

                                    // ==Tao giao dich
                                    new GiaoDich(LoaiGiaoDich.Rut, tiennap, "Nap tien vao tai khoan ky han", tk);

                                } else
                                    System.out.println("\n**Giao dich bi huy!");

                                break;
                            }
                        }
                        System.out.println("\n**NAP TIEN THANH CONG");
                        break;
                    }
                    System.out.println("\n**Tai Khoan chua den ngay dao han");
                    break;
                }

                case 3: {
                    // Rút tiền từ TK có kỳ hạn
                    List<TaiKhoanCoKyHan> ds = dstk.layDanhSachTaiKhoanKyHanTheoCCCD(khDN.getSoCCCD());

                    System.out.printf("\n====Danh sach tai khoan ky han cua: %s\n", khDN.getHoTen());

                    if (ds.isEmpty()) {
                        System.out.println("\n**Chua co tai khoan ky han");
                        break;
                    }

                    ds.forEach(s -> System.out.println(s));

                    Config.sc.nextLine();
                    System.out.print("\nNhap STK muon rut tien: ");
                    String stk = Config.sc.nextLine();

                    TaiKhoanCoKyHan tkKH = dstk.layTaiKhoanKyHanTheoSTK(stk);
                    if (tkKH == null) {
                        System.out.println("\n**Khong tim thay tai khoan!!");
                        break;
                    }

                    if (tkKH.isDaoHan()) {
                        double tienrut;
                        while (true) {
                            System.out.print("So tien muon rut (>= 50.000 VNĐ): ");
                            tienrut = Config.sc.nextDouble();

                            if (tienrut >= 50000)
                                break;
                        }

                        if (tienrut > tkKH.getSoTien() || tkKH.getSoTien() - tienrut < 100000) {
                            System.out.println("\n**So du khong du de rut!");
                        } else {
                            System.out.print("\nXac nhan (1.Dong y/2.Huy): ");
                            int chon5 = Config.sc.nextInt();

                            if (chon5 == 1) {
                                tkKH.rutTien(tienrut);
                                tk.setSoTien(tk.getSoTien() + tienrut);
                                System.out.println("\n**RUT TIEN THANH CONG!\n");

                                // ==Tao giao dich
                                new GiaoDich(LoaiGiaoDich.Rut, tienrut, "Rut tien tu tai khoan ky han", tk);

                            } else
                                System.out.println("\n**Giao dich bi huy!");

                        }
                        break;
                    }

                    System.out.print("**Tai Khoan chua den ngay dao han!\nBan van muon rut?(1.Yes/2.No):");
                    int chon4 = Config.sc.nextInt();
                    if (chon4 == 1) {
                        LocalDate now = LocalDate.now();
                        long soNgay = tkKH.getNgayTao().until(now, ChronoUnit.DAYS);

                        double tienLai = tkKH.getSoTien() + (soNgay * (0.002 / 365) * tkKH.getSoTien());
                        double tienTatToan = tk.getSoTien() + tienLai;

                        // ==Tao giao dich
                        new GiaoDich(LoaiGiaoDich.Rut, tienLai, "Rut tien truoc dao han", tk);

                        tkKH.setSoTien(0);
                        tk.setSoTien(tienTatToan);
                        dstk.xoaTaiKhoan(tkKH);

                        System.out.println("\n**RUT TIEN THANH CONG!**\n");
                    }

                    break;
                }

                default: {
                    break;
                }
            }
        } while (chon < 4);
    }
}
