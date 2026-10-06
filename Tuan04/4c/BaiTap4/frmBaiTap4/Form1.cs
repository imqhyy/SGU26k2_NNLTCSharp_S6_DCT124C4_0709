using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap4
{
    public partial class Form1 : Form
    {
        // Biến lưu số thứ nhất
        private double giaTriThuNhat = 0;
        // Biến lưu phép toán đang chọn (+, -, *, /)
        private string phepToan = "";
        // Cờ đánh dấu người dùng vừa bấm nút phép toán xong
        private bool isDangChonPhepToan = false;
        public Form1()
        {
            InitializeComponent();
        }



        // ==========================================
        // 1. SỰ KIỆN CLICK CHUNG CHO CÁC PHÍM SỐ (0-9)
        // ==========================================
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Nếu màn hình đang hiển thị 0 hoặc vừa bấm phép toán -> Xóa để gõ số mới
            if (txtHienThi.Text == "0" || isDangChonPhepToan)
            {
                txtHienThi.Text = btn.Text;
                isDangChonPhepToan = false;
            }
            else
            {
                txtHienThi.Text += btn.Text; // Nối tiếp số vào sau
            }
        }

        // ==========================================
        // 2. SỰ KIỆN CLICK CHUNG CHO CÁC PHÉP TOÁN (+, -, *, /)
        // ==========================================
        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Lưu lại số hiện tại trên màn hình
            if (double.TryParse(txtHienThi.Text, out double so))
            {
                giaTriThuNhat = so;
            }

            phepToan = btn.Text;        // Lưu lại phép toán vừa chọn
            isDangChonPhepToan = true;  // Đánh dấu để lần gõ số tiếp theo sẽ ghi đè màn hình
        }

        // ==========================================
        // 3. NÚT TÍNH KẾT QUẢ (=)
        // ==========================================
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phepToan)) return;

            if (!double.TryParse(txtHienThi.Text, out double giaTriThuHai))
            {
                return;
            }

            double ketQua = 0;

            switch (phepToan)
            {
                case "+":
                    ketQua = giaTriThuNhat + giaTriThuHai;
                    break;
                case "-":
                    ketQua = giaTriThuNhat - giaTriThuHai;
                    break;
                case "*":
                    ketQua = giaTriThuNhat * giaTriThuHai;
                    break;
                case "/":
                    if (giaTriThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHienThi.Text = "0";
                        phepToan = "";
                        return;
                    }
                    ketQua = giaTriThuNhat / giaTriThuHai;
                    break;
            }

            // Hiển thị kết quả ra màn hình
            txtHienThi.Text = ketQua.ToString();

            // Cập nhật lại giá trị thứ nhất bằng kết quả để có thể tiếp tục tính toán tiếp
            giaTriThuNhat = ketQua;
            phepToan = "";
            isDangChonPhepToan = true;
        }

        // ==========================================
        // 4. NÚT XÓA LÀM MỚI (C)
        // ==========================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "0";
            giaTriThuNhat = 0;
            phepToan = "";
            isDangChonPhepToan = false;
        }
    }
}
