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
    public partial class fTKDoanhThu : Form
    {
        public fTKDoanhThu()
        {
            InitializeComponent();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string tungay = dtpkTuNgay.Value.ToString("yyyy/MM/dd");
            string ngayden = dtpkDenNgay.Value.ToString("yyyy/MM/dd");
            try
            {
                List<HoaDonADO> dshd = new List<HoaDonADO>();


                var i = 1;
                var shd = 0;
                double tong = 0;

                foreach (var item in HoaDonADO.DSHD)
                {

                    // dtpkTuNgay <= item <= ngayden; 

                    var kq1 = AppCode.Extention.SoSanhNgay(tungay, item.NgayLap.ToString("yyyy/MM/dd"));
                    var kq2 = AppCode.Extention.SoSanhNgay(item.NgayLap.ToString("yyyy/MM/dd"), ngayden);

                    if (kq1 == true && kq2 == true)
                    {
                        item.STT = i;
                        dshd.Add(item);
                        i++;
                        tong += item.TongTien;
                        shd += 1;
                    }
                }
                grvTKHoaDon.DataSource = dshd;
                lblTong.Text = tong.ToString() + " VNĐ";
                lblSHD.Text = shd.ToString() + " HĐ";

            }
            catch
            {
                return;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = Excel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)Excel.ActiveSheet;

                Excel.Visible = true;

                // MessageBox.Show(grvTD.Columns[0].HeaderText.ToString());
                for (int i = 1; i < grvTKHoaDon.ColumnCount + 1; i++)
                {
                    ws.Cells[1, i] = grvTKHoaDon.Columns[i - 1].HeaderText;

                }

                int sohang = grvTKHoaDon.RowCount;

                //  MessageBox.Show(sohang.ToString());

                for (int i = 0; i < sohang; i++)
                {
                    ws.Cells[i + 2, 1] = grvTKHoaDon.Rows[i].Cells[0].Value;
                    ws.Cells[i + 2, 2] = grvTKHoaDon.Rows[i].Cells[1].Value;
                    ws.Cells[i + 2, 3] = grvTKHoaDon.Rows[i].Cells[2].Value;
                    ws.Cells[i + 2, 4] = grvTKHoaDon.Rows[i].Cells[3].Value;
                    ws.Cells[i + 2, 5] = grvTKHoaDon.Rows[i].Cells[4].Value;
                }
            }
            catch (Exception)
            {
                return;
                throw;
            }

        }



        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DateTime tungay = DateTime.Now;
            try
            {
                List<HoaDon> dshd = new List<HoaDon>();
                using (var k = new AppCode.QuanCafe())

                {
                    var i = 1;
                    double t = 0;
                    foreach (var item in k.DSHoaDon)
                    {

                        if (tungay.Date.Day == item.NgayLap.Day)
                        {
                            item.STT = i;
                            dshd.Add(item);
                            i++;
                            t += item.Tong_Tien;
                        }
                    }
                    MessageBox.Show(dshd.Count.ToString());

                    grvTKHoaDon.DataSource = dshd;
                    lblTong.Text = t.ToString() + " VNĐ";

                }
            }
            catch
            {
                return;
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
