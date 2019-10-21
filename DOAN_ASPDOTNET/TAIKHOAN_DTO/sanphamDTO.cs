using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANPHAM_DTO
{
   
 public class sanphamDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string tenlaptop;

        public string Tenlaptop
        {
            get { return tenlaptop; }
            set { tenlaptop = value; }
        }
        private string malaptop;

        public string Malaptop
        {
            get { return malaptop; }
            set { malaptop = value; }
        }
        private string thongsolaptop;

        public string Thongsolaptop
        {
            get { return thongsolaptop; }
            set { thongsolaptop = value; }
        }
        private int gialaptop;

        public int Gialaptop
        {
            get { return gialaptop; }
            set { gialaptop = value; }
        }
        private bool tingtranglaptop;

        public bool Tingtranglaptop
        {
            get { return tingtranglaptop; }
            set { tingtranglaptop = value; }
        }
        private int soluongtonkho;

        public int Soluongtonkho
        {
            get { return soluongtonkho; }
            set { soluongtonkho = value; }
        }
        private string goibaohanh;

        public string Goibaohanh
        {
            get { return goibaohanh; }
            set { goibaohanh = value; }
        }
        private string khuyenmai;

        public string Khuyenmai
        {
            get { return khuyenmai; }
            set { khuyenmai = value; }
        }
    }
}
