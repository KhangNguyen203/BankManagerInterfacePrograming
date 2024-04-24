/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.bosung;

import java.util.List;

import com.nhk.detai7.Account;
import com.nhk.detai7.KhachHang;
import com.nhk.detai7.QuanLyKhachHang;
import com.nhk.detai7.QuanLyTaiKhoan;
import com.nhk.detai7.TaiKhoan;

/**
 *
 * @author 84355
 */
public class MenuAdmin {
    public static void menuAdmin(QuanLyTaiKhoan dstk, QuanLyKhachHang dskh) {
        int chon;
        do {
            System.out.printf("\n\t*************** MENU QUAN TRI VIEN **************\n"
                    + "\t* 1. Tra cuu khach hang theo ho ten & STK       *\n"
                    + "\t* 2. Tra cuu danh sach tai khoan cua khach hang *\n"
                    + "\t* 3. Sap xep khach hang giam dan theo so du     *\n"
                    + "\t* 4. Danh Sach tai khoan trong he thong         *\n"
                    + "\t* 5. Danh Sach khach hang trong he thong        *\n"
                    + "\t* 6. Dang xuat                                  *\n"
                    + "\t*************************************************\n"
                    + "Ban chon: ");
            chon = Config.sc.nextInt();

            switch (chon) {
                case 1: {
                    // Tra cuu khach hang theo ho ten & STK
                    Config.sc.nextLine();
                    System.out.print("Nhap so tai khoan can tra cuu: ");
                    String stkTC = Config.sc.nextLine();
                    System.out.print("Nhap ten khach hang can tra cuu: ");
                    String tenTC = Config.sc.nextLine();

                    KhachHang khTC = dskh.layKhachHang(tenTC, stkTC);

                    if (khTC == null) {
                        System.out.println("\n**Thong tin khong chinh xac");
                        break;
                    }
                    System.out.print(khTC);
                    break;
                }
                case 2: {
                    // Tra cuu danh sach tai khoan cua khach hang
                    Config.sc.nextLine();
                    System.out.print("Nhap ma khach can tra cuu: ");
                    String maKH = Config.sc.nextLine();

                    List<Account> list = dstk.layDanhSachTaiKhoan(maKH);

                    if (list.isEmpty()) {
                        System.out.println("\n**So tai khoan khong ton tai");
                        break;
                    }

                    System.out.printf("\n====TAI KHOAN CUA %s====\n", maKH);
                    for (Account account : list) {
                        System.out.println(account);
                    }
                    break;
                }

                case 3: {
                    // Sap xep tai khoan giam dan theo so su
                    System.out.println("\n====SAP XEP KHACH HANG====");
                    dstk.sapXepTaiKhoanGiamDanTheoSoDu();
                    List<TaiKhoan> list3 = dstk.layDanhSachTaiKhoan();

                    list3.forEach(s -> System.out.println(s));

                    break;
                }
                case 4: {
                    // Danh Sach cac tai khoan trong he thong
                    System.out.println("\n====TAI KHOAN TRONG HE THONG====");
                    dstk.XuatTatCaTaiKhoan();
                    break;
                }
                case 5: {
                    // Danh Sach cac khach hang trong he thong
                    System.out.println("\n====KHACH HANG TRONG HE THONG====");
                    dskh.XuatDSKhachHang();
                    break;
                }

                default: {
                    break;
                }
            }
        } while (chon < 6);
    }
}
