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

        
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txt != null && txt.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && txt != null && (txt.SelectionStart != 0 || txt.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtA.Text.Trim(), out _)) errorProvider1.SetError(txtA, "");
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtB.Text.Trim(), out _)) errorProvider1.SetError(txtB, "");
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (!float.TryParse(txtA.Text.Trim(), out float a))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số a hợp lệ!");
                hopLe = false;
            }

            if (!float.TryParse(txtB.Text.Trim(), out float b))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số b hợp lệ!");
                hopLe = false;
            }

            if (!hopLe)
            {
                MessageBox.Show("Dữ liệu nhập vào chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo đối tượng từ class TinhToan
            TinhToan dt = new TinhToan(a, b);

            if (rdoCong.Checked)
            {
                txtKetQua.Text = dt.Cong().ToString();
            }
            else if (rdoTru.Checked)
            {
                txtKetQua.Text = dt.Tru().ToString();
            }
            else if (rdoNhan.Checked)
            {
                txtKetQua.Text = dt.Nhan().ToString();
            }
            else if (rdoChia.Checked)
            {
                if (b == 0)
                {
                    errorProvider1.SetError(txtB, "Không thể chia cho 0!");
                    MessageBox.Show("Phép chia bị lỗi! Số chia phải khác 0.", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKetQua.Clear();
                }
                else
                {
                    txtKetQua.Text = dt.Chia().ToString();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        }
    }


    public class TinhToan
    {
        // Thuộc tính private
        private float _a;
        private float _b;

        // Properties Get/Set
        public float A
        {
            get { return _a; }
            set { _a = value; }
        }

        public float B
        {
            get { return _b; }
            set { _b = value; }
        }

        // Phương thức khởi tạo (Constructor)
        public TinhToan()
        {
            _a = _b = 0;
        }

        public TinhToan(float a, float b)
        {
            _a = a;
            _b = b;
        }

        // Các phương thức tính toán
        public float Cong()
        {
            return _a + _b;
        }

        public float Tru()
        {
            return _a - _b;
        }

        public float Nhan()
        {
            return _a * _b;
        }

        public float Chia()
        {
            return _a / _b;
        }
    }
}
