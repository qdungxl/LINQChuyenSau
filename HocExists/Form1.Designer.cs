namespace HocExists
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnTaoDanhSach = new System.Windows.Forms.Button();
            this.lstN = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(105, 43);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(208, 26);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDanhSach
            // 
            this.btnTaoDanhSach.Location = new System.Drawing.Point(189, 96);
            this.btnTaoDanhSach.Name = "btnTaoDanhSach";
            this.btnTaoDanhSach.Size = new System.Drawing.Size(124, 31);
            this.btnTaoDanhSach.TabIndex = 2;
            this.btnTaoDanhSach.Text = "Tạo danh sách";
            this.btnTaoDanhSach.UseVisualStyleBackColor = true;
            this.btnTaoDanhSach.Click += new System.EventHandler(this.btnTaoDanhSach_Click);
            // 
            // lstN
            // 
            this.lstN.FormattingEnabled = true;
            this.lstN.ItemHeight = 20;
            this.lstN.Location = new System.Drawing.Point(53, 146);
            this.lstN.Name = "lstN";
            this.lstN.Size = new System.Drawing.Size(260, 204);
            this.lstN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(105, 368);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(208, 26);
            this.txtTim.TabIndex = 5;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(189, 423);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(124, 35);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(367, 43);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(307, 307);
            this.lvSanPham.TabIndex = 7;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên muốn tìm:";
            // 
            // txtTimSP
            // 
            this.txtTimSP.Location = new System.Drawing.Point(478, 362);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(195, 26);
            this.txtTimSP.TabIndex = 9;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(478, 415);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(161, 43);
            this.btnTimSP.TabIndex = 10;
            this.btnTimSP.Text = "TimSP";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 483);
            this.Controls.Add(this.btnTimSP);
            this.Controls.Add(this.txtTimSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstN);
            this.Controls.Add(this.btnTaoDanhSach);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học Exists";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTaoDanhSach;
        private System.Windows.Forms.ListBox lstN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Button btnTimSP;
    }
}

