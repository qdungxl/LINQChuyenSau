namespace HocOrderBy
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
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTangDanC2 = new System.Windows.Forms.Button();
            this.btnGiamDanC2 = new System.Windows.Forms.Button();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTenTangDan = new System.Windows.Forms.Button();
            this.btnTangDanQuery = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGiamDanQuery = new System.Windows.Forms.Button();
            this.btnPhucHop = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnGiamDanC2);
            this.splitContainer1.Panel1.Controls.Add(this.btnTangDanC2);
            this.splitContainer1.Panel1.Controls.Add(this.btnGiamDan);
            this.splitContainer1.Panel1.Controls.Add(this.btnTangDan);
            this.splitContainer1.Panel1.Controls.Add(this.lstDS);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtN);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPhucHop);
            this.splitContainer1.Panel2.Controls.Add(this.btnGiamDanQuery);
            this.splitContainer1.Panel2.Controls.Add(this.btnTangDanQuery);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.btnTenTangDan);
            this.splitContainer1.Panel2.Controls.Add(this.lvSanPham);
            this.splitContainer1.Size = new System.Drawing.Size(887, 571);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Location = new System.Drawing.Point(70, 464);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Size = new System.Drawing.Size(118, 37);
            this.btnGiamDan.TabIndex = 4;
            this.btnGiamDan.Text = "Giảm dần";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            this.btnGiamDan.Click += new System.EventHandler(this.btnGiamDan_Click);
            // 
            // btnTangDan
            // 
            this.btnTangDan.Location = new System.Drawing.Point(70, 407);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Size = new System.Drawing.Size(118, 37);
            this.btnTangDan.TabIndex = 4;
            this.btnTangDan.Text = "Tăng dần";
            this.btnTangDan.UseVisualStyleBackColor = true;
            this.btnTangDan.Click += new System.EventHandler(this.btnTangDan_Click);
            // 
            // lstDS
            // 
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 20;
            this.lstDS.Location = new System.Drawing.Point(0, 94);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(409, 284);
            this.lstDS.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tạo DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(145, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(132, 26);
            this.txtN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // btnTangDanC2
            // 
            this.btnTangDanC2.Location = new System.Drawing.Point(214, 407);
            this.btnTangDanC2.Name = "btnTangDanC2";
            this.btnTangDanC2.Size = new System.Drawing.Size(138, 37);
            this.btnTangDanC2.TabIndex = 5;
            this.btnTangDanC2.Text = "Tăng dần C2";
            this.btnTangDanC2.UseVisualStyleBackColor = true;
            this.btnTangDanC2.Click += new System.EventHandler(this.btnTangDanC2_Click);
            // 
            // btnGiamDanC2
            // 
            this.btnGiamDanC2.Location = new System.Drawing.Point(214, 464);
            this.btnGiamDanC2.Name = "btnGiamDanC2";
            this.btnGiamDanC2.Size = new System.Drawing.Size(138, 37);
            this.btnGiamDanC2.TabIndex = 6;
            this.btnGiamDanC2.Text = "Giảm dần C2";
            this.btnGiamDanC2.UseVisualStyleBackColor = true;
            this.btnGiamDanC2.Click += new System.EventHandler(this.btnGiamDanC2_Click);
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(0, 0);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(471, 323);
            this.lvSanPham.TabIndex = 0;
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
            this.columnHeader2.Width = 200;
            // 
            // btnTenTangDan
            // 
            this.btnTenTangDan.Location = new System.Drawing.Point(45, 364);
            this.btnTenTangDan.Name = "btnTenTangDan";
            this.btnTenTangDan.Size = new System.Drawing.Size(139, 40);
            this.btnTenTangDan.TabIndex = 1;
            this.btnTenTangDan.Text = "Tên tăng dần";
            this.btnTenTangDan.UseVisualStyleBackColor = true;
            this.btnTenTangDan.Click += new System.EventHandler(this.btnTenTangDan_Click);
            // 
            // btnTangDanQuery
            // 
            this.btnTangDanQuery.Location = new System.Drawing.Point(251, 364);
            this.btnTangDanQuery.Name = "btnTangDanQuery";
            this.btnTangDanQuery.Size = new System.Drawing.Size(139, 40);
            this.btnTangDanQuery.TabIndex = 1;
            this.btnTangDanQuery.Text = "Query";
            this.btnTangDanQuery.UseVisualStyleBackColor = true;
            this.btnTangDanQuery.Click += new System.EventHandler(this.btnTangDanQuery_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Giảm  dần";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGiamDanQuery
            // 
            this.btnGiamDanQuery.Location = new System.Drawing.Point(251, 429);
            this.btnGiamDanQuery.Name = "btnGiamDanQuery";
            this.btnGiamDanQuery.Size = new System.Drawing.Size(139, 40);
            this.btnGiamDanQuery.TabIndex = 1;
            this.btnGiamDanQuery.Text = "Query";
            this.btnGiamDanQuery.UseVisualStyleBackColor = true;
            this.btnGiamDanQuery.Click += new System.EventHandler(this.btnGiamDanQuery_Click);
            // 
            // btnPhucHop
            // 
            this.btnPhucHop.Location = new System.Drawing.Point(45, 493);
            this.btnPhucHop.Name = "btnPhucHop";
            this.btnPhucHop.Size = new System.Drawing.Size(139, 52);
            this.btnPhucHop.TabIndex = 2;
            this.btnPhucHop.Text = "Phức hợp";
            this.btnPhucHop.UseVisualStyleBackColor = true;
            this.btnPhucHop.Click += new System.EventHandler(this.btnPhucHop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 571);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học OrderBy và OrderDesending";
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
        private System.Windows.Forms.Button btnGiamDan;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiamDanC2;
        private System.Windows.Forms.Button btnTangDanC2;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnGiamDanQuery;
        private System.Windows.Forms.Button btnTangDanQuery;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTenTangDan;
        private System.Windows.Forms.Button btnPhucHop;
    }
}

