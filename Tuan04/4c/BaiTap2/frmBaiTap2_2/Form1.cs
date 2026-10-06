using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace frmBaiTap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Kiểm tra định dạng email khi ra khỏi textbox txtEmail (Sự kiện Leave)
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            // Biểu thức Regex chuẩn kiểm tra định dạng email (VD: abc@xyz.com)
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, pattern))
            {
                errorProvider1.SetError(txtEmail, "Định dạng email không hợp lệ (ví dụ: example@gmail.com)!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

        }

        // 2. Nhấn Enter tại textbox Xác nhận mật khẩu thì kích hoạt Đăng ký
        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn tiếng "ding" mặc định của Windows khi gõ Enter trong SingleLine TextBox
                e.SuppressKeyPress = true; 
                btnRegister.PerformClick(); // Giả lập hành động click nút Đăng ký
            }
        }

        // 3. Xử lý nút Đăng ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // Bắt buộc nhập các ô có (*)
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập địa chỉ email!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");
                isValid = false;
            }

            // Kiểm tra mật khẩu khớp nhau
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show("Vui lòng hoàn thiện đúng và đầy đủ thông tin các mục bắt buộc (*).", 
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin lên MessageBox theo yêu cầu đề bài
            string info = $"THÔNG TIN ĐĂNG KÝ THÀNH CÔNG:\n" +
                          $"- Tên đăng nhập: {txtUsername.Text}\n" +
                          $"- Địa chỉ Email: {txtEmail.Text}\n" +
                          $"- Mật khẩu: {txtPassword.Text}";

            MessageBox.Show(info, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 4. Hỏi xác nhận trước khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn đóng màn hình Đăng ký?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.No)
            {
                e.Cancel = true; // Ngăn đóng form
            }
        }

        // 1. Tên đăng nhập: Ngay khi người dùng bắt đầu gõ chữ -> Xóa lỗi bỏ trống
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, ""); // hoặc errorProvider1.SetError(txtUsername, null);
            }
        }

        // 2. Mật khẩu: Ngay khi có nhập ký tự -> Xóa lỗi bỏ trống
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "");
            }

            // Nếu người dùng đã gõ ô xác nhận trước đó, kiểm tra xem 2 ô đã khớp nhau lại chưa
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        // 3. Xác nhận mật khẩu: Gõ đến khi nào trùng khớp với txtPassword -> Tự biến mất icon lỗi
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

    }

}
