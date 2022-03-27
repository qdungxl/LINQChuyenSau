namespace BaiTapRenLuyenKyThuatLinQ
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
            this.btnXemNguyenTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lsbNguyenTo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnXemNguyenTo
            // 
            this.btnXemNguyenTo.Location = new System.Drawing.Point(212, 12);
            this.btnXemNguyenTo.Name = "btnXemNguyenTo";
            this.btnXemNguyenTo.Size = new System.Drawing.Size(171, 46);
            this.btnXemNguyenTo.TabIndex = 0;
            this.btnXemNguyenTo.Text = "Xem số nguyên tố";
            this.btnXemNguyenTo.UseVisualStyleBackColor = true;
            this.btnXemNguyenTo.Click += new System.EventHandler(this.btnXemNguyenTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(84, 32);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(111, 26);
            this.txtN.TabIndex = 2;
            // 
            // lsbNguyenTo
            // 
            this.lsbNguyenTo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsbNguyenTo.FormattingEnabled = true;
            this.lsbNguyenTo.ItemHeight = 20;
            this.lsbNguyenTo.Location = new System.Drawing.Point(0, 74);
            this.lsbNguyenTo.Name = "lsbNguyenTo";
            this.lsbNguyenTo.Size = new System.Drawing.Size(386, 184);
            this.lsbNguyenTo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 258);
            this.Controls.Add(this.lsbNguyenTo);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemNguyenTo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rèn luyện LinQ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemNguyenTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ListBox lsbNguyenTo;
    }
}

