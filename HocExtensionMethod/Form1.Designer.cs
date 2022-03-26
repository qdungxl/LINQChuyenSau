namespace HocExtensionMethod
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
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuoi1 = new System.Windows.Forms.TextBox();
            this.txtChuoi2 = new System.Windows.Forms.TextBox();
            this.btnNoi = new System.Windows.Forms.Button();
            this.lblNoiChuoi = new System.Windows.Forms.Label();
            this.btnTinhTuoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(62, 85);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(95, 50);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(62, 32);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(95, 26);
            this.txtN.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(58, 163);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(51, 20);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chuỗi 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuỗi 2:";
            // 
            // txtChuoi1
            // 
            this.txtChuoi1.Location = new System.Drawing.Point(164, 225);
            this.txtChuoi1.Name = "txtChuoi1";
            this.txtChuoi1.Size = new System.Drawing.Size(228, 26);
            this.txtChuoi1.TabIndex = 5;
            // 
            // txtChuoi2
            // 
            this.txtChuoi2.Location = new System.Drawing.Point(164, 265);
            this.txtChuoi2.Name = "txtChuoi2";
            this.txtChuoi2.Size = new System.Drawing.Size(228, 26);
            this.txtChuoi2.TabIndex = 6;
            // 
            // btnNoi
            // 
            this.btnNoi.Location = new System.Drawing.Point(291, 316);
            this.btnNoi.Name = "btnNoi";
            this.btnNoi.Size = new System.Drawing.Size(100, 35);
            this.btnNoi.TabIndex = 7;
            this.btnNoi.Text = "Nối";
            this.btnNoi.UseVisualStyleBackColor = true;
            this.btnNoi.Click += new System.EventHandler(this.btnNoi_Click);
            // 
            // lblNoiChuoi
            // 
            this.lblNoiChuoi.AutoSize = true;
            this.lblNoiChuoi.Location = new System.Drawing.Point(160, 371);
            this.lblNoiChuoi.Name = "lblNoiChuoi";
            this.lblNoiChuoi.Size = new System.Drawing.Size(51, 20);
            this.lblNoiChuoi.TabIndex = 8;
            this.lblNoiChuoi.Text = "label3";
            // 
            // btnTinhTuoi
            // 
            this.btnTinhTuoi.Location = new System.Drawing.Point(302, 85);
            this.btnTinhTuoi.Name = "btnTinhTuoi";
            this.btnTinhTuoi.Size = new System.Drawing.Size(90, 38);
            this.btnTinhTuoi.TabIndex = 9;
            this.btnTinhTuoi.Text = "Tính tuổi";
            this.btnTinhTuoi.UseVisualStyleBackColor = true;
            this.btnTinhTuoi.Click += new System.EventHandler(this.btnTinhTuoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 424);
            this.Controls.Add(this.btnTinhTuoi);
            this.Controls.Add(this.lblNoiChuoi);
            this.Controls.Add(this.btnNoi);
            this.Controls.Add(this.txtChuoi2);
            this.Controls.Add(this.txtChuoi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnTinhTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học Extension Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoi1;
        private System.Windows.Forms.TextBox txtChuoi2;
        private System.Windows.Forms.Button btnNoi;
        private System.Windows.Forms.Label lblNoiChuoi;
        private System.Windows.Forms.Button btnTinhTuoi;
    }
}

