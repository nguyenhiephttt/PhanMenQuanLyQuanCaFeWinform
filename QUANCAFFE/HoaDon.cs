using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
    public partial class HoaDon
    {

       

       
        DBQUANCAFFEDataContext dc = new DBQUANCAFFEDataContext();
        public double Tong_Tien
        {
            get
            {
                return this.TongTien1(this.GiamGia);
            }
        }
        public int STT { set; get; } 
        public string TenNhanVien
        {
            get
            {
                return this.TenNV();
            }
        }

        public double GiamGia { set; get; }
        private string TenNV()
        {
            foreach (var item in dc.NhanViens.ToList())
            {
                if (this.IDNhanVienLap == item.IDNV)
                {
                    return item.TenNV;
                }
            }
            return "Null";

        }
        public  List<CTHoaDon> DSCTHD()
        {
            List<CTHoaDon> ds = new List<CTHoaDon>();
            foreach(var item in dc.CTHoaDons.ToList())
            {
                if (this.IDHoaDon == item.IDHoaDon)
                {
                    ds.Add(item);
                }
            }
            return ds;
        }
        public double TongTien1(double giamgia)
        {
            double t = 0;
            foreach (var item in DSCTHD())
            {
                t += ((item.SoLuong * item.GiaBan));
            }
            return t - (t *giamgia  / 100);
        }
        
    }
}
