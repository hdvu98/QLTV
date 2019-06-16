using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class fm_Dashboard : Form
    {
        public delegate string GetUserName();
        public GetUserName OnGetUserName;

        public delegate string GetPassWord();
        public GetPassWord OnGetPassWord;

        public delegate int GetRole();
        public GetRole OnGetRole;

        public delegate string NameAccount();
        public NameAccount GetNameAccount;
        public fm_Dashboard()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
            btnQLPhieu.selected = true;
            control_area.Controls.Clear();
            control_area.Controls.Add(new UC_Form());

        }
        public string CallPassWord()
        {
            return OnGetPassWord();
        }

        public string Call()
        {
           return OnGetUserName();
        }
        public void SetChucVuAndName()
        {
            if (OnGetRole() == 1) { txtChucVu.Text = "Admin"; }
            if (OnGetRole() == 0) { 
                txtChucVu.Text = "Nhân viên"; 
                btnAdmin.Visible = false;
                btnDangXuat.Location  = new Point(0,347);
               
            }
            txtUser.Text = GetNameAccount();
        }
    
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            UC_Profile pf = new UC_Profile();
            pf.OnUSName += delegate { return Call(); };
            pf.OnPassWord += delegate { return CallPassWord(); };
            control_area.Controls.Add(pf);
            toggler(sender);
            pf.LoadDataEmployee();

        }
        void toggler(Object sender)
        {
            btnTaiKhoan.selected = false;
            btnQLSach.selected = false;
            btnQLPhieu.selected = false;
            btnQLDocGia.selected = false;
            btnDangXuat.selected = false;
            btnThongKe.selected = false;
            ((Bunifu.Framework.UI.BunifuFlatButton)sender).selected = true;

        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            UC_Book uc_book = new UC_Book();
            control_area.Controls.Add(uc_book);
            toggler(sender);
            uc_book.LoadDataBOOK();
            uc_book.LoadDataBOOK_TYPE();
            uc_book.LoadDataPUBLISHING_HOUSE();
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            UC_Reader uc_reader = new UC_Reader();
            control_area.Controls.Add(uc_reader);
            toggler(sender);
            uc_reader.LoadDataREADER();
      
        }

        private void btnQLPhieu_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            control_area.Controls.Add(new UC_Form());
            toggler(sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            control_area.Controls.Add(new UC_Stat());
            toggler(sender);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
   
            control_area.Controls.Clear();
            UC_Admin uc_admin = new UC_Admin();
            uc_admin.OnUSName += delegate { return Call(); };
            control_area.Controls.Add(uc_admin);
            toggler(sender);
            uc_admin.LoadDataNhanVien();
           
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
            this.Hide();
            Login login = new Login(); 
            login.ShowDialog();
            this.Close();
        }
    }
}
