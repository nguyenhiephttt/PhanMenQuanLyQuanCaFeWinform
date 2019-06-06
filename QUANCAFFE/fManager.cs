using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;


namespace QUANCAFFE
{

    public partial class fManager : Form
    {

        public fManager()
        {
            InitializeComponent();

            LoadDSBan();
            LoadDSDoUong();
            TinhTien.giamgia = double.Parse(txtGiamGia.Text);
            // this.KeyPress += new KeyPressEventHandler(this.Keypress);


        }

        //private void Keypress(object sender, KeyPressEventArgs e)
        //{
        //    MessageBox.Show("button: " + e.KeyChar);

        //}


        private void LoadDSDoUong()
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {

                    grvDSDoUongF.DataSource = k.DSDoUong;

                    //from sp in k.DSDoUong
                    //                      select   new
                    //                      {
                    //                          sp.TenDoUong,
                    //                          sp.IDLoai,
                    //                          sp.GiaBan 
                    //                      };
                }
            }
            catch
            {
                return;
            }
        }
        private void LoadDSBan()
        {
            try
            {

                using (var k = new AppCode.QuanCafe())
                {

                    for (int i = 0; i < k.DSBan.Count; i++)
                    {

                        Button btnBan = new Button();
                        btnBan.Width = 78;
                        btnBan.Height = 88;

                        btnBan.Text = k.DSBan[i].TenBan + Environment.NewLine;
                        btnBan.ForeColor = Color.Blue;
                        btnBan.TextAlign = ContentAlignment.BottomCenter;
                        //lay dung dan tuong doi
                        string[] s = { "\\bin" };
                        string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Image\\icons8-coffee-to-go-80.png";
                        btnBan.BackgroundImage = Image.FromFile(path);

                        btnBan.Click += btnBan_Click;
                        btnBan.Tag = k.DSBan[i];

                        switch (k.DSBan[i].TrangThai)
                        {
                            case "Trống":
                                btnBan.BackColor = Color.Azure;
                                break;
                            case "Có người":
                                btnBan.BackColor = Color.Red;
                                break;
                                //case "Chưa gọi":
                                //btnBan.BackColor = Color.Blue;
                        }
                        flpDSBan.Controls.Add(btnBan);
                    }
                };
            }
            catch
            {

            }
        }
        private void btnBan_Click(object sender, EventArgs e)
        {
            int idban = ((sender as Button).Tag as Ban).IDBan;
            //MessageBox.Show(System.IO.Directory.GetCurrentDirectory() + @"\Image\icons8 -coffee-to-go-80.png");

            AppCode.STBan.idBan = idban;
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var ban = k.TimBan(idban);
                    //Hien thi ten ban
                    lblTenBan.Text = ban.TenBan;
                    if (ban.TrangThai == "Trống")
                    {
                        if (MessageBox.Show("Bạn muốn mỡ bàn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {
                            (sender as Button).BackColor = Color.Red;
                            var o = new Ban()
                            {
                                IDBan = idban,
                                TenBan = ban.TenBan,
                                TrangThai = "Có người"
                            };

                            k.CapNhatBan(o);
                        }
                    }

                    LoadHD(idban);
                    LoadTongTien();

                }
                // (sender as Button).BackColor = Color.Red;
                //MessageBox.Show("idban=" + ((sender as Button).Tag as Ban).IDBan.ToString());
            }
            catch
            {

            }
        }
        private void LoadHD(int id)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var kq = k.TimHoaDonTheoIDBan(id);
                    if (kq == null)
                    {
                        grvCTBanTest.DataSource = null;
                        //MessageBox.Show("Khong co hoa don");
                        return;

                    }
                    if (kq != null)
                    {
                        AppCode.STHoaDon.idHoaDon = kq.IDHoaDon;
                        //MessageBox.Show("ID HOA DON=" + kq.IDHoaDon.ToString());
                        LoadDSCTHD(kq.IDHoaDon);
                    }



                }
            }
            catch
            {
                return;
            }
        }

        private void LoadDSCTHD(int iDHoaDon)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var kq = k.TimDSCTHD(iDHoaDon);
                    grvCTBanTest.DataSource = kq;

                    //var result = from p in k.DSCTHD
                    //             from c in k.DSDoUong
                    //             where p.IDDoUong == c.IDDoUong
                    //             select new
                    //             {
                    //                 TenDoUong =  c.TenDoUong,
                    //             };
                    //MessageBox.Show("Ket qua=" + result.Count().ToString());
                    //   grvTest.DataSource = kq;
                    //Tủy chỉnh dataGridView control
                    LoadTongTien();
                }
            }


            catch
            {

            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void quảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fQuanLy f = new fQuanLy();
            f.ShowDialog();
            LoadDSDoUong();
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            fThongTinTaiKhoan f = new fThongTinTaiKhoan();
            //hien thi form Thong tin tai khoan
            f.ShowDialog();
        }

        private void btnThemMon_Click_1(object sender, EventArgs e)
        {


            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    //Kiem tra trang thai ban
                    var kqtimban = k.TimBan(AppCode.STBan.idBan);
                    if (kqtimban.TrangThai == "Trống")
                    {
                        if (MessageBox.Show("Bạn muốn mỡ bàn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                        {
                            var o = new Ban()
                            {
                                IDBan = kqtimban.IDBan,
                                TenBan = kqtimban.TenBan,
                                TrangThai = "Có người"
                            };
                            //cap nhat trang thai ban
                            k.CapNhatBan(o);
                            flpDSBan.Controls.Clear();
                            LoadDSBan();
                        }
                        else
                        {
                            return;
                        }
                    }



                    int rowSelected = grvDSDoUongF.CurrentRow.Index;
                    // dataGridView.Rows[rowSelected].Cells[i].Value;
                    var hd = k.TimHoaDonTheoIDBan(AppCode.STBan.idBan);
                    //Ban chua co hoa don
                    if (hd == null)
                    {
                        MessageBox.Show("dat tao hd");

                         hd = new HoaDon()
                        {

                            TrangThai = false,
                            NgayLap = DateTime.Now,
                            IDNhanVienLap = AppCode.STNhanVien.idNhanVien,
                            IDBan = AppCode.STBan.idBan,


                        };


                        //var hd = new HoaDonADO(
                        //    0,
                        //    AppCode.STBan.idBan,
                        //    DateTime.Now,
                        //    AppCode.STNhanVien.idNhanVien,
                        //   false
                        //);

                        var kq1 = k.ThemHoaDon(hd);
                        AppCode.STHoaDon.idHoaDon = hd.IDHoaDon;

                    }
                   

                    if(hd!=null)
                    {

                        var cthd = new CTHoaDonADO()
                        {
                            IDHoaDon = hd.IDHoaDon,
                            IDDoUong = k.TimDoUongTheoTen(grvDSDoUongF.Rows[rowSelected].Cells[0].Value.ToString()).IDDoUong,
                            SoLuong = int.Parse(nudSoLuong.Value.ToString()),
                            GiaGoc = k.TimDoUongTheoTen(grvDSDoUongF.Rows[rowSelected].Cells[0].Value.ToString()).GiaGoc,
                            GiaBan = double.Parse(grvDSDoUongF.Rows[rowSelected].Cells[3].Value.ToString())
                        };

                       
                        string sql = @"SP_GOIMON '" + cthd.IDHoaDon + "', '" + cthd.IDDoUong + "','" + cthd.SoLuong + "','" + cthd.GiaGoc + "','" + cthd.GiaBan + "' ";
                        var gt = XuLyDuLieu.ThucThiThemXoaSua(sql);
                        MessageBox.Show(gt.ToString());
                        LoadDSCTHD(hd.IDHoaDon);
                        LoadTongTien();
                        LoadDSDoUong();           
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void đặtSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDatSoLuong f2 = new fDatSoLuong();
            f2.ShowDialog();
            LoadDSCTHD(AppCode.STHoaDon.idHoaDon);
        }
        private void grvCTBanTest_SelectionChanged(object sender, EventArgs e)
        {
            int rowSelected = grvCTBanTest.CurrentRow.Index;

            try
            {
                using (var k = new AppCode.QuanCafe())
                {

                    var kq = k.TimDoUong(k.TimDSCTHD(AppCode.STHoaDon.idHoaDon)[rowSelected].IDDoUong);
                    AppCode.STDoUong.id = kq.IDDoUong;
                    AppCode.STDoUong.soLuong = int.Parse(grvCTBanTest.Rows[rowSelected].Cells[2].Value.ToString());
                    AppCode.STDoUong.giaban = int.Parse(grvCTBanTest.Rows[rowSelected].Cells[3].Value.ToString());
                    AppCode.STDoUong.giagoc = kq.GiaGoc;
                    AppCode.STDoUong.loai = kq.IDLoai;
                    AppCode.STDoUong.ten = kq.TenDoUong;

                }
            }
            catch
            {
                return;
            }
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new DBQUANCAFFEDataContext())
                {

                    if (AppCode.STBan.idBan == 0)
                    {
                        MessageBox.Show("Hãy chọn bàn cần gộp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    var timban = k.Bans.FirstOrDefault(c => c.IDBan == AppCode.STBan.idBan);
                    var timhd = k.HoaDons.FirstOrDefault(c => c.IDBan == AppCode.STBan.idBan);
                    if (timban.TrangThai == "Trống")
                    {
                        MessageBox.Show("Bàn này chưa được mở", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        return;
                    }

                    if (timhd == null)
                    {
                        MessageBox.Show("Bàn này chưa gọi món", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        fGopBan f = new fGopBan();
                        f.ShowDialog();
                        LoadDSCTHD(AppCode.STBanGop.idBan);
                        flpDSBan.Controls.Clear();
                        LoadDSBan();
                    }
                }
            }
            catch
            {
                return;
            }


        }

        private void LoadTongTien()
        {
            double t = 0;

            try
            {
                using (var k = new AppCode.QuanCafe())
                {

                    foreach (var item in k.TimDSCTHD(AppCode.STHoaDon.idHoaDon))
                    {
                        t += ((item.SoLuong * item.GiaBan));
                    }
                }
            }
            catch
            {

            }
            txtTamTinh.Text = t.ToString();
            txtTongTien.Text = txtTamTinh.Text;
        }



        private void trviewDoUong_Click(object sender, EventArgs e)
        {
            List<DoUong> ds = new List<DoUong>();
            TreeViewHitTestInfo info = trviewDoUong.HitTest(trviewDoUong.PointToClient(Cursor.Position));
            if (info != null)
                //   MessageBox.Show(info.Node.Text);
                try
                {
                    using (var k = new AppCode.QuanCafe())
                    {
                        foreach (var item in k.DSDoUong)
                        {
                            if (k.TimLoaiDU(item.IDLoai).TenLoai.ToUpper() == info.Node.Text.ToUpper())
                            {
                                ds.Add(item);

                            }
                        }
                        grvDSDoUongF.DataSource = ds;
                    }
                }
                catch
                {

                }
        }



        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            double t = 0;
            double giamgia = 0;
            try
            {
                if(double.TryParse(txtGiamGia.Text,out giamgia))
                {
                    if (giamgia >= 0 && giamgia <= 100)
                    {
                        TinhTien.giamgia = giamgia;

                        try
                        {
                            using (var k = new AppCode.QuanCafe())
                            {

                                foreach (var item in k.TimDSCTHD(AppCode.STHoaDon.idHoaDon))
                                {
                                    t += ((item.SoLuong * item.GiaBan) -
                                        (item.SoLuong * item.GiaBan) *
                                        (double.Parse(txtGiamGia.Text) / 100));
                                }
                            }
                        }
                        catch
                        {

                        }

                        txtTongTien.Text = t.ToString();
                    }
                    else
                    {
                        giamgia = 0;
                        txtGiamGia.Text = "0";
                        MessageBox.Show("Giam giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                 
                }
                else
                {
                    giamgia = 0;
                    txtGiamGia.Text = "0";
                    MessageBox.Show("Giam giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
            }
            catch
            {


                giamgia = 0;
                txtGiamGia.Text = "0";
                return;
            }
 
        }


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var timhd = k.TimHoaDon(AppCode.STHoaDon.idHoaDon);

                    timhd.TrangThai = true;
                    timhd.GiamGia = TinhTien.giamgia;
                    //MessageBox.Show(timhd.GiamGia.ToString());
                    k.SuaHD(timhd);
                    var timban = k.TimBan(AppCode.STBan.idBan);
                    //cap nhat
                    timban.TrangThai = "Trống";
                    k.CapNhatBan(timban);
                    txtGiamGia.Text = string.Empty;
                    txtTamTinh.Text = string.Empty;
                    txtTongTien.Text = string.Empty;

                    flpDSBan.Controls.Clear();
                    LoadDSBan();
                    grvCTBanTest.DataSource = null;

                    fThanhToan f = new fThanhToan();
                    f.ShowDialog();


                }

            }
            catch
            {

            }

        }




        private void btnTimDoUong_Click(object sender, EventArgs e)
        {

            TimKiem();
        }

        private void TimKiem()
        {
            try
            {
                if (AppCode.Extention.ChuoiHopLe(txtTimDoUong.Text) == false)
                {
                    MessageBox.Show("Từ khóa bạn nhập không hợp lệ",
                        "Thông báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);

                    using (var k = new AppCode.QuanCafe())
                    {
                        grvDSDoUongF.DataSource = k.DSDoUong;
                    }
                    return;
                }
                using (var k = new AppCode.QuanCafe())
                {
                    List<DoUong> ds = new List<DoUong>();
                    foreach (var douong in k.DSDoUong)
                    {
                        if (douong.TenDoUong.Contains(txtTimDoUong.Text)){
                            ds.Add(douong);
                        }
                      
                    }
                   // var kq = k.TimDoUongTheoTen(txtTimDoUong.Text);
                    if (ds != null)
                    {
                        grvDSDoUongF.DataSource = ds;
                    }
                    else
                    {

                        MessageBox.Show("Không tìm thấy đồ uống " + txtTimDoUong.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch
            {

            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTKDoanhThu f = new fTKDoanhThu();
            f.ShowDialog();
        }


        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            try
            {
                var idhdon = AppCode.STHoaDon.idHoaDon;

                using (var k = new AppCode.QuanCafe())
                {
                    var iddouong = k.TimDoUongTheoTen(grvCTBanTest.CurrentRow.Cells[0].Value.ToString());


                    var kq = k.XoaDU_Ban(idhdon, iddouong.IDDoUong);
                    if (kq == true)
                    {
                        LoadDSCTHD(idhdon);
                        MessageBox.Show("Xoá thành công", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {

            }
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }

        }
        //Phim tat
        private void fManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                TimKiem();
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                this.Close();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                hóaĐơnToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.T)
            {
                try
                {
                    using (var k = new AppCode.QuanCafe())
                    {
                        var timhd = k.TimHoaDon(AppCode.STHoaDon.idHoaDon);

                        timhd.TrangThai = true;
                        timhd.GiamGia = TinhTien.giamgia;
                        //MessageBox.Show(timhd.GiamGia.ToString());
                        k.SuaHD(timhd);
                        var timban = k.TimBan(AppCode.STBan.idBan);

                        timban.TrangThai = "Trống";
                        k.CapNhatBan(timban);
                        flpDSBan.Controls.Clear();
                        LoadDSBan();
                        grvCTBanTest.DataSource = null;

                        fThanhToan f = new fThanhToan();
                        f.ShowDialog();
                    }

                }
                catch
                {

                }
            }
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {

                   
                if (MessageBox.Show("Bạn muốn hủy bàn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != System.Windows.Forms.DialogResult.Cancel)
                {

                var kqtimban = XuLyDuLieu.DocDuLieu("EXEC SP_TimBan '" + AppCode.STBan.idBan + "' ");
                var tenban = kqtimban.Rows[0]["TenBan"].ToString();
                int idban = AppCode.STBan.idBan;
                XuLyDuLieu.ThucThiThemXoaSua("SP_UPDATE_BAN '" +idban + "','" + tenban + "',Trống");

                try
                {
                    using (var k = new AppCode.QuanCafe())
                    {
                        var timhd = k.TimHoaDon(AppCode.STHoaDon.idHoaDon);

                        timhd.TrangThai = true;
                        timhd.GiamGia = TinhTien.giamgia;
                        //MessageBox.Show(timhd.GiamGia.ToString());
                        k.SuaHD(timhd);
                        var timban = k.TimBan(AppCode.STBan.idBan);
                        //cap nhat
                        timban.TrangThai = "Trống";
                        k.CapNhatBan(timban);
                        txtGiamGia.Text  = "0";
                        txtTamTinh.Text  = "0";
                        txtTongTien.Text = "0";

                        lblTenBan.Text = "";
                        grvCTBanTest.DataSource = null;

                       

                    }

                }
                catch
                {

                }


                flpDSBan.Controls.Clear();
                LoadDSBan();

               }
        }
    }
}
