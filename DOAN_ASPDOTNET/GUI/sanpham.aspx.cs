using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using SANPHAM_DTO;

namespace GUI
{
    public partial class sanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnthemsp_Click(object sender, EventArgs e)
        {

            sanphamDTO sp = new sanphamDTO();
            sp.Malaptop = txtmasp.Text;
            sp.Gialaptop =  Convert.ToInt32(txtgia.Text);
            sp.Goibaohanh = txtgoibaohanh.Text;
            sp.Khuyenmai = txtkhuyenmai.Text;
            if ()
            {
                Response.Write("<script>alert('Đăng kí thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Tên tài khoản đã có người sử dụng. Đăng kí thất bại')</script>");
            }
        
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}