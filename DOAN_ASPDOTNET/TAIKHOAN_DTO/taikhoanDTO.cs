using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAIKHOAN_DTO
{
    public class taikhoanDTO
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string SDT;

        public string SDT1
        {
            get { return SDT; }
            set { SDT = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private bool laAdmin = false;

        public bool LaAdmin
        {
            get { return laAdmin; }
            set { laAdmin = value; }
        }
        private string anhDaidien=" ";

        public string AnhDaidien
        {
            get { return anhDaidien; }
            set { anhDaidien = value; }
        }
        private bool trangThai = true;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

       
    }
}
