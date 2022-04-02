namespace HocToArray
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
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.lblMang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(39, 35);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(197, 52);
            this.btnTaoMang.TabIndex = 0;
            this.btnTaoMang.Text = "Tạo Mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // lblMang
            // 
            this.lblMang.AutoSize = true;
            this.lblMang.Location = new System.Drawing.Point(39, 120);
            this.lblMang.Name = "lblMang";
            this.lblMang.Size = new System.Drawing.Size(51, 20);
            this.lblMang.TabIndex = 1;
            this.lblMang.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 279);
            this.Controls.Add(this.lblMang);
            this.Controls.Add(this.btnTaoMang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học ToArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Label lblMang;
    }
}

