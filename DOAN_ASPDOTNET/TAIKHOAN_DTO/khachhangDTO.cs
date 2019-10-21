using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAIKHOAN_DTO
{
   public class khachhangDTO
    {
        private string thongtinkhachhang;

        public string Thongtinkhachhang
        {
            get { return thongtinkhachhang; }
            set { thongtinkhachhang = value; }
        }
        private string taikhoankhachhang;

        public string Taikhoankhachhang
        {
            get { return taikhoankhachhang; }
            set { taikhoankhachhang = value; }
        }
        private bool tinhtrang;

        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
        private string loaikhachhang;

        public string Loaikhachhang
        {
            get { return loaikhachhang; }
            set { loaikhachhang = value; }
        }
    }
}
