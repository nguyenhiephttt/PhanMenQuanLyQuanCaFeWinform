namespace QUANCAFFE
{
    partial class fThanhToan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThanhToan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grvCTHD = new System.Windows.Forms.DataGridView();
            this.TenDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblSoban = new System.Windows.Forms.Label();
            this.lblNhanVienLap = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.qUANCAFFEDataSet = new QUANCAFFE.QUANCAFFEDataSet();
            this.qUANCAFFEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập:     ";
            // 
            // grvCTHD
            // 
            this.grvCTHD.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDoUong,
            this.SoLuong,
            this.GiaBan,
            this.ThanhTien});
            this.grvCTHD.DataSource = this.qUANCAFFEDataSetBindingSource;
            this.grvCTHD.Location = new System.Drawing.Point(18, 99);
            this.grvCTHD.Name = "grvCTHD";
            this.grvCTHD.Size = new System.Drawing.Size(447, 257);
            this.grvCTHD.TabIndex = 3;
            this.grvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TenDoUong
            // 
            this.TenDoUong.DataPropertyName = "TenMatHang";
            this.TenDoUong.HeaderText = "Mặt hàng";
            this.TenDoUong.Name = "TenDoUong";
            this.TenDoUong.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền ";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giam giá:";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(390, 384);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "Print";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(309, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lblSoban
            // 
            this.lblSoban.AutoSize = true;
            this.lblSoban.Location = new System.Drawing.Point(97, 9);
            this.lblSoban.Name = "lblSoban";
            this.lblSoban.Size = new System.Drawing.Size(23, 13);
            this.lblSoban.TabIndex = 9;
            this.lblSoban.Text = "null";
            // 
            // lblNhanVienLap
            // 
            this.lblNhanVienLap.AutoSize = true;
            this.lblNhanVienLap.Location = new System.Drawing.Point(97, 35);
            this.lblNhanVienLap.Name = "lblNhanVienLap";
            this.lblNhanVienLap.Size = new System.Drawing.Size(23, 13);
            this.lblNhanVienLap.TabIndex = 10;
            this.lblNhanVienLap.Text = "null";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(97, 62);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(23, 13);
            this.lblNgayLap.TabIndex = 11;
            this.lblNgayLap.Text = "null";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(97, 394);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(23, 13);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "null";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(97, 369);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(23, 13);
            this.lblGiamGia.TabIndex = 13;
            this.lblGiamGia.Text = "null";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // qUANCAFFEDataSet
            // 
            this.qUANCAFFEDataSet.DataSetName = "QUANCAFFEDataSet";
            this.qUANCAFFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANCAFFEDataSetBindingSource
            // 
            this.qUANCAFFEDataSetBindingSource.DataSource = this.qUANCAFFEDataSet;
            this.qUANCAFFEDataSetBindingSource.Position = 0;
            // 
            // fThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 501);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.lblNhanVienLap);
            this.Controls.Add(this.lblSoban);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grvCTHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "fThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print form";
            this.Load += new System.EventHandler(this.fThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grvCTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblSoban;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.BindingSource qUANCAFFEDataSetBindingSource;
        private QUANCAFFEDataSet qUANCAFFEDataSet;
    }
}