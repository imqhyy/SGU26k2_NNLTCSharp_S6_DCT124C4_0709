using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mảng các chữ số cơ sở
        private readonly string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        // ==========================================
        // HÀM CHUYỂN SỐ THÀNH CHỮ (TỪ 1 ĐẾN 999)
        // ==========================================
        private string ChuyenSoThanhChu(int n)
        {
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int donVi = n % 10;

            string ketQua = "";

            // 1. Đọc hàng trăm (nếu có)
            if (tram > 0)
            {
                ketQua += chuSo[tram] + " Trăm ";
            }

            // 2. Đọc hàng chục
            if (chuc > 1)
            {
                ketQua += chuSo[chuc] + " Mươi ";
            }
            else if (chuc == 1)
            {
                ketQua += "Mười ";
            }
            else if (tram > 0 && chuc == 0 && donVi > 0)
            {
                ketQua += "Lẻ ";
            }

            // 3. Đọc hàng đơn vị
            if (donVi > 0)
            {
                if (chuc > 1 && donVi == 1)
                {
                    ketQua += "Mốt";
                }
                else if (chuc >= 1 && donVi == 5)
                {
                    ketQua += "Lăm";
                }
                else
                {
                    ketQua += chuSo[donVi];
                }
            }

            return ketQua.Trim();
        }

        // ==========================================
        // 1. NÚT THỰC HIỆN
        // ==========================================
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblKetQua.Text = "";

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtSoNhap.Text))
            {
                errorProvider1.SetError(txtSoNhap, "Vui lòng nhập một số!");
                txtSoNhap.Focus();
                return;
            }

            // Kiểm tra số nguyên hợp lệ trong khoảng 1 đến 999
            if (!int.TryParse(txtSoNhap.Text.Trim(), out int so) || so < 1 || so > 999)
            {
                errorProvider1.SetError(txtSoNhap, "Chỉ được nhập số nguyên từ 1 đến 999!");
                MessageBox.Show("Vui lòng nhập một số nguyên dương từ 1 đến 999!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoNhap.SelectAll();
                txtSoNhap.Focus();
                return;
            }

            // Đọc số và hiển thị ra Label kết quả
            lblKetQua.Text = ChuyenSoThanhChu(so);
        }

        // ==========================================
        // 2. NÚT XÓA (TRẢ LẠI TRẠNG THÁI BAN ĐẦU)
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoNhap.Clear();
            lblKetQua.Text = "";
            errorProvider1.Clear();
            txtSoNhap.Focus();
        }

        // ==========================================
        // 3. NÚT THOÁT VÀ XÁC NHẬN ĐÓNG FORM
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn thoát?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không đóng form
            }
        }

        // ==========================================
        // XÓA BÁO LỖI KHI ĐANG GÕ LẠI
        // ==========================================
        private void txtSoNhap_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoNhap.Text.Trim(), out int val) && val >= 1 && val <= 999)
            {
                errorProvider1.SetError(txtSoNhap, "");
            }
        }
    }
}
