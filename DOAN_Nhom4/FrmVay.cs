﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace DOAN_Nhom4
{
    public partial class FrmVay : Form
    {
        ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay();
        public FrmVay()
        {
            InitializeComponent();
            this.Size = new Size(1501, 858);
        }
        private void FrmVay_Load(object sender, EventArgs e)
        {
            string[] danhxung = {"Ông", "Bà"};
            string[] nghe = { "Chọn", "NONG NGHIEP VA DV CO LIEN QUAN", "LAM NGHIEP VA DV CO LIEN QUAN", "KHAI THAC, NUOI TRONG THUY SAN",
                            "KHAI THAC THAN CUNG VA THAN NON", "KHAI THAC DAU MO VA KHI DOT TU NHIEN", "SAN XUAT O TO", "NHAN VIEN TRONG NGANH DICH VU", 
                            "NHA BAO", "NHA GIAO", "SINH VIEN, HOC SINH","NOI TRO, HUU TRI", "THO THU CONG", "LANH DAO DOANH NGHIEP","KINH DOANH MOI GIOI THUONG MAI",
                            "NHAN VIEN VAN PHONG", "NGHE Y, DUOC", "NGHE NONG", "GIAO THONG VAN TAI", "BUON BAN TIEU THUONG", "CONG NHAN", "KE TOAN KIEM TOAN",
                            "KY SU XAY DUNG", "KIEN TRUC SU", "CAN BO NHA NUOC", "LAM THUE", "HOAT DONG Y TE", "GIAO DUC VA DAO TAO", "HOAT DONG DIEU TRA DAM BAO AN TOAN", "NGHE KHAC"};
            string[] thunhap = {"Chọn" ,"<= 3 triệu đồng", ">= 3-5 triệu đồng", ">= 5-10 triệu đồng", ">= 10-20 triệu đồng", ">= 20 triệu đồng" };
            string[] SPvay = {"Chọn", "Sản phẩm cho vay nhu cầu nhà ở", "Sản phẩm cho vay sản xuất kinh doanh", "Sản phẩm cho vay mua oto", "Sản phẩm cho vay tiêu dùng không có tài sản đảm bảo",
                            "Sản phẩm cho vay tiêu dùng đảm bảo bằng bất động sản", "Cho vay khác"};
            cb_DanhXung.DataSource = danhxung;
            cb_NgheNghiep.DataSource = nghe;
            cb_ThuNhap.DataSource = thunhap;
            cb_SPVay.DataSource = SPvay;    
        }

        private void txt_DiaChiLienLac_Click(object sender, EventArgs e)
        {
            if (txt_DiaChiLienLac.Text == "Địa chỉ khác")
            {
                txt_DiaChiLienLac.Text = "";
                txt_DiaChiLienLac.ForeColor = Color.Black;
            }
        }

        private void txt_DiaChiLienLac_Leave(object sender, EventArgs e)
        {
            if (txt_DiaChiLienLac.Text == "")
            {
                txt_DiaChiLienLac.Text = "Địa chỉ khác";
                txt_DiaChiLienLac.ForeColor = Color.Silver;
            }
        }
        private void llbl_DieuKhoan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=BtOEztT1Qzk");
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string s;
            if (cb_DiaChiLienLac.Checked == true)
            {
                s = cb_DiaChiLienLac.Text;
                txt_DiaChiLienLac.ReadOnly = true;
            }
            else
                s = txt_DiaChiLienLac.Text;
            ttNgDung = new ThongTinNguoiDungVay(cb_DanhXung.Text, txt_HoTen.Text, txt_CCCD.Text, txt_DiaChi.Text, txt_SDT.Text, txt_Email.Text, cb_NgheNghiep.Text, cb_ThuNhap.Text, cb_SPVay.Text, txt_SoTienVay.Text, txt_ThoiGianVay.Text, s, txt_NgayVay.Value);
            //XacNhanThongTinNguoiDungVay xacnhan = new XacNhanThongTinNguoiDungVay(ttNgDung);
        }
    }
}
