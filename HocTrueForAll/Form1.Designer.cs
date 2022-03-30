namespace HocTrueForAll
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHanDung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLe);
            this.splitContainer1.Panel1.Controls.Add(this.btnChan);
            this.splitContainer1.Panel1.Controls.Add(this.btnNhap);
            this.splitContainer1.Panel1.Controls.Add(this.lstDS);
            this.splitContainer1.Panel1.Controls.Add(this.txtNhap);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnHanDung);
            this.splitContainer1.Panel2.Controls.Add(this.lvSanPham);
            this.splitContainer1.Size = new System.Drawing.Size(653, 462);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(98, 35);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(188, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // lstDS
            // 
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 20;
            this.lstDS.Location = new System.Drawing.Point(13, 141);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(273, 184);
            this.lstDS.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(174, 82);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(112, 37);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(37, 351);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(249, 37);
            this.btnChan.TabIndex = 4;
            this.btnChan.Text = "Có phải toàn chẳn không?";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(37, 394);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(249, 37);
            this.btnLe.TabIndex = 4;
            this.btnLe.Text = "Có phải toàn lẻ không?";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(0, 0);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(324, 242);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hạn dùng";
            this.columnHeader3.Width = 150;
            // 
            // btnHanDung
            // 
            this.btnHanDung.Location = new System.Drawing.Point(36, 273);
            this.btnHanDung.Name = "btnHanDung";
            this.btnHanDung.Size = new System.Drawing.Size(253, 52);
            this.btnHanDung.TabIndex = 1;
            this.btnHanDung.Text = "Kiểm tra hạn dùng";
            this.btnHanDung.UseVisualStyleBackColor = true;
            this.btnHanDung.Click += new System.EventHandler(this.btnHanDung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học TrueForAll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnHanDung;
    }
}

