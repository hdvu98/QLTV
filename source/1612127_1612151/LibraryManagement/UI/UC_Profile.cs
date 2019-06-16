using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagement.DAO;
using LibraryManagement.DTO;
using System.Security.Cryptography;
namespace LibraryManagement
{
    public partial class UC_Profile : UserControl
    {
        public delegate string USname();
        public event USname OnUSName = null;

        public delegate string PassWord();
        public event PassWord OnPassWord = null;

        LibraryBUS library = new LibraryBUS();

       
        public UC_Profile()
        {
            InitializeComponent();
            edtPassword.isPassword = true;
            edtNewpassword.isPassword = true;
            edtRepassword.isPassword = true;
        }
       
        public void LoadDataEmployee()
        {
            DataTable dt = library.LoadDataEmployee(OnUSName());
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    edtID.Text = dt.Rows[0][0].ToString();
                    edtName.Text = dt.Rows[0][2].ToString();
                    edtAddress.Text = dt.Rows[0][3].ToString();
                    edtEmail.Text = dt.Rows[0][4].ToString();
                    edtPhone.Text = dt.Rows[0][5].ToString();
                    edtData_of_birth.Value = DateTime.Parse(dt.Rows[0][6].ToString());
                    if (dt.Rows[0][7].ToString().ToLower() == "nam") { nam.Checked = true; }
                    if (dt.Rows[0][7].ToString().ToLower() == "nữ") { nu.Checked = true; }
                }
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            ep.Employee_ID = edtID.Text;
            ep.UserName = OnUSName();
            ep.Name = edtName.Text;
            ep.Employee_Addres = edtAddress.Text;
            ep.Email = edtEmail.Text;
            ep.Phone_number = edtPhone.Text;
            if (nam.Checked == true) { ep.Gender = "Nam"; }
            if (nu.Checked == true) { ep.Gender = "Nữ"; }
            ep.Date_of_birth = edtData_of_birth.Value.ToString("yyyy/MM/dd");
            library.EditEmployee(ep);
            LoadDataEmployee();
            MessageBox.Show("Cập nhật thông tin thành công");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable data = library.LoadDataAccount(OnUSName());
            string pass = data.Rows[0][0].ToString();
            string pw = "";
            byte[] buffer = Encoding.UTF8.GetBytes(edtPassword.Text);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            for (int i = 0; i < buffer.Length; i++)
            {
                pw += buffer[i].ToString("x2");
            }
            
            string a = edtNewpassword.Text;
            string b = edtRepassword.Text;
            if (pass != pw) { 
                MessageBox.Show("Mật khẩu hiện tại không đúng");
            }
            else if(a.Length < 5){
                MessageBox.Show("Độ dài mật khẩu phải nhiều hơn 5 kí tự");
            }
            else 
            {
                if (a != b) MessageBox.Show("Mật khẩu nhập lại không đúng");
                else
                {
                    string savepass = "";
                    byte[] buffer1 = Encoding.UTF8.GetBytes(a);
                    MD5CryptoServiceProvider md1 = new MD5CryptoServiceProvider();
                    buffer1 = md1.ComputeHash(buffer1);
                    for (int i = 0; i < buffer1.Length; i++)
                    {
                        savepass += buffer1[i].ToString("x2");
                    }
                    library.EditPasswordAccount(OnUSName(), savepass);
                    MessageBox.Show("Cập nhật mật khẩu thành công");
                }
            }
        }

        private void edtPassword_OnValueChanged(object sender, EventArgs e)
        {
            edtPassword.isPassword = true;
        }

        private void edtNewpassword_OnValueChanged(object sender, EventArgs e)
        {
            edtNewpassword.isPassword = true;
        }

        private void edtRepassword_OnValueChanged(object sender, EventArgs e)
        {
            edtRepassword.isPassword = true;
        }

     
    }
}
