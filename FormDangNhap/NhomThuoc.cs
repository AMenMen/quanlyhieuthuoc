using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class NhomThuoc
    {
        public string maNhomThuoc;
        public string tenNhomThuoc;

        // Ham xay dung khong doi so cua lop Nhom thuoc
        public NhomThuoc()
        {

        }

        // Ham xay dung co doi so cua Nhom thuoc
        public NhomThuoc(string maNhomThuoc, string tenNhomThuoc)
        {
            this.maNhomThuoc = maNhomThuoc;
            this.tenNhomThuoc = tenNhomThuoc;
        }

        // Ma nhom thuoc
        public void setMaNhomThuoc(string maNhomThuoc)
        {
            this.maNhomThuoc = maNhomThuoc;
        }

        public string getMaNhomThuoc()
        {
            return this.maNhomThuoc;
        }

        // Ten nhom thuoc
        public void setTenNhomThuoc(string tenNhomThuoc)
        {
            this.tenNhomThuoc = tenNhomThuoc;
        }

        public string getTenNhomThuoc()
        {
            return this.tenNhomThuoc;
        }
    }
}
