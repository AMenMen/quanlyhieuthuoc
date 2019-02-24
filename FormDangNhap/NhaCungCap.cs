using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class NhaCungCap
    {
        public string maNhaCungCap;
        public string tenNhaCungCap;

        // Ham xay dung khong tham so cua lop Nha cung cap
        public NhaCungCap()
        {

        }

        // Ham xay dung co doi so cua lop Nha cung cap
        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
        }

        // Ma nha cung cap
        public void setMaNhaCungCap(string maNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
        }

        public string getNhaCungCap()
        {
            return this.maNhaCungCap;
        }

        // Ten nha cung cap
        public void setTenNhaCungCap(string tenNhaCungCap)
        {
            this.tenNhaCungCap = tenNhaCungCap;
        }

        public string getTenNhaCungCap()
        {
            return this.tenNhaCungCap;
        }
    }
}
