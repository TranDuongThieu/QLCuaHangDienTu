﻿namespace CuaHangDienTu.Models
{
    public class ProductModel
    {
        public string MaMH { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Gia { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public int DaBan { get; set; }

        public ProductModel(string MaMH, string MaSP, string TenSP, int Gia, string HinhAnh, int SoLuong, int DaBan)
        {
            this.MaMH = MaMH;
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.Gia = Gia;
            this.DaBan = DaBan;
            this.SoLuong = SoLuong;
            this.HinhAnh = HinhAnh;
        }

    }
}
