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
    public partial class fDatSoLuong : Form
    {
        public fDatSoLuong()
        {
            InitializeComponent();
           
        }

        private void fDatSoLuong_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch
            {
                return;
            }
           
        }

        private void btnSuaSL_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Text bõx=" + int.Parse(txtSuaSoluong.Text).ToString());
            try
            {
                

                //MessageBox.Show("ID DO UONG="+o.IDDoUong.ToString()
                //    +"ID Hoa don ="+AppCode.STHoaDon.idHoaDon.ToString());
                using(var k=new AppCode.QuanCafe())
                {
                 var kq=k.SuaCTHD(AppCode.STHoaDon.idHoaDon,AppCode.STDoUong.id, int.Parse(txtSuaSoluong.Text));
                    if (kq == true)
                    {
                        MessageBox.Show("Cập nhật số lượng thành công", "Thông báo");
                    }
                    if (kq == false)
                    {
                        MessageBox.Show("Cập nhật số lượng thất bại", "Thông báo");

                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
