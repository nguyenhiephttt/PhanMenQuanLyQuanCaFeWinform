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
    public partial class fThongTinTaiKhoan : Form
    {
        public fThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        OpenFileDialog open;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiHinh_Click(object sender, EventArgs e)
        {
         
            open = new OpenFileDialog();
            open.InitialDirectory = "D:";
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                picHinh.Image = Image.FromStream(open.OpenFile());

            }
        }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
              
                using (var k = new AppCode.QuanCafe())
                {
                    NhanVien kq = k.TimNV(AppCode.STNhanVien.idNhanVien);
                    txtTenDN.Text = kq.TenDN;
                    txtTenNhanVien.Text = kq.TenNV;
                    txtMatKhau.Text = kq.MatKhau;
                    // Image img = Image.FromFile("loginimg.png");
                  bmp = new Bitmap(kq.DuongDanHinh);
                     picHinh.Image = bmp;
                   

                }
            }
            catch
            {

            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppCode.Extention.ChuoiHopLe(txtMatKhauMoi.Text) && string.Compare(txtMatKhauMoi.Text, txtNhapLaiMatKhau.Text) == 0)
                {
                    bmp.Save(@"D:\HOCTAP\Documents_Year3_HK2\HE_QTCSDL\QUANCAFFE\Image\Login\"+open.FileName);
                    var o = new NhanVien()
                    {
                        TenDN = txtTenDN.Text,
                        TenNV = txtTenNhanVien.Text,
                        MatKhau = txtMatKhauMoi.Text,
                        TenHinh=open.FileName

                    };
                    MessageBox.Show(open.FileName);
                    using (var k = new AppCode.QuanCafe())
                    {
                        var kq = k.CapNhatTK(AppCode.STNhanVien.idNhanVien, o);

                        if (kq != null)
                        {
                            fThongTinTaiKhoan_Load(sender, e);
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
