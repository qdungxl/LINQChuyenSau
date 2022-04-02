namespace HocTake
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
            this.lstInt = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTake = new System.Windows.Forms.ListBox();
            this.txtTake = new System.Windows.Forms.TextBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.lvDanhBa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVeDau = new System.Windows.Forms.Button();
            this.btnQuaTrai = new System.Windows.Forms.Button();
            this.btnQuaPhai = new System.Windows.Forms.Button();
            this.btnVeCuoi = new System.Windows.Forms.Button();
            this.lblViTri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(78, 27);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(66, 26);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // btnTaoDS
            // 
            this.btnTaoDS.Location = new System.Drawing.Point(150, 13);
            this.btnTaoDS.Name = "btnTaoDS";
            this.btnTaoDS.Size = new System.Drawing.Size(85, 40);
            this.btnTaoDS.TabIndex = 2;
            this.btnTaoDS.Text = "Tạo DS";
            this.btnTaoDS.UseVisualStyleBackColor = true;
            this.btnTaoDS.Click += new System.EventHandler(this.btnTaoDS_Click);
            // 
            // lstInt
            // 
            this.lstInt.FormattingEnabled = true;
            this.lstInt.ItemHeight = 20;
            this.lstInt.Location = new System.Drawing.Point(28, 73);
            this.lstInt.Name = "lstInt";
            this.lstInt.Size = new System.Drawing.Size(207, 144);
            this.lstInt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Take:";
            // 
            // lstTake
            // 
            this.lstTake.FormattingEnabled = true;
            this.lstTake.ItemHeight = 20;
            this.lstTake.Location = new System.Drawing.Point(28, 291);
            this.lstTake.Name = "lstTake";
            this.lstTake.Size = new System.Drawing.Size(207, 124);
            this.lstTake.TabIndex = 3;
            // 
            // txtTake
            // 
            this.txtTake.Location = new System.Drawing.Point(78, 241);
            this.txtTake.Name = "txtTake";
            this.txtTake.Size = new System.Drawing.Size(66, 26);
            this.txtTake.TabIndex = 4;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(175, 241);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(60, 26);
            this.btnTake.TabIndex = 5;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // lvDanhBa
            // 
            this.lvDanhBa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDanhBa.FullRowSelect = true;
            this.lvDanhBa.GridLines = true;
            this.lvDanhBa.HideSelection = false;
            this.lvDanhBa.Location = new System.Drawing.Point(294, 27);
            this.lvDanhBa.Name = "lvDanhBa";
            this.lvDanhBa.Size = new System.Drawing.Size(368, 324);
            this.lvDanhBa.TabIndex = 6;
            this.lvDanhBa.UseCompatibleStateImageBehavior = false;
            this.lvDanhBa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ten";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phone";
            this.columnHeader2.Width = 200;
            // 
            // btnVeDau
            // 
            this.btnVeDau.Location = new System.Drawing.Point(294, 369);
            this.btnVeDau.Name = "btnVeDau";
            this.btnVeDau.Size = new System.Drawing.Size(53, 36);
            this.btnVeDau.TabIndex = 7;
            this.btnVeDau.Text = "|<";
            this.btnVeDau.UseVisualStyleBackColor = true;
            this.btnVeDau.Click += new System.EventHandler(this.btnVeDau_Click);
            // 
            // btnQuaTrai
            // 
            this.btnQuaTrai.Location = new System.Drawing.Point(353, 369);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new System.Drawing.Size(53, 36);
            this.btnQuaTrai.TabIndex = 7;
            this.btnQuaTrai.Text = "<<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new System.EventHandler(this.btnQuaTrai_Click);
            // 
            // btnQuaPhai
            // 
            this.btnQuaPhai.Location = new System.Drawing.Point(551, 369);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new System.Drawing.Size(53, 36);
            this.btnQuaPhai.TabIndex = 7;
            this.btnQuaPhai.Text = ">>";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new System.EventHandler(this.btnQuaPhai_Click);
            // 
            // btnVeCuoi
            // 
            this.btnVeCuoi.Location = new System.Drawing.Point(610, 369);
            this.btnVeCuoi.Name = "btnVeCuoi";
            this.btnVeCuoi.Size = new System.Drawing.Size(53, 36);
            this.btnVeCuoi.TabIndex = 7;
            this.btnVeCuoi.Text = ">|";
            this.btnVeCuoi.UseVisualStyleBackColor = true;
            this.btnVeCuoi.Click += new System.EventHandler(this.btnVeCuoi_Click);
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(459, 385);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(51, 20);
            this.lblViTri.TabIndex = 8;
            this.lblViTri.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 451);
            this.Controls.Add(this.lblViTri);
            this.Controls.Add(this.btnVeCuoi);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnVeDau);
            this.Controls.Add(this.lvDanhBa);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.txtTake);
            this.Controls.Add(this.lstTake);
            this.Controls.Add(this.lstInt);
            this.Controls.Add(this.btnTaoDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Take";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTaoDS;
        private System.Windows.Forms.ListBox lstInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTake;
        private System.Windows.Forms.TextBox txtTake;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.ListView lvDanhBa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnVeDau;
        private System.Windows.Forms.Button btnQuaTrai;
        private System.Windows.Forms.Button btnQuaPhai;
        private System.Windows.Forms.Button btnVeCuoi;
        private System.Windows.Forms.Label lblViTri;
    }
}

