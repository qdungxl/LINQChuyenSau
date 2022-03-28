namespace HocFindAll
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
            this.btnTao = new System.Windows.Forms.Button();
            this.lstGoc = new System.Windows.Forms.ListBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lstChan = new System.Windows.Forms.ListBox();
            this.lvSPGoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnLocSP = new System.Windows.Forms.Button();
            this.lvSPLoc = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(182, 41);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 1;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(336, 41);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 26);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo DS";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lstGoc
            // 
            this.lstGoc.FormattingEnabled = true;
            this.lstGoc.ItemHeight = 20;
            this.lstGoc.Location = new System.Drawing.Point(12, 105);
            this.lstGoc.Name = "lstGoc";
            this.lstGoc.Size = new System.Drawing.Size(189, 144);
            this.lstGoc.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(235, 143);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(111, 37);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lstChan
            // 
            this.lstChan.FormattingEnabled = true;
            this.lstChan.ItemHeight = 20;
            this.lstChan.Location = new System.Drawing.Point(379, 105);
            this.lstChan.Name = "lstChan";
            this.lstChan.Size = new System.Drawing.Size(198, 144);
            this.lstChan.TabIndex = 5;
            // 
            // lvSPGoc
            // 
            this.lvSPGoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSPGoc.FullRowSelect = true;
            this.lvSPGoc.GridLines = true;
            this.lvSPGoc.HideSelection = false;
            this.lvSPGoc.Location = new System.Drawing.Point(3, 301);
            this.lvSPGoc.Name = "lvSPGoc";
            this.lvSPGoc.Size = new System.Drawing.Size(294, 275);
            this.lvSPGoc.TabIndex = 6;
            this.lvSPGoc.UseCompatibleStateImageBehavior = false;
            this.lvSPGoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá Min:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(412, 298);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(80, 26);
            this.txtMin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá Max:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(412, 341);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(80, 26);
            this.txtMax.TabIndex = 8;
            // 
            // btnLocSP
            // 
            this.btnLocSP.Location = new System.Drawing.Point(538, 301);
            this.btnLocSP.Name = "btnLocSP";
            this.btnLocSP.Size = new System.Drawing.Size(106, 66);
            this.btnLocSP.TabIndex = 9;
            this.btnLocSP.Text = "Tim";
            this.btnLocSP.UseVisualStyleBackColor = true;
            this.btnLocSP.Click += new System.EventHandler(this.btnLocSP_Click);
            // 
            // lvSPLoc
            // 
            this.lvSPLoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSPLoc.FullRowSelect = true;
            this.lvSPLoc.GridLines = true;
            this.lvSPLoc.HideSelection = false;
            this.lvSPLoc.Location = new System.Drawing.Point(350, 383);
            this.lvSPLoc.Name = "lvSPLoc";
            this.lvSPLoc.Size = new System.Drawing.Size(294, 193);
            this.lvSPLoc.TabIndex = 6;
            this.lvSPLoc.UseCompatibleStateImageBehavior = false;
            this.lvSPLoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Giá";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 592);
            this.Controls.Add(this.btnLocSP);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvSPLoc);
            this.Controls.Add(this.lvSPGoc);
            this.Controls.Add(this.lstChan);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lstGoc);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học FindAll";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ListBox lstGoc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ListBox lstChan;
        private System.Windows.Forms.ListView lvSPGoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnLocSP;
        private System.Windows.Forms.ListView lvSPLoc;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

