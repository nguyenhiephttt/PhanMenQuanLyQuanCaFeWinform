using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANCAFFE.AppCode
{
  public static class   Extention
    {
        public static bool ChuoiHopLe(string s)
        {
            return !string.IsNullOrEmpty(s) || !string.IsNullOrWhiteSpace(s);
        }

        public static bool NgayHopLe(this string s, out DateTime ngay)
        {
            return DateTime.TryParseExact(s, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngay);
        }

       
        public static bool IsNumber(string s)
        {
            foreach (Char kt in s)
            {
                //if (kt == '.')
                //{
                //    continue;
                //}
                if (!Char.IsDigit(kt))
                {
                    return false;
                }
            }
            return true;

        }
        public static void CleanTextBox(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is TextBox)
                {
                    var txt = child as TextBox;
                    txt.Text = string.Empty;
                }
            }
        }

        public static bool SoSanhNgay(string s1,string s2)
        {
             var kq = string.Compare(s1, s2, true);
            
            if (kq <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
