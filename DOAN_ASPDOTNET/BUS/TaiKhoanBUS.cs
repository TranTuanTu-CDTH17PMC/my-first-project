using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using TAIKHOAN_DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static bool KTDangNhap(string tenTK, string mk)
        {
            if (!TaiKhoanDAO.KTTKTonTai(tenTK))
            {
                return false;   
            }
            else
            {
                return mk == TaiKhoanDAO.LayMatKhau(tenTK);
            }
        }
        public static bool DangKi(taikhoanDTO tk)
        {
            if (TaiKhoanDAO.KTTKTonTai(tk.TenTaiKhoan))
            {
                return false;
            }
            else
            {
                return TaiKhoanDAO.ThemTK(tk);
            }
        }
    }
}
