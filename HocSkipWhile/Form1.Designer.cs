namespace HocSkipWhile
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstInt = new System.Windows.Forms.ListBox();
            this.btnSkipWhile = new System.Windows.Forms.Button();
            this.txtDieuKien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKQ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(115, 34);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(202, 26);
            this.txtN.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tạo DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstInt
            // 
            this.lstInt.FormattingEnabled = true;
            this.lstInt.ItemHeight = 20;
            this.lstInt.Location = new System.Drawing.Point(27, 94);
            this.lstInt.Name = "lstInt";
            this.lstInt.Size = new System.Drawing.Size(166, 224);
            this.lstInt.TabIndex = 3;
            // 
            // btnSkipWhile
            // 
            this.btnSkipWhile.Location = new System.Drawing.Point(343, 349);
            this.btnSkipWhile.Name = "btnSkipWhile";
            this.btnSkipWhile.Size = new System.Drawing.Size(112, 49);
            this.btnSkipWhile.TabIndex = 4;
            this.btnSkipWhile.Text = "SkipWhile";
            this.btnSkipWhile.UseVisualStyleBackColor = true;
            this.btnSkipWhile.Click += new System.EventHandler(this.btnSkipWhile_Click);
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Location = new System.Drawing.Point(147, 372);
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.Size = new System.Drawing.Size(170, 26);
            this.txtDieuKien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập điều kiện:";
            // 
            // lstKQ
            // 
            this.lstKQ.FormattingEnabled = true;
            this.lstKQ.ItemHeight = 20;
            this.lstKQ.Location = new System.Drawing.Point(289, 94);
            this.lstKQ.Name = "lstKQ";
            this.lstKQ.Size = new System.Drawing.Size(166, 224);
            this.lstKQ.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDieuKien);
            this.Controls.Add(this.btnSkipWhile);
            this.Controls.Add(this.lstKQ);
            this.Controls.Add(this.lstInt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Học SkipWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstInt;
        private System.Windows.Forms.Button btnSkipWhile;
        private System.Windows.Forms.TextBox txtDieuKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKQ;
    }
}

