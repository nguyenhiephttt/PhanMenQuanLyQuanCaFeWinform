namespace QUANCAFFE
{
    partial class fDatSoLuong
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
            this.btnSuaSL = new System.Windows.Forms.Button();
            this.txtSuaSoluong = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt số lượng cho mặt hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSuaSL
            // 
            this.btnSuaSL.Location = new System.Drawing.Point(118, 81);
            this.btnSuaSL.Name = "btnSuaSL";
            this.btnSuaSL.Size = new System.Drawing.Size(71, 23);
            this.btnSuaSL.TabIndex = 1;
            this.btnSuaSL.Text = "Ghi lại";
            this.btnSuaSL.UseVisualStyleBackColor = true;
            this.btnSuaSL.Click += new System.EventHandler(this.btnSuaSL_Click);
            // 
            // txtSuaSoluong
            // 
            this.txtSuaSoluong.Location = new System.Drawing.Point(101, 55);
            this.txtSuaSoluong.Name = "txtSuaSoluong";
            this.txtSuaSoluong.Size = new System.Drawing.Size(172, 20);
            this.txtSuaSoluong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(204, 81);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fDatSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(285, 135);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuaSoluong);
            this.Controls.Add(this.btnSuaSL);
            this.Controls.Add(this.label1);
            this.Name = "fDatSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt số lượng";
            this.Load += new System.EventHandler(this.fDatSoLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaSL;
        private System.Windows.Forms.MaskedTextBox txtSuaSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
    }
}