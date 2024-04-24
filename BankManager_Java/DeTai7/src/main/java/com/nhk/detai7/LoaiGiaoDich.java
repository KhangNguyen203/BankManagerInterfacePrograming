package com.nhk.detai7;

public enum LoaiGiaoDich {
    Rut {
        @Override
        public String show() {
            return"withdrawal";
        }
    },

    Nop {
        @Override
        public String show() {  
            return "deposit";
        }
    };

    public abstract String show();
}
