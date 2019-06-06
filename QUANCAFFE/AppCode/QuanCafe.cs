using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE.AppCode
{
    class QuanCafe : IQuanCafe
    {
        DBQUANCAFFEDataContext dc = null;
        public QuanCafe()
        {
            dc = new DBQUANCAFFEDataContext();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public List<ChucVu> DSCV
        { 
            get
            {
                return dc.ChucVus.ToList();

            }
        }
        #region Quan Ly chuc vu
        public bool SuaCV(ChucVu cv)
        {
            var kq = TimCV(cv.IDChucVu);
            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    kq.TenChucVu = cv.TenChucVu;
                    kq.MoTa = cv.MoTa;
                    dc.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ThemCV(ChucVu cv)
        {
            var kq = TimCV(cv.IDChucVu);
            try
            {
                if (kq == null)
                {
                    dc.ChucVus.InsertOnSubmit(cv);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public ChucVu TimCV(string idchucvu)
        {
            return dc.ChucVus.FirstOrDefault(cv => cv.IDChucVu == idchucvu);
        }

        public bool XoaCV(string idchucvu)
        {
            var kq = TimCV(idchucvu);

            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    dc.ChucVus.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        #endregion

        #region Quan Ly nhan vien
        public List<NhanVien> DSNV
        {
            get
            {
                return dc.NhanViens.ToList();

            }
        }
        public bool SuaNV(NhanVien o)
        {
            var kq = TimNV(o.IDNV);
            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    kq.TenNV = o.TenNV;
                    kq.TenDN = o.TenDN;
                    kq.MatKhau = o.MatKhau;
                    kq.QueQuan = o.QueQuan;
                    kq.SDT = o.SDT;
                    kq.NoiTamTru = o.NoiTamTru;
                    kq.NgaySinh = o.NgaySinh;
                    kq.IDChucVu = o.IDChucVu;
                    kq.GioiTinh = o.GioiTinh;
                    dc.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool ThemNV(NhanVien o)
        {
            var kq = TimNV(o.IDNV);
            try
            {
                if (kq == null)
                {
                    dc.NhanViens.InsertOnSubmit(o);
                    dc.SubmitChanges();
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public NhanVien TimNV(int idnv)
        {
            return dc.NhanViens.FirstOrDefault(o => o.IDNV == idnv);
        }
        public NhanVien TimNVToTenDN(String tendn)
        {
            return dc.NhanViens.FirstOrDefault(o => o.TenDN == tendn);
        }
        public bool XoaNV(int idnv)
        {
            var kq = TimNV(idnv);

            try
            {

                if (kq == null)
                {
                    return false;
                }
                else
                {
                    dc.NhanViens.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        public int SoDong(int idnv)
        {
            for (var i = 0; i < DSNV.Count; i++)
            {
                if (DSNV[i].IDNV == idnv)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Quan Ly Loai
        public List<LoaiDoUong> DSLoaiDoUong
        {
            get
            {
                return dc.LoaiDoUongs.ToList();

            }
        }
        public bool SuaLoaiDoUong(LoaiDoUong o)
        {
            var kq = TimLoaiDU(o.IDLoai);
            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    kq.TenLoai = o.TenLoai;

                    dc.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool ThemLoaiDU(LoaiDoUong o)
        {
            //  var kq = TimLoaiDU(o.IDLoai);
            try
            {

                dc.LoaiDoUongs.InsertOnSubmit(o);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public LoaiDoUong TimLoaiDU(int id)
        {
            return dc.LoaiDoUongs.FirstOrDefault(o => o.IDLoai == id);
        }
        public bool XoaLoaiDU(int id)
        {
            var kq = TimLoaiDU(id);

            try
            {

                if (kq == null)
                {
                    return false;
                }
                else
                {
                    dc.LoaiDoUongs.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }


        }
        public int SoDongInDSLoai(int id)
        {
            for (var i = 0; i < DSLoaiDoUong.Count; i++)
            {
                if (DSLoaiDoUong[i].IDLoai == id)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Quan Ly Do Uong
        public List<DoUong> DSDoUong
        {
            get
            {
                return dc.DoUongs.ToList();

            }
        }
        public bool SuaDoUong(DoUong o)
        {
          
            var kq = TimDoUong(o.IDDoUong);
            
            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    kq.TenDoUong = o.TenDoUong;
                    kq.IDLoai = o.IDLoai;
                    kq.GiaGoc = o.GiaGoc;
                    kq.GiaBan = o.GiaBan;
                    kq.SoLuong = o.SoLuong;
                    kq.NgayNhapHang = o.NgayNhapHang;
                    kq.DonViTinh = o.DonViTinh;
                    dc.SubmitChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool ThemDoUong(DoUong o)
        {
            //  var kq = TimLoaiDU(o.IDLoai);
            try
            {
                dc.DoUongs.InsertOnSubmit(o);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DoUong TimDoUong(int id)
        {
            return dc.DoUongs.FirstOrDefault(o => o.IDDoUong == id);
        }
        public DoUong TimDoUongTheoTen(string tenDoUong)
        {
            return dc.DoUongs.FirstOrDefault(o => o.TenDoUong == tenDoUong);
        }
        public bool XoaDoUong(int id)
        {

            try
            {
                dc.DoUongs.DeleteOnSubmit(this.TimDoUong(id));
                dc.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }
        public int SoDongInDSDoUong(int id)
        {
            for (var i = 0; i < DSDoUong.Count; i++)
            {
                if (DSDoUong[i].IDLoai == id)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
        #region Quan Ly Ban
        public List<Ban> DSBan
        {
            get
            {
                return dc.Bans.ToList();
            }
        }
        public bool CapNhatBan(Ban o)
        {
            var kq = TimBan(o.IDBan);
            try
            {
                if (kq == null)
                {
                    return false;
                }
                else
                {
                    kq.TenBan = o.TenBan;
                    kq.TrangThai = o.TrangThai;
                    dc.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }



        public bool ThemBan(Ban o)
        {
            try
            {
                dc.Bans.InsertOnSubmit(o);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public Ban TimBan(int id)
        {
            return dc.Bans.FirstOrDefault(o => o.IDBan == id);
        }
        public bool XoaBan(int idBan)
        {
            var kq = TimBan(idBan);

            try
            {

                if (kq == null)
                {
                    return false;
                }
                else
                {
                    dc.Bans.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }


        }

        public int SoDongInDSBan(int id)
        {
            for (var i = 0; i < DSBan.Count; i++)
            {
                if (DSBan[i].IDBan == id)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Quan Ly Hoa Don
        public List<HoaDon> DSHoaDon
        {
            get
            {
                return dc.HoaDons.ToList();
            }
        }
        public List<HoaDon> DSHoaDonTrue
        {
            get
            {
                List<HoaDon> ds = new List<HoaDon>();
                foreach (var item in DSHoaDon) {
                    if (item.TrangThai == true)
                    {
                        ds.Add(item);
                    }
                }
                return ds;
            }
        }
        public bool XoaHoaDon(int idhoadon)
        {
            
            
            var kq = this.TimHoaDon(idhoadon);
           
            try
            {
                    dc.HoaDons.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                
            }
            catch
            {
                return false;
            }
        }

        public HoaDon TimHoaDon(int iDHoaDon)
        {
            return dc.HoaDons.FirstOrDefault(o => o.IDHoaDon == iDHoaDon);
            
        }

        public bool ThemHoaDon(HoaDon o)
        {
            try
            {
                dc.HoaDons.InsertOnSubmit(o);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public HoaDon TimHoaDonTheoIDBan(int id)
        {
            foreach (var hd in this.DSHoaDon)
            {
                if (hd.IDBan == id && hd.TrangThai == false)
                {
                    return hd;
                }
            }
            return null;
        }

        #endregion
        #region Quan Ly Chi Tiet Hoa Don
        public List<CTHoaDon> DSCTHD
        {
            get
            {
                return dc.CTHoaDons.ToList();
            }
        }

        public bool ThemCTHD(CTHoaDon o)
        {
            try
            {
                dc.CTHoaDons.InsertOnSubmit(o);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<CTHoaDon> TimDSCTHD(int id)
        {
            List<CTHoaDon> ds = new List<CTHoaDon>();
            foreach (var item in this.DSCTHD)
            {
                if (item.IDHoaDon == id)
                {
                    ds.Add(item);
                }
            }
            return ds;
        }
        public bool XoaDU_Ban(int idhd,int iddouong )
        {
            var kq = dc.CTHoaDons.FirstOrDefault(o => o.IDDoUong == iddouong && o.IDHoaDon == idhd);
             try
              {
                if(kq==null)
                {
                    return false;
                }
                else
                {
                    dc.CTHoaDons.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }
              }
            catch
            {
                return false;
            }
        }

        
        public bool SuaHD(HoaDon hd)
        {
            var kq = TimHoaDon(hd.IDBan);
            if (kq == null)
            {
                return false;
            }
            kq.TrangThai = hd.TrangThai;
            kq.GiamGia = hd.GiamGia;
            dc.SubmitChanges();
            return true;
        }
        public bool XoaCTHD(int idhoadon, int iddouong) 
        {
            var kq = TimCTHDTheoDoUong(idhoadon, iddouong);
            try
            {

                if (kq == null)
                {
                    return false;
                }
                else
                {
                    dc.CTHoaDons.DeleteOnSubmit(kq);
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }

        }
        public bool SuaCTHD(int idHD, int idDouong, int soluong)
        {
            var kq = TimCTHDTheoDoUong(idHD, idDouong);
            try
            {

                kq.SoLuong += soluong;
                dc.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public CTHoaDon TimCTHDTheoDoUong(int idHoaDon, int iDDoUong)
        {
            try
            {
                return dc.CTHoaDons.FirstOrDefault(o => o.IDHoaDon == idHoaDon && o.IDDoUong == iDDoUong);

            }
            catch
            {
                return null;
            }
        }

        //public int SoDongInDSBan(int id)
        //{
        //    for (var i = 0; i < DSBan.Count; i++)
        //    {
        //        if (DSBan[i].IDBan == id)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        #endregion
        //Gop ban
        public bool GopBan(int idBanGop, int idBanBiGop)
        {
            var timhdbanbigop = this.TimHoaDonTheoIDBan(idBanBiGop);
            
            var timhd = this.TimHoaDonTheoIDBan(idBanGop);

            var hd = new HoaDon()
            {
                IDBan = idBanGop,
                IDNhanVienLap = timhdbanbigop.IDNhanVienLap
            };
            //ban cau co hoa don
            if (timhd == null)
            {
                ThemHoaDon(hd);
            }
            foreach (var item in DSCTHD)
            {

                if (item.IDHoaDon == timhdbanbigop.IDHoaDon)
                {
                    //Neu ban gop chua co hoa don
                    if (timhd == null)
                    {
                        var o = new CTHoaDon()
                        {
                            IDHoaDon = hd.IDHoaDon,
                            IDDoUong = item.IDDoUong,
                            GiaBan = item.GiaBan,
                            GiaGoc = item.GiaGoc,
                            SoLuong = item.SoLuong,
                            
                        };
                        ThemCTHD(o);
                     

                    }
                    //Neu ban gop da co hoa don: lay sp tu ban bi gop + vao ban gop
                    else
                    {
                        var kq = TimCTHDTheoDoUong(timhd.IDHoaDon, item.IDDoUong);
                        //1 San pham gop chua co trong ban gop
                        if (kq == null)
                        {
                            var o = new CTHoaDon()
                            {
                                IDHoaDon = timhd.IDHoaDon,
                                IDDoUong = item.IDDoUong,
                                GiaBan = item.GiaBan,
                                GiaGoc = item.GiaGoc,
                                SoLuong = item.SoLuong,
                               
                            };
                            ThemCTHD(o);
                            
                        }
                        //San pham da co trong ban gop:them item.SoLuong vao hoa don co ma la timhd.IDHoaDon
                        if (kq != null)
                        {
                            SuaCTHD(timhd.IDHoaDon, item.IDDoUong, item.SoLuong);
                        }
                    }

                    this.XoaCTHD(item.IDHoaDon, item.IDDoUong);
                }
            }
            //sau khi gop ban
            //+1. Cap nhat trang thai ban
            //+2. Xoa hao don
            var ban = new Ban()
            {
                IDBan = idBanBiGop,
                TenBan = TimBan(idBanBiGop).TenBan,
                TrangThai = "Trống"
            };
            CapNhatBan(ban);
            dc.SubmitChanges();
            return true;
        }
        //quan ly tai khoan
        public bool CapNhatTK(int idNV,NhanVien o)
        {
            try
            {
                var kq = TimNV(idNV);
                if(kq==null)
                {
                    return false;
                }
                else
                {
                    kq.TenDN = o.TenDN;
                    kq.TenNV = o.TenNV;
                    kq.MatKhau = o.MatKhau;
                    kq.TenHinh = o.TenHinh;
                    dc.SubmitChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool XoaCTHDTheoIDHD(int idhd)
        {
            var kq = TimDSCTHD(idhd);
            try
            {

                if (kq == null)
                {
                    return false;
                }
                else
                {
                    foreach(var item in kq)
                    {
                        dc.CTHoaDons.DeleteOnSubmit(item);
                    }
                    
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        

        //phan quyen
        public List<Quyen> DSQuyen
        {

            get
            {
                return dc.Quyens.ToList();
            }
        }

        public List<Quyen> DSQuyenTheoCV(string idcv)
        {
            List<Quyen> ds = new List<Quyen>();
           foreach(var item in DSQuyen)
            {
                if (item.IDChucVu == idcv)
                {
                    ds.Add(item);
                }
            }
            return ds;
        }
        public Quyen TimQuyen(string idcv, string tentab)
        {
            return dc.Quyens.FirstOrDefault(o => o.IDChucVu == idcv && o.TenTab == tentab);
        }
        public bool SuaQuyen(Quyen q)
        {
            try
            {
                var kq = TimQuyen(q.IDChucVu, q.TenTab);
                if (kq == null)
                {
                    return false;
                }
                else
                {
                  
                    kq.Them = q.Them;
                    kq.Xoa = q.Xoa;
                    kq.Sua = q.Sua;
                    dc.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        //Form
        public List<Tab> DSTabPageQL
        {

            get
            {
                return dc.Tabs.ToList();
            }
        }
    }
}
