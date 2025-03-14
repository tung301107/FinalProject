﻿namespace DTO
{
    public class DTO_VatLieu
    {
        public int MaVatLieu { get; set; }
        public string Ten { get; set; }
        public int Loai { get; set; }
        public string TenLoai { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuong { get; set; }
        public DTO_VatLieu() { }

        public DTO_VatLieu(int maVatLieu, string ten, string tenLoai, decimal donGiaNhap, decimal donGiaBan, string donViTinh, int soLuong)
        {
            MaVatLieu = maVatLieu;
            Ten = ten;
            TenLoai = tenLoai;
            DonGiaNhap = donGiaNhap;
            DonGiaBan = donGiaBan;
            DonViTinh = donViTinh;
            SoLuong = soLuong;
        }

    }
}
