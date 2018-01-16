using System;
using QLGR.BusinessLayer;
using System.Data;
using System.Windows.Forms;
using QLGR.Entities;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public static string tenDangNhap, matKhau;
        string quyen;
       

        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
    
           
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            //txtChucVu.Text = DangNhapBLL.XemDL("QUYEN", tenDangNhap, matKhau).Rows[0][0].ToString();
            GetThongTinTaiKhoan();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.DiaChi = txtDiaChi.Text;
                taiKhoan.Email = txtEmail.Text;
                taiKhoan.HoTen = txtHoTen.Text;
                taiKhoan.SDT = txtSDT.Text;
                taiKhoan.TenDangNhap = tenDangNhap;
                taiKhoan.Quyen = quyen;
                taiKhoan.MatKhau = matKhau;

                TaiKhoanBLL.ThayDoiThongTinTaiKhoan(taiKhoan);
                MessageBox.Show("Thay đổi thông tin tài khoản thành công!", "Thông báo");
                this.Close();
            }
            catch {; }
        }

        private void labelX1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        void GetThongTinTaiKhoan()
        {
            DataTable dt = DangNhapBLL.GetThongTinNguoiDung(tenDangNhap);
            txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
            txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            string chucVu = dt.Rows[0]["QUYEN"].ToString();
            quyen = chucVu.Trim();
            if (chucVu == "GIAMDOC   ")
                txtChucVu.Text = "Giám đốc";
            else if (chucVu == "QUANLI    ")
                txtChucVu.Text = "Quản lí";
            else if (chucVu == "NHANVIEN  ")
                txtChucVu.Text = "Nhân viên";
        }
    }
}
