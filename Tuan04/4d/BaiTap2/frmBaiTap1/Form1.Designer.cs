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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBacHai = new System.Windows.Forms.RadioButton();
            this.rdoBacNhat = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBacHai);
            this.groupBox1.Controls.Add(this.rdoBacNhat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(48, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rdoBacHai
            // 
            this.rdoBacHai.AutoSize = true;
            this.rdoBacHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdoBacHai.Location = new System.Drawing.Point(21, 62);
            this.rdoBacHai.Name = "rdoBacHai";
            this.rdoBacHai.Size = new System.Drawing.Size(200, 26);
            this.rdoBacHai.TabIndex = 1;
            this.rdoBacHai.TabStop = true;
            this.rdoBacHai.Text = "Phương trình bậc hai";
            this.rdoBacHai.UseVisualStyleBackColor = true;
            this.rdoBacHai.CheckedChanged += new System.EventHandler(this.rdoBacHai_CheckedChanged);
            // 
            // rdoBacNhat
            // 
            this.rdoBacNhat.AutoSize = true;
            this.rdoBacNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rdoBacNhat.Location = new System.Drawing.Point(21, 30);
            this.rdoBacNhat.Name = "rdoBacNhat";
            this.rdoBacNhat.Size = new System.Drawing.Size(211, 26);
            this.rdoBacNhat.TabIndex = 0;
            this.rdoBacNhat.TabStop = true;
            this.rdoBacNhat.Text = "Phương trình bậc nhất";
            this.rdoBacNhat.UseVisualStyleBackColor = true;
            this.rdoBacNhat.CheckedChanged += new System.EventHandler(this.rdoBacNhat_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập b";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(48, 304);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(59, 20);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(132, 216);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(148, 26);
            this.txtA.TabIndex = 6;
            this.txtA.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(132, 259);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(148, 26);
            this.txtB.TabIndex = 7;
            this.txtB.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(132, 304);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(148, 26);
            this.txtC.TabIndex = 8;
            this.txtC.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtKetQua.Location = new System.Drawing.Point(132, 352);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(284, 104);
            this.txtKetQua.TabIndex = 9;
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGiai.Location = new System.Drawing.Point(337, 218);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(79, 50);
            this.btnGiai.TabIndex = 10;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThoat.Location = new System.Drawing.Point(337, 292);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 50);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 490);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 1-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBacHai;
        private System.Windows.Forms.RadioButton rdoBacNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

