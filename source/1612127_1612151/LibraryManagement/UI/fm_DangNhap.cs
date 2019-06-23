using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace LibraryManagement
{
    public partial class Login : Form
    {
        LibraryBUS library = new LibraryBUS();

        public Login()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this, 15);
           // autoLogin();
           
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
              string username = edtUsername.Text;
              string password = edtPassword.Text;
            login(username, password);

            
        }
        private void login(string username,string pass)
        {
            string encodedPassword = "";
            encodedPassword = encodePassword(pass);
            DataTable dt = library.FindAccount(username, encodedPassword);
            DataTable dt2 = library.FindNameAccount(username);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    List<int> list = dt.AsEnumerable().Select(r => r.Field<int>("ROLE")).ToList();
                    int mabt = list[0];

                    fm_Dashboard cs = new fm_Dashboard();
                    cs.OnGetUserName += delegate { return edtUsername.Text; };
                    cs.OnGetPassWord += delegate { return edtPassword.Text; };
                    cs.OnGetRole += delegate { return mabt; };
                    cs.GetNameAccount += delegate { return dt2.Rows[0][0].ToString(); };
                    cs.SetChucVuAndName();
                    if (checkGhiNhoDN.Checked)
                    {
                        Properties.Settings.Default.username = edtUsername.Text;
                        Properties.Settings.Default.password = encodePassword(edtPassword.Text);
                        Properties.Settings.Default.Save();
                    }
                    this.Hide();
                    cs.ShowDialog();
                    this.Close();

                }
                else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
        private void autoLogin()
        {
            if (Properties.Settings.Default.username.Length>0 )
            {
                DataTable dt = library.FindAccount(Properties.Settings.Default.username, Properties.Settings.Default.password);
                DataTable dt2 = library.FindNameAccount(Properties.Settings.Default.username);
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        List<int> list = dt.AsEnumerable().Select(r => r.Field<int>("ROLE")).ToList();
                        int mabt = list[0];

                        fm_Dashboard cs = new fm_Dashboard();
                        cs.OnGetUserName += delegate { return edtUsername.Text; };
                        cs.OnGetPassWord += delegate { return edtPassword.Text; };
                        cs.OnGetRole += delegate { return mabt; };
                        cs.GetNameAccount += delegate { return dt2.Rows[0][0].ToString(); };
                        cs.SetChucVuAndName();
                        if (checkGhiNhoDN.Checked)
                        {
                            Properties.Settings.Default.username = edtUsername.Text;
                            Properties.Settings.Default.password = encodePassword(edtPassword.Text);
                            Properties.Settings.Default.Save();
                        }
                        this.Hide();
                        cs.ShowDialog();
                        this.Close();

                    }
                    else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
        
           
        }

        string encodePassword(string password)
        {
            string pass = "";
            byte[] buffer = Encoding.UTF8.GetBytes(password);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                pass += buffer[i].ToString("x2");
            }
            return pass;
        }

        private void login_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin.Click += btnLogin_Click;
            }
        }

        private void checkGhiNhoDN_OnChange(object sender, EventArgs e)
        {
           
        }
    }
}
