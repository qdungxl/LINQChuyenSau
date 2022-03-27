namespace HocCacLoaiCuPhapLinQ
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
            this.btnVD1 = new System.Windows.Forms.Button();
            this.btnVD2 = new System.Windows.Forms.Button();
            this.btnVD3 = new System.Windows.Forms.Button();
            this.btnVD4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVD1
            // 
            this.btnVD1.Location = new System.Drawing.Point(34, 26);
            this.btnVD1.Name = "btnVD1";
            this.btnVD1.Size = new System.Drawing.Size(93, 32);
            this.btnVD1.TabIndex = 0;
            this.btnVD1.Text = "Ví dụ 1";
            this.btnVD1.UseVisualStyleBackColor = true;
            this.btnVD1.Click += new System.EventHandler(this.btnVD1_Click);
            // 
            // btnVD2
            // 
            this.btnVD2.Location = new System.Drawing.Point(163, 26);
            this.btnVD2.Name = "btnVD2";
            this.btnVD2.Size = new System.Drawing.Size(101, 32);
            this.btnVD2.TabIndex = 1;
            this.btnVD2.Text = "Ví dụ 2";
            this.btnVD2.UseVisualStyleBackColor = true;
            // 
            // btnVD3
            // 
            this.btnVD3.Location = new System.Drawing.Point(34, 76);
            this.btnVD3.Name = "btnVD3";
            this.btnVD3.Size = new System.Drawing.Size(93, 33);
            this.btnVD3.TabIndex = 2;
            this.btnVD3.Text = "Ví dụ 3";
            this.btnVD3.UseVisualStyleBackColor = true;
            this.btnVD3.Click += new System.EventHandler(this.btnVD3_Click);
            // 
            // btnVD4
            // 
            this.btnVD4.Location = new System.Drawing.Point(163, 76);
            this.btnVD4.Name = "btnVD4";
            this.btnVD4.Size = new System.Drawing.Size(101, 33);
            this.btnVD4.TabIndex = 3;
            this.btnVD4.Text = "Ví dụ 4";
            this.btnVD4.UseVisualStyleBackColor = true;
            this.btnVD4.Click += new System.EventHandler(this.btnVD4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 182);
            this.Controls.Add(this.btnVD4);
            this.Controls.Add(this.btnVD3);
            this.Controls.Add(this.btnVD2);
            this.Controls.Add(this.btnVD1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học các loại cú pháp LinQ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVD1;
        private System.Windows.Forms.Button btnVD2;
        private System.Windows.Forms.Button btnVD3;
        private System.Windows.Forms.Button btnVD4;
    }
}

