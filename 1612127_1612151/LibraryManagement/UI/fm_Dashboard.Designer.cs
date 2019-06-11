namespace LibraryManagement
{
    partial class fm_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTaiKhoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThongKe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLPhieu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLDocGia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLSach = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.control_area = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::LibraryManagement.Properties.Resources.minimize_window_512px;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1083, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 34);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::LibraryManagement.Properties.Resources.close_icon;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1120, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(32, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(71, 16);
            this.txtUser.TabIndex = 3;
            this.txtUser.Text = "Username";
            // 
            // txtChucVu
            // 
            this.txtChucVu.AutoSize = true;
            this.txtChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.ForeColor = System.Drawing.Color.White;
            this.txtChucVu.Location = new System.Drawing.Point(53, 120);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(46, 16);
            this.txtChucVu.TabIndex = 6;
            this.txtChucVu.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.txtChucVu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnTaiKhoan);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.btnQLPhieu);
            this.panel2.Controls.Add(this.btnQLDocGia);
            this.panel2.Controls.Add(this.btnQLSach);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 554);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.BorderRadius = 0;
            this.btnDangXuat.ButtonText = "Đăng xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Iconimage = global::LibraryManagement.Properties.Resources.logout_rounded_left_512px;
            this.btnDangXuat.Iconimage_right = null;
            this.btnDangXuat.Iconimage_right_Selected = null;
            this.btnDangXuat.Iconimage_Selected = null;
            this.btnDangXuat.IconMarginLeft = 0;
            this.btnDangXuat.IconMarginRight = 0;
            this.btnDangXuat.IconRightVisible = true;
            this.btnDangXuat.IconRightZoom = 0D;
            this.btnDangXuat.IconVisible = true;
            this.btnDangXuat.IconZoom = 50D;
            this.btnDangXuat.IsTab = false;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 387);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDangXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDangXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangXuat.selected = false;
            this.btnDangXuat.Size = new System.Drawing.Size(180, 40);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Textcolor = System.Drawing.Color.White;
            this.btnDangXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.user_500px;
            this.pictureBox1.Location = new System.Drawing.Point(36, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaiKhoan.BorderRadius = 0;
            this.btnTaiKhoan.ButtonText = "Tài khoản";
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiKhoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTaiKhoan.Iconimage = global::LibraryManagement.Properties.Resources.edit_user_male_512px;
            this.btnTaiKhoan.Iconimage_right = null;
            this.btnTaiKhoan.Iconimage_right_Selected = null;
            this.btnTaiKhoan.Iconimage_Selected = null;
            this.btnTaiKhoan.IconMarginLeft = 0;
            this.btnTaiKhoan.IconMarginRight = 0;
            this.btnTaiKhoan.IconRightVisible = true;
            this.btnTaiKhoan.IconRightZoom = 0D;
            this.btnTaiKhoan.IconVisible = true;
            this.btnTaiKhoan.IconZoom = 50D;
            this.btnTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTaiKhoan.IsTab = true;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 147);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTaiKhoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTaiKhoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTaiKhoan.selected = true;
            this.btnTaiKhoan.Size = new System.Drawing.Size(180, 40);
            this.btnTaiKhoan.TabIndex = 12;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Textcolor = System.Drawing.Color.White;
            this.btnTaiKhoan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "Quản lý nhân viên";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = global::LibraryManagement.Properties.Resources.admin_settings_male_512px;
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 50D;
            this.btnAdmin.IsTab = true;
            this.btnAdmin.Location = new System.Drawing.Point(0, 347);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(180, 40);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Quản lý nhân viên";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.White;
            this.btnAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThongKe.BorderRadius = 0;
            this.btnThongKe.ButtonText = "Thống kê";
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.DisabledColor = System.Drawing.Color.Gray;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThongKe.Iconimage = global::LibraryManagement.Properties.Resources.bullish_512px;
            this.btnThongKe.Iconimage_right = null;
            this.btnThongKe.Iconimage_right_Selected = null;
            this.btnThongKe.Iconimage_Selected = null;
            this.btnThongKe.IconMarginLeft = 0;
            this.btnThongKe.IconMarginRight = 0;
            this.btnThongKe.IconRightVisible = true;
            this.btnThongKe.IconRightZoom = 0D;
            this.btnThongKe.IconVisible = true;
            this.btnThongKe.IconZoom = 50D;
            this.btnThongKe.IsTab = true;
            this.btnThongKe.Location = new System.Drawing.Point(0, 307);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnThongKe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThongKe.selected = false;
            this.btnThongKe.Size = new System.Drawing.Size(180, 40);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Textcolor = System.Drawing.Color.White;
            this.btnThongKe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLPhieu
            // 
            this.btnQLPhieu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLPhieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLPhieu.BorderRadius = 0;
            this.btnQLPhieu.ButtonText = "Quản lý phiếu";
            this.btnQLPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLPhieu.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhieu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLPhieu.Iconimage = global::LibraryManagement.Properties.Resources.overview_pages_3_512px;
            this.btnQLPhieu.Iconimage_right = null;
            this.btnQLPhieu.Iconimage_right_Selected = null;
            this.btnQLPhieu.Iconimage_Selected = null;
            this.btnQLPhieu.IconMarginLeft = 0;
            this.btnQLPhieu.IconMarginRight = 0;
            this.btnQLPhieu.IconRightVisible = true;
            this.btnQLPhieu.IconRightZoom = 0D;
            this.btnQLPhieu.IconVisible = true;
            this.btnQLPhieu.IconZoom = 50D;
            this.btnQLPhieu.IsTab = true;
            this.btnQLPhieu.Location = new System.Drawing.Point(0, 267);
            this.btnQLPhieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQLPhieu.Name = "btnQLPhieu";
            this.btnQLPhieu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLPhieu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLPhieu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLPhieu.selected = false;
            this.btnQLPhieu.Size = new System.Drawing.Size(180, 40);
            this.btnQLPhieu.TabIndex = 9;
            this.btnQLPhieu.Text = "Quản lý phiếu";
            this.btnQLPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLPhieu.Textcolor = System.Drawing.Color.White;
            this.btnQLPhieu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhieu.Click += new System.EventHandler(this.btnQLPhieu_Click);
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLDocGia.BorderRadius = 0;
            this.btnQLDocGia.ButtonText = "Quản lý độc giả";
            this.btnQLDocGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDocGia.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDocGia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLDocGia.Iconimage = global::LibraryManagement.Properties.Resources.group_foreground_selected_96px;
            this.btnQLDocGia.Iconimage_right = null;
            this.btnQLDocGia.Iconimage_right_Selected = null;
            this.btnQLDocGia.Iconimage_Selected = null;
            this.btnQLDocGia.IconMarginLeft = 0;
            this.btnQLDocGia.IconMarginRight = 0;
            this.btnQLDocGia.IconRightVisible = true;
            this.btnQLDocGia.IconRightZoom = 0D;
            this.btnQLDocGia.IconVisible = true;
            this.btnQLDocGia.IconZoom = 50D;
            this.btnQLDocGia.IsTab = true;
            this.btnQLDocGia.Location = new System.Drawing.Point(0, 227);
            this.btnQLDocGia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLDocGia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLDocGia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLDocGia.selected = false;
            this.btnQLDocGia.Size = new System.Drawing.Size(180, 40);
            this.btnQLDocGia.TabIndex = 8;
            this.btnQLDocGia.Text = "Quản lý độc giả";
            this.btnQLDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDocGia.Textcolor = System.Drawing.Color.White;
            this.btnQLDocGia.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDocGia.Click += new System.EventHandler(this.btnQLDocGia_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLSach.BorderRadius = 0;
            this.btnQLSach.ButtonText = "Quản lý sách";
            this.btnQLSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLSach.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLSach.Iconimage = global::LibraryManagement.Properties.Resources.open_book_96px;
            this.btnQLSach.Iconimage_right = null;
            this.btnQLSach.Iconimage_right_Selected = null;
            this.btnQLSach.Iconimage_Selected = null;
            this.btnQLSach.IconMarginLeft = 0;
            this.btnQLSach.IconMarginRight = 0;
            this.btnQLSach.IconRightVisible = true;
            this.btnQLSach.IconRightZoom = 0D;
            this.btnQLSach.IconVisible = true;
            this.btnQLSach.IconZoom = 50D;
            this.btnQLSach.IsTab = true;
            this.btnQLSach.Location = new System.Drawing.Point(0, 187);
            this.btnQLSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLSach.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQLSach.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLSach.selected = false;
            this.btnQLSach.Size = new System.Drawing.Size(180, 40);
            this.btnQLSach.TabIndex = 7;
            this.btnQLSach.Text = "Quản lý sách";
            this.btnQLSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSach.Textcolor = System.Drawing.Color.White;
            this.btnQLSach.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.Click += new System.EventHandler(this.btnQLSach_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // control_area
            // 
            this.control_area.Location = new System.Drawing.Point(180, 40);
            this.control_area.Name = "control_area";
            this.control_area.Size = new System.Drawing.Size(984, 554);
            this.control_area.TabIndex = 2;
            // 
            // fm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 594);
            this.Controls.Add(this.control_area);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtChucVu;
        private System.Windows.Forms.Label txtUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLSach;
        private Bunifu.Framework.UI.BunifuFlatButton btnThongKe;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLPhieu;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLDocGia;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangXuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnTaiKhoan;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel control_area;
    }
}