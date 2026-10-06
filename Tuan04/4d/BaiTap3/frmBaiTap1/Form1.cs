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
        // Biến tích lũy tổng kết
        private int tongSoKhachHang = 0;
        private double tongDoanhThu = 0;
        private double tienKhachHienTai = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Form Load: Trạng thái ban đầu
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetFormNhap();
            txtTongKhachHang.Text = "0";
            txtTongTienThanhToan.Text = "0 đ";
        }

        // Hàm đưa form về trạng thái nhập mới
        private void ResetFormNhap()
        {
            txtTenKhachHang.Clear();
            txtSoKhachHang.Clear();
            chkSinhVien.Checked = false;

            // Bỏ chọn radio button nước uống
            radCafeDen.Checked = false;
            radCafeDa.Checked = false;
            radCafeSua.Checked = false;
            radCafeKem.Checked = false;
            radCafeSua.Checked = false;

            // Bỏ chọn checkbox thức ăn
            chkBanhMyTrung.Checked = false;
            chkBanhMyCa.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;
            chkMyTomTrung.Checked = false;

            // Trạng thái các nút bấm
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            tienKhachHienTai = 0;
            txtTenKhachHang.Focus();
        }

        // 2. Kiểm tra điều kiện bật nút Tính Tiền
        private void KiemTraThongTinNhap()
        {
            bool coTen = !string.IsNullOrWhiteSpace(txtTenKhachHang.Text);
            bool coSoKhach = int.TryParse(txtSoKhachHang.Text, out int soLuong) && soLuong > 0;

            bool coChonNuoc = radCafeDen.Checked || radCafeDa.Checked ||
                             radCafeSua.Checked || radCafeKem.Checked || radCafeSua.Checked;

            bool coChonMonAn = chkBanhMyTrung.Checked || chkBanhMyCa.Checked ||
                               chkMyXaoBo.Checked || chkMyCay.Checked || chkMyTomTrung.Checked;

            // Bật nút Tính tiền khi đã điền tên, số khách và có gọi món (nước hoặc đồ ăn)
            btnTinhTien.Enabled = coTen && coSoKhach && (coChonNuoc || coChonMonAn);
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            KiemTraThongTinNhap();
        }

        private void txtSoKhachHang_TextChanged(object sender, EventArgs e)
        {
            KiemTraThongTinNhap();
        }

        private void Mon_CheckedChanged(object sender, EventArgs e)
        {
            KiemTraThongTinNhap();
        }

        // Chặn không cho nhập chữ vào ô số khách hàng
        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 3. Xử lý nút Tính Tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double tongTienNuoc = 0;
            double tongTienThucAn = 0;

            // Đơn giá nước uống
            if (radCafeDen.Checked) tongTienNuoc = 20000;
            else if (radCafeDa.Checked) tongTienNuoc = 25000;
            else if (radCafeSua.Checked) tongTienNuoc = 25000;
            else if (radCafeSua.Checked) tongTienNuoc = 30000;
            else if (radCafeKem.Checked) tongTienNuoc = 35000;

            // Đơn giá thức ăn
            if (chkBanhMyTrung.Checked) tongTienThucAn += 15000;
            if (chkBanhMyCa.Checked) tongTienThucAn += 15000;
            if (chkMyTomTrung.Checked) tongTienThucAn += 20000;
            if (chkMyXaoBo.Checked) tongTienThucAn += 30000;
            if (chkMyCay.Checked) tongTienThucAn += 50000;

            double tongTienChuaGiam = tongTienNuoc + tongTienThucAn;

            // Áp dụng giảm 20% nếu là Sinh viên
            if (chkSinhVien.Checked)
            {
                tienKhachHienTai = tongTienChuaGiam * 0.8;
            }
            else
            {
                tienKhachHienTai = tongTienChuaGiam;
            }

            MessageBox.Show(
                $"Khách hàng: {txtTenKhachHang.Text.Trim()}\n" +
                $"Số lượng: {txtSoKhachHang.Text} người\n" +
                $"Tổng số tiền cần thanh toán: {tienKhachHienTai:N0} VNĐ" +
                (chkSinhVien.Checked ? " (Đã giảm 20% SV)" : ""),
                "Hóa đơn thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        // 4. Xử lý nút Nhập lại
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            ResetFormNhap();
        }

        // 5. Xử lý nút Thanh toán (Cộng dồn vào hệ thống)
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoKhachHang.Text, out int soKhach))
            {
                tongSoKhachHang += soKhach;
            }
            tongDoanhThu += tienKhachHienTai;

            txtTongKhachHang.Text = tongSoKhachHang.ToString();
            txtTongTienThanhToan.Text = $"{tongDoanhThu:N0} VNĐ";

            btnThanhToan.Enabled = false;
            ResetFormNhap();
        }

        // 6. Xử lý nút Thoát và xác nhận khi đóng form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
