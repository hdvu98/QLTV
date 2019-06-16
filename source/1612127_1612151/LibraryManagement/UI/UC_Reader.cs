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

namespace LibraryManagement
{
    public partial class UC_Reader : UserControl
    {
        LibraryBUS library = new LibraryBUS();
        string id = "";
        public UC_Reader()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            string[] items = { "Mã ID", "Tên độc giả","Giới tính","Số điện thoại","Địa chỉ","Email" };
            foreach (var item in items)
            {
                bunifuDropdown2.AddItem(item);
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            btnNgaySinh.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            edtAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            edtPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            edtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if(gender.ToLower()=="nam")
            {
                Nam.Checked = true;
              
            }
            else if(gender.ToLower()=="nữ")
            {
                nu.Checked = true;
            }
           
        }
        public void LoadDataREADER()
        {
            var table = library.LoadDataREADER();
            dataGridView1.DataSource = table;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();
            rd.Name = edtName.Text;
            rd.Phone_number = edtPhone.Text;
            rd.Email = edtEmail.Text;
            rd.Addres = edtAddress.Text;
            if (Nam.Checked == true) { rd.Gender = "Nam"; }
            if (nu.Checked == true) { rd.Gender = "Nữ"; }
            rd.Date_of_birth = btnNgaySinh.Value.ToString("yyyy/MM/dd");
            library.InsertReader(rd);
            LoadDataREADER();  
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            rd.Reader_Id = id;
            rd.Name = edtName.Text;
            rd.Phone_number = edtPhone.Text;
            rd.Email = edtEmail.Text;
            rd.Addres = edtAddress.Text;
            if (Nam.Checked == true) { rd.Gender = "Nam"; }
            if (nu.Checked == true) { rd.Gender = "Nữ"; }
            rd.Date_of_birth = btnNgaySinh.Value.ToString("yyyy/MM/dd");
            library.EditReader(rd);
            LoadDataREADER();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            library.DeleteReader(id);
            LoadDataREADER();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            string column = "NAME";
            string text = this.bunifuDropdown2.selectedValue;
            if (text == "Mã ID")
            {
                column = "READER_ID";
            }
            if (text == "Tên độc giả")
            {
                column = "NAME";
            }
            if (text == "Giới tính")
            {
                column = "GENDER";
            }
            if (text == "Số điện thoại")
            {
                column = "PHONE_NUMBER";
            }
            if (text == "Email")
            {
                column = "EMAIL";
            }
            string query = edtSearch.Text;
            DataTable data = new DataTable();
            data = library.SearchReader(column, query);
            dataGridView1.DataSource = data;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = library.LoadDataREADER();
            dataGridView1.DataSource = data;
        }

        private void nu_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
