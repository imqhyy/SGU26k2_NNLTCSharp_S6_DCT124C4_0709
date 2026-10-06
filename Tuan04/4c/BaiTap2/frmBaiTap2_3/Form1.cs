using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // THUẬT TOÁN TÌM UCLN VÀ BCNN
        // ==========================================
        // Dùng thuật toán Euclid tìm UCLN
        private long TimUCLN(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Công thức: BCNN(a, b) = (|a * b|) / UCLN(a, b)
        private long TimBCNN(long a, long b, long ucln)
        {
            return (a * b) / ucln;
        }

        // ==========================================
        // NÚT THỰC HIỆN
        // ==========================================
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            long a = 0, b = 0;

            // Kiểm tra số a (phải là số nguyên > 0)
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số a!");
                hopLe = false;
            }
            else if (!long.TryParse(txtA.Text.Trim(), out a) || a <= 0)
            {
                errorProvider1.SetError(txtA, "Số a phải là số nguyên dương lớn hơn 0!");
                hopLe = false;
            }

            // Kiểm tra số b (phải là số nguyên > 0)
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số b!");
                hopLe = false;
            }
            else if (!long.TryParse(txtB.Text.Trim(), out b) || b <= 0)
            {
                errorProvider1.SetError(txtB, "Số b phải là số nguyên dương lớn hơn 0!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng kiểm tra lại!",
                                "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán và hiển thị
            long ucln = TimUCLN(a, b);
            long bcnn = TimBCNN(a, b, ucln);

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // ==========================================
        // NÚT TIẾP TỤC (LÀM MỚI TRẠNG THÁI)
        // ==========================================
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            errorProvider1.Clear();
            txtA.Focus(); // Đưa con trỏ văn bản về ô số a
        }

        // ==========================================
        // NÚT THOÁT VÀ XÁC NHẬN ĐÓNG FORM
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Kích hoạt sự kiện FormClosing
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không cho đóng form
            }
        }

        // ==========================================
        // XÓA BÁO LỖI KHI ĐANG GÕ LẠI
        // ==========================================
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtA.Text.Trim(), out long val) && val > 0)
            {
                errorProvider1.SetError(txtA, "");
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtB.Text.Trim(), out long val) && val > 0)
            {
                errorProvider1.SetError(txtB, "");
            }
        }
    }
}
