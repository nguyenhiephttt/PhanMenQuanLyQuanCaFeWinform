using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANCAFFE.AppCode
{
    public interface IQuanCafe : IDisposable
    {
        #region Quan ly chuc vu Chuc Vu
                                
        ChucVu TimCV(string idchucvu);
        bool ThemCV(ChucVu cv);
        bool XoaCV(string idchucvu);
        bool SuaCV(ChucVu cv);
        #endregion
        //--------------------//

        //#region Quan ly ban
        //Ban TimBan(string idban);D:\HOCTAP\Information_Technology\C#\Winform\QUANCAFFE\QUANCAFFE\IQuanCafe.cs
        //bool ThemBan(Ban ban);
        //bool XoaBan(string idban);
        //bool SuaBan(Ban ban);
        //#endregion

        ////--------------------//
        //#region Quan ly loai
        //LoaiDoUong TimLoai(int idloai);
        //bool ThemLoai(LoaiDoUong l);
        //bool XoaLoai(int idloai);
        //bool SuaLoai(LoaiDoUong loai);
        //#endregion
        //////---------------------//
        //#region Quan ly  do uong
        //DoUong TimDoUong(int iddu);
        //bool ThemDoUong(DoUong du);
        //bool XoaDoUong(int iddu);
        //bool SuaDoUong(DoUong du);
        //#endregion
        //////---------------------//
        //#region Quan ly  nhan vien
        //NhanVien TimNV(int nv);
        //bool ThemNV(NhanVien nv);
        //bool XoaNV(int idnv);
        //bool SuaNV(NhanVien nv);
        //#endregion
        ////---------------------//
        //#region Quan ly hoa don
        //HoaDon TimHD(int idhd);
        //bool ThemHD(HoaDon hd);
        //bool XoaHD(int idhd);
        //bool SuaHD(HoaDon hd);
        //#endregion

        ////---------------------//
        //#region Quan ly  CTHD
        //CTHoaDon TimCTHD(int iddu);

        //#endregion 

    }
}
