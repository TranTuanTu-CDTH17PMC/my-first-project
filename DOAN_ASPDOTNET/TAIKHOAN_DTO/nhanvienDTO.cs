using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAIKHOAN_DTO
{
  public class nhanvienDTO
    {
        private string manv;


        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private string thongtinnv;

        public string Thongtinnv
        {
            get { return thongtinnv; }
            set { thongtinnv = value; }
        }
        private string chucvu;


        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        private int luong;

        public int Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        private DateTime ngaydilam;

        public DateTime Ngaydilam
        {
            get { return ngaydilam; }
            set { ngaydilam = value; }
        }
        private bool tinhtrang;

        public bool Tinhtrang
        {
            get { return tinhtrang; }
            set { tinhtrang = value; }
        }
    
    }
}
