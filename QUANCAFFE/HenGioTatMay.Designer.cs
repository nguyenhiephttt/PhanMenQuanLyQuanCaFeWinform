namespace QUANCAFFE
{
    partial class HenGioTatMay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGiay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPhut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGio = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShutDow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGio)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudGiay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudPhut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudGio);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 58);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giây";
            // 
            // nudGiay
            // 
            this.nudGiay.Location = new System.Drawing.Point(179, 12);
            this.nudGiay.Name = "nudGiay";
            this.nudGiay.Size = new System.Drawing.Size(40, 20);
            this.nudGiay.TabIndex = 4;
            this.nudGiay.ValueChanged += new System.EventHandler(this.nudGiay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phút";
            // 
            // nudPhut
            // 
            this.nudPhut.Location = new System.Drawing.Point(88, 12);
            this.nudPhut.Name = "nudPhut";
            this.nudPhut.Size = new System.Drawing.Size(40, 20);
            this.nudPhut.TabIndex = 2;
            this.nudPhut.ValueChanged += new System.EventHandler(this.nudPhut_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ";
            // 
            // nudGio
            // 
            this.nudGio.Location = new System.Drawing.Point(3, 12);
            this.nudGio.Name = "nudGio";
            this.nudGio.Size = new System.Drawing.Size(40, 20);
            this.nudGio.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnShutDow);
            this.panel2.Location = new System.Drawing.Point(12, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 42);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hủy lệnh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnShutDow
            // 
            this.btnShutDow.Location = new System.Drawing.Point(3, 3);
            this.btnShutDow.Name = "btnShutDow";
            this.btnShutDow.Size = new System.Drawing.Size(75, 23);
            this.btnShutDow.TabIndex = 0;
            this.btnShutDow.Text = "Shutdown";
            this.btnShutDow.UseVisualStyleBackColor = true;
            this.btnShutDow.Click += new System.EventHandler(this.btnShutDow_Click);
            // 
            // HenGioTatMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 129);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HenGioTatMay";
            this.Text = "HenGioTatMay";
            this.Load += new System.EventHandler(this.HenGioTatMay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudGiay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShutDow;
    }
}