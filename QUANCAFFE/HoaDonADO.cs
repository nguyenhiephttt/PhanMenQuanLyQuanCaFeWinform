using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
    class HoaDonADO
    {
        private int iDHoaDon;
        private int iDBan;
        private DateTime ngayLap;
        private float tongTien;
        private int iDNhanVienLap;
        private bool trangThai;

        public int IDHoaDon { get => iDHoaDon; set => iDHoaDon = value; }
        public int IDBan { get => iDBan; set => iDBan = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        
        public int IDNhanVienLap { get => iDNhanVienLap; set => iDNhanVienLap = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        public int STT { set; get; }
        public string TenNhanVien
        {
            get
            {
                return this.TenNV();
            }
        }
        private string TenNV()
        {
            foreach (var item in NhanVienADO.DSNV)
            {
                if (this.IDNhanVienLap == item.IDNV)
                {
                    return item.TenNV;
                }
            }
            return "Null";

        }
     
        public double GiamGia { set; get; }
        public double TongTien
        {
            set
            {
                this.TongTien = value;
            }
            get
            {
                return this.TongTien1(this.GiamGia);
            }
        }
        public double TongTien1(double giamgia)
        {
           
            double t = 0;
            foreach (var item in CTHoaDonADO.DSCTHD_TT)
            {
                if(item.IDHoaDon==this.IDHoaDon)
                t += item.SoLuong*item.GiaBan;
            }
            return t - (t * giamgia / 100);
        }

        public HoaDonADO
          (
            int IDHoaDon,
            int IDBan
          , DateTime NgayLap
          , int IDNhanVienLap
          , bool TrangThai

        )
        {
            this.IDHoaDon = IDHoaDon;
            this.IDBan = IDBan;
            this.NgayLap = NgayLap;
            this.IDNhanVienLap = IDNhanVienLap;
            this.TrangThai = TrangThai;
        }

        //DANH SACH HOA DON
        public static List<HoaDonADO> DSHD
        {
            get
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_DANHSACHHOADON");
                HoaDonADO hd;
                List<HoaDonADO> dshd = new List<HoaDonADO>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    hd = new HoaDonADO(
                       int.Parse(data.Rows[i]["IDHoaDon"].ToString())
                      ,int.Parse( data.Rows[i]["IDBan"].ToString())
                      , DateTime.Parse(data.Rows[i]["NgayLap"].ToString())
                      ,int.Parse( data.Rows[i]["IDNhanVienLap"].ToString())
                      ,bool.Parse( data.Rows[i]["TrangThai"].ToString())
                       );
                    dshd.Add(hd);
                }
                return dshd;
            }
        }
        //Them nhan vien
        public static bool Them(HoaDonADO hd)
        {
            #region cau truy van
                       #endregion
            int kq = XuLyDuLieu.ThucThiThemXoaSua("SP_CREATE_HOADON'" + hd.IDBan + "', '" + hd.NgayLap + "','" + hd.IDNhanVienLap + "','" + hd.TrangThai + "'  ");

            if (kq == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static HoaDonADO Tim(int ma)
        {
            string sql = @"EXEC SP_TIMHOADON" + ma + "' ";
            var t = XuLyDuLieu.DocDuLieu(sql);
            if (t.Rows.Count == 0) return null;//k tim thay
            else


                return new HoaDonADO(
                   int.Parse(t.Rows[0]["IDHoaDon"].ToString()),
                   int.Parse(t.Rows[0]["IDBan"].ToString()),
                    DateTime.Parse(t.Rows[0]["NgayLap"].ToString()),
                   int.Parse(t.Rows[0]["IDNhanVienLap"].ToString()),
                   bool.Parse( t.Rows[0]["TrangThai"].ToString())
                    );

        }

        public static bool Sua(HoaDonADO hd)
        {
            #region cau truy van
            int gt = XuLyDuLieu.ThucThiThemXoaSua("SP_UPDATE_HOADON '" + hd.iDHoaDon + hd.IDBan + "', '" + hd.NgayLap + "','" + hd.IDNhanVienLap + "','" + hd.TrangThai + "' ");
            return gt > 0;
            #endregion
        }
        public static bool Xoa(int id)
        {
            #region cau truy van
            int gt = XuLyDuLieu.ThucThiThemXoaSua("P_DELETE_HOADON'" + id + "'");
            return gt > 0;
            #endregion
        }
    }
}
