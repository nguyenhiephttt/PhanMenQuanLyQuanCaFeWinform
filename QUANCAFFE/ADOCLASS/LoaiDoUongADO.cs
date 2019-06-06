using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE.ADOCLASS
{
    class LoaiDoUongADO
    {
        private int idLoai { set; get; }
        public int IDLoai
        {
            get { return idLoai; }
            set { idLoai = value; }
        }

        private string tenLoai { set; get; }

        public string TenLoai
        {
            get { return tenLoai; }
            set { tenLoai = value; }
        }

        //DANH SACH LOAI DO UONG
        //DEMO TH1
        public static List<ADOCLASS.LoaiDoUongADO> DSLoai
        {
            get
                
            {
              //  var data = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_TH1");
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_XULY_TH1");
                ADOCLASS.LoaiDoUongADO e;
                List<ADOCLASS.LoaiDoUongADO> dsloai = new List<ADOCLASS.LoaiDoUongADO>();
                for (int i = 0; i < data.Rows.Count; i++)
                {

                    e = new ADOCLASS.LoaiDoUongADO()
                    {
                      IDLoai=  int.Parse(data.Rows[i]["IDLoai"].ToString()),
                      TenLoai=  data.Rows[i]["TenLoai"].ToString()
                    };
                    dsloai.Add(e);
                }
                return dsloai;
            }
        }
        //DEMO TH2
        public static List<ADOCLASS.LoaiDoUongADO> DSLoaiTH2
        {
            get

            {
                //var data = XuLyDuLieu.DocDuLieu("EXEC SP_DSLOAI_TH1");
                var data = XuLyDuLieu.DocDuLieu("EXEC SP_READLOAI_TH2");
                ADOCLASS.LoaiDoUongADO e;
                List<ADOCLASS.LoaiDoUongADO> dsloai = new List<ADOCLASS.LoaiDoUongADO>();
                for (int i = 0; i < data.Rows.Count; i++)
                {

                    e = new ADOCLASS.LoaiDoUongADO()
                    {
                        IDLoai = int.Parse(data.Rows[i]["IDLoai"].ToString()),
                        TenLoai = data.Rows[i]["TenLoai"].ToString()
                    };
                    dsloai.Add(e);
                }
                return dsloai;
            }
        }
    }
}
