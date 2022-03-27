namespace HocDelegate
{
    partial class delegateVsListbox
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
            this.lsbSo = new System.Windows.Forms.ListBox();
            this.btnToChan = new System.Windows.Forms.Button();
            this.btnToSoLe = new System.Windows.Forms.Button();
            this.btnToNguyenTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbSo
            // 
            this.lsbSo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbSo.FormattingEnabled = true;
            this.lsbSo.ItemHeight = 20;
            this.lsbSo.Location = new System.Drawing.Point(0, 0);
            this.lsbSo.Name = "lsbSo";
            this.lsbSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbSo.Size = new System.Drawing.Size(233, 460);
            this.lsbSo.TabIndex = 0;
            // 
            // btnToChan
            // 
            this.btnToChan.Location = new System.Drawing.Point(276, 46);
            this.btnToChan.Name = "btnToChan";
            this.btnToChan.Size = new System.Drawing.Size(210, 84);
            this.btnToChan.TabIndex = 1;
            this.btnToChan.Text = "Tô số chẵn";
            this.btnToChan.UseVisualStyleBackColor = true;
            this.btnToChan.Click += new System.EventHandler(this.btnToChan_Click);
            // 
            // btnToSoLe
            // 
            this.btnToSoLe.Location = new System.Drawing.Point(276, 166);
            this.btnToSoLe.Name = "btnToSoLe";
            this.btnToSoLe.Size = new System.Drawing.Size(210, 84);
            this.btnToSoLe.TabIndex = 1;
            this.btnToSoLe.Text = "Tô số lẻ";
            this.btnToSoLe.UseVisualStyleBackColor = true;
            this.btnToSoLe.Click += new System.EventHandler(this.btnToSoLe_Click);
            // 
            // btnToNguyenTo
            // 
            this.btnToNguyenTo.Location = new System.Drawing.Point(276, 288);
            this.btnToNguyenTo.Name = "btnToNguyenTo";
            this.btnToNguyenTo.Size = new System.Drawing.Size(210, 84);
            this.btnToNguyenTo.TabIndex = 1;
            this.btnToNguyenTo.Text = "Tô số nguyên tố";
            this.btnToNguyenTo.UseVisualStyleBackColor = true;
            this.btnToNguyenTo.Click += new System.EventHandler(this.btnToNguyenTo_Click);
            // 
            // delegateVsListbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 460);
            this.Controls.Add(this.btnToNguyenTo);
            this.Controls.Add(this.btnToSoLe);
            this.Controls.Add(this.btnToChan);
            this.Controls.Add(this.lsbSo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "delegateVsListbox";
            this.Text = "DelegateVsListbox";
            this.Load += new System.EventHandler(this.delegateVsListbox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbSo;
        private System.Windows.Forms.Button btnToChan;
        private System.Windows.Forms.Button btnToSoLe;
        private System.Windows.Forms.Button btnToNguyenTo;
    }
}