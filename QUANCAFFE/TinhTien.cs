using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
   
        static class TinhTien
        {
            public static double giamgia { set; get; }
            public static List<CTHoaDon> DSCTHD()
            {

                var ds = new List<CTHoaDon>();

                using (var k = new AppCode.QuanCafe())
                {
                    ds = k.TimDSCTHD(AppCode.STHoaDon.idHoaDon);

                    return ds;
                }
            }
            public static double TongTien(double giamgia)
            {
           
                double t = 0;
                foreach (var item in DSCTHD())
                {
                    t += ((item.SoLuong * item.GiaBan));
                }
                return t - (t * giamgia/100);
            }
        }
    
}
