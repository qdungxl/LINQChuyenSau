namespace HocLinQtoSQL
{
    partial class frmMain
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
            this.btnTruyVanMethod = new System.Windows.Forms.Button();
            this.btnTimSPMethod = new System.Windows.Forms.Button();
            this.btnTimSPQuery = new System.Windows.Forms.Button();
            this.btnXemChiTietMethod = new System.Windows.Forms.Button();
            this.btnXemChiTietQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTruyVanMethod
            // 
            this.btnTruyVanMethod.Location = new System.Drawing.Point(12, 12);
            this.btnTruyVanMethod.Name = "btnTruyVanMethod";
            this.btnTruyVanMethod.Size = new System.Drawing.Size(205, 60);
            this.btnTruyVanMethod.TabIndex = 0;
            this.btnTruyVanMethod.Text = "Truy vấn SP dùng method Syntax";
            this.btnTruyVanMethod.UseVisualStyleBackColor = true;
            this.btnTruyVanMethod.Click += new System.EventHandler(this.btnTruyVanMethod_Click);
            // 
            // btnTimSPMethod
            // 
            this.btnTimSPMethod.Location = new System.Drawing.Point(12, 90);
            this.btnTimSPMethod.Name = "btnTimSPMethod";
            this.btnTimSPMethod.Size = new System.Drawing.Size(205, 60);
            this.btnTimSPMethod.TabIndex = 1;
            this.btnTimSPMethod.Text = "Tìm SP trong khoảng giá Method syntax";
            this.btnTimSPMethod.UseVisualStyleBackColor = true;
            this.btnTimSPMethod.Click += new System.EventHandler(this.btnTimSPMethod_Click);
            // 
            // btnTimSPQuery
            // 
            this.btnTimSPQuery.Location = new System.Drawing.Point(249, 90);
            this.btnTimSPQuery.Name = "btnTimSPQuery";
            this.btnTimSPQuery.Size = new System.Drawing.Size(205, 60);
            this.btnTimSPQuery.TabIndex = 2;
            this.btnTimSPQuery.Text = "Tìm SP trong khoảng giá Query syntax";
            this.btnTimSPQuery.UseVisualStyleBackColor = true;
            this.btnTimSPQuery.Click += new System.EventHandler(this.btnTimSPQuery_Click);
            // 
            // btnXemChiTietMethod
            // 
            this.btnXemChiTietMethod.Location = new System.Drawing.Point(12, 175);
            this.btnXemChiTietMethod.Name = "btnXemChiTietMethod";
            this.btnXemChiTietMethod.Size = new System.Drawing.Size(205, 60);
            this.btnXemChiTietMethod.TabIndex = 3;
            this.btnXemChiTietMethod.Text = "Xem chi tiết sản phẩm Method";
            this.btnXemChiTietMethod.UseVisualStyleBackColor = true;
            this.btnXemChiTietMethod.Click += new System.EventHandler(this.btnXemChiTietMethod_Click);
            // 
            // btnXemChiTietQuery
            // 
            this.btnXemChiTietQuery.Location = new System.Drawing.Point(249, 175);
            this.btnXemChiTietQuery.Name = "btnXemChiTietQuery";
            this.btnXemChiTietQuery.Size = new System.Drawing.Size(205, 60);
            this.btnXemChiTietQuery.TabIndex = 4;
            this.btnXemChiTietQuery.Text = "Xem chi tiết sản phẩm Query";
            this.btnXemChiTietQuery.UseVisualStyleBackColor = true;
            this.btnXemChiTietQuery.Click += new System.EventHandler(this.btnXemChiTietQuery_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 415);
            this.Controls.Add(this.btnXemChiTietQuery);
            this.Controls.Add(this.btnXemChiTietMethod);
            this.Controls.Add(this.btnTimSPQuery);
            this.Controls.Add(this.btnTimSPMethod);
            this.Controls.Add(this.btnTruyVanMethod);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Học LinQ to Sql";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTruyVanMethod;
        private System.Windows.Forms.Button btnTimSPMethod;
        private System.Windows.Forms.Button btnTimSPQuery;
        private System.Windows.Forms.Button btnXemChiTietMethod;
        private System.Windows.Forms.Button btnXemChiTietQuery;
    }
}

