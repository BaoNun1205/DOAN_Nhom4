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
    public partial class FrmAdminDichVu : Form
    {
        public FrmAdminDichVu()
        {
            InitializeComponent();
        }
        

        private void FrmAdminDichVu_Load(object sender, EventArgs e)
        {
            NapTien nt = new NapTien();
            this.Controls.Add(nt);
            nt.Location = new Point(185, 127);
            nt.Size = new Size(763, 542);
            nt.Show();
            nt.BringToFront();
        }
        private void btn_NapTien_Click(object sender, EventArgs e)
        {
            NapTien nt = new NapTien();
            this.Controls.Add(nt);
            nt.Location = new Point(185, 127);
            nt.Size = new Size(763, 542);
            nt.Show();
            nt.BringToFront();
        }
        private void btn_RutTien_Click(object sender, EventArgs e)
        {
            RutTien rt = new RutTien();
            this.Controls.Add(rt);      
            rt.Location = new Point(185, 127);
            rt.Size = new Size(763, 542);
            rt.Show();
            rt.BringToFront();
        }

        private void btn_ChuyenTien_Click(object sender, EventArgs e)
        {
            ChuyenTien ct = new ChuyenTien();
            this.Controls.Add(ct);
            ct.Location = new Point(185, 127);
            ct.Size = new Size(763, 542);
            ct.Show();
            ct.BringToFront();
        }
    }
}