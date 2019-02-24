using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class ChiTietHoaDonXuat
    {
        public string soChungTuXuat;
        public string maThuoc;
        public int donGiaBan;
        public int soLuongXuat;

        public ChiTietHoaDonXuat()
        {

        }

        public ChiTietHoaDonXuat(string soChungTuXuat, string maThuoc, int donGiaBan, int soLuongXuat)
        {
            this.soChungTuXuat = soChungTuXuat;
            this.maThuoc = maThuoc;
            this.donGiaBan = donGiaBan;
            this.soLuongXuat = soLuongXuat;
        }

        // Don gia ban
        public void setDonGiaBan(int donGiaBan)
        {
            this.donGiaBan = donGiaBan;
        }

        public int getDonGiaBan()
        {
            return this.donGiaBan;
        }

        // So luong xuat
        public void setSoLuongXuat(int soLuongXuat)
        {
            this.soLuongXuat = soLuongXuat;
        }

        public int getSoLuongXuat()
        {
            return this.soLuongXuat;
        }
    }
}
