using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ==========================================
        // 1. SỰ KIỆN CLICK CHỌN / HỦY CHỌN GHẾ DÙNG CHUNG
        // ==========================================
        private void btnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // 1. Nếu ghế đã bán (màu vàng) -> Cảnh báo
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế số " + btn.Text + " này đã được bán! Vui lòng chọn ghế khác.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 2. Nếu ghế đang chọn (màu xanh) -> Bấm lại để HỦY CHỌN, trả về màu trắng
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
            // 3. Nếu ghế chưa bán (trắng hoặc màu mặc định ban đầu) -> CHỌN GHẾ, chuyển sang màu xanh
            else
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White; // Chữ trắng cho nổi trên nền xanh
            }
        }

        // ==========================================
        // HÀM TÍNH TIỀN CHO TỪNG GHẾ THEO LÔ
        // ==========================================
        private int LayGiaVeTheoGhe(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5)
            {
                return 1000; // Lô A: Ghế 1 đến 5
            }
            else if (soGhe >= 6 && soGhe <= 10)
            {
                return 1500; // Lô B: Ghế 6 đến 10
            }
            else if (soGhe >= 11 && soGhe <= 15)
            {
                return 2000; // Lô C: Ghế 11 đến 15
            }
            return 0;
        }

        // ==========================================
        // 2. NÚT CHỌN (THANH TOÁN)
        // ==========================================
        private void btnChon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soGheChon = 0;

            // Duyệt bên trong groupBox1 thay vì this.Controls
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is Button btn && btn.BackColor == Color.Blue)
                {
                    if (int.TryParse(btn.Text, out int soGhe))
                    {
                        tongTien += LayGiaVeTheoGhe(soGhe);
                        soGheChon++;

                        // Chuyển ghế sang màu vàng (đã bán)
                        btn.BackColor = Color.Yellow;
                        btn.ForeColor = Color.Black;
                    }
                }
            }

            if (soGheChon == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị tổng số tiền ra ô Thành Tiền
            txtThanhTien.Text = tongTien.ToString();
            MessageBox.Show($"Bạn đã mua thành công {soGheChon} vé.\nTổng số tiền: {tongTien} đ",
                            "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================
        // 3. NÚT HỦY BỎ
        // ==========================================
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Duyệt bên trong groupBox1 chứa 15 nút ghế
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is Button btn && btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            // Đặt Thành Tiền về 0
            txtThanhTien.Text = "0";
        }

        // ==========================================
        // 4. NÚT KẾT THÚC & HỎI XÁC NHẬN THOÁT
        // ==========================================
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn kết thúc chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true; // Ngăn không cho đóng Form
            }
        }

        
    }
}
