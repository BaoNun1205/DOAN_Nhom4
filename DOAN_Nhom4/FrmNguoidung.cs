namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public FrmNguoidung()
        {
            InitializeComponent();
        }
        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblXinchao.Parent = picBoxNguoidung;
            lblXinchao.BackColor = Color.Transparent;

            pnlTaikhoan.Parent = picBoxNguoidung;
            pnlTaikhoan.BackColor = Color.Transparent;

            pnlCaidat.Parent = picBoxNguoidung;
            pnlCaidat.BackColor = Color.Transparent;

            
        }
        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void picBoxChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void lblChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        private void btnChuyentien_MouseLeave(object sender, EventArgs e)
        {
            btnChuyentien.BorderColor = Color.Transparent;
        }

        private void picBoxChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        private void lblChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        private void btnTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }

        private void btnTienich_MouseLeave(object sender, EventArgs e)
        {
            btnTienich.BorderColor = Color.Transparent;
        }

        private void picBoxTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }

        private void lblTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }
        private void btnTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }

        private void btnTietkiem_MouseLeave(object sender, EventArgs e)
        {
            btnTietkiem.BorderColor = Color.Transparent;
        }

        private void picBoxTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }

        private void lblTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }
    }
}