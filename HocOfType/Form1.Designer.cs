namespace HocOfType
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
            this.lvGoc = new System.Windows.Forms.ListView();
            this.btnLocChinhThuc = new System.Windows.Forms.Button();
            this.btnLocThoiVu = new System.Windows.Forms.Button();
            this.lvLoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.chkLaThoiVu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lvGoc
            // 
            this.lvGoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvGoc.FullRowSelect = true;
            this.lvGoc.GridLines = true;
            this.lvGoc.HideSelection = false;
            this.lvGoc.Location = new System.Drawing.Point(12, 12);
            this.lvGoc.Name = "lvGoc";
            this.lvGoc.Size = new System.Drawing.Size(279, 191);
            this.lvGoc.TabIndex = 0;
            this.lvGoc.UseCompatibleStateImageBehavior = false;
            this.lvGoc.View = System.Windows.Forms.View.Details;
            // 
            // btnLocChinhThuc
            // 
            this.btnLocChinhThuc.Location = new System.Drawing.Point(12, 231);
            this.btnLocChinhThuc.Name = "btnLocChinhThuc";
            this.btnLocChinhThuc.Size = new System.Drawing.Size(128, 47);
            this.btnLocChinhThuc.TabIndex = 1;
            this.btnLocChinhThuc.Text = "Lọc chính thức";
            this.btnLocChinhThuc.UseVisualStyleBackColor = true;
            this.btnLocChinhThuc.Click += new System.EventHandler(this.btnLocChinhThuc_Click);
            // 
            // btnLocThoiVu
            // 
            this.btnLocThoiVu.Location = new System.Drawing.Point(162, 231);
            this.btnLocThoiVu.Name = "btnLocThoiVu";
            this.btnLocThoiVu.Size = new System.Drawing.Size(107, 47);
            this.btnLocThoiVu.TabIndex = 1;
            this.btnLocThoiVu.Text = "Lọc thời vụ";
            this.btnLocThoiVu.UseVisualStyleBackColor = true;
            // 
            // lvLoc
            // 
            this.lvLoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvLoc.FullRowSelect = true;
            this.lvLoc.GridLines = true;
            this.lvLoc.HideSelection = false;
            this.lvLoc.Location = new System.Drawing.Point(12, 308);
            this.lvLoc.Name = "lvLoc";
            this.lvLoc.Size = new System.Drawing.Size(279, 191);
            this.lvLoc.TabIndex = 0;
            this.lvLoc.UseCompatibleStateImageBehavior = false;
            this.lvLoc.View = System.Windows.Forms.View.Details;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên";
            this.columnHeader4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(431, 11);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(199, 26);
            this.txtMa.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(431, 59);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(199, 26);
            this.txtTen.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(431, 164);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 39);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // chkLaThoiVu
            // 
            this.chkLaThoiVu.AutoSize = true;
            this.chkLaThoiVu.Location = new System.Drawing.Point(431, 118);
            this.chkLaThoiVu.Name = "chkLaThoiVu";
            this.chkLaThoiVu.Size = new System.Drawing.Size(96, 24);
            this.chkLaThoiVu.TabIndex = 7;
            this.chkLaThoiVu.Text = "Là thời vụ";
            this.chkLaThoiVu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 520);
            this.Controls.Add(this.chkLaThoiVu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocThoiVu);
            this.Controls.Add(this.btnLocChinhThuc);
            this.Controls.Add(this.lvLoc);
            this.Controls.Add(this.lvGoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học OfType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGoc;
        private System.Windows.Forms.Button btnLocChinhThuc;
        private System.Windows.Forms.Button btnLocThoiVu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvLoc;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox chkLaThoiVu;
    }
}

