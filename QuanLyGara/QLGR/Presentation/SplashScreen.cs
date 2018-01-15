using System;
using System.Drawing;
using System.Windows.Forms;


namespace QLGR.Presentation
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void ProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarX1.Increment(1);
            if (progressBarX1.Value == 100)
            {
                ProgressTimer.Stop();
                this.Hide();
                new frmDangNhap().ShowDialog();
                this.Close();
            }
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(170, 45, 45, 48);
          
        }
    }
}
