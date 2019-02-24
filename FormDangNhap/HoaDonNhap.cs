using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class HoaDonNhap
    {
        public string maHoaDonNhap;
        public string soChungTuNhap;
        public string nhanVienNhap; // Ma nhan vien lap hoa don
        public string nhaCungCap;
        public DateTime thoiGianNhap;
        public int tongTienNhap;

        public HoaDonNhap()
        {

        }

        public HoaDonNhap(string maHoaDonNhap, string soChungTuNhap, string nhanVienNhap, string nhaCungCap, DateTime thoiGianNhap, int tongTienNhap)
        {
            this.maHoaDonNhap = maHoaDonNhap;
            this.soChungTuNhap = soChungTuNhap;
            this.nhanVienNhap = nhanVienNhap;
            this.nhaCungCap = nhaCungCap;
            this.thoiGianNhap = thoiGianNhap;
            this.tongTienNhap = tongTienNhap;
        }

        // So chung tu nhap
        public void setSoChungTuNhap(string soChungTuNhap)
        {
            this.soChungTuNhap = soChungTuNhap;
        }

        public string getSoChungTuNhap()
        {
            return this.soChungTuNhap;
        }

        // Nhan vien nhap
        public void setNhanVienNhap(string nhanVienNhap)
        {
            this.nhanVienNhap = nhanVienNhap;
        }

        public string getNhanVienNhap()
        {
            return this.nhanVienNhap;
        }

        // Nha cung cap
        public void setNhaCungCap(string nhaCungCap)
        {
            this.nhaCungCap = nhaCungCap;
        }

        public string getNhaCungCap()
        {
            return this.nhaCungCap;
        }

        // Thoi gian nhap
        public void setThoiGianNhan(DateTime thoiGianNhap)
        {
            this.thoiGianNhap = thoiGianNhap;
        }
        
        public DateTime getThoiGianNhap()
        {
            return this.thoiGianNhap;
        }

        // Tong tien nhap
        public void setTongTienNhap(int tongTienNhap)
        {
            this.tongTienNhap = tongTienNhap;
        }

        public int getTongTienNhap()
        {
            return this.tongTienNhap;
        }
    }
}
