using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANCAFFE
{
    public partial class fLogin : Form
    {


       
        public fLogin()
        {
            InitializeComponent();

        }

       

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn thoát?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = @"EXEC SP_TimTaiKkhoan '" + txtTenDN.Text + "' ";
                var t = XuLyDuLieu.DocDuLieu(sql);

                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else

                {
                    if (t.Rows.Count == 0 || t.Rows[0]["MatKhau"].ToString() != txtMatKhau.Text)
                    {
                        MessageBox.Show("Mật khẩu hoặc tên đăng nhập chưa đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    else
                    {
                        AppCode.STNhanVien.idNhanVien = int.Parse(t.Rows[0]["IDNV"].ToString());
                        AppCode.STNhanVien.IDChucVu = (t.Rows[0]["IDChucVu"].ToString());
                        AppCode.STNhanVien.TenNhanVien = t.Rows[0]["TENNV"].ToString();
                      
                        fManager f = new fManager();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }



                }


            }
            catch
            {

            }
           
        }

        private void btnthoát_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (var k = new AppCode.QuanCafe())
                    {
                        var kq = k.TimNVToTenDN(txtTenDN.Text);
                        if (kq == null || kq.MatKhau != txtMatKhau.Text)
                        {
                            MessageBox.Show("Mật khẩu hoặc tên đăng nhập chưa đúng");
                            return;
                        }
                        else
                        {
                            AppCode.STNhanVien.idNhanVien = kq.IDNV;
                            AppCode.STNhanVien.IDChucVu = kq.IDChucVu;
                            AppCode.STNhanVien.TenNhanVien = kq.TenNV;
                            fManager f = new fManager();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                        }

                    }
                }
                catch
                {

                }
            }
        }

     

       

        
    }
}
