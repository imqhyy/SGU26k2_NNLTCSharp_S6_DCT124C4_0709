using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBaiTap2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // ==========================================
        // MỨC 2: CHẶN KÝ TỰ KHÔNG PHẢI SỐ KHI GÕ PHÍM
        // ==========================================
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép: Chữ số, phím điều khiển (Backspace), dấu chấm/phẩy thập phân, dấu trừ (số âm)
            TextBox txt = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true; // Chặn không cho ký tự xuất hiện
            }

            // Chỉ cho phép tối đa một dấu chấm thập phân
            if (e.KeyChar == '.' && txt != null && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // Dấu trừ chỉ được đứng ở vị trí đầu tiên
            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }


        // ==========================================
        // XÓA LỖI TỰ ĐỘNG KHI NGƯỜI DÙNG NHẬP LẠI
        // ==========================================
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtA.Text.Trim(), out _))
            {
                errorProvider1.SetError(txtA, "");
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtB.Text.Trim(), out _))
            {
                errorProvider1.SetError(txtB, "");
            }
        }

        // ==========================================
        // MỨC 1: HÀM DÙNG CHUNG ĐỂ VALIDATE DỮ LIỆU
        // ==========================================
        private bool ValidateDuLieu(out double a, out double b)
        {
            a = 0;
            b = 0;
            bool hopLe = true;

            // Kiểm tra ô a
            if (string.IsNullOrWhiteSpace(txtA.Text))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập giá trị cho a!");
                hopLe = false;
            }
            else if (!double.TryParse(txtA.Text.Trim(), out a))
            {
                errorProvider1.SetError(txtA, "Giá trị a phải là một số hợp lệ!");
                hopLe = false;
            }

            // Kiểm tra ô b
            if (string.IsNullOrWhiteSpace(txtB.Text))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập giá trị cho b!");
                hopLe = false;
            }
            else if (!double.TryParse(txtB.Text.Trim(), out b))
            {
                errorProvider1.SetError(txtB, "Giá trị b phải là một số hợp lệ!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng định dạng. Vui lòng kiểm tra lại!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return hopLe;
        }

        // ==========================================
        // XỬ LÝ 4 PHÉP TÍNH
        // ==========================================
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (ValidateDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a + b).ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (ValidateDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a - b).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (ValidateDuLieu(out double a, out double b))
            {
                txtKetQua.Text = (a * b).ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (ValidateDuLieu(out double a, out double b))
            {
                // Kiểm tra chia cho 0
                if (b == 0)
                {
                    errorProvider1.SetError(txtB, "Không thể chia cho 0!");
                    MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKetQua.Clear();
                    txtB.Focus();
                    return;
                }

                txtKetQua.Text = (a / b).ToString();
            }
        }


        // ==========================================
        // HỎI XÁC NHẬN KHI THOÁT
        // ==========================================
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn thoát chương trình?",
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
}
