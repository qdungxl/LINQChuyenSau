namespace HocMaxMin
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
            this.lstInt = new System.Windows.Forms.ListBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(154, 29);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(148, 26);
            this.txtN.TabIndex = 1;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(349, 12);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(116, 43);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lstInt
            // 
            this.lstInt.FormattingEnabled = true;
            this.lstInt.ItemHeight = 20;
            this.lstInt.Location = new System.Drawing.Point(45, 91);
            this.lstInt.Name = "lstInt";
            this.lstInt.Size = new System.Drawing.Size(257, 244);
            this.lstInt.TabIndex = 3;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(349, 91);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(116, 45);
            this.btnMax.TabIndex = 4;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(349, 152);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(116, 45);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 376);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.lstInt);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học MaxMin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.ListBox lstInt;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}

