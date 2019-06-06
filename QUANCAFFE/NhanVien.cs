using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{

    public partial class NhanVien
    {
        
        public string TenHinh{ set; get; }
        public string DuongDanHinh
        {
            get
            {
                if (string.IsNullOrEmpty(this.TenHinh))
                    return @"D:\HOCTAP\Documents_Year3_HK2\HE_QTCSDL\QUANCAFFE\Image\Login\loginimg.png";
                return string.Format(@"~/D:\HOCTAP\Documents_Year3_HK2\HE_QTCSDL\QUANCAFFE\Image\Login\{0}", this.TenHinh);
            }
        }

    }
}
