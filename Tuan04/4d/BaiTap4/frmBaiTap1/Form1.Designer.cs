namespace frmBaiTap1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radPhongDon = new System.Windows.Forms.RadioButton();
            this.radPhongDoi = new System.Windows.Forms.RadioButton();
            this.radPhongBa = new System.Windows.Forms.RadioButton();
            this.chkTivi = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkMayNuocNong = new System.Windows.Forms.CheckBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongSoLuotNguoi = new System.Windows.Forms.Label();
            this.lblTongSoTien = new System.Windows.Forms.Label();
            this.txtTongSoLuotNguoi = new System.Windows.Forms.TextBox();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(263, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoNgayO);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 473);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số ngày ở:";
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(168, 131);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(100, 26);
            this.txtSoNgayO.TabIndex = 4;
            this.txtSoNgayO.TextChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            this.txtSoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayO_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(168, 75);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(429, 26);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(168, 38);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(429, 26);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.btnTongKet);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.lblThanhTien);
            this.panel2.Controls.Add(this.btnNhapMoi);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Location = new System.Drawing.Point(671, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 473);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radPhongBa);
            this.groupBox1.Controls.Add(this.radPhongDoi);
            this.groupBox1.Controls.Add(this.radPhongDon);
            this.groupBox1.Location = new System.Drawing.Point(60, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMayNuocNong);
            this.groupBox2.Controls.Add(this.chkInternet);
            this.groupBox2.Controls.Add(this.chkTivi);
            this.groupBox2.Location = new System.Drawing.Point(271, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 196);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiện nghi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAnSang);
            this.groupBox3.Controls.Add(this.chkKaraoke);
            this.groupBox3.Location = new System.Drawing.Point(483, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 196);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dịch vụ";
            // 
            // radPhongDon
            // 
            this.radPhongDon.AutoSize = true;
            this.radPhongDon.Location = new System.Drawing.Point(9, 37);
            this.radPhongDon.Name = "radPhongDon";
            this.radPhongDon.Size = new System.Drawing.Size(111, 24);
            this.radPhongDon.TabIndex = 0;
            this.radPhongDon.TabStop = true;
            this.radPhongDon.Text = "Phòng đơn";
            this.radPhongDon.UseVisualStyleBackColor = true;
            this.radPhongDon.CheckedChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            // 
            // radPhongDoi
            // 
            this.radPhongDoi.AutoSize = true;
            this.radPhongDoi.Location = new System.Drawing.Point(9, 86);
            this.radPhongDoi.Name = "radPhongDoi";
            this.radPhongDoi.Size = new System.Drawing.Size(105, 24);
            this.radPhongDoi.TabIndex = 1;
            this.radPhongDoi.TabStop = true;
            this.radPhongDoi.Text = "Phòng đôi";
            this.radPhongDoi.UseVisualStyleBackColor = true;
            this.radPhongDoi.CheckedChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            // 
            // radPhongBa
            // 
            this.radPhongBa.AutoSize = true;
            this.radPhongBa.Location = new System.Drawing.Point(9, 133);
            this.radPhongBa.Name = "radPhongBa";
            this.radPhongBa.Size = new System.Drawing.Size(102, 24);
            this.radPhongBa.TabIndex = 2;
            this.radPhongBa.TabStop = true;
            this.radPhongBa.Text = "Phòng ba";
            this.radPhongBa.UseVisualStyleBackColor = true;
            this.radPhongBa.CheckedChanged += new System.EventHandler(this.KiemTraNhapLieu_Event);
            // 
            // chkTivi
            // 
            this.chkTivi.AutoSize = true;
            this.chkTivi.Location = new System.Drawing.Point(7, 37);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new System.Drawing.Size(57, 24);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(7, 87);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(91, 24);
            this.chkInternet.TabIndex = 1;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkMayNuocNong
            // 
            this.chkMayNuocNong.AutoSize = true;
            this.chkMayNuocNong.Location = new System.Drawing.Point(7, 134);
            this.chkMayNuocNong.Name = "chkMayNuocNong";
            this.chkMayNuocNong.Size = new System.Drawing.Size(143, 24);
            this.chkMayNuocNong.TabIndex = 2;
            this.chkMayNuocNong.Text = "Máy nước nóng";
            this.chkMayNuocNong.UseVisualStyleBackColor = true;
            // 
            // chkAnSang
            // 
            this.chkAnSang.AutoSize = true;
            this.chkAnSang.Location = new System.Drawing.Point(20, 88);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new System.Drawing.Size(94, 24);
            this.chkAnSang.TabIndex = 4;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            // 
            // chkKaraoke
            // 
            this.chkKaraoke.AutoSize = true;
            this.chkKaraoke.Location = new System.Drawing.Point(20, 38);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new System.Drawing.Size(94, 24);
            this.chkKaraoke.TabIndex = 3;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(18, 17);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(123, 30);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "&Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(176, 17);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(123, 30);
            this.btnNhapMoi.TabIndex = 1;
            this.btnNhapMoi.Text = "&Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(34, 75);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(88, 20);
            this.lblThanhTien.TabIndex = 2;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(150, 68);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(286, 26);
            this.txtThanhTien.TabIndex = 3;
            // 
            // btnTongKet
            // 
            this.btnTongKet.Location = new System.Drawing.Point(18, 146);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(123, 30);
            this.btnTongKet.TabIndex = 4;
            this.btnTongKet.Text = "Tổng &Kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTongSoTien);
            this.groupBox4.Controls.Add(this.txtTongSoLuotNguoi);
            this.groupBox4.Controls.Add(this.lblTongSoTien);
            this.groupBox4.Controls.Add(this.lblTongSoLuotNguoi);
            this.groupBox4.Location = new System.Drawing.Point(18, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 177);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tổng kết";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(18, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongSoLuotNguoi
            // 
            this.lblTongSoLuotNguoi.AutoSize = true;
            this.lblTongSoLuotNguoi.Location = new System.Drawing.Point(20, 38);
            this.lblTongSoLuotNguoi.Name = "lblTongSoLuotNguoi";
            this.lblTongSoLuotNguoi.Size = new System.Drawing.Size(106, 20);
            this.lblTongSoLuotNguoi.TabIndex = 0;
            this.lblTongSoLuotNguoi.Text = "Số lượt người:";
            // 
            // lblTongSoTien
            // 
            this.lblTongSoTien.AutoSize = true;
            this.lblTongSoTien.Location = new System.Drawing.Point(20, 89);
            this.lblTongSoTien.Name = "lblTongSoTien";
            this.lblTongSoTien.Size = new System.Drawing.Size(100, 20);
            this.lblTongSoTien.TabIndex = 1;
            this.lblTongSoTien.Text = "Tổng số tiền:";
            // 
            // txtTongSoLuotNguoi
            // 
            this.txtTongSoLuotNguoi.Location = new System.Drawing.Point(132, 38);
            this.txtTongSoLuotNguoi.Name = "txtTongSoLuotNguoi";
            this.txtTongSoLuotNguoi.ReadOnly = true;
            this.txtTongSoLuotNguoi.Size = new System.Drawing.Size(286, 26);
            this.txtTongSoLuotNguoi.TabIndex = 2;
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.Location = new System.Drawing.Point(132, 86);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.ReadOnly = true;
            this.txtTongSoTien.Size = new System.Drawing.Size(286, 26);
            this.txtTongSoTien.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAnSang;
        private System.Windows.Forms.CheckBox chkKaraoke;
        private System.Windows.Forms.CheckBox chkMayNuocNong;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkTivi;
        private System.Windows.Forms.RadioButton radPhongBa;
        private System.Windows.Forms.RadioButton radPhongDoi;
        private System.Windows.Forms.RadioButton radPhongDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTongSoLuotNguoi;
        private System.Windows.Forms.Label lblTongSoTien;
        private System.Windows.Forms.Label lblTongSoLuotNguoi;
        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.TextBox txtTongSoTien;
    }
}

