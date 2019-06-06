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
    public partial class fGopBan : Form
    {
        public fGopBan()
        {
            InitializeComponent();
            LoadDSBan();
        }

        private void LoadDSBan()
        {
            try
            {

                using (var k = new AppCode.QuanCafe())
                {
                    for (int i = 0; i < k.DSBan.Count; i++)
                    {
                        if (k.DSBan[i].IDBan == AppCode.STBan.idBan)
                        {
                            continue;
                        }
                        Button btnBan = new Button();
                        btnBan.Width = 80;
                        btnBan.Height = 88;

                        btnBan.Text = k.DSBan[i].TenBan + Environment.NewLine;
                        btnBan.ForeColor = Color.Blue;
                        btnBan.TextAlign = ContentAlignment.BottomCenter;
                        string[] s = { "\\bin" };
                        string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Image\\icons8-coffee-to-go-80.png";
                        btnBan.BackgroundImage = Image.FromFile(path);
                        //  btnBan.BackgroundImage = Image.FromFile(@"D:\HOCTAP\Information_Technology\C#\Winform\QUANCAFFE\QUANCAFFE\Image\icons8-coffee-to-go-80.png");
                        btnBan.Click += btnBan_Click;
                        btnBan.Tag = k.DSBan[i];
                        flowLayoutPanel1.Controls.Add(btnBan);
                        switch (k.DSBan[i].TrangThai)
                        {
                            case "Trống":
                                btnBan.BackColor = Color.Azure;
                                break;
                            case "Có người":
                                btnBan.BackColor = Color.Red;
                                break;
                        }

                    }
                };
            }
            catch
            {

            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
           
            AppCode.STBanGop.idBan = ((sender as Button).Tag as Ban).IDBan;
            MessageBox.Show("Ma ban gop=" + AppCode.STBanGop.idBan.ToString());
        }

        private void btnGopBan_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (var k = new AppCode.QuanCafe())
                {
                    //var kq = k.TimHoaDonTheoIDBan(AppCode.STBan.idBan); 
                    var kq = k.GopBan(AppCode.STBanGop.idBan, AppCode.STBan.idBan);
                    if (kq == true)
                    {
                        MessageBox.Show("Gop thanh cong");
                        
                    }
                    else
                    {
                        MessageBox.Show("Gop that bai");
                    }

                }
            }
            catch
            {

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
