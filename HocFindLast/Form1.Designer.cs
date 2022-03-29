namespace HocFindLast
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnTaoDS = new System.Windows.Forms.Button();
            this.lstDS = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lvSP = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTimNgay = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnTimNgay);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lvSP);
            this.splitContainer1.Size = new System.Drawing.Size(785, 551);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lstDS);
            this.splitContainer2.Panel1.Controls.Add(this.btnTaoDS);
            this.splitContainer2.Panel1.Controls.Add(this.txtN);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtKQ);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.btnTim);
            this.splitContainer2.Panel2.Controls.Add(this.txtTim);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(383, 551);
            this.splitContainer2.SplitterDistance = 346;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(95, 33);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(145, 26);
            this.txtN.TabIndex = 1;
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(271, 23);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(93, 35);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tao DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstDS
            // 
            this.lstDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstDS.FormattingEnabled = true;
            this.lstDS.ItemHeight = 20;
            this.lstDS.Location = new System.Drawing.Point(0, 82);
            this.lstDS.Name = "lstDS";
            this.lstDS.Size = new System.Drawing.Size(383, 264);
            this.lstDS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập N cần tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(161, 39);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 26);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(267, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(93, 39);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(198, 99);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(162, 26);
            this.txtKQ.TabIndex = 4;
            // 
            // lvSP
            // 
            this.lvSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSP.FullRowSelect = true;
            this.lvSP.GridLines = true;
            this.lvSP.HideSelection = false;
            this.lvSP.Location = new System.Drawing.Point(0, 0);
            this.lvSP.Name = "lvSP";
            this.lvSP.Size = new System.Drawing.Size(398, 330);
            this.lvSP.TabIndex = 0;
            this.lvSP.UseCompatibleStateImageBehavior = false;
            this.lvSP.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chọn ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 387);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnTimNgay
            // 
            this.btnTimNgay.Location = new System.Drawing.Point(283, 442);
            this.btnTimNgay.Name = "btnTimNgay";
            this.btnTimNgay.Size = new System.Drawing.Size(103, 41);
            this.btnTimNgay.TabIndex = 3;
            this.btnTimNgay.Text = "Tim";
            this.btnTimNgay.UseVisualStyleBackColor = true;
            this.btnTimNgay.Click += new System.EventHandler(this.btnTimNgay_Click);
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
            this.columnHeader3.Text = "Hạn dùng";
            this.columnHeader3.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 551);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học FindLast";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lstDS;
        private System.Windows.Forms.Button btnTaoDS;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvSP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

