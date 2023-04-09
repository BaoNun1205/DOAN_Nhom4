﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmXacNhanGiaoDichVay : Form
    {
        public NguoiDung nguoiDung;
        public ThongTinNguoiDungVay ttNgDung;
        public Panel pnlNguoiDung;
        public TaiKhoanNganHang tknh;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        public FrmXacNhanGiaoDichVay()
        {
            InitializeComponent();
        }
        public FrmXacNhanGiaoDichVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh, ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchVay, pnlNguoiDung);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            ttNgDung.NgayDenHan = ttNgDung.NgayDenHan.AddMonths(1);
            ttNgDung.TongSoTienPhaiTra -= (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham);
            ttNgDung.ThoiGianVay -= 1;
            ttNgDung.SoTienVay = ttNgDung.SoTienVay - (ttNgDung.SoTienHangThang - int.Parse(txt_SoTienLai.Text));
            ttNgDung.PhiTraCham = 0;
            tknh.SoDu -= ttNgDung.SoTienHangThang;
            if (ttNgDung.ThoiGianVay != 0)
            {
                ttNgDungDAO.Update(ttNgDung);
                tknhDAO.Sua(tknh);
                GiaoDich gd = new GiaoDich("Thanh toan khoan vay 1 thang", "HHB",nguoiDung.tenTK, nguoiDung.SoTK, "HHB", "", "", ttNgDung.SoTienHangThang, "Thanh toan khoan vay");
                lsgdDAO.Them(gd);
                MessageBox.Show("Hoàn tất thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmThongTinTaiKhoanVay frmThongTinTaiKhoanVay = new FrmThongTinTaiKhoanVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTaiKhoanVay, pnlNguoiDung);
            }
            else
            {
                ttNgDungDAO.Xoa(ttNgDung);
                MessageBox.Show("Bạn đã thanh toán xong khoản vay", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmTienIchVay FrmTienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
                DOAN_Nhom4.ClassAddForm.addForm(FrmTienIchVay, pnlNguoiDung);
            }
            
        }

        private void FrmXacNhanGiaoDichVay_Load(object sender, EventArgs e)
        {
            txt_TKNguon.Text = nguoiDung.SoTK;
            txt_TKVay.Text = nguoiDung.SoTK;
            BigInteger tmp = ttNgDung.SoTienVay / ttNgDung.ThoiGianVay;
            txt_SoTienGoc.Text = tmp.ToString("N0");
            txt_SoTienLai.Text = (ttNgDung.SoTienHangThang - tmp).ToString();
            txt_PhiTraCham.Text = ttNgDung.PhiTraCham.ToString("N0");
            txt_TongSoTien.Text = (ttNgDung.SoTienHangThang + ttNgDung.PhiTraCham).ToString("N0");
            txt_NgayGiaoDich.Value = DateTime.Now;
        }
    }
}