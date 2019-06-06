using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE
{
    class NhanVienADO
    {
        //TenNV,
        // NgaySinh,
        //    GoiTinh,
        // NoiTamTru,
        // SDT,
        // QueQuan,
        // TenDN,
        // MatKhau,
        // IDChucVu
        private int idnv;

        public int IDNV
        {
            get { return idnv; }
            set { idnv = value; }
        }

        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        private DateTime ngaysinh { set; get; }
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private bool gioiTinh { set; get; }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        private string noitamtru { set; get; }
        public string NoiTamTru
        {
            get { return noitamtru; }
            set { noitamtru = value; }
        }
        private string sdt { set; get; }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string quequan { set; get; }

        public string QueQuan
        {
            get { return quequan; }
            set { quequan = value; }
        }


        private string tenCV;
        private string tenDN { set; get; }
        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        private string matKhau { set; get; }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }


        private string idcv;

        public string IDChucVu
        {
            get { return idcv; }
            set { idcv = value; }
        }

        public string TenCV
        {
            get
            {

                string sql = @"select * from ChucVu where IDChucVu=@ma";
                var t = XuLyDuLieu.DocDuLieu(sql, "@ma", this.idcv);

                tenCV = t.Rows[0]["TenChucVu"].ToString();
                return tenCV;
            }

        }
        public NhanVienADO
            (int MaNV,
            string TenNV
            , DateTime NgaySinh
            , string NoiTamTru
            , string SDT
             , string QueQuan
             , string TenDN
             , string MatKhau
             , string IDChucVu
          )
        {
            this.IDNV = MaNV;
            this.TenNV = TenNV;
            this.NgaySinh = NgaySinh;
            this.NoiTamTru = NoiTamTru;
            this.SDT = SDT;
            this.QueQuan = QueQuan;
            this.TenDN = TenDN;
            this.MatKhau = MatKhau;
            this.IDChucVu = IDChucVu;
        }

        public NhanVienADO()
        {
        }


        //DANH SACH NHAN VIEN
        public static List<NhanVienADO> DSNV
        {
            get
            {
                var data = XuLyDuLieu.DocDuLieu("EXEC P_DSNV");
                NhanVienADO e;
                List<NhanVienADO> dsnv = new List<NhanVienADO>();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    //TenNV,
                    // NgaySinh,
                    //    GoiTinh,
                    // NoiTamTru,
                    // SDT,
                    // QueQuan,
                    // TenDN,
                    // MatKhau,


                    // IDChucVu
                    e = new NhanVienADO(
                      int.Parse(data.Rows[i]["IDNV"].ToString()),
                      data.Rows[i]["TenNV"].ToString()
                      , DateTime.Parse(data.Rows[i]["NgaySinh"].ToString())
                      , data.Rows[i]["NoiTamTru"].ToString()
                      , data.Rows[i]["SDT"].ToString()
                      , data.Rows[i]["QueQuan"].ToString()
                      , data.Rows[i]["TenDN"].ToString()
                      , data.Rows[i]["MatKhau"].ToString()
                      , data.Rows[i]["IDChucVu"].ToString()
                       );
                    dsnv.Add(e);
                }
                return dsnv;
            }
        }
        //Them nhan vien
        public static bool Them(NhanVienADO o)
        {
            #region cau truy van
            string sql = @"P_INSERTNHANVIEN";
            #endregion
            var kq = XuLyDuLieu.ThucThiThemXoaSua(sql
                , "@TenNV", o.TenNV
                , "@NgaySinh", o.NgaySinh
                , "@NoiTamTru", o.NoiTamTru
                , "@SDT", o.SDT
                , "@QueQuan", o.QueQuan
                , "@TenDN", o.TenDN
                , "@MatKhau", o.MatKhau
                , "@TenDN", o.TenDN
                , "IDChucVu", o.IDChucVu

                );
            if (kq == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static NhanVienADO Tim(int ma)
        {
            string sql = @"EXEC SP_TIMNHANVIEN '" + ma + "' ";
            var t = XuLyDuLieu.DocDuLieu(sql);
            if (t.Rows.Count == 0) return null;//k tim thay
            else


                return new NhanVienADO(
                   int.Parse(t.Rows[0]["IDNV"].ToString()),
                     t.Rows[0]["TENNV"].ToString(),
                    DateTime.Parse(t.Rows[0]["NgaySinh"].ToString()),
                     //bool.Parse( t.Rows[0]["GioiTinh"].ToString()),
                     t.Rows[0]["NoiTamTru"].ToString(),
                     t.Rows[0]["SDT"].ToString(),
                     t.Rows[0]["QueQuan"].ToString(),
                     t.Rows[0]["TenDN"].ToString(),
                     t.Rows[0]["MatKhau"].ToString(),
                     t.Rows[0]["IDChucVu"].ToString()
                    );

        }

        public static bool Sua(NhanVienADO o)
        {
            #region cau truy van
            var kq = Tim(o.IDNV);

            if (kq == null) return false;//ko co gi de xoa.

            int gt = XuLyDuLieu.ThucThiThemXoaSua("P_UPDATENHANVIEN '" + o.IDNV + "', '"
                + o.TenNV + "','" + o.NgaySinh + "','" + true + "','" + o.NoiTamTru + "','" + o.SDT + "','" 
                + o.QueQuan + "','" + o.TenDN + "','" +  o.MatKhau + "', '" + o.IDChucVu + "' ");
            return gt > 0;
            #endregion
        }
        public static bool Xoa(int id)
        {
            #region cau truy van
            var kq = Tim(id);

            if (kq == null) return false;//ko co gi de xoa.

            int gt = XuLyDuLieu.ThucThiThemXoaSua("SP_DELETENHANVIEN'" + id + "'");
            return gt > 0;
            #endregion
        }
    }
}
