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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void edtPassword_OnValueChanged(object sender, EventArgs e)
        {
            edtPassword.isPassword = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            fm_Dashboard dashboard = new fm_Dashboard();
            dashboard.Show();
            ///this.Close();
        }
    }
}
