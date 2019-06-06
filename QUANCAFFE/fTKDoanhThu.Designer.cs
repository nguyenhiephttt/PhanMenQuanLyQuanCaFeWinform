namespace QUANCAFFE
{
    partial class fTKDoanhThu
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ngày hôm nay");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tháng trước");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Qúy trước");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Năm trước");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tuần trước");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTKDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imglThhongKe = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvTKHoaDon = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANCAFFEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANCAFFEDataSet = new QUANCAFFE.QUANCAFFEDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtpkDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSHD = new System.Windows.Forms.Label();
            this.tpTK = new System.Windows.Forms.TabControl();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpTKBieuDo = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTKHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpTK.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 428);
            this.panel1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imglThhongKe;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            treeNode6.Name = "TKNgayHomNay";
            treeNode6.Text = "Ngày hôm nay";
            treeNode7.Name = "TKThangTruoc";
            treeNode7.Text = "Tháng trước";
            treeNode8.Name = "TKQuyTruoc";
            treeNode8.Text = "Qúy trước";
            treeNode9.Name = "TKNamTruoc";
            treeNode9.Text = "Năm trước";
            treeNode10.Name = "TKTuanTruoc";
            treeNode10.Text = "Tuần trước";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(207, 399);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imglThhongKe
            // 
            this.imglThhongKe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglThhongKe.ImageStream")));
            this.imglThhongKe.TransparentColor = System.Drawing.Color.Transparent;
            this.imglThhongKe.Images.SetKeyName(0, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(1, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(2, "icons8-calendar-18.png");
            this.imglThhongKe.Images.SetKeyName(3, "icons8-calendar-18.png");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 32);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí thống kê";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.tpTK);
            this.panel2.Location = new System.Drawing.Point(213, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 428);
            this.panel2.TabIndex = 1;
            // 
            // grvTKHoaDon
            // 
            this.grvTKHoaDon.AutoGenerateColumns = false;
            this.grvTKHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grvTKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTKHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.IDHoaDon,
            this.NhanVien,
            this.NgayLap,
            this.TongTien});
            this.grvTKHoaDon.DataSource = this.qUANCAFFEDataSetBindingSource;
            this.grvTKHoaDon.EnableHeadersVisualStyles = false;
            this.grvTKHoaDon.Location = new System.Drawing.Point(0, 3);
            this.grvTKHoaDon.Name = "grvTKHoaDon";
            this.grvTKHoaDon.Size = new System.Drawing.Size(573, 392);
            this.grvTKHoaDon.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.DataPropertyName = "IDHoaDon";
            this.IDHoaDon.HeaderText = "Hóa đơn";
            this.IDHoaDon.Name = "IDHoaDon";
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "TenNhanVien";
            this.NhanVien.HeaderText = "Nhân viên lập";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Width = 150;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 130;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // qUANCAFFEDataSetBindingSource
            // 
            this.qUANCAFFEDataSetBindingSource.DataSource = this.qUANCAFFEDataSet;
            this.qUANCAFFEDataSetBindingSource.Position = 0;
            // 
            // qUANCAFFEDataSet
            // 
            this.qUANCAFFEDataSet.DataSetName = "QUANCAFFEDataSet";
            this.qUANCAFFEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXem);
            this.panel3.Controls.Add(this.dtpkDenNgay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpkTuNgay);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(826, 32);
            this.panel3.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(595, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 23);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpkDenNgay
            // 
            this.dtpkDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkDenNgay.Location = new System.Drawing.Point(369, 3);
            this.dtpkDenNgay.Name = "dtpkDenNgay";
            this.dtpkDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpkDenNgay.TabIndex = 3;
            this.dtpkDenNgay.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "@Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "@Từ ngày";
            // 
            // dtpkTuNgay
            // 
            this.dtpkTuNgay.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dtpkTuNgay.CausesValidation = false;
            this.dtpkTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTuNgay.Location = new System.Drawing.Point(79, 3);
            this.dtpkTuNgay.Name = "dtpkTuNgay";
            this.dtpkTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpkTuNgay.TabIndex = 0;
            this.dtpkTuNgay.Value = new System.DateTime(2018, 4, 30, 18, 50, 12, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền:";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(707, 470);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 23);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(584, 475);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(39, 13);
            this.lblTong.TabIndex = 5;
            this.lblTong.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng số HĐ:";
            // 
            // lblSHD
            // 
            this.lblSHD.AutoSize = true;
            this.lblSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHD.ForeColor = System.Drawing.Color.Red;
            this.lblSHD.Location = new System.Drawing.Point(442, 476);
            this.lblSHD.Name = "lblSHD";
            this.lblSHD.Size = new System.Drawing.Size(39, 13);
            this.lblSHD.TabIndex = 7;
            this.lblSHD.Text = "NULL";
            // 
            // tpTK
            // 
            this.tpTK.Controls.Add(this.tpTable);
            this.tpTK.Controls.Add(this.tpTKBieuDo);
            this.tpTK.Location = new System.Drawing.Point(4, 4);
            this.tpTK.Name = "tpTK";
            this.tpTK.SelectedIndex = 0;
            this.tpTK.Size = new System.Drawing.Size(577, 421);
            this.tpTK.TabIndex = 1;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.grvTKHoaDon);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(569, 395);
            this.tpTable.TabIndex = 0;
            this.tpTable.Text = "Thống kê table";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpTKBieuDo
            // 
            this.tpTKBieuDo.Location = new System.Drawing.Point(4, 22);
            this.tpTKBieuDo.Name = "tpTKBieuDo";
            this.tpTKBieuDo.Padding = new System.Windows.Forms.Padding(3);
            this.tpTKBieuDo.Size = new System.Drawing.Size(569, 395);
            this.tpTKBieuDo.TabIndex = 1;
            this.tpTKBieuDo.Text = "Thống kê Biểu Đồ";
            this.tpTKBieuDo.UseVisualStyleBackColor = true;
            // 
            // fTKDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 496);
            this.Controls.Add(this.lblSHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fTKDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTKHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANCAFFEDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpTK.ResumeLayout(false);
            this.tpTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imglThhongKe;
        private System.Windows.Forms.DataGridView grvTKHoaDon;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpkDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.BindingSource qUANCAFFEDataSetBindingSource;
        private QUANCAFFEDataSet qUANCAFFEDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSHD;
        private System.Windows.Forms.TabControl tpTK;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpTKBieuDo;
    }
}