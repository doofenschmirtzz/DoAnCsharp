using System;
using System.Windows.Forms;
using QLGR.BusinessLayer;
using System.Runtime.InteropServices;

namespace QLGR.Presentation
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void txtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            labStatus.Visible = false;
        }

        void DangNhap()
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text))
            {
                if (DangNhapBLL.XemDL("*", txtTaiKhoan.Text, txtMatKhau.Text).Rows.Count != 0)
                {
                    frmThongTinTaiKhoan.tenDangNhap = txtTaiKhoan.Text;
                    frmThongTinTaiKhoan.matKhau = txtMatKhau.Text;
                    frmThayDoiMatKhau.taiKhoan = txtTaiKhoan.Text;
                    frmMain formMain = new frmMain();
                    frmMain.quyen = DangNhapBLL.XemDL("QUYEN", txtTaiKhoan.Text, txtMatKhau.Text).Rows[0][0].ToString();
                    this.Hide();
                    formMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    labStatus.Visible = true;
                    txtMatKhau.Clear();
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '•';
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.TextLength != 0)
                labStatus.Visible = false;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                DangNhap();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength != 0)
                labStatus.Visible = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void frmDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
