/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.bosung;

import com.nhk.detai7.LoaiGiaoDich;
import java.util.List;

import com.nhk.detai7.Account;
import com.nhk.detai7.GiaoDich;
import com.nhk.detai7.KhachHang;
import com.nhk.detai7.Main;
import com.nhk.detai7.QuanLyTaiKhoan;
import com.nhk.detai7.TaiKhoan;
import com.nhk.detai7.TaiKhoanCoKyHan;

/**
 *
 * @author 84355
 */
public class MenuUser {

    public static void menuUser(KhachHang khDN, TaiKhoan tk, QuanLyTaiKhoan dstk) {
        int chon;
        do {
            System.out.printf("\n\t******** MENU KHACH HANG *********\n"
                    + "\t    STK: %s\n"
                    + "\t    Ho & ten: %s\n"
                    + "\t**********************************\n"
                    + "\t* 1. Tai Khoan Ky Han            *\n"
                    + "\t* 2. Chuyen Khoan                *\n"
                    + "\t* 3. Nap tien vao Tai Khoan Chinh*\n"
                    + "\t* 4. Rut tien Tai Khoan Chinh    *\n"
                    + "\t* 5. Xem thong tin ca nhan       *\n"
                    + "\t* 6. Xem thong tin lai xuat      *\n"
                    + "\t* 7. Bien dong so du             *\n"
                    + "\t* 8. Doi mat khau                *\n"
                    + "\t* 9. Khoa tai khoan              *\n"
                    + "\t* 0. Dang xuat!                  *\n"
                    + "\t**********************************\n"
                    + "Ban chon: ", khDN.getMaKH(), khDN.getHoTen());
            chon = Config.sc.nextInt();

            switch (chon) {
                case 1: {
                    MenuUserSub.subMenuUser(khDN, tk, dstk);
                    break;
                }

                case 2: {
                    // Chuyen khoan
                    double tien;

                    Config.sc.nextLine();
                    System.out.print("Nhap STK muon chuyen tien: ");
                    String tk3 = Config.sc.nextLine();

                    TaiKhoan tkck = dstk.layTaiKhoanTheoSTK(tk3);
                    if (tkck == null || tkck.getSoTK().equals(khDN.getMaKH())) {
                        System.out.println("\n**Khong tim thay tai khoan!");
                        break;
                    }

                    System.out.println("\n== Nguoi nhan: " + tkck.getUser().getHoTen());

                    while (true) {
                        System.out.print("\nNhap so tien(>=2.000VNĐ):");
                        tien = Config.sc.nextDouble();

                        if (tien >= 2000)
                            break;
                    }

                    System.out.print("\nXac nhan (1.Dong y/2.Huy): ");
                    int chon4 = Config.sc.nextInt();

                    if (chon4 == 1) {
                        tk.chuyenKhoan(tkck, tien);

                        // ==Tao giao dich
                        new GiaoDich(LoaiGiaoDich.Rut, tien, "Chuyen tien", tk);
                        new GiaoDich(LoaiGiaoDich.Nop, tien, "Nhan tien", tkck);
                    } else
                        System.out.println("\n**Giao dich bi huy!");

                    break;
                }

                case 3: {
                    // Nap tien vao Tai Khoan Chinh
                    System.out.print("     So tien muon nap vao tai khoan chinh (>=50.000VNĐ): ");
                    double tiennapTKC = Config.sc.nextDouble();

                    if (tiennapTKC < 0) {
                        System.out.println("So tien nop khong hop le!");
                        break;
                    }

                    do {
                        if (tiennapTKC < 50000) {
                            System.out.print("Vui long nhap lai! (>=50000): ");
                            tiennapTKC = Config.sc.nextDouble();
                        }
                    } while (tiennapTKC < 50000);

                    System.out.print("\nXac nhan (1.Dong y/2.Huy): ");
                    int chon5 = Config.sc.nextInt();

                    if (chon5 == 1) {
                        tk.nopTien(tiennapTKC);
                        System.out.println("\n**Nap tien thanh cong!");

                        // ==Tao giao dich
                        new GiaoDich(LoaiGiaoDich.Nop, tiennapTKC, "Nap tien vao tai khoan chinh", tk);

                    } else
                        System.out.println("\n**Giao dich bi huy!");

                    break;
                }

                case 4: {
                    // Rut tien tu Tai Khoan Chinh
                    double tienrutTKC;
                    while (true) {
                        System.out.print("So tien muon rut (>= 50.000VNĐ): ");
                        tienrutTKC = Config.sc.nextDouble();

                        if (tienrutTKC >= 50000)
                            break;
                    }

                    if (tienrutTKC > tk.getSoTien() || tk.getSoTien() - tienrutTKC < 50000) {
                        System.out.println("**So du khong du de rut!");
                    } else {
                        System.out.print("\nXac nhan (1.Dong y/2.Huy): ");
                        int chon6 = Config.sc.nextInt();

                        if (chon6 == 1) {
                            tk.rutTien(tienrutTKC);
                            System.out.println("\n**RUT TIEN THANH CONG!\n");

                            // ==Tao giao dich
                            new GiaoDich(LoaiGiaoDich.Rut, tienrutTKC, "Rut tien tu tai khoan chinh", tk);

                        } else
                            System.out.println("\n**Giao dich bi huy!");

                        break;

                    }
                    break;
                }

                case 5: {
                    // Xem thong tin ca nhan
                    dstk.hienThongTinTheoMaKhachHang(khDN.getMaKH());

                    break;
                }

                case 6: {
                    // Tinh lai cua khach hang
                    System.out.println("\n=====DANH SACH TAI KHOAN=====");
                    List<Account> ds4 = dstk.layDanhSachTaiKhoan(khDN.getMaKH());
                    ds4.forEach(System.out::println);
                    System.out.println();

                    Config.sc.nextLine();
                    System.out.print("Nhap so tai khoan can tra cuu: ");
                    String stk3 = Config.sc.nextLine();

                    Account acc = dstk.layAccountTheoSTKvaKHDN(stk3, khDN);
                    if (acc == null) {
                        System.out.println("\n**Khong tim thay tai khoan");
                        break;
                    }

                    String tien = Config.format.format(acc.getSoTien());

                    String result = "\n* * * * * * Tinh Lai * * * * * * *\n" +
                            "*  So tai khoan: %s\n" +
                            "*  %s\n" +
                            "*  So tien: %s\n";

                    if (acc instanceof TaiKhoanCoKyHan) {
                        TaiKhoanCoKyHan accKyHan = (TaiKhoanCoKyHan) acc;
                        String lai = Config.format.format(accKyHan.tinhLai());
                        result += String.format("*  Ky han: %s\n" +
                                "*  Tien lai: %s\n" +
                                "*  Nhan vao: %s\n" +
                                "*  Ngay tao: %s\n" +
                                "* * * * * * * * * * * * * * * * * *\n",
                                accKyHan.getKyHan(), lai, accKyHan.getNgayDaoHan(), accKyHan.getNgayTao());
                    } else {
                        String lai2 = Config.format.format(acc.tinhLai());
                        result += String.format("*  Tien lai: %s\n" +
                                "*  Nhan vao: Moi thang\n" +
                                "* * * * * * * * * * * * * * * * * *\n",
                                lai2);
                    }

                    System.out.printf(result, acc.getSoTK(), acc.getLoaiTK(), tien);
                    break;
                }

                case 7: {
                    // Lich su giao dich
                    System.out.println("\n=====LICH SU GIAO DICH=====");
                    List<GiaoDich> ds3 = tk.getFuctuations();
                    if (!ds3.isEmpty())
                        ds3.forEach(s -> System.out.println(s));
                    else
                        System.out.println("\t(Trong)");
                    System.out.println("===========================\n");
                    break;
                }

                case 8: {
                    // Doi mat khau
                    Config.sc.nextLine();
                    System.out.print("     Nhap mat khau moi: ");
                    String matkhauMoi = Config.sc.nextLine();
                    khDN.setPassword(matkhauMoi);
                    System.out.println("\n**Doi mat khau thanh cong!\n");
                    break;
                }
                case 9: {
                    System.out.println(
                            "\n**Luu y quan trong: \n     Neu ban khoa tai khoan nay thi tat ca cac thong tin sau cua ban se bi huy \n     (Tai khoan chinh, tai khoan ky han, lich su giao dich,...)");
                    System.out.print("\nBan co muon khoa (1.yes/2.no): ");
                    int chon2 = Config.sc.nextInt();
                    if (chon2 == 1) {
                        dstk.xoaTaiKhoan(khDN.getMaKH());

                        System.out.println(
                                "\n\n**Khoa tai khoan thanh cong! \nCam on quy khach da chon ngan hang chung toi. Hen gap lai!");
                        // Main.main(null);
                    }
                    break;
                }

                default: {
                    break;
                }
            }
        } while (chon > 0 && chon < 9);
    }
}
