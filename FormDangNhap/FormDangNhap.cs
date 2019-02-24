using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap();
        }

        private void KiemTraDangNhap()
        {
            // Lay du lieu tai khoan va mat khau nguoi dung nhap vao
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            // Kiem tra du lieu rong
            if (taiKhoan == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!");
                txtTaiKhoan.Focus(); // Dua con tro chuot ve lai o nhap tai khoan
            }
            else if (matKhau == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtMatKhau.Focus(); // Dua con tro chuot ve lai o nhap mat khau
            }
            else
            {
                // Kiem tra tai khoan va mat khau có dung hay khong
                if (taiKhoan == "kiet" && matKhau == "12345678")
                {
                    MessageBox.Show("Đăng nhập thành công!"); 
                    TrangChu trangChu = new TrangChu(); // Tao moi mot trang chu khi dang nhap thanh cong
                    trangChu.Show(); // Show trang chu len
                    this.Hide(); // An form hien tai - form dang nhap
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu bị sai!");
                    txtMatKhau.Focus(); // Dua con tro chuot ve lai o mat khau
                    txtMatKhau.SelectAll(); // To den mat khau
                }
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void nhapVao_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hoi truoc khi thoat
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel);
            if(dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Su dung phim enter de ra lenh dang nhap
            if((Keys)e.KeyChar == Keys.Enter)
            {
                //MessageBox.Show("Bắt được Enter");
                KiemTraDangNhap();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !checkBox1.Checked; // An/Hien noi dung mat khau
        }
    }
}
