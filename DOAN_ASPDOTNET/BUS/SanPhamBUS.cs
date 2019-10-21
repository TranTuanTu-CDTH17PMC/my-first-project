using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using SANPHAM_DTO;
namespace BUS
{
    class SanPhamBUS
    {
        public static bool themsanpham(taikhoanDTO sp)
        {
            if (TaiKhoanDAO.KTSPTonTai(sp.))
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
