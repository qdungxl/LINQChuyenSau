namespace HocAny
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
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstGiaTri = new System.Windows.Forms.ListBox();
            this.btnChan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHocBong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập gia trị:";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(146, 28);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(142, 26);
            this.txtGiaTri.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(317, 12);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(83, 41);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstGiaTri
            // 
            this.lstGiaTri.FormattingEnabled = true;
            this.lstGiaTri.ItemHeight = 20;
            this.lstGiaTri.Location = new System.Drawing.Point(34, 79);
            this.lstGiaTri.Name = "lstGiaTri";
            this.lstGiaTri.Size = new System.Drawing.Size(366, 184);
            this.lstGiaTri.TabIndex = 3;
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(49, 280);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(113, 34);
            this.btnChan.TabIndex = 4;
            this.btnChan.Text = "Any chẳng";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 251);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnHocBong
            // 
            this.btnHocBong.Location = new System.Drawing.Point(456, 280);
            this.btnHocBong.Name = "btnHocBong";
            this.btnHocBong.Size = new System.Drawing.Size(155, 34);
            this.btnHocBong.TabIndex = 6;
            this.btnHocBong.Text = "Có học bổng";
            this.btnHocBong.UseVisualStyleBackColor = true;
            this.btnHocBong.Click += new System.EventHandler(this.btnHocBong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 332);
            this.Controls.Add(this.btnHocBong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.lstGiaTri);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học Any";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstGiaTri;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHocBong;
    }
}

