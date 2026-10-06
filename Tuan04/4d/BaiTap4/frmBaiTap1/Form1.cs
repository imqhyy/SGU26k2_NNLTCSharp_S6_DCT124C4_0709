using System;
using System.Drawing;
using System.Windows.Forms;

namespace frmBaiTap1
{
    public partial class Form1 : Form
    {
        // Biến lưu trữ tổng kết ca/cuối ngày
        private int tongSoLuotKhach = 0;
        private double tongDoanhThu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Form Load: Thiết lập trạng thái ban đầu khi mở chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            txtThanhTien.ReadOnly = true;
            txtTongSoLuotNguoi.ReadOnly = true;
            txtTongSoTien.ReadOnly = true;

            ResetFormNhap();
            txtTongSoLuotNguoi.Text = "0";
            txtTongSoTien.Text = "0 VND";
        }

        // Đưa khu vực nhập liệu về trạng thái trống ban đầu
        private void ResetFormNhap()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();

            // Bỏ chọn loại phòng
            radPhongDon.Checked = false;
            radPhongDoi.Checked = false;
            radPhongBa.Checked = false;

            // Bỏ chọn tiện nghi
            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            // Bỏ chọn dịch vụ
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            txtThanhTien.Text = "0 VND";

            // Thiết lập trạng thái nút bấm
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = (tongSoLuotKhach > 0);

            txtHoTen.Focus();
        }

        // 2. Kiểm tra điều kiện nhập liệu để bật nút Thanh Toán
        private void KiemTraNhapLieu_Event(object sender, EventArgs e)
        {
            bool coHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool coDiaChi = !string.IsNullOrWhiteSpace(txtDiaChi.Text);
            bool coSoNgayO = int.TryParse(txtSoNgayO.Text, out int soNgay) && soNgay > 0;
            bool coChonLoaiPhong = radPhongDon.Checked || radPhongDoi.Checked || radPhongBa.Checked;

            // Chỉ bật nút Thanh toán khi nhập đầy đủ thông tin bắt buộc
            btnThanhToan.Enabled = coHoTen && coDiaChi && coSoNgayO && coChonLoaiPhong;
        }

        // Chặn nhập ký tự chữ vào ô Số ngày ở
        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 3. Xử lý nút Thanh Toán: Tính tiền phòng của khách hiện tại
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soNgayO = int.Parse(txtSoNgayO.Text);
            double giaPhongNgay = 0;

            // Đơn giá phòng theo ngày
            if (radPhongDon.Checked) giaPhongNgay = 300000;
            else if (radPhongDoi.Checked) giaPhongNgay = 350000;
            else if (radPhongBa.Checked) giaPhongNgay = 400000;

            double tienPhong = giaPhongNgay * soNgayO;

            // Đơn giá tiện nghi: 10.000đ mỗi loại
            double tienTienNghi = 0;
            if (chkTivi.Checked) tienTienNghi += 10000;
            if (chkInternet.Checked) tienTienNghi += 10000;
            if (chkMayNuocNong.Checked) tienTienNghi += 10000;

            // Đơn giá dịch vụ: Karaoke 50.000đ, Ăn sáng 15.000đ/ngày
            double tienDichVu = 0;
            if (chkKaraoke.Checked) tienDichVu += 50000;
            if (chkAnSang.Checked) tienDichVu += (15000 * soNgayO);

            double tongTienKhach = tienPhong + tienTienNghi + tienDichVu;

            // Xuất thành tiền ra TextBox
            txtThanhTien.Text = $"{tongTienKhach:N0} VND";

            // Cộng dồn vào số liệu ca làm việc
            tongSoLuotKhach += 1;
            tongDoanhThu += tongTienKhach;

            // Cập nhật trạng thái nút bấm
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = true;
            btnTongKet.Enabled = true;
        }

        // 4. Xử lý nút Nhập Mới: Chuẩn bị đón lượt khách tiếp theo
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            ResetFormNhap();
        }

        // 5. Xử lý nút Tổng Kết: Xuất tổng kết ca, reset bộ đếm và xóa trắng form
        private void btnTongKet_Click(object sender, EventArgs e)
        {
            // Xuất số liệu tổng kết ra ô hiển thị
            txtTongSoLuotNguoi.Text = tongSoLuotKhach.ToString();
            txtTongSoTien.Text = $"{tongDoanhThu:N0} VND";

            // Khởi tạo lại giá trị tích lũy về 0 cho ca mới
            tongSoLuotKhach = 0;
            tongDoanhThu = 0;

            // Xóa trắng form nhập
            ResetFormNhap();

            // Mờ nút Tổng kết
            btnTongKet.Enabled = false;
        }

        // 6. Xử lý nút Thoát và hộp thoại xác nhận
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}