using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        // 1. Kiểm tra txtYourName khi mất tiêu điểm (Leave)
        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "You must enter Your Name");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        // 2. Kiểm tra năm sinh khi đang gõ ký tự (TextChanged)
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            // Kiểm tra chuỗi có phải số không
            if (ctr.Text.Length > 0 && !int.TryParse(ctr.Text, out _))
            {
                this.errorProvider1.SetError(ctr, "This is not a valid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        // 3. Nút Show: Hiển thị tên và tính tuổi
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYourName.Text) || string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int age = DateTime.Now.Year - Convert.ToInt32(txtYear.Text);
                string s = "My Name is: " + txtYourName.Text + "\n" + "Age: " + age.ToString();
                MessageBox.Show(s);
            }
            catch
            {
                MessageBox.Show("Năm sinh không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            
        }

        // 4. Nút Clear: Xóa trắng và focus lại ô Your Name
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Clear();
            txtYear.Clear();
            errorProvider1.Clear();
            txtYourName.Focus();
        }

        // 5. Nút Exit: Đóng Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 6. Sự kiện FormClosing: Hỏi xác nhận khi đóng ứng dụng
        private void frmBaiTap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true; // Hủy thao tác đóng form
            }
        }
       

       
    }
}
