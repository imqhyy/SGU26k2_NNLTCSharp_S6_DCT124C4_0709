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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.txtTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.txtTongKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCafeKem = new System.Windows.Forms.RadioButton();
            this.radCafeDa = new System.Windows.Forms.RadioButton();
            this.radCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.radCafeSua = new System.Windows.Forms.RadioButton();
            this.radCafeDen = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMyCay = new System.Windows.Forms.CheckBox();
            this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
            this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.chkBanhMyCa = new System.Windows.Forms.CheckBox();
            this.chkBanhMyTrung = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAFE SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(246, 66);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(291, 26);
            this.txtTenKhachHang.TabIndex = 3;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Location = new System.Drawing.Point(246, 94);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(291, 26);
            this.txtSoKhachHang.TabIndex = 4;
            this.txtSoKhachHang.TextChanged += new System.EventHandler(this.txtSoKhachHang_TextChanged);
            this.txtSoKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoKhachHang_KeyPress);
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(264, 476);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.ReadOnly = true;
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(291, 26);
            this.txtTongTienThanhToan.TabIndex = 8;
            // 
            // txtTongKhachHang
            // 
            this.txtTongKhachHang.Location = new System.Drawing.Point(264, 447);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.ReadOnly = true;
            this.txtTongKhachHang.Size = new System.Drawing.Size(291, 26);
            this.txtTongKhachHang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng khách hàng";
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Location = new System.Drawing.Point(204, 138);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(108, 24);
            this.chkSinhVien.TabIndex = 9;
            this.chkSinhVien.Text = "Sinh viên?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCafeKem);
            this.groupBox1.Controls.Add(this.radCafeDa);
            this.groupBox1.Controls.Add(this.radCafeSuaDa);
            this.groupBox1.Controls.Add(this.radCafeSua);
            this.groupBox1.Controls.Add(this.radCafeDen);
            this.groupBox1.Location = new System.Drawing.Point(18, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nước uống";
            // 
            // radCafeKem
            // 
            this.radCafeKem.AutoSize = true;
            this.radCafeKem.Location = new System.Drawing.Point(162, 79);
            this.radCafeKem.Name = "radCafeKem";
            this.radCafeKem.Size = new System.Drawing.Size(102, 24);
            this.radCafeKem.TabIndex = 4;
            this.radCafeKem.TabStop = true;
            this.radCafeKem.Text = "Cafe kem";
            this.radCafeKem.UseVisualStyleBackColor = true;
            this.radCafeKem.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // radCafeDa
            // 
            this.radCafeDa.AutoSize = true;
            this.radCafeDa.Location = new System.Drawing.Point(162, 36);
            this.radCafeDa.Name = "radCafeDa";
            this.radCafeDa.Size = new System.Drawing.Size(90, 24);
            this.radCafeDa.TabIndex = 3;
            this.radCafeDa.TabStop = true;
            this.radCafeDa.Text = "Cafe đá";
            this.radCafeDa.UseVisualStyleBackColor = true;
            this.radCafeDa.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // radCafeSuaDa
            // 
            this.radCafeSuaDa.AutoSize = true;
            this.radCafeSuaDa.Location = new System.Drawing.Point(6, 122);
            this.radCafeSuaDa.Name = "radCafeSuaDa";
            this.radCafeSuaDa.Size = new System.Drawing.Size(120, 24);
            this.radCafeSuaDa.TabIndex = 2;
            this.radCafeSuaDa.TabStop = true;
            this.radCafeSuaDa.Text = "Cafe sữa đá";
            this.radCafeSuaDa.UseVisualStyleBackColor = true;
            this.radCafeSuaDa.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // radCafeSua
            // 
            this.radCafeSua.AutoSize = true;
            this.radCafeSua.Location = new System.Drawing.Point(6, 79);
            this.radCafeSua.Name = "radCafeSua";
            this.radCafeSua.Size = new System.Drawing.Size(98, 24);
            this.radCafeSua.TabIndex = 1;
            this.radCafeSua.TabStop = true;
            this.radCafeSua.Text = "Cafe sữa";
            this.radCafeSua.UseVisualStyleBackColor = true;
            this.radCafeSua.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // radCafeDen
            // 
            this.radCafeDen.AutoSize = true;
            this.radCafeDen.Location = new System.Drawing.Point(6, 36);
            this.radCafeDen.Name = "radCafeDen";
            this.radCafeDen.Size = new System.Drawing.Size(99, 24);
            this.radCafeDen.TabIndex = 0;
            this.radCafeDen.TabStop = true;
            this.radCafeDen.Text = "Cafe đen";
            this.radCafeDen.UseVisualStyleBackColor = true;
            this.radCafeDen.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMyCay);
            this.groupBox2.Controls.Add(this.chkMyXaoBo);
            this.groupBox2.Controls.Add(this.chkMyTomTrung);
            this.groupBox2.Controls.Add(this.chkBanhMyCa);
            this.groupBox2.Controls.Add(this.chkBanhMyTrung);
            this.groupBox2.Location = new System.Drawing.Point(335, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 168);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thức ăn";
            // 
            // chkMyCay
            // 
            this.chkMyCay.AutoSize = true;
            this.chkMyCay.Location = new System.Drawing.Point(158, 79);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new System.Drawing.Size(83, 24);
            this.chkMyCay.TabIndex = 4;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            this.chkMyCay.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // chkMyXaoBo
            // 
            this.chkMyXaoBo.AutoSize = true;
            this.chkMyXaoBo.Location = new System.Drawing.Point(158, 37);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new System.Drawing.Size(106, 24);
            this.chkMyXaoBo.TabIndex = 3;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            this.chkMyXaoBo.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // chkMyTomTrung
            // 
            this.chkMyTomTrung.AutoSize = true;
            this.chkMyTomTrung.Location = new System.Drawing.Point(6, 123);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new System.Drawing.Size(127, 24);
            this.chkMyTomTrung.TabIndex = 2;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            this.chkMyTomTrung.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // chkBanhMyCa
            // 
            this.chkBanhMyCa.AutoSize = true;
            this.chkBanhMyCa.Location = new System.Drawing.Point(6, 79);
            this.chkBanhMyCa.Name = "chkBanhMyCa";
            this.chkBanhMyCa.Size = new System.Drawing.Size(118, 24);
            this.chkBanhMyCa.TabIndex = 1;
            this.chkBanhMyCa.Text = "Bánh mỳ cá";
            this.chkBanhMyCa.UseVisualStyleBackColor = true;
            this.chkBanhMyCa.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // chkBanhMyTrung
            // 
            this.chkBanhMyTrung.AutoSize = true;
            this.chkBanhMyTrung.Location = new System.Drawing.Point(6, 36);
            this.chkBanhMyTrung.Name = "chkBanhMyTrung";
            this.chkBanhMyTrung.Size = new System.Drawing.Size(138, 24);
            this.chkBanhMyTrung.TabIndex = 0;
            this.chkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanhMyTrung.UseVisualStyleBackColor = true;
            this.chkBanhMyTrung.CheckedChanged += new System.EventHandler(this.Mon_CheckedChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(69, 372);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(106, 49);
            this.btnTinhTien.TabIndex = 12;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(190, 372);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(106, 49);
            this.btnNhapLai.TabIndex = 13;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(317, 372);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(106, 49);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(449, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 49);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 597);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Controls.Add(this.txtTongKhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.TextBox txtTongTienThanhToan;
        private System.Windows.Forms.TextBox txtTongKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCafeKem;
        private System.Windows.Forms.RadioButton radCafeDa;
        private System.Windows.Forms.RadioButton radCafeSuaDa;
        private System.Windows.Forms.RadioButton radCafeSua;
        private System.Windows.Forms.RadioButton radCafeDen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMyCay;
        private System.Windows.Forms.CheckBox chkMyXaoBo;
        private System.Windows.Forms.CheckBox chkMyTomTrung;
        private System.Windows.Forms.CheckBox chkBanhMyCa;
        private System.Windows.Forms.CheckBox chkBanhMyTrung;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
    }
}

