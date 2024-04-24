 /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.nhk.detai7;

import java.time.LocalDate;

/**
 *
 * @author admin
 */
public enum KyHan {
    MOT_TUAN(7, 2) {
        @Override
        public LocalDate tinhDaoHan(LocalDate d) {
            return d.plusDays(7);
        }

        @Override
        public double tinhTienLai(double st) {
            return (st * this.laiSuat) / (100 * 12 * 4);
        }
    },
    MOT_THANG(1, 5.5) {
        @Override
        public LocalDate tinhDaoHan(LocalDate d) {
            return d.plusMonths(1);
        }

        @Override
        public double tinhTienLai(double st) {
            return (st * this.laiSuat) / (100 * 12);
        }
    },
    SAU_THANG(6, 7.5) {
        @Override
        public LocalDate tinhDaoHan(LocalDate d) {
            return d.plusMonths(6);
        }

        @Override
        public double tinhTienLai(double st) {
            return (st * this.laiSuat) / (100 * 2);
        }
    },
    MOT_NAM(1, 7.9) {
        @Override
        public LocalDate tinhDaoHan(LocalDate d) {
            return d.plusYears(1);
        }

        @Override
        public double tinhTienLai(double st) {
            return (st * this.laiSuat) / 100;
        }
    };

    protected int khoangThoiGian;
    protected double laiSuat;

    private KyHan(int khoangTGian, double ls) {
        this.khoangThoiGian = khoangTGian;
        this.laiSuat = ls;
    }

    public abstract LocalDate tinhDaoHan(LocalDate d);

    public abstract double tinhTienLai(double st);
}

