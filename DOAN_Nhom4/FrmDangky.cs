﻿using DOAN_Nhom4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmDangky : Form
    {
        NguoiDungDAO khDAO = new NguoiDungDAO();
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmDangky()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FrmDangnhap frmdangnhap = new FrmDangnhap();
            this.Hide();
            frmdangnhap.ShowDialog();
            this.Close();
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang()
            {
                TenNh = "HHB",
                SoTk = txtSoTK.Text,
                TenKh = txtTenTK.Text,
                NgaySinh = timeNgaySinh.Value,
                Cccd = txtCCCD.Text,
                Email = txtEmail.Text,
                Sdt = txtSDT.Text
            };
            TaiKhoanNganHang tknh = new TaiKhoanNganHang()
            {
                TenNh = "HHB",
                SoTk = txtSoTK.Text,
                TenDn = txtTenDN.Text,
                MatKhau = txtMatkhau.Text,
                SoDu = 50000,
                NgayDangKy = txtNgayDangKy.Value
            };
            if (!khDAO.IsEmpty(kh) && !tknhDAO.IsEmpty(tknh))
            {
                if (!khDAO.IsPhone(kh))
                    MessageBox.Show("So dien thoai khong hop le");
                else if (!khDAO.IsEmail(kh))
                    MessageBox.Show("Email khong hop le");
                else
                {
                    khDAO.Them(kh);
                    tknhDAO.Them(tknh);
                    FrmDangnhap frmdangnhap = new FrmDangnhap();
                    this.Hide();
                    frmdangnhap.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Chua nhap du thong tin");
        }
    }
}
