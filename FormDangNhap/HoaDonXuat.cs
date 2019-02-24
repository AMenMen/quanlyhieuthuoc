using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class HoaDonXuat
    {
        public string maHoaDonXuat;
        public string soChungTuXuat;
        public string nhanVienXuat; // Ma nhan vien lap hoa don xuat
        public DateTime thoiGianXuat;
        public int tongTienBan;

        public HoaDonXuat()
        {

        }

        public HoaDonXuat(string maHoaDonXuat, string soChungTuXuat, string nhanVienXuat, DateTime thoiGianXuat, int tongTienBan)
        {
            this.maHoaDonXuat = maHoaDonXuat;
            this.soChungTuXuat = soChungTuXuat;
            this.nhanVienXuat = nhanVienXuat;
            this.thoiGianXuat = thoiGianXuat;
            this.tongTienBan = tongTienBan;
        }

        // So chung tu xuat
        public void setSoChungTuXuat(string soChungTuXuat)
        {
            this.soChungTuXuat = soChungTuXuat;
        }

        public string getSoChungTuXuat()
        {
            return this.soChungTuXuat;
        }

        // Nhan vien xuat
        public void setNhanVienXuat(string nhanVienXuat)
        {
            this.nhanVienXuat = nhanVienXuat;
        }

        public string getNhanVienXuat()
        {
            return this.nhanVienXuat;
        }

        // Thoi gian xuat
        public void setThoiGianXuat(DateTime thoiGianXuat)
        {
            this.thoiGianXuat = thoiGianXuat;
        }

        public DateTime getThoiGianXuat()
        {
            return this.thoiGianXuat;
        }

        // Tong tien ban
        public void setTongTienBan(int tongTienBan)
        {
            this.tongTienBan = tongTienBan;
        }

        public int getTongTienBan()
        {
            return this.tongTienBan;
        }

    }
}
