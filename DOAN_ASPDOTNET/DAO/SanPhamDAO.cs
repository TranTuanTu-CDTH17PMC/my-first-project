using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TAIKHOAN_DTO;

namespace DAO
{
    class SanPhamDAO
    {
        public static bool KTSPTonTai(string masp)
        {
            string query = "SELECT COUNT(*) FROM sanpham WHERE masp = @masp";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@masp", masp);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }
        public static bool ThemTK(taikhoanDTO tk)
        {
            string query = "INSERT INTO SANPHAM (Masp, tensp, thongtin, Giatien, SoLuongtonkho, MaloaiSP, Anhminhhoa, TrangThai) VALUES (@MaSP, @TenSP, @ThongTin, @GiaTien, @SoLuongTonKho, @MaLoai, @AnhMinhHoa, @TrangThai)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@MaSP", tk.TenTaiKhoan);
            param[1] = new SqlParameter("@TenSP", tk.MatKhau);
            param[2] = new SqlParameter("@GiaTien", tk.Email);
            param[3] = new SqlParameter("@SoLuongTonKHo", tk.SDT1);
            param[4] = new SqlParameter("@MaLoaiSP", tk.DiaChi);
            param[5] = new SqlParameter("@AnhMinhHoa", tk.HoTen);
            param[6] = new SqlParameter("@LaAdmin", tk.LaAdmin);
            param[7] = new SqlParameter("@AnhDaiDien", tk.AnhDaidien);
            param[8] = new SqlParameter("@TrangThai", tk.TrangThai);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }
    }
}
