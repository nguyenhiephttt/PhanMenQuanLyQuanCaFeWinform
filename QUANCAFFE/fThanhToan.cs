using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANCAFFE
{
    public partial class fThanhToan : Form
    {
        Bitmap memoryImage;
        Bitmap bmp;
      
        public fThanhToan()
        {
            InitializeComponent();
            LoadCTHD();
        }

        private void LoadCTHD()
        {
            try
            { 
                using(var k=new AppCode.QuanCafe())
                {
                    List<CTHoaDon> dscthd = new List<CTHoaDon>();
                    
                    var tthd = k.TimHoaDon(AppCode.STHoaDon.idHoaDon);
                    dscthd = k.TimDSCTHD(tthd.IDHoaDon);
                    //Set data 
                    lblSoban.Text = k.TimBan(tthd.IDBan).TenBan;
                    lblNhanVienLap.Text = k.TimNV(tthd.IDNhanVienLap).TenNV;
                    lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    grvCTHD.DataSource = dscthd;
                    lblGiamGia.Text = TinhTien.giamgia.ToString()+"%";
                   
                    //Tong tien
                    double t = 0;
                    foreach (var item in dscthd)
                    {
                        t += ((item.SoLuong * item.GiaBan));
                    }
                    lblTongTien.Text = (t-(t*TinhTien.giamgia/100)).ToString()+" VNĐ";
                     

                }
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

          
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);       
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0,this.Size);
            printPreviewDialog1.ShowDialog();


            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();

           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = CreateGraphics();
            Image memImage = new Bitmap(Size.Width, Size.Height, graphic);
            Graphics memGraphic = Graphics.FromImage(memImage);
            IntPtr dc1 = graphic.GetHdc();
            IntPtr dc2 = memGraphic.GetHdc();

            graphic.ReleaseHdc(dc1);
            memGraphic.ReleaseHdc(dc2);
            e.Graphics.DrawImage(memImage, 0, 0);
            e.Graphics.DrawImage(bmp,0,0); 
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
           
        }
    }
}
