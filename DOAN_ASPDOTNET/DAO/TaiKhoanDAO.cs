using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TAIKHOAN_DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static bool KTTKTonTai(string tenTK)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }
      
        public static string LayMatKhau(string tenTK)
        {
            string query = "SELECT MatKhau FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();
        }

        public static bool ThemTK(taikhoanDTO tk)
        {
            string query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, SDT, DiaChi, HoTen, LaAdmin, AnhDaiDien, TrangThai) VALUES (@TenTaiKhoan, @MatKhau, @Email, @SDT, @DiaChi, @HoTen, @LaAdmin, @AnhDaiDien, @TrangThai)";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@TenTaiKhoan", tk.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", tk.MatKhau);
            param[2] = new SqlParameter("@Email", tk.Email);
            param[3] = new SqlParameter("@SDT", tk.SDT1);
            param[4] = new SqlParameter("@DiaChi", tk.DiaChi);
            param[5] = new SqlParameter("@HoTen", tk.HoTen);
            param[6] = new SqlParameter("@LaAdmin", tk.LaAdmin);
            param[7] = new SqlParameter("@AnhDaiDien", tk.AnhDaidien);
            param[8] = new SqlParameter("@TrangThai", tk.TrangThai);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static bool ThemTK(string tenTK, string mk, string email, string sdt, string diaChi, string hoTen)
        {
            throw new NotImplementedException();
        }
    }
}
