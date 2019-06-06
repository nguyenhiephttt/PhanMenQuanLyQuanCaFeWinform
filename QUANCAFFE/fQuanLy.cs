using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace QUANCAFFE
{

    public partial class fQuanLy : Form
    {
        public event EventHandler SelectedIndexChanged;
        public fQuanLy()
        {
            InitializeComponent();

            tpQuanLy.SelectedIndexChanged += new EventHandler(tpQuanLy_SelectedIndexChanged);
          
        }
        private void tpQuanLy_SelectedIndexChanged(Object sender, EventArgs e)
        {
            LoadPhanQuyen();
            try
            {
                using (var k = new AppCode.QuanCafe())
                {

                    for (var i = 1; i < k.DSTabPageQL.Count; i++)
                    {
                        var kq = k.TimQuyen(AppCode.STNhanVien.IDChucVu,
                                        k.DSTabPageQL[i].TenTab);
                        switch (i)
                        {


                            case 1:
                                if (kq.Them == false)
                                {
                                    btnThemBan.Enabled = false;

                                }
                                if (kq.Them == true)
                                {
                                    btnThemBan.Enabled = true;
                                }
                                if (kq.Xoa == false)
                                {
                                    btnXoaBan.Enabled = false;
                                }
                                if (kq.Xoa == true)
                                {
                                    btnXoaBan.Enabled = true;
                                }
                                if (kq.Sua == false)
                                {
                                    btnSuaBan.Enabled = false;
                                }
                                if (kq.Sua == true)
                                {
                                    btnSuaBan.Enabled = true;
                                }
                                break;

                            case 2:

                                if (kq.Xoa == false)
                                {
                                    btnXoaDU.Enabled = false;
                                }
                                if (kq.Xoa == true)
                                {
                                    btnXoaDU.Enabled = true;
                                }

                                break;

                            case 3:
                                if (kq.Them == false)
                                {
                                    btnThemLoai.Enabled = false;

                                }
                                if (kq.Them == true)
                                {
                                    btnThemLoai.Enabled = true;
                                }
                                if (kq.Xoa == false)
                                {
                                    btnXoaLoai.Enabled = false;
                                }
                                if (kq.Xoa == true)
                                {
                                    btnXoaLoai.Enabled = true;
                                }
                                if (kq.Sua == false)
                                {
                                    btnSuaLoai.Enabled = false;
                                }
                                if (kq.Sua == true)
                                {
                                    btnSuaLoai.Enabled = true;
                                }
                                break;
                            case 4:
                                if (kq.Them == false)
                                {
                                    btnThemNV.Enabled = false;

                                }
                                if (kq.Them == true)
                                {
                                    btnThemNV.Enabled = true;
                                }
                                if (kq.Xoa == false)
                                {
                                    btnXoaNV.Enabled = false;
                                }
                                if (kq.Xoa == true)
                                {
                                    btnXoaNV.Enabled = true;
                                }
                                if (kq.Sua == false)
                                {
                                    btnSuaNV.Enabled = false;
                                }
                                if (kq.Sua == true)
                                {
                                    btnSuaNV.Enabled = true;
                                }
                                break;
                            case 5:
                                if (kq.Them == false)
                                {
                                    btnThemDU.Enabled = false;

                                }
                                if (kq.Them == true)
                                {
                                    btnThemDU.Enabled = true;
                                }
                                if (kq.Xoa == false)
                                {
                                    btnXoaDU.Enabled = false;
                                }
                                if (kq.Xoa == true)
                                {
                                    btnXoaDU.Enabled = true;
                                }
                                if (kq.Sua == false)
                                {
                                    btnSuaDU.Enabled = false;
                                }
                                if (kq.Sua == true)
                                {
                                    btnSuaDU.Enabled = true;
                                }
                                break;

                        }

                    }

                }
            }
            catch
            {

            }

        }
        private void btnHuyChon_Click(object sender, EventArgs e)
        {
           
        }
        #region CODE KET NOI SQL
        //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-TNST8J7;Initial Catalog=QLSV;Integrated Security=True");
        //private void ketnoicsdl()
        //{
        //    cnn.Open();
        //    string sql = "select * from sinhvien";  // lay het du lieu trong bang sinh vien
        //    SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
        //    com.CommandType = CommandType.Text;
        //    SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
        //    DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
        //    da.Fill(dt);  // đổ dữ liệu vào kho
        //    cnn.Close();  // đóng kết nối
        //    dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        //}
        #endregion
        private void fQuanLy_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadDSCV();
            // LoadDSNV();
            LoadDanhSachNhanVien();
            LoadDSLoai();
            LoadDSDoUong();
            LoadLoaiDoUong();
            LoadDSBan();
            LoadDSHoaDon();
            LoadPhanQuyen();
            if (AppCode.STNhanVien.IDChucVu != "CV1")
            {
                btnThemQuyen.Enabled = false;
                btnXoaQuyen.Enabled = false;
                btnSuaQuyen.Enabled = false;
                btnPQ.Enabled = false;
            }



        }

        private void LoadPhanQuyen()
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    // MessageBox.Show(cbbChucVuPQ.ValueMember);
                    grvDSQuyen.DataSource = k.DSQuyenTheoCV(cbbChucVuPQ.SelectedValue.ToString());

                }
            }
            catch
            {

            }
        }

        private void LoadDSHoaDon()
        {
            try
            {

                using (var k = new AppCode.QuanCafe())
                {
                    grvDSHD.DataSource = k.DSHoaDonTrue;
                }

            }
            catch
            {
                return;
            }
        }

        private void LoadDSCV()
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    grvDSCV.DataSource = k.DSCV;
                }
            }
            catch
            {
                return;
            }

        }
        #region QL CHUC VU
        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var cv = new ChucVu()
                    {
                        IDChucVu = txtIDCV.Text,
                        TenChucVu = txtTenCV.Text,
                        MoTa = txtMoTaCV.Text
                    };

                    var kq = k.ThemCV(cv);
                    if (kq == true)
                    {
                        LoadDSCV();
                        MessageBox.Show("Thêm thành công", "Thất bại ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                return;
            }

        }
        private void grvDSCV_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = grvDSCV.CurrentCell.RowIndex;

            LoadThongTinChucVu(vitri);
        }
        private void LoadThongTinChucVu(int vitri)
        {
            try
            {
                txtIDCV.Text = grvDSCV.Rows[vitri].Cells[1].Value.ToString().Trim();
                txtTenCV.Text = grvDSCV.Rows[vitri].Cells[2].Value.ToString();
                //date.Value = Convert.ToDateTime(dgv_KH.Rows[VT].Cells[2].Value.ToString());
                // tb_DC.Text = dgv_KH.Rows[VT].Cells[3].Value.ToString().Trim();
                txtMoTaCV.Text = grvDSCV.Rows[vitri].Cells[3].Value.ToString();


            }
            catch (Exception e)
            {
                //clear text box
            }
        }
        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var cv = new ChucVu()
                    {
                        IDChucVu = txtIDCV.Text,
                        TenChucVu = txtTenCV.Text,
                        MoTa = txtMoTaCV.Text
                    };

                    var kq = k.SuaCV(cv);
                    if (kq == true)
                    {
                        LoadDSCV();
                        MessageBox.Show("Sửa thành công", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {
                return;
            }

        }
        private void btnXoaQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {


                    var kq = k.XoaCV(txtIDCV.Text);
                    if (kq == true)
                    {
                        LoadDSCV();
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
                return;
            }
        }
        private void btnTimChucVu_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {


                    var kq = k.TimCV(txtIDChucVu.Text);
                    if (kq == null)
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        txtIDCV.Text = kq.IDChucVu;
                        txtTenCV.Text = kq.TenChucVu;
                        txtMoTaCV.Text = kq.MoTa;
                    }

                }
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region QL NHAN VIEN
        private void LoadChucVu()
        {

            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    cbbChucVu.DataSource = k.DSCV;
                    cbbChucVu.DisplayMember = "TenChucVu";
                    cbbChucVuPQ.DataSource = k.DSCV;
                    cbbChucVuPQ.DisplayMember = "TenChucVu";
                }
            }
            catch
            {
                return;
            }

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                //using (var k = new AppCode.QuanCafe())
                //{
                var o = new NhanVienADO()
                {

                    IDNV = 0,
                    TenNV = txtTenNV.Text,
                    NgaySinh = dtPk.Value,
                    NoiTamTru = txtNoiTamTru.Text,
                    SDT = txtSDT.Text,
                    QueQuan = txtQueQuan.Text,
                    TenDN = txtTenDNNV.Text,
                    MatKhau = txtMatKhauNV.Text,
                    IDChucVu = cbbChucVu.SelectedValue.ToString()

                };

                string sql = @"P_INSERTNHANVIEN '" + o.TenNV + "','" + o.NgaySinh + "',true,'" + o.NoiTamTru + "','" + o.SDT + "','" + o.QueQuan + "','" + o.TenDN + "','" + o.MatKhau + "','" + o.IDChucVu + "' ";
                #endregion
                var kq = XuLyDuLieu.ThucThiThemXoaSua(sql);
                //  var kq = NhanVienADO.Them(o);
                if (kq != 1)
                {

                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ;
                    return;
                }
                else
                {
                    LoadDanhSachNhanVien();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // }
            }
            catch
            {
                return;
            }



        }


        private void grvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = grvDSNV.CurrentCell.RowIndex;

            //  MessageBox.Show(vitri.ToString())=lay vi tri hang hien tai;

            LoadThongTinNhanVien(vitri);
        }

        private void LoadThongTinNhanVien(int vitri)
        {

            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    txtMaNV.Text = grvDSNV.Rows[vitri].Cells[1].Value.ToString().Trim();
                    txt2MaNV.Text = grvDSNV.Rows[vitri].Cells[1].Value.ToString().Trim();
                    txtTenNV.Text = grvDSNV.Rows[vitri].Cells[2].Value.ToString();
                    dtPk.Value = Convert.ToDateTime(grvDSNV.Rows[vitri].Cells[3].Value.ToString());
                    txtNoiTamTru.Text = grvDSNV.Rows[vitri].Cells[5].Value.ToString();
                    txtSDT.Text = grvDSNV.Rows[vitri].Cells[6].Value.ToString().Trim();
                    txtTenDNNV.Text = grvDSNV.Rows[vitri].Cells[7].Value.ToString();
                    txtMatKhauNV.Text = grvDSNV.Rows[vitri].Cells[8].Value.ToString();
                    cbbChucVu.Text = k.TimCV((grvDSNV.Rows[vitri].Cells[9].Value.ToString())).TenChucVu;
                }

            }
            catch (Exception e)
            {
                //clear text box
            }

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            try
            {

                var o = new NhanVienADO()
                {

                    IDNV = int.Parse(txt2MaNV.Text),
                    TenNV = txtTenNV.Text,
                    NgaySinh = dtPk.Value,
                    NoiTamTru = txtNoiTamTru.Text,
                    SDT = txtSDT.Text,
                    QueQuan = txtQueQuan.Text,
                    TenDN = txtTenDNNV.Text,
                    MatKhau = txtMatKhauNV.Text,
                    IDChucVu = cbbChucVu.SelectedValue.ToString()

                };

                int gt = XuLyDuLieu.ThucThiThemXoaSua("P_UPDATENHANVIEN '" + o.IDNV + "', '" + o.TenNV + "','" + o.NgaySinh + "','" + true + "','" + o.NoiTamTru + "','" + o.SDT + "','" + o.QueQuan + "','" + o.TenDN + "','" + o.MatKhau + "', '" + o.IDChucVu + "' ");

                var kq = NhanVienADO.Sua(o);
                if (kq == false)
                {

                    MessageBox.Show("Sủa  thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    LoadDanhSachNhanVien();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch
            {

            }

        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    int kq = k.SoDong(int.Parse(txtMaNV.Text));

                    if (kq == -1)
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadThongTinNhanVien(kq);
                        return;
                    }

                }
            }
            catch
            {
                return;
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in grvDSNV.Rows)
                {

                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value != ckbChon.TrueValue)
                    {
                        NhanVienADO.Xoa(int.Parse(grvDSNV.Rows[row.Index].Cells[1].Value.ToString().Trim()));
                    }
                }
                var kq = NhanVienADO.Xoa(int.Parse(txtMaNV.Text));
                if (kq == true)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                LoadDanhSachNhanVien();

            }
            catch
            {
                return;
            }
        }


        #region QL LOAI DO UONG
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                //demo loi bong ma
                if (mtrTH3_LOI.Checked)
                {
                   int kq=XuLyDuLieu.ThucThiThemXoaSua("SP_WRITELOAI_TH3 '"+ txtTenLoai.Text + "'");
                    if (kq != 0)
                    {
                        MessageBox.Show("Thêm tành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSDoUong();
                        return;

                    }
                    else
                    {
                         MessageBox.Show("Thêm that bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                return;

                    }
                }

                if (mtrTH3_SuaLoi.Checked)
                {
                    int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_WRITELOAI_TH3 '" + txtTenLoai.Text + "'");
                    if (kq != 0)
                    {
                        MessageBox.Show("Thêm tành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSDoUong();
                        return;

                    }
                    else
                    {
                        MessageBox.Show("Thêm that bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;

                    }
                }

                using (var k = new AppCode.QuanCafe())
                {

                    var o = new LoaiDoUong()
                    {
                        // IDLoai=int.Parse(txt1MaLoai.Text),
                        TenLoai = txtTenLoai.Text,

                    };

                    var kq = k.ThemLoaiDU(o);
                    if (kq == true)
                    {
                        LoadDSLoai();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            catch
            {
                return;
            }

        }
        private void LoadDSLoai()
        {
            try
            {
                
                    grvDSLoaiDU.DataSource = ADOCLASS.LoaiDoUongADO.DSLoai;
                
            }
            catch
            {
                return;
            }

        }
        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    foreach (DataGridViewRow row in grvDSNV.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];

                        if (chk.Value != ckbChonLoai.TrueValue)
                        {
                            k.XoaLoaiDU(int.Parse(grvDSNV.Rows[row.Index].Cells[1].Value.ToString().Trim()));
                            // MessageBox.Show(grvDSNV.Rows[row.Index].Cells[1].Value.ToString().Trim());
                        }
                    }
                    var kq = k.XoaLoaiDU(int.Parse(txtMaLoai.Text));
                    if (kq == true)
                    {
                        MessageBox.Show("Xoá thành công", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    LoadDSLoai();

                }
            }
            catch
            {
                return;
            }
        }
        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
          
                    var o = new LoaiDoUong()
                    {
                        IDLoai = Convert.ToInt32(txtMaLoai.Text),
                        TenLoai = txtTenLoai.Text
                    };
            try
            {
                if (mtrTH1_LOI.Checked)
                {
                    int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_UPDAELOAI_TH1 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
                    LoadDSLoai();

                    MessageBox.Show("cap nhat thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                //DEMO TH1
                // int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_UPDAELOAI_TH1 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
                if (mtrTH1_SuaLoi.Checked)
                {
                    int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_UPDAELOAI_TH1 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
                    LoadDSLoai();

                    MessageBox.Show("cap nhat thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                if (mtrTH2_LOI.Checked)
                {
                    int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_WRITELOAI_TH2 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
                    if (kq != 0)
                    {
                        LoadDSLoai();

                        MessageBox.Show("Update thanh cong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                if (mtrTH2_SuaLoi.Checked)
                {
                    int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_WRITELOAI_TH2 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
                    if (kq != 0)
                    {
                        LoadDSLoai();

                        MessageBox.Show("Update thanh cong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    //LoadDSLoai();
                }

                if (mtrTH4_Loi.Checked)
                {

                    XuLyDuLieu.ThucThiThemXoaSua("SP_TH4_XULY_T1 '" + int.Parse(txtMaLoai.Text) + "', '" + txtTenLoai.Text + "' ");
                    MessageBox.Show("Update thanh cong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LoadDSLoai();

                }
                if (mtrTH4_Loi2_T2.Checked)
                {

                  var kq=   XuLyDuLieu.ThucThiThemXoaSua("SP_TH4_XULY_T2 '" + int.Parse(txtMaLoai.Text) + "', '" + txtTenLoai.Text + "' ");
                    if (kq == 0)
                    {
                        MessageBox.Show("Update that bai", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                       
                        return;
                    }
                    MessageBox.Show("Update thanh cong", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LoadDSLoai();

                }

                //DEMO TH2
                // int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_WRITELOAI_TH2 '" + o.IDLoai + "', '" + o.TenLoai + "' ");
            }
            catch
            {

            }
           


        }
        private void btnTimLoai_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var kq = k.TimLoaiDU(int.Parse(txt2MaLoai.Text));
                    if (kq == null)
                    {
                        MessageBox.Show("Không tìm thấy", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        txtMaLoai.Text = kq.IDLoai.ToString();
                        txtTenLoai.Text = kq.TenLoai;
                        return;
                    }

                }
            }
            catch
            {
                return;
            }
        }
        private void grvDSLoaiDU_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = grvDSLoaiDU.CurrentCell.RowIndex;

            LoadThongTinLoaiDU(vitri);
        }
        private void LoadThongTinLoaiDU(int vitri)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    txtMaLoai.Text = grvDSLoaiDU.Rows[vitri].Cells[1].Value.ToString().Trim();
                    txtTenLoai.Text = grvDSLoaiDU.Rows[vitri].Cells[2].Value.ToString().Trim();
                }

            }
            catch (Exception e)
            {
                //clear text box
            }
        }
        #endregion
        #region
        private void LoadThongTinDoUong(int vitri)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    txt2MaDU.Text = grvDSDoUong.Rows[vitri].Cells[1].Value.ToString().Trim();
                    txtTenDU.Text = grvDSDoUong.Rows[vitri].Cells[2].Value.ToString();
                    cbbLoaiDU.Text = k.TimLoaiDU((int.Parse(grvDSDoUong.Rows[vitri].Cells[3].Value.ToString()))).TenLoai;
                    txtSoLuong.Text = grvDSDoUong.Rows[vitri].Cells[4].Value.ToString();
                    txtGiaGoc.Text = grvDSDoUong.Rows[vitri].Cells[5].Value.ToString();
                    txtGiaBan.Text = grvDSDoUong.Rows[vitri].Cells[6].Value.ToString();
                    dtpkNgayNhap.Value = Convert.ToDateTime(grvDSDoUong.Rows[vitri].Cells[7].Value.ToString());
                    cbbDVT.Text = grvDSDoUong.Rows[vitri].Cells[8].Value.ToString();
                }
            }
            catch (Exception e)
            {
                //clear text box
            }
        }
        private void LoadLoaiDoUong()
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    cbbLoaiDU.DataSource = k.DSLoaiDoUong;
                    cbbLoaiDU.DisplayMember = "TenLoai";
                };
            }
            catch
            {
                return;
            }

        }
        private void LoadDSDoUong()
        {
            LoadDSLoai();
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    grvDSDoUong.DataSource = k.DSDoUong;
                }
            }
            catch
            {
                return;
            }
        }
        private void btnThemDU_Click(object sender, EventArgs e)
        {


            try
            {
                var o = new DoUong()
                {
                    TenDoUong = txtTenDU.Text,
                    IDLoai = int.Parse(cbbLoaiDU.SelectedValue.ToString()),
                    GiaGoc = double.Parse(txtGiaGoc.Text),
                    GiaBan = double.Parse(txtGiaBan.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                    NgayNhapHang = dtPk.Value,
                    DonViTinh = cbbDVT.Text
                };
                MessageBox.Show(dtPk.Value.ToString());
                using (var k = new AppCode.QuanCafe())
                {


                    var kq = k.ThemDoUong(o);
                    if (kq == false)
                    {

                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        LoadDSDoUong();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            catch
            {
                return;
            }

        }
        private void btnXoaDU_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    foreach (DataGridViewRow row in grvDSDoUong.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];

                        if (chk.Value != ckbChonDoUong.TrueValue)
                        {
                            k.XoaDoUong(int.Parse(grvDSDoUong.Rows[row.Index].Cells[1].Value.ToString().Trim()));

                        }
                    }
                    LoadDSDoUong();

                }

            }
            catch
            {
                return;
            }
        }
        private void grvDSDoUong_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = grvDSDoUong.CurrentCell.RowIndex;
            //  MessageBox.Show(vitri.ToString())=lay vi tri hang hien tai;
            LoadThongTinDoUong(vitri);
        }
        private void btnSuaDU_Click(object sender, EventArgs e)
        {
            try
            {
                var o = new DoUong()
                {
                    IDDoUong = int.Parse(txt2MaDU.Text),
                    TenDoUong = txtTenDU.Text,
                    IDLoai = int.Parse(cbbLoaiDU.SelectedValue.ToString()),
                    GiaGoc = double.Parse(txtGiaGoc.Text),
                    GiaBan = double.Parse(txtGiaBan.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                    NgayNhapHang = dtpkNgayNhap.Value,
                    DonViTinh = cbbDVT.Text,

                };

                using (var k = new AppCode.QuanCafe())
                {
                    var kq = k.SuaDoUong(o);
                    if (kq == true)
                    {
                        LoadDSDoUong();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch
            {
                return;
            }

        }

        private void txtTimDU_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    LoadThongTinDoUong(k.SoDongInDSDoUong(int.Parse(txtMaDU.Text)));
                }
            }
            catch
            {

            }


        }

        #endregion
        #region  Quan ly ban  
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var o = new Ban()
                    {
                        // IDLoai=int.Parse(txt1MaLoai.Text),
                        TenBan = txtTenBan.Text,
                        TrangThai = cbbTrangThai.Text
                    };
                    MessageBox.Show(o.TrangThai.ToString());
                    var kq = k.ThemBan(o);
                    if (kq == true)
                    {
                        LoadDSBan();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

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
                    grvDSBan.DataSource = k.DSBan;
                }

            }
            catch
            {
                //MessageBox.Show("Một ngoại lệ đã xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        #endregion
        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    var idban = Convert.ToInt32(txtMaBan.Text);
                    MessageBox.Show(idban.ToString());
                    var kq = k.XoaBan(idban);
                    if (kq == true)
                    {
                        LoadDSBan();
                        MessageBox.Show("Xoá thành công", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Xoá thất bại", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            try
            {
                var ban = new Ban()
                {
                    IDBan = Convert.ToInt32(txtMaBan.Text),
                    TrangThai = cbbTrangThai.Text,
                    TenBan = txtTenBan.Text,
                };
                using (var k = new AppCode.QuanCafe())
                {
                    var kq = k.CapNhatBan(ban);
                    if (kq == true)
                    {
                        LoadDSBan();
                        MessageBox.Show("Cập nhật thành công", "Thông báo");

                    }
                    else
                        MessageBox.Show("Cập nhật thất bại", "Thông báo ");

                }
            }
            catch { }
        }

        private void grvDSBan_SelectionChanged(object sender, EventArgs e)
        {
            var indexrow = grvDSBan.CurrentRow.Index;
            LoadTTBan(indexrow);
        }

        private void LoadTTBan(int indexrow)
        {
            txtMaBan.Text = grvDSBan.Rows[indexrow].Cells[1].Value.ToString();//Cot 1 la ma ban
            txtTenBan.Text = grvDSBan.Rows[indexrow].Cells[2].Value.ToString();
            cbbTrangThai.Text = grvDSBan.Rows[indexrow].Cells[3].Value.ToString();

        }
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                //int gt = XuLyDuLieu.ThucThiThemXoaSua("P_DELETE_HOADON'" + int.Parse(grvDSHD.CurrentRow.Cells[1].Value.ToString().Trim()) + "'");
                //MessageBox.Show(gt.ToString());

                foreach (DataGridViewRow row in grvDSHD.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];

                        if (chk.Value != cbkChonHD.TrueValue)
                        {
                            // MessageBox.Show(chk.Value.ToString());
                            HoaDonADO.Xoa(int.Parse(grvDSHD.Rows[row.Index].Cells[1].Value.ToString().Trim()));
                        }
                    }
                MessageBox.Show("Xóa thành công");
                LoadDSHoaDon();

            }
            catch
            {
                return;
            }
        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    for (var i = 0; i < k.DSTabPageQL.Count; i++)
                    {
                        var q = new Quyen()
                        {
                            IDChucVu = cbbChucVuPQ.SelectedValue.ToString(),
                            TenTab = grvDSQuyen.Rows[i].Cells[0].Value.ToString(),
                            
                            Them = bool.Parse(grvDSQuyen.Rows[i].Cells[1].Value.ToString()),
                            Xoa = bool.Parse(grvDSQuyen.Rows[i].Cells[2].Value.ToString()),
                            Sua = bool.Parse(grvDSQuyen.Rows[i].Cells[3].Value.ToString())


                        };


                        k.SuaQuyen(q);
                      

                    }


                }
                MessageBox.Show("Phân quyền thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                LoadPhanQuyen();
            }
            catch
            {

            }
        }

        private void cbbChucVuPQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPhanQuyen();
        }


        private void tpQLLoai_Click(object sender, EventArgs e)
        {

        }
        private void tpQLLoai_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ahoo");
        }

        private void LoadDanhSachNhanVien()
        {
            try
            {
                grvDSNV.DataSource = NhanVienADO.DSNV;

            }
            catch
            {
                return;
            }

        }

      
        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            txt2MaNV.Text = string.Empty;
            txtTenNV.Text = string.Empty;
            txtQueQuan.Text = string.Empty;
            txtNoiTamTru.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTenDNNV.Text = string.Empty;
            txtMatKhauNV.Text = string.Empty;
        }

        //------------------------------------TH2---------------------------------------
        private void LoadDSLoaiTH2()
        {
            try
            {

                grvDSLoaiDU.DataSource = ADOCLASS.LoaiDoUongADO.DSLoai;

            }
            catch
            {
                return;
            }

        }



        

        private void btnXemDSLoai_Click(object sender, EventArgs e)
        {
            grvDSLoaiDU.DataSource = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_VIEW");
        }

        private void btnDeMo_Click(object sender, EventArgs e)
        {
            if (mtrTH1_LOI.Checked)
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_TH1");
                grvDSLoaiDU.DataSource = data;
            }
            // grvDSLoaiDU.DataSource = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_TH1");
            if (mtrTH1_SuaLoi.Checked)
            {
                grvDSLoaiDU.DataSource = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_XULY_TH1");
            }
            if (mtrTH2_LOI.Checked)
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_READLOAI_TH2");
                grvDSLoaiDU.DataSource = data;
            }
            if (mtrTH2_SuaLoi.Checked)
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_XULY_TH2");
                grvDSLoaiDU.DataSource = data;
            }
            if (mtrTH3_LOI.Checked)
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_READLOAI_TH3");
                grvDSLoaiDU.DataSource = data;
            }
            if (mtrTH3_SuaLoi.Checked)
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_XULY_TH3");
                grvDSLoaiDU.DataSource = data;
            }
        }

        private void grvDSQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
  
}

