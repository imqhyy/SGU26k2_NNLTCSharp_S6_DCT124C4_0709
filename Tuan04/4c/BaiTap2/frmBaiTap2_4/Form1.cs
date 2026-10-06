using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap2_4
{
    public partial class Form1 : Form
    {
        // Khai báo một danh sách số nguyên để lưu các số người dùng đã nhập
        private List<int> danhSachSo = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // 1. NÚT NHẬP (THÊM SỐ VÀO DÃY VÀ TÍNH TOÁN)
        // ==========================================
        private void btnNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số nguyên!");
                txtNhapSo.Focus();
                return;
            }

            if (!int.TryParse(txtNhapSo.Text.Trim(), out int so))
            {
                errorProvider1.SetError(txtNhapSo, "Giá trị nhập phải là một số nguyên hợp lệ!");
                MessageBox.Show("Vui lòng chỉ nhập số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapSo.SelectAll();
                txtNhapSo.Focus();
                return;
            }

            // 1. Lưu số vào danh sách
            danhSachSo.Add(so);

            // 2. Hiển thị dãy số đã nhập (nối các số cách nhau bởi khoảng trắng)
            txtDaySo.Text = string.Join(" ", danhSachSo);

            // 3. Tính toán tổng dãy, tổng chẵn, tổng lẻ
            int tongDay = 0;
            int tongChan = 0;
            int tongLe = 0;

            foreach (int x in danhSachSo)
            {
                tongDay += x;
                if (x % 2 == 0)
                {
                    tongChan += x;
                }
                else
                {
                    tongLe += x;
                }
            }

            // 4. Xuất kết quả ra các ô
            txtTongDay.Text = tongDay.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();

            // 5. Chuẩn bị cho lần nhập tiếp theo
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // ==========================================
        // 2. NÚT TIẾP TỤC (TRẢ VỀ TRẠNG THÁI BAN ĐẦU)
        // ==========================================
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // Xóa sạch danh sách số đã lưu
            danhSachSo.Clear();

            // Xóa trắng toàn bộ các ô nhập/kết quả
            txtNhapSo.Clear();
            txtDaySo.Clear();
            txtTongDay.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            errorProvider1.Clear();

            // Đưa con trỏ về ô Nhập số
            txtNhapSo.Focus();
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
        // 4. XÓA BÁO LỖI KHI ĐANG GÕ LẠI
        // ==========================================
        private void txtNhapSo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapSo.Text.Trim(), out _))
            {
                errorProvider1.SetError(txtNhapSo, "");
            }
        }
    }
}
