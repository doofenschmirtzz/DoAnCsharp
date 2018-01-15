using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace QLGR.Presentation
{
    public partial class frmThongTinPhanMem : Form
    {
        public frmThongTinPhanMem()
        {
            InitializeComponent();
        }
        private void frmThongTinPhanMem_Load(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

       

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(120, 246, 246, 246);

        }
    }
}
