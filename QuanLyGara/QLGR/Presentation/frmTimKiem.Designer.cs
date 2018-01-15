namespace QLGR.Presentation
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTimKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelSL = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.dgvPTT = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvCTPSC = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtBienSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNgayTiepNhan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtHieuXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtChuXe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTienNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPSC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AllowUserToAddRows = false;
            this.dgvTimKiem.AllowUserToDeleteRows = false;
            this.dgvTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTimKiem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKiem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTimKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTimKiem.Location = new System.Drawing.Point(29, 91);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimKiem.Size = new System.Drawing.Size(421, 324);
            this.dgvTimKiem.TabIndex = 0;
            this.dgvTimKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKiem_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(91, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(204, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(12, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tìm kiếm:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(921, 104);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(116, 72);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(921, 212);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 68);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(921, 315);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 69);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelX10
            // 
            this.labelX10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX10.Location = new System.Drawing.Point(346, 22);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(153, 23);
            this.labelX10.TabIndex = 0;
            this.labelX10.Text = "Số xe tìm kiếm được là: ";
            // 
            // labelSL
            // 
            this.labelSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSL.BackColor = System.Drawing.Color.Transparent;
            this.labelSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSL.Location = new System.Drawing.Point(505, 22);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(31, 23);
            this.labelSL.TabIndex = 7;
            this.labelSL.Text = "0";
            // 
            // labelX11
            // 
            this.labelX11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.ForeColor = System.Drawing.Color.White;
            this.labelX11.Location = new System.Drawing.Point(451, 3);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(275, 46);
            this.labelX11.TabIndex = 6;
            this.labelX11.Text = "T Ì M    K I Ế M";
            // 
            // labelX13
            // 
            this.labelX13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX13.Location = new System.Drawing.Point(191, 429);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(95, 23);
            this.labelX13.TabIndex = 8;
            this.labelX13.Text = "Phiếu thu tiền";
            // 
            // labelX12
            // 
            this.labelX12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX12.Location = new System.Drawing.Point(730, 429);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(153, 23);
            this.labelX12.TabIndex = 9;
            this.labelX12.Text = "Chi tiết phiếu sửa chữa";
            // 
            // dgvPTT
            // 
            this.dgvPTT.AllowUserToAddRows = false;
            this.dgvPTT.AllowUserToDeleteRows = false;
            this.dgvPTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPTT.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPTT.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPTT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPTT.Location = new System.Drawing.Point(25, 458);
            this.dgvPTT.Name = "dgvPTT";
            this.dgvPTT.ReadOnly = true;
            this.dgvPTT.Size = new System.Drawing.Size(425, 112);
            this.dgvPTT.TabIndex = 10;
            // 
            // dgvCTPSC
            // 
            this.dgvCTPSC.AllowUserToAddRows = false;
            this.dgvCTPSC.AllowUserToDeleteRows = false;
            this.dgvCTPSC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCTPSC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCTPSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPSC.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTPSC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCTPSC.Location = new System.Drawing.Point(487, 458);
            this.dgvCTPSC.Name = "dgvCTPSC";
            this.dgvCTPSC.ReadOnly = true;
            this.dgvCTPSC.Size = new System.Drawing.Size(569, 112);
            this.dgvCTPSC.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelX11);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 60);
            this.panel1.TabIndex = 12;
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.White;
            this.labelX7.Location = new System.Drawing.Point(10, 71);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(117, 25);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Ngày tiếp nhận:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBienSo.Border.Class = "TextBoxBorder";
            this.txtBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBienSo.Location = new System.Drawing.Point(133, 12);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.ReadOnly = true;
            this.txtBienSo.Size = new System.Drawing.Size(255, 24);
            this.txtBienSo.TabIndex = 0;
            // 
            // txtNgayTiepNhan
            // 
            this.txtNgayTiepNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNgayTiepNhan.Border.Class = "TextBoxBorder";
            this.txtNgayTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTiepNhan.Location = new System.Drawing.Point(133, 72);
            this.txtNgayTiepNhan.Name = "txtNgayTiepNhan";
            this.txtNgayTiepNhan.ReadOnly = true;
            this.txtNgayTiepNhan.Size = new System.Drawing.Size(255, 24);
            this.txtNgayTiepNhan.TabIndex = 2;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.Window;
            this.labelX2.Location = new System.Drawing.Point(55, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 25);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Biển số:";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(55, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(72, 25);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Hiệu xe:";
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtHieuXe.Border.Class = "TextBoxBorder";
            this.txtHieuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHieuXe.Location = new System.Drawing.Point(133, 42);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.ReadOnly = true;
            this.txtHieuXe.Size = new System.Drawing.Size(255, 24);
            this.txtHieuXe.TabIndex = 1;
            // 
            // labelX9
            // 
            this.labelX9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.White;
            this.labelX9.Location = new System.Drawing.Point(56, 14);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(60, 25);
            this.labelX9.TabIndex = 3;
            this.labelX9.Text = "Chủ xe:";
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(56, 103);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(60, 25);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tiền nợ:";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.White;
            this.labelX5.Location = new System.Drawing.Point(40, 132);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(76, 25);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Điện thoại:";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(72, 161);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(44, 25);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Email:";
            // 
            // labelX8
            // 
            this.labelX8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.White;
            this.labelX8.Location = new System.Drawing.Point(59, 43);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(57, 25);
            this.labelX8.TabIndex = 4;
            this.labelX8.Text = "Địa chỉ:";
            // 
            // txtChuXe
            // 
            this.txtChuXe.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtChuXe.Border.Class = "TextBoxBorder";
            this.txtChuXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuXe.Location = new System.Drawing.Point(133, 19);
            this.txtChuXe.Name = "txtChuXe";
            this.txtChuXe.Size = new System.Drawing.Size(257, 24);
            this.txtChuXe.TabIndex = 3;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtTienNo.Border.Class = "TextBoxBorder";
            this.txtTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNo.Location = new System.Drawing.Point(133, 103);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(257, 24);
            this.txtTienNo.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(133, 50);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(257, 46);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(133, 134);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(257, 24);
            this.txtDienThoai.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 24);
            this.txtEmail.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txtHieuXe);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.txtNgayTiepNhan);
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.txtBienSo);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Location = new System.Drawing.Point(477, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 106);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtDienThoai);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.txtTienNo);
            this.panel3.Controls.Add(this.txtChuXe);
            this.panel3.Controls.Add(this.labelX8);
            this.panel3.Controls.Add(this.labelX6);
            this.panel3.Controls.Add(this.labelX5);
            this.panel3.Controls.Add(this.labelX4);
            this.panel3.Controls.Add(this.labelX9);
            this.panel3.Location = new System.Drawing.Point(477, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 206);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.labelX1);
            this.panel4.Location = new System.Drawing.Point(30, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 38);
            this.panel4.TabIndex = 15;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.labelX13);
            this.panel5.Controls.Add(this.labelX12);
            this.panel5.Controls.Add(this.dgvPTT);
            this.panel5.Controls.Add(this.dgvCTPSC);
            this.panel5.Controls.Add(this.labelX10);
            this.panel5.Controls.Add(this.btnThoat);
            this.panel5.Controls.Add(this.dgvTimKiem);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.labelSL);
            this.panel5.Controls.Add(this.btnCapNhat);
            this.panel5.Location = new System.Drawing.Point(-1, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1099, 612);
            this.panel5.TabIndex = 16;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(197)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1098, 667);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPSC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimKiem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnCapNhat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelSL;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPTT;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCTPSC;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBienSo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNgayTiepNhan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHieuXe;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChuXe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTienNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}