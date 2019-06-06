using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE.AppCode
{
    public static class ChiTietBan
    {
        public static List<DoUong> ds = new List<DoUong>();
        public static List<DoUong> DSDoUong
        {
            get
            {
                return ds;
            }
        }
        public static double TongTien
        {
            get
            {
                double tongTien = 0;
                foreach (var sp in DSDoUong)
                {
                    tongTien += sp.SoLuong * sp.GiaBan;
                }
                return tongTien;
            }
        }

        public static int SoMatHang
        {
            get
            {
                return DSDoUong.Count;
            }
        }
        public static int SoLuongProduct
        {
            get
            {
                int dem = 0;
                foreach (var sp in DSDoUong)
                {
                    dem += sp.SoLuong;
                }
                return dem;
            }
        }
        public static DoUong TimDoUong(int idDoUong)
        {
            foreach (var sp in DSDoUong)
            {
                if (sp.IDDoUong == idDoUong)
                    return sp;
            }
            return null;
        }
        public static void ThemDoUongVaoBan(DoUong sp, int soLuong = 1)
        {
            var kq = ChiTietBan.TimDoUong(sp.IDDoUong);
            //if (kq.Quantity < sp.SoLuongDaMua) return;

            if (kq == null)
            {
                kq = sp;
                ds.Add(kq);
                kq.SoLuong = soLuong;
            }
            else
            {
                kq.SoLuong += soLuong;
            }
        }

        public static void DeleteCart()
        {
            DSDoUong.Clear();
        }

        public static void XoaDoUong(int idDuUong)
        {
            DSDoUong.Remove(ChiTietBan.TimDoUong(idDuUong));
        }

    }
}
