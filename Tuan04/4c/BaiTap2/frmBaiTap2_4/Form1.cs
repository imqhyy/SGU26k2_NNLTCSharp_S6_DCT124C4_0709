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
        // 1. NÚT NHẬP (THÊM DÃY SỐ VÀ TÍNH TOÁN)
        // ==========================================
        private void btnNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // 1. Kiểm tra ô nhập có bị bỏ trống không
            if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một dãy số!");
                txtNhapSo.Focus();
                return;
            }

            // 2. Tách chuỗi thành các phần tử (hỗ trợ phân tách bằng dấu cách ' ' hoặc dấu phẩy ',')
            string[] tokens = txtNhapSo.Text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> danhSachMoi = new List<int>();

            // 3. Kiểm tra tính hợp lệ của từng phần tử trong chuỗi
            foreach (string item in tokens)
            {
                if (int.TryParse(item.Trim(), out int so))
                {
                    danhSachMoi.Add(so);
                }
                else
                {
                    errorProvider1.SetError(txtNhapSo, $"Phần tử '{item}' không phải là số nguyên hợp lệ!");
                    MessageBox.Show($"Giá trị '{item}' không đúng định dạng số nguyên. Vui lòng kiểm tra lại!",
                                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhapSo.SelectAll();
                    txtNhapSo.Focus();
                    return;
                }
            }

            // 4. Cập nhật danh sách (lưu dãy số mới nhập)
            danhSachSo = danhSachMoi;

            // 5. Hiển thị dãy số lên ô txtDaySo
            txtDaySo.Text = string.Join(" ", danhSachSo);

            // 6. Tính tổng dãy, tổng chẵn, tổng lẻ
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

            // 7. Hiển thị kết quả ra giao diện
            txtTongDay.Text = tongDay.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();
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
            if (!string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                errorProvider1.SetError(txtNhapSo, "");
            }
        }
    }
}
