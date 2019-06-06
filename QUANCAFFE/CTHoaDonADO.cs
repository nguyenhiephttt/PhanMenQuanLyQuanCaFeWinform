using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
    class CTHoaDonADO
    {

        private int iDHoaDon;
        private int iDDoUong;
        private int soLuong;
        private double giaGoc;
        private double giaBan;
     
        public int IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }
        public int IDDoUong { get => iDDoUong; set => iDDoUong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaGoc { get => giaGoc; set => giaGoc = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        //public string TenMatHang
        //{
        //    get
        //    {
        //        return this.TenSP();
        //    }
        //}

        //public string DonViTinh
        //{
        //    get
        //    {
        //        return this.DVT();
        //    }
        //}
        //private string TenSP()
        //{
        //    foreach (var item in DoUong.DSDU())
        //    {
        //        if (this.IDDoUong == item.IDDoUong)
        //        {
        //            return item.TenDoUong;
        //        }
        //    }
        //    return " Null";

        //}

        //private string DVT()
        //{
        //    foreach (var item in DoUong.DSDU())
        //    {
        //        if (this.IDDoUong == item.IDDoUong)
        //        {
        //            return item.DonViTinh;
        //        }
        //    }
        //    return "Not Name";

        //}
        public double ThanhTien
        {
            get
            {
                return this.SoLuong * this.GiaBan;
            }
        }

        public CTHoaDonADO(int idhd,int iddouong,int s,double giagoc, double giaban)
        {
            IDHoaDon = idhd;
            IDDoUong = iddouong;
            SoLuong = s;
            GiaGoc = giagoc;
            GiaBan = giaban;
        }

        public CTHoaDonADO()
        {
        }

        public static List<CTHoaDonADO> DSCTHD_TT
        {

            get
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_DSCT_HD");
                CTHoaDonADO hd;
                List<CTHoaDonADO> dshd = new List<CTHoaDonADO>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    hd = new CTHoaDonADO(
                       int.Parse(data.Rows[i]["IDHoaDon"].ToString())
                      , int.Parse(data.Rows[i]["IDDoUong"].ToString())
                      , int.Parse(data.Rows[i]["SoLuong"].ToString())
                      , double.Parse(data.Rows[i]["GiaGoc"].ToString())
                      , double.Parse(data.Rows[i]["GiaBan"].ToString())
                       );
                    dshd.Add(hd);
                }
                return dshd;
            }
        }

    }
}
