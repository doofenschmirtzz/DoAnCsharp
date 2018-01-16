using System;
using QLGR.BusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace QLGR.Presentation
{
    public partial class frmThayDoiMatKhau : Form
    {
        public static string taiKhoan;
        FormCollection allForm = Application.OpenForms;

        public frmThayDoiMatKhau()
        {
            InitializeComponent();
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtMatKhauHienThoi.Text, TaiKhoanBLL.MatKhauCu(taiKhoan).Trim()))
            {
                if (txtMatKhauMoi.Text.Length >= 4 && txtMatKhauMoi.Text.Length <= 20)
                {
                    if (string.Equals(txtMatKhauMoi.Text, txtNhapLaiMKMoi.Text))
                    {
                        try
                        {
                            TaiKhoanBLL.ThayDoiMatKhau(taiKhoan, txtMatKhauMoi.Text);
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK);
                        }
                        catch {; }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp.\nXin nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauMoi.Clear();
                        txtNhapLaiMKMoi.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải từ 4-20 kí tự", "Lỗi", MessageBoxButtons.OK);
                    txtMatKhauMoi.Clear();
                    txtNhapLaiMKMoi.Clear();
                }
            }

            else
            {
                MessageBox.Show("Mật khẩu hiện thời không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThayDoiMatKhau_Load(object sender, EventArgs e)
        {
        }

        void DangXuat()
        {
            Form frmMain = new Form();
            foreach (Form frm in allForm)
            {
                if (frm.Name == "frmMain")
                {
                    frmMain.Hide();
                    new frmDangNhap().Show();
                    frmMain.Close();
                    return;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(120, 63, 78, 85);
        }

        

        private void labelX1_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauHienThoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}
