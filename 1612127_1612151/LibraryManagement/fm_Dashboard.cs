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
        public fm_Dashboard()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
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
            control_area.Controls.Add(new UC_Profile());
            toggler(sender);
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
            control_area.Controls.Add(new UC_Book());
            toggler(sender);
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            control_area.Controls.Clear();
            control_area.Controls.Add(new UC_Reader());
            toggler(sender);
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
            control_area.Controls.Add(new UC_Admin());
            toggler(sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
        
            Close();
        }
    }
}
