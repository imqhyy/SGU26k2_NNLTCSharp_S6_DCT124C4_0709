using System;
using System.Drawing;
using System.Windows.Forms;

namespace frmBaiTap2
{
    public partial class Form1 : Form
    {
        // Cờ ngăn vòng lặp sự kiện CheckedChanged kích hoạt lẫn nhau
        private bool isUpdating = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 1. SỰ KIỆN KHI FORM VỪA LOAD LÊN (CHỌN SẴN REGULAR VÀ AUTOCOLOR)
        private void Form1_Load(object sender, EventArgs e)
        {
            rdoAutoColor.Checked = true;
            chkRegular.Checked = true;
        }

        // ==========================================
        // 2. XỬ LÝ ĐỔI MÀU BẰNG RADIOBUTTON
        // ==========================================
        private void rdoAutoColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAutoColor.Checked)
                lblHienThi.ForeColor = Color.Black;
        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
                lblHienThi.ForeColor = Color.Red;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreen.Checked)
                lblHienThi.ForeColor = Color.Green;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlue.Checked)
                lblHienThi.ForeColor = Color.Blue;
        }

        // ==========================================
        // 3. XỬ LÝ KIỂU CHỮ (FONT STYLE)
        // ==========================================
        private void chkFont_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;
            isUpdating = true;

            CheckBox clickedBox = sender as CheckBox;

            // Xử lý tính tương hỗ giữa các CheckBox
            if (clickedBox == chkRegular && chkRegular.Checked)
            {
                // Nếu chọn Regular thì tắt tất cả các kiểu định dạng khác
                chkBold.Checked = false;
                chkItalic.Checked = false;
                chkBoldItalic.Checked = false;
            }
            else if (clickedBox == chkBoldItalic)
            {
                // Nếu bấm Bold Italic thì đồng bộ trạng thái sang cả Bold và Italic
                chkBold.Checked = chkBoldItalic.Checked;
                chkItalic.Checked = chkBoldItalic.Checked;
                if (chkBoldItalic.Checked) chkRegular.Checked = false;
            }
            else if (clickedBox == chkBold || clickedBox == chkItalic)
            {
                // Nếu bấm Bold hoặc Italic riêng lẻ
                if (chkBold.Checked || chkItalic.Checked)
                {
                    chkRegular.Checked = false;
                }

                // Cập nhật lại ô Bold Italic nếu cả hai cùng được tick
                chkBoldItalic.Checked = (chkBold.Checked && chkItalic.Checked);
            }

            // Nếu người dùng bỏ tick hết sạch, tự động đưa về Regular
            if (!chkBold.Checked && !chkItalic.Checked && !chkBoldItalic.Checked)
            {
                chkRegular.Checked = true;
            }

            // Áp dụng định dạng font lên Label
            FontStyle style = FontStyle.Regular;

            if (chkBold.Checked && chkItalic.Checked)
            {
                style = FontStyle.Bold | FontStyle.Italic;
            }
            else if (chkBold.Checked)
            {
                style = FontStyle.Bold;
            }
            else if (chkItalic.Checked)
            {
                style = FontStyle.Italic;
            }

            lblHienThi.Font = new Font(lblHienThi.Font.FontFamily, lblHienThi.Font.Size, style);

            isUpdating = false;
        }

        // ==========================================
        // 4. NÚT EXIT VÀ XÁC NHẬN THOÁT
        // ==========================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có thực sự muốn thoát không?",
                "Xác nhận",
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