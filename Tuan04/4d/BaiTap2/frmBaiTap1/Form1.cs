using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // 1. SỰ KIỆN FORM LOAD
        // ==========================================
        private void Form1_Load(object sender, EventArgs e)
        {
            btnGiai.Enabled = false;        // Ban đầu nút Giải mờ đi
            rdoBacNhat.Checked = true;      // Mặc định chọn PT bậc nhất
        }

        // ==========================================
        // 2. CHUYỂN ĐỔI CHẾ ĐỘ GIẢI
        // ==========================================
        private void rdoBacNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                // Bậc nhất: Ẩn/làm mờ ô nhập c
                txtC.Clear();
                txtC.Enabled = false;
                lblC.ForeColor = Color.Gray; // Đổi nhãn màu mờ đi
                errorProvider1.SetError(txtC, "");

                KiemTraDuLieuDeMoNutGiai();
            }
        }

        private void rdoBacHai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacHai.Checked)
            {
                // Bậc hai: Hiện và mở lại ô nhập c
                txtC.Enabled = true;
                lblC.ForeColor = Color.Black;

                KiemTraDuLieuDeMoNutGiai();
            }
        }

        // ==========================================
        // 3. KIỂM TRA ĐIỀU KIỆN ĐỂ MỞ SÁNG NÚT GIẢI
        // ==========================================
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieuDeMoNutGiai();
        }

        private void KiemTraDuLieuDeMoNutGiai()
        {
            bool duDieuKien = false;

            if (rdoBacNhat.Checked)
            {
                // Bậc nhất chỉ cần a và b được nhập
                if (!string.IsNullOrWhiteSpace(txtA.Text) && !string.IsNullOrWhiteSpace(txtB.Text))
                {
                    duDieuKien = true;
                }
            }
            else if (rdoBacHai.Checked)
            {
                // Bậc hai cần cả 3 ô a, b, c
                if (!string.IsNullOrWhiteSpace(txtA.Text) &&
                    !string.IsNullOrWhiteSpace(txtB.Text) &&
                    !string.IsNullOrWhiteSpace(txtC.Text))
                {
                    duDieuKien = true;
                }
            }

            btnGiai.Enabled = duDieuKien;
        }

        // ==========================================
        // 4. XỬ LÝ NÚT GIẢI
        // ==========================================
        private void btnGiai_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (!double.TryParse(txtA.Text.Trim(), out double a))
            {
                errorProvider1.SetError(txtA, "Hệ số a phải là một số hợp lệ!");
                hopLe = false;
            }

            if (!double.TryParse(txtB.Text.Trim(), out double b))
            {
                errorProvider1.SetError(txtB, "Hệ số b phải là một số hợp lệ!");
                hopLe = false;
            }

            double c = 0;
            if (rdoBacHai.Checked)
            {
                if (!double.TryParse(txtC.Text.Trim(), out c))
                {
                    errorProvider1.SetError(txtC, "Hệ số c phải là một số hợp lệ!");
                    hopLe = false;
                }
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng định dạng số!", "Lỗi nhập liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi class thực hiện giải
            if (rdoBacNhat.Checked)
            {
                PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b);
                txtKetQua.Text = pt.GiaiBacNhat();
            }
            else
            {
                PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
                txtKetQua.Text = pt.GiaiBacHai();
            }

            // Sau khi giải xong, nút Giải mờ đi theo yêu cầu đề bài
            btnGiai.Enabled = false;
        }

        // ==========================================
        // 5. NÚT THOÁT VÀ XÁC NHẬN ĐÓNG FORM
        // ==========================================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

    public class PhuongTrinhBacHai
    {
        // Thuộc tính a, b, c
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public PhuongTrinhBacHai()
        {
            A = B = C = 0;
        }

        // Dành cho phương trình bậc nhất: ax + b = 0
        public PhuongTrinhBacHai(double a, double b)
        {
            A = a;
            B = b;
            C = 0;
        }

        // Dành cho phương trình bậc hai: ax^2 + bx + c = 0
        public PhuongTrinhBacHai(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Giải phương trình bậc nhất: a*x + b = 0
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0)
                    return "Phương trình có vô số nghiệm";
                else
                    return "Phương trình vô nghiệm";
            }
            double x = -B / A;
            return $"Phương trình có nghiệm x = {x:F2}";
        }

        // Giải phương trình bậc hai: a*x^2 + b*x + c = 0
        public string GiaiBacHai()
        {
            if (A == 0)
            {
                // Trở về bậc nhất: B*x + C = 0
                if (B == 0)
                    return C == 0 ? "Phương trình có vô số nghiệm" : "Phương trình vô nghiệm";
                double x = -C / B;
                return $"Phương trình có nghiệm x = {x:F2}";
            }

            double delta = B * B - 4 * A * C;
            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return $"Phương trình có nghiệm kép\r\nx1 = x2 ={x:F2}";
            }
            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return $"Phương trình có 2 nghiệm phân biệt:\r\nx1 = {x1:F2}\r\nx2 = {x2:F2}";
            }
        }
    }
}
