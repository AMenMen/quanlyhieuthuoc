using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormDangNhap
{
    class Thuoc
    {
        public string maThuoc;
        public string tenThuoc;
        public string maNhomThuoc;
        public string congDung;
        public string thanhPhan;
        public string xuatXu;
        public int soLuong;
        public string donViTinh;
        public double giaBan;
        
        // Ham xay dung khong tham so cua Thuoc
        public Thuoc()
        {

        }

        // Ham xay dung co tham so cua Thuoc
        public Thuoc(string maThuoc, string tenThuoc, string maNhomThuoc, string congDung, string thanhPhan, string xuatXu, int soLuong, string donViTinh, double giaBan)
        {
            this.maThuoc = maThuoc;
            this.tenThuoc = tenThuoc;
            this.maNhomThuoc = maNhomThuoc;
            this.congDung = congDung;
            this.thanhPhan = thanhPhan;
            this.xuatXu = xuatXu;
            this.soLuong = soLuong;
            this.donViTinh = donViTinh;
            this.giaBan = giaBan;
        }

        // Ten Thuoc
        public void setTenThuoc(string tenThuoc)
        {
            this.tenThuoc = tenThuoc;
        }

        public string getTenThuoc()
        {
            return this.tenThuoc;
        }

        // Cong dung
        public void setCongDung(string congDung)
        {
            this.congDung = congDung;
        }

        public string getCongDung()
        {
            return this.congDung;
        }

        // Thanh phan
        public void setThanhPhan(string thanhPhan)
        {
            this.thanhPhan = thanhPhan;
        }

        public string getThanhPhan()
        {
            return this.thanhPhan;
        }

        // Xuat xu

        public void setXuatXu(string xuatXu)
        {
            this.xuatXu = xuatXu;
        }

        public string getXuatXu()
        {
            return this.xuatXu;
        }

        // So luong
        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public int getSoLuong()
        {
            return this.soLuong;
        }

        // Don vi tinh
        public void setDonViTinh(string donViTinh)
        {
            this.donViTinh = donViTinh;
        }

        public string getDonViTinh()
        {
            return this.donViTinh;
        }

        // Gia ban
        public void setGiaBan(double giaBan)
        {
            this.giaBan = giaBan;
        }

        public double getGiaBan()
        {
            return this.giaBan;
        }


    }
}
