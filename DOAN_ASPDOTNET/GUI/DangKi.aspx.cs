using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using TAIKHOAN_DTO;

namespace GUI
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKi_Click(object sender, EventArgs e)
        {
            taikhoanDTO tk = new taikhoanDTO();
            tk.TenTaiKhoan = txtTenTK.Text;
            tk.MatKhau= txtMK.Text;
            tk.Email= txtEmail.Text;
            tk.SDT1= txtSDT.Text;
            tk.DiaChi= txtDiaChi.Text;
            tk.HoTen= txtHoTen.Text;

            if (TaiKhoanBUS.DangKi(tk))
            {
                Response.Write("<script>alert('Đăng kí thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Tên tài khoản đã có người sử dụng. Đăng kí thất bại')</script>");
            }
        }
    }
}