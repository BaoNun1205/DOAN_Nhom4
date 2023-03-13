﻿using System;
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
    public partial class FrmBaomat : Form
    {
        public NguoiDung ngdung;
        public FrmBaomat()
        {
            InitializeComponent();
        }

        public FrmBaomat(NguoiDung ngdung)
        {
            InitializeComponent();
            this.ngdung = ngdung;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(ngdung);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            FrmDoimatkhau frmdoimk = new FrmDoimatkhau(ngdung);
            this.Hide();
            frmdoimk.ShowDialog();
            this.Close();
        }
    }
}