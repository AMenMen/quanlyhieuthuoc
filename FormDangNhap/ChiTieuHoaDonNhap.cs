using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class ChiTieuHoaDonNhap
    {
        public string soChungTuNhap;
        public string maThuoc;
        public int donGiaVon; // Don gia von
        public int soLuongNhap;

        public ChiTieuHoaDonNhap()
        {

        }

        public ChiTieuHoaDonNhap(string soChungTuNhap, string maThuoc, int donGiaVon, int soLuongNhap)
        {
            this.soChungTuNhap = soChungTuNhap;
            this.maThuoc = maThuoc;
            this.donGiaVon = donGiaVon;
            this.soLuongNhap = soLuongNhap;
        }

        // Don gia von
        public void setDonGiaVon(int donGiaVon)
        {
            this.donGiaVon = donGiaVon;
        }

        public int getDonGiaVon()
        {
            return this.donGiaVon;
        }

        // So luong nhap
        public void setSoLuongNhap(int soLuongNhap)
        {
            this.soLuongNhap = soLuongNhap;
        }

        public int getSoLuongNhap()
        {
            return this.soLuongNhap;
        }
    }
}
