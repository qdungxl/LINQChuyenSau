namespace HocFindIndex
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
            this.btnTaoDS = new System.Windows.Forms.Button();
            this.lstNguon = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGTTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViTriDauTien = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(72, 24);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(183, 26);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(132, 69);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(123, 38);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstNguon
            // 
            this.lstNguon.FormattingEnabled = true;
            this.lstNguon.ItemHeight = 20;
            this.lstNguon.Location = new System.Drawing.Point(12, 127);
            this.lstNguon.Name = "lstNguon";
            this.lstNguon.Size = new System.Drawing.Size(243, 164);
            this.lstNguon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá trị muốn tìm:";
            // 
            // txtGTTim
            // 
            this.txtGTTim.Location = new System.Drawing.Point(167, 308);
            this.txtGTTim.Name = "txtGTTim";
            this.txtGTTim.Size = new System.Drawing.Size(88, 26);
            this.txtGTTim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vị trí đầu tiên:";
            // 
            // txtViTriDauTien
            // 
            this.txtViTriDauTien.Location = new System.Drawing.Point(167, 403);
            this.txtViTriDauTien.Name = "txtViTriDauTien";
            this.txtViTriDauTien.Size = new System.Drawing.Size(88, 26);
            this.txtViTriDauTien.TabIndex = 7;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(176, 340);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(79, 26);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(274, 24);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(78, 404);
            this.line1.TabIndex = 9;
            this.line1.Text = "line1";
            this.line1.Thickness = 4;
            this.line1.VerticalLine = true;
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
            this.lvSanPham.Location = new System.Drawing.Point(370, 24);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(413, 181);
            this.lvSanPham.TabIndex = 10;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Xuất xứ";
            this.columnHeader3.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Xuất xứ:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(489, 238);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(142, 26);
            this.txtXuatXu.TabIndex = 12;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Location = new System.Drawing.Point(692, 225);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(91, 39);
            this.btnTimSP.TabIndex = 13;
            this.btnTimSP.Text = "Tìm SP";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vị trí:";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(489, 283);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(142, 26);
            this.txtViTri.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 466);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimSP);
            this.Controls.Add(this.txtXuatXu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtViTriDauTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGTTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNguon);
            this.Controls.Add(this.btnTaoDS);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học FindIndex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTaoDS;
        private System.Windows.Forms.ListBox lstNguon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGTTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtViTriDauTien;
        private System.Windows.Forms.Button btnTim;
        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtViTri;
    }
}

