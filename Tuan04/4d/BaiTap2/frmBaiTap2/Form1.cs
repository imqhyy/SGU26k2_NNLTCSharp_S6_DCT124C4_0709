using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace frmBaiTap2
{
    public partial class Form1 : Form
    {
        private MangSoNguyen mang = new MangSoNguyen();
        private bool daNhapMang = false;

        public Form1()
        {
            InitializeComponent();
        }

        // =========================================================
        // 1. NÚT "Nhập mảng :"
        // =========================================================
        private void btnNhapMang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhapMang.Text))
            {
                MessageBox.Show("Vui lòng nhập các phần tử của mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapMang.Focus();
                daNhapMang = false;
                return;
            }

            if (!mang.KhoiTaoTuChuoi(txtNhapMang.Text))
            {
                MessageBox.Show("Dữ liệu mảng không hợp lệ! Vui lòng chỉ nhập các số nguyên cách nhau bằng khoảng trắng.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapMang.SelectAll();
                txtNhapMang.Focus();
                daNhapMang = false;
                return;
            }

            daNhapMang = true;
            txtKetQuaMang.Text = mang.XuatChuoi();
            MessageBox.Show($"Nhập mảng thành công với {mang.SoPhanTu} phần tử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraMangHopLe()
        {
            if (!daNhapMang || mang.SoPhanTu == 0)
            {
                MessageBox.Show("Vui lòng nhấn nút [Nhập mảng :] trước khi thực hiện thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapMang.Focus();
                return false;
            }
            return true;
        }

        // =========================================================
        // 2. SẮP XẾP
        // =========================================================
        private void btnThucHienSapXep_Click(object sender, EventArgs e)
        {
            if (!KiemTraMangHopLe()) return;

            if (rdoTang.Checked)
                mang.SapXepTang();
            else
                mang.SapXepGiam();

            txtKetQuaMang.Text = mang.XuatChuoi();
            txtNhapMang.Text = mang.XuatChuoi();
        }

        // =========================================================
        // 3. TÌM KIẾM
        // =========================================================
        private void rdoTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQuaTim.Clear();

            if (rdoTimGiaTri.Checked)
            {
                lblKetQuaTim.Text = "Vị trí tìm được là :";
                txtTimGiaTri.Enabled = true;
                txtTimViTri.Enabled = false;
                txtTimViTri.Clear();
                txtTimGiaTri.Focus();
            }
            else if (rdoTimViTri.Checked)
            {
                lblKetQuaTim.Text = "Số tìm được là :";
                txtTimViTri.Enabled = true;
                txtTimGiaTri.Enabled = false;
                txtTimGiaTri.Clear();
                txtTimViTri.Focus();
            }
        }

        private void txtTimGiaTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!KiemTraMangHopLe()) return;

                if (!int.TryParse(txtTimGiaTri.Text.Trim(), out int val))
                {
                    MessageBox.Show("Vui lòng nhập giá trị cần tìm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int index = mang.TimViTriCuaGiaTri(val);
                txtKetQuaTim.Text = index != -1 ? index.ToString() : "Không tìm thấy";
            }
        }

        private void txtTimViTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!KiemTraMangHopLe()) return;

                if (!int.TryParse(txtTimViTri.Text.Trim(), out int viTri))
                {
                    MessageBox.Show("Vui lòng nhập vị trí hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    txtKetQuaTim.Text = mang.LayGiaTriTaiViTri(viTri).ToString();
                }
                catch
                {
                    txtKetQuaTim.Text = "Không có";
                    MessageBox.Show("Vị trí nằm ngoài phạm vi mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================
        // 4. XÓA (KIỂM TRA TÍNH TĂNG DẦN THỰC TẾ CỦA MẢNG)
        // =========================================================
        private void rdoXoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoXoaGiaTri.Checked)
            {
                txtXoaGiaTri.Enabled = true;
                txtXoaViTri.Enabled = false;
                txtXoaViTri.Clear();
                txtXoaGiaTri.Focus();
            }
            else if (rdoXoaViTri.Checked)
            {
                txtXoaViTri.Enabled = true;
                txtXoaGiaTri.Enabled = false;
                txtXoaGiaTri.Clear();
                txtXoaViTri.Focus();
            }
        }

        private void txtXoaGiaTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!KiemTraMangHopLe()) return;

                // Kiểm tra trực tiếp mảng hiện thời có đang tăng dần không
                if (!mang.KiemTraSapXepTang())
                {
                    MessageBox.Show("Cần sắp xếp tăng dần trước khi thực hiện thao tác xóa!", "Cần sắp xếp tăng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtXoaGiaTri.Text.Trim(), out int giaTri))
                {
                    MessageBox.Show("Vui lòng nhập giá trị cần xóa hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mang.XoaTheoGiaTri(giaTri))
                {
                    txtKetQuaMang.Text = mang.XuatChuoi();
                    txtNhapMang.Text = mang.XuatChuoi();
                    txtXoaGiaTri.Clear();
                    MessageBox.Show("Đã xóa phần tử thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị cần xóa trong mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtXoaViTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!KiemTraMangHopLe()) return;

                if (!mang.KiemTraSapXepTang())
                {
                    MessageBox.Show("Cần sắp xếp tăng dần trước khi thực hiện thao tác xóa!", "Cần sắp xếp tăng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtXoaViTri.Text.Trim(), out int viTri))
                {
                    MessageBox.Show("Vui lòng nhập vị trí cần xóa hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mang.XoaTaiViTri(viTri))
                {
                    txtKetQuaMang.Text = mang.XuatChuoi();
                    txtNhapMang.Text = mang.XuatChuoi();
                    txtXoaViTri.Clear();
                    MessageBox.Show("Đã xóa phần tử tại vị trí chỉ định!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vị trí cần xóa nằm ngoài phạm vi mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================
        // 5. THÊM (KHÔNG DÙNG RADIOBUTTON, GÕ XONG TẠI VỊ TRÍ THÌ ENTER)
        // =========================================================
        private void txtViTriThem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (!KiemTraMangHopLe()) return;

                // Kiểm tra trực tiếp xem mảng trước đó có đang xếp tăng hay không
                if (!mang.KiemTraSapXepTang())
                {
                    MessageBox.Show("Cần sắp xếp tăng dần trước khi thực hiện thao tác thêm!", "Cần sắp xếp tăng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtGiaTriThem.Text.Trim(), out int giaTri) ||
                    !int.TryParse(txtViTriThem.Text.Trim(), out int viTri))
                {
                    MessageBox.Show("Vui lòng nhập giá trị và vị trí thêm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (mang.ThemTaiViTri(giaTri, viTri))
                {
                    txtKetQuaMang.Text = mang.XuatChuoi();
                    txtNhapMang.Text = mang.XuatChuoi();

                    txtGiaTriThem.Clear();
                    txtViTriThem.Clear();
                    txtGiaTriThem.Focus();

                    MessageBox.Show("Đã chèn phần tử vào mảng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vị trí thêm nằm ngoài giới hạn mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================================================
        // 6. THAY THẾ (2 TEXTBOX THEO RADIO, NHẬP SỐ THAY THẾ VÀ ENTER)
        // =========================================================
        private void rdoThayThe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThayTheGiaTri.Checked)
            {
                txtGiaTriCanThay.Enabled = true;
                txtViTriCanThay.Enabled = false;
                txtViTriCanThay.Clear();
                txtGiaTriCanThay.Focus();
            }
            else if (rdoThayTheViTri.Checked)
            {
                txtViTriCanThay.Enabled = true;
                txtGiaTriCanThay.Enabled = false;
                txtGiaTriCanThay.Clear();
                txtViTriCanThay.Focus();
            }
        }

        private void txtSoThayThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Chặn tiếng bíp mặc định của Windows
                if (!KiemTraMangHopLe()) return;

                // 1. Kiểm tra số mới muốn thay thế vào
                if (!int.TryParse(txtSoThayThe.Text.Trim(), out int soMoi))
                {
                    MessageBox.Show("Vui lòng nhập số thay thế hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSoThayThe.Focus();
                    return;
                }

                bool ketQua = false;

                // 2. Trường hợp thay thế theo GIÁ TRỊ
                if (rdoThayTheGiaTri.Checked)
                {
                    if (!int.TryParse(txtGiaTriCanThay.Text.Trim(), out int cu))
                    {
                        MessageBox.Show("Vui lòng nhập giá trị cũ cần thay thế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtGiaTriCanThay.Focus();
                        return;
                    }
                    ketQua = mang.ThayTheTheoGiaTri(cu, soMoi);
                }
                // 3. Trường hợp thay thế theo VỊ TRÍ (Index)
                else if (rdoThayTheViTri.Checked)
                {
                    if (!int.TryParse(txtViTriCanThay.Text.Trim(), out int viTri))
                    {
                        MessageBox.Show("Vui lòng nhập vị trí cần thay thế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtViTriCanThay.Focus();
                        return;
                    }
                    ketQua = mang.ThayTheTaiViTri(viTri, soMoi);
                }

                // 4. Cập nhật kết quả lên giao diện
                if (ketQua)
                {
                    txtKetQuaMang.Text = mang.XuatChuoi();
                    txtNhapMang.Text = mang.XuatChuoi();

                    // Xóa trắng các ô nhập của nhóm thay thế
                    txtGiaTriCanThay.Clear();
                    txtViTriCanThay.Clear();
                    txtSoThayThe.Clear();

                    MessageBox.Show("Thay thế phần tử thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị hoặc vị trí cần thay thế trong mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // =========================================================
        // 7. TỔNG & MAX - MIN
        // =========================================================
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (!KiemTraMangHopLe()) return;

            txtTongMang.Text = mang.TongMang().ToString();
            txtTongChan.Text = mang.TongChan().ToString();
            txtTongLe.Text = mang.TongLe().ToString();
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (!KiemTraMangHopLe()) return;

            txtMax.Text = mang.TimMax().ToString();
            txtMin.Text = mang.TimMin().ToString();
        }

        // =========================================================
        // RESET & THOÁT
        // =========================================================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNhapMang.Clear();
            txtKetQuaMang.Clear();
            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtTimGiaTri.Clear();
            txtTimViTri.Clear();
            txtKetQuaTim.Clear();
            txtXoaGiaTri.Clear();
            txtXoaViTri.Clear();
            txtGiaTriThem.Clear();
            txtViTriThem.Clear();
            txtGiaTriCanThay.Clear();
            txtViTriCanThay.Clear();
            txtSoThayThe.Clear();

            daNhapMang = false;
            txtNhapMang.Focus();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Sắp xếp mặc định tăng
            rdoTang.Checked = true;

            // 2. Tìm kiếm: chọn sẵn Tìm vị trí
            rdoTimViTri.Checked = true;
            txtTimViTri.Enabled = true;
            txtTimGiaTri.Enabled = false;

            // 3. Xóa: chọn sẵn Xóa vị trí
            rdoXoaViTri.Checked = true;
            txtXoaViTri.Enabled = true;
            txtXoaGiaTri.Enabled = false;

            // 4. Thay thế: chọn sẵn Giá trị cần thay thế
            rdoThayTheGiaTri.Checked = true;
            txtGiaTriCanThay.Enabled = true;
            txtViTriCanThay.Enabled = false;
        }
    }

    // =========================================================
    // CLASS QUẢN LÝ MẢNG
    // =========================================================
    public class MangSoNguyen
    {
        private List<int> arr;

        public MangSoNguyen()
        {
            arr = new List<int>();
        }

        public bool KhoiTaoTuChuoi(string input)
        {
            arr.Clear();
            if (string.IsNullOrWhiteSpace(input)) return false;

            string[] tokens = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string t in tokens)
            {
                if (int.TryParse(t, out int val))
                {
                    arr.Add(val);
                }
                else
                {
                    return false;
                }
            }
            return arr.Count > 0;
        }

        public string XuatChuoi()
        {
            return string.Join(" ", arr);
        }

        public void SapXepTang()
        {
            arr.Sort();
        }

        public void SapXepGiam()
        {
            arr.Sort((a, b) => b.CompareTo(a));
        }

        // Kiểm tra thực tế xem các phần tử hiện tại có đang theo thứ tự tăng dần không
        public bool KiemTraSapXepTang()
        {
            if (arr.Count <= 1) return true;
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }

        public int TimViTriCuaGiaTri(int giaTri)
        {
            return arr.IndexOf(giaTri);
        }

        public int LayGiaTriTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < arr.Count)
                return arr[viTri];
            throw new IndexOutOfRangeException();
        }

        public bool XoaTheoGiaTri(int giaTri)
        {
            return arr.Remove(giaTri);
        }

        public bool XoaTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < arr.Count)
            {
                arr.RemoveAt(viTri);
                return true;
            }
            return false;
        }

        public bool ThemTaiViTri(int giaTri, int viTri)
        {
            if (viTri >= 0 && viTri <= arr.Count)
            {
                arr.Insert(viTri, giaTri);
                return true;
            }
            return false;
        }

        public int TongMang() => arr.Sum();
        public int TongChan() => arr.Where(x => x % 2 == 0).Sum();
        public int TongLe() => arr.Where(x => x % 2 != 0).Sum();

        public int TimMax() => arr.Count > 0 ? arr.Max() : 0;
        public int TimMin() => arr.Count > 0 ? arr.Min() : 0;

        public bool ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi)
        {
            int index = arr.IndexOf(giaTriCu);
            if (index != -1)
            {
                arr[index] = giaTriMoi;
                return true;
            }
            return false;
        }

        public bool ThayTheTaiViTri(int viTri, int giaTriMoi)
        {
            if (viTri >= 0 && viTri < arr.Count)
            {
                arr[viTri] = giaTriMoi;
                return true;
            }
            return false;
        }

        public int SoPhanTu => arr.Count;
    }
}