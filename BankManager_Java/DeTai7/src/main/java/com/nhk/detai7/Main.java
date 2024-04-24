/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.time.LocalDate;

import com.nhk.bosung.MenuAdmin;
import com.nhk.bosung.Config;
import com.nhk.bosung.MenuUser;

/**
 *
 * @author 84355
 */
public class Main {
    public static void main(String[] args) {
        int chon1 = 0;
        KhachHang khDN;
        TaiKhoan tkChinhCuaKHDN;
        QuanLyKhachHang qlKH = new QuanLyKhachHang();
        QuanLyTaiKhoan qlTK = new QuanLyTaiKhoan();

        // =============DU LIEU SAN=================
        KhachHang kh1 = new KhachHang("Nguyen Hong Khang", "nam", "20/03/2002", "Binh Phuoc", "0123", "123");
        kh1.setPassword("123456");
        KhachHang kh2 = new KhachHang("Thu Phuong", "nu", "01/01/2002", "Binh Phuoc", "0124", "124");
        kh2.setPassword("123456");  
        KhachHang kh3 = new KhachHang("Tran A", "nu", "01/01/2002", "Ho Chi Minh", "0125", "125");

        TaiKhoan tk1 = new TaiKhoan(kh1, 2500000);
        Account tk2 = new TaiKhoan(kh2, 3000000);
        Account tk3 = new TaiKhoan(kh3, 3500000);

        Account tkkh1 = new TaiKhoanCoKyHan(kh1, KyHan.SAU_THANG, 500000, tk1);
        // tkkh1.ngayTao = LocalDate.of(2024, 01, 01);

        TaiKhoanCoKyHan tkkh2 = new TaiKhoanCoKyHan(kh1, KyHan.MOT_NAM, 200000, tk1);
        tkkh2.setNgayDaoHan(LocalDate.now());

        qlKH.themKhachHang(kh1, kh2, kh3);
        qlTK.themTaiKhoan(tk1, tk2, tk3, tkkh1, tkkh2);

        // ===============Menu=====================
        while (true) {
            System.out.print("\n\t***************************\n"
                    + "\t*  * * * * MENU * * *  *  *\n"
                    + "\t*  *                   *  *\n"
                    + "\t*  * 1. Mo Tai Khoan   *  *\n"
                    + "\t*  *                   *  *\n"
                    + "\t*  * 2. Dich vu khac   *  *\n"
                    + "\t*  *                   *  *\n"
                    + "\t*  * 3. Thoat          *  *\n"
                    + "\t*  *                   *  *\n"
                    + "\t*  * * * * * * * * * * *  *\n"
                    + "\t***************************\n"
                    + "Ban chon: ");
            chon1 = Config.sc.nextInt();
            switch (chon1) {
                case 1:
                    double soTienGui;
                    System.out.print("\n==== NHAP THONG TIN KHACH HANG ==== \n");
                    KhachHang kh = new KhachHang();
                    kh.nhapKhachHang();

                    System.out.print("So tien gui (>50000VND): ");
                    soTienGui = Config.sc.nextDouble();
                    do {
                        if (soTienGui < 50000) {
                            System.out.printf("Vui long nhap lai! (>50000VND): ");
                            soTienGui = Config.sc.nextDouble();
                        }
                    } while (soTienGui < 50000);

                    if (qlKH.isKhachHangDaCo(kh.getSoCCCD())) {
                        if (kh.isActive())
                            System.out.println("\n**Khach hang da ton tai! Tao tai khoan that bai!");
                        else if (!kh.isActive()) {
                            System.out.print("\n**Ban da tao tai khoan truoc do\nCo muon kich hoat lai (1.yes/2.no): ");
                            int chon3 = Config.sc.nextInt();
                            if (chon3 == 1) {
                                KhachHang a = qlKH.layKhachHang(kh.getSoCCCD());

                                System.out.print("\nBan van dung so dien thoai cu? (1.yes/2.no): ");
                                int chon4 = Config.sc.nextInt();
                                if (chon4 == 2) {
                                    Config.sc.nextLine();
                                    System.out.print("\nNhap so dien thoai hien tai cua ban: ");
                                    String phone = Config.sc.nextLine();

                                    if (qlKH.isSDTTonTai(phone)) {
                                        System.out.println("**So dien thoai da ton tai");
                                        break;
                                    }

                                    a.setSdt(phone);
                                }

                                a.setActive(true);
                                TaiKhoan taikhoann = new TaiKhoan(a, soTienGui);
                                qlTK.themTaiKhoan(taikhoann);
                                taikhoann.user.setPassword(KhachHang.taoMatKhauNgauNhien(6));

                                System.out.println("\n**Kich hoat lai tai khoan thanh cong!");
                                System.out.print(a);
                                System.out.printf("*  Mat khau: %s\n" + "* * * * * * * * * * * * * * * * * *\n",
                                        taikhoann.user.getPassword());
                            }
                            break;
                        }
                    } else {
                        qlKH.themKhachHang(kh);
                        TaiKhoan tk = new TaiKhoan(kh, soTienGui);
                        tk.user.setActive(true);
                        qlTK.themTaiKhoan(tk);

                        System.out.println("\n**TAO THANH CONG**");
                        System.out.println(tk);
                        System.out.printf("*  Mat khau: %s\n" + "* * * * * * * * * * * * * * * * * *\n",
                                tk.user.getPassword());
                    }
                    break;
                case 2:
                    System.out.println("\n===== Dang Nhap =====");
                    Config.sc.nextLine();
                    System.out.print("Ten dang nhap: ");
                    String username = Config.sc.nextLine();
                    System.out.print("Mat khau: ");
                    String password = Config.sc.nextLine();

                    if (username.equals("admin") && password.equals("123456")) {
                        // ===Menu Admin====
                        MenuAdmin.menuAdmin(qlTK, qlKH);
                        break;
                    }

                    khDN = qlKH.dangNhap(username, password);

                    if (khDN == null) {
                        System.out.println("\n**Thong tin dang nhap khong chinh xac!!");
                        break;
                    }
                    tkChinhCuaKHDN = qlTK.layTaiKhoanTheoSTK(khDN.getMaKH());
                    // ===Menu User====
                    MenuUser.menuUser(khDN, tkChinhCuaKHDN, qlTK);
                    break;

                default:{
                    System.out.println("**Cam on ban da dung chuong trinh");
                    break;
                }
            }

        }

    }
}
