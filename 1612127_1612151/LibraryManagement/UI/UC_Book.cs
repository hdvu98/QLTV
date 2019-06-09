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
    public partial class UC_Book : UserControl
    {

        LibraryBUS library = new LibraryBUS();
         public int id = 0;
         string ph_id = "";
        public UC_Book()
        {
            InitializeComponent();
            this.dataTypeOfBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTypeOfBook_CellClick);
            bunifuDropdown1.AddItem("Tên thể loại");
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            string [] items = {"Mã ID","Tên","Địa chỉ","Số ĐT","Email"};
            foreach(var item in items)
            {
                Combobox2.AddItem(item);
            } 
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            DataTable dt = library.GetDataNamePH();
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("NAME")).ToList();
            foreach(var it in list)
            {
                dropdownNXB.AddItem(it);
            }
            DataTable dt2 = library.GetDataBookTypeName();
            List<string> list2 = dt2.AsEnumerable().Select(r => r.Field<string>("BTYPE")).ToList();
            foreach (var it in list2)
            {
                dropdownTheLoai.AddItem(it);
            }
            string[] dulieus = { "Mã ID", "Tên sách", "Tác giả", "Nhà sản xuất", "Tóm tắt" };
            foreach (var item in dulieus)
            {
                bunifuDropdown2.AddItem(item);
            } 
        }
        public void LoadDataBOOK()
        {
            var table = library.LoadDataBOOK();
            dataGridView1.DataSource = table;
        }
        public void LoadDataBOOK_TYPE()
        {
            var table = library.LoadDataBOOK_TYPE();
            dataTypeOfBook.DataSource = table;
        }
        public void LoadDataPUBLISHING_HOUSE()
        {
            var table = library.LoadDataPUBLISHING_HOUSE();
            dataGridView2.DataSource = table;
        }
      
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book_type bt = new Book_type();
            bt.BType = bunifuMaterialTextbox1.Text;
            library.InsertBook_type(bt);
            LoadDataBOOK_TYPE();  
        }
        private void dataTypeOfBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string btype = dataTypeOfBook.CurrentRow.Cells[1].Value.ToString();
            bunifuMaterialTextbox1.Text = btype;
           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Book_type bt = new Book_type();
            int id = int.Parse(dataTypeOfBook.CurrentRow.Cells[0].Value.ToString());
            bt.Id = id;
            bt.BType = bunifuMaterialTextbox1.Text;
            library.EditBook_type(bt);
            LoadDataBOOK_TYPE();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int id = int.Parse(dataTypeOfBook.CurrentRow.Cells[0].Value.ToString());
            library.DeleteBook_type(id);
            LoadDataBOOK_TYPE();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = edtSearch.Text;
            DataTable data = new DataTable();
            data = library.SearchBook_type(query);
            dataTypeOfBook.DataSource = data;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = library.LoadDataBOOK_TYPE();
            dataTypeOfBook.DataSource = data;
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            Publishing_house ph = new Publishing_house();
            ph.Name = edtNXB.Text;
            ph.PH_address = edtAdress.Text;
            ph.Phone_number = edtPhoneNum.Text;
            ph.Email = edtEmail.Text;
            library.InsertPublish_House(ph);
            LoadDataPUBLISHING_HOUSE();  
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string NXB = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            string Address = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            string Phone = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            string Email = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            edtNXB.Text = NXB;
            edtPhoneNum.Text = Phone;
            edtAdress.Text = Address;
            edtEmail.Text = Email;

        }
        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            Publishing_house ph = new Publishing_house();
            string ph_id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ph.PH_Id = ph_id;
            ph.Name = edtNXB.Text;
            ph.Phone_number = edtPhoneNum.Text;
            ph.PH_address = edtAdress.Text;
            ph.Email = edtEmail.Text;
            library.EditPublish_House(ph);
            LoadDataPUBLISHING_HOUSE();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string ph_id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            library.DeletePublish_House(ph_id);
            LoadDataPUBLISHING_HOUSE();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = library.LoadDataPUBLISHING_HOUSE();
            dataGridView2.DataSource = data;
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            string column = "NAME";
            string text = this.Combobox2.selectedValue;
            if (text == "Địa chỉ") {
                column = "PH_ADDRESS";
            }
            if (text == "Mã ID") { 
                column = "PH_ID";
            }
            if (text == "Tên") {
                column = "NAME";
            }
            if (text == "Số ĐT"){
               column = "PHONE_NUMBER";
            }
            if (text == "Email") {
               column = "EMAIL";
            }
   
            string query = Search.Text;
            DataTable data = new DataTable();
            data = library.SearchPublish_House(column, query);
            dataGridView2.DataSource = data;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            edtTenSach.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            edtTacGia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btnNgayXB.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            edtGiaSach.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //string Email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            edtSoLuong.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            edtTomTat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }
        private string PH_ID()
        {

            DataTable dt = library.GetIDFromNameNXB(dropdownNXB.selectedValue);
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("PH_ID")).ToList();
            string maPH = list[0].ToString();
            return maPH;
        }
        private int BT_ID()
        {

            DataTable dt4 = library.GetIDFromNameBookType(dropdownTheLoai.selectedValue);
            List<int> list4 = dt4.AsEnumerable().Select(r => r.Field<int>("BTYPE_ID")).ToList();
            int mabt = list4[0];
            return mabt;
        }
        private void addBook_Click(object sender, EventArgs e)
        {
            string a = PH_ID();
            int c = BT_ID();
            Book b = new Book();
            b.Name = edtTenSach.Text;
            MessageBox.Show(b.Name);
            b.author = edtTacGia.Text;
            b.summary = edtTomTat.Text;
            b.price = float.Parse(edtGiaSach.Text);
            b.amount = edtSoLuong.Text;
            b.publish_year = btnNgayXB.Value.ToString("yyyy/MM/dd");

            library.InsertBook(b, a, c);
            LoadDataBOOK();

        }

        private void EditBook_Click(object sender, EventArgs e)
        {
            string a = PH_ID();
            int c = BT_ID();
            Book b = new Book();
            string ph_id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            b.ph_id= ph_id;
            b.Name = edtTenSach.Text;
            b.author = edtTacGia.Text;
            b.amount = edtSoLuong.Text;
            b.summary = edtTomTat.Text;
            b.price = float.Parse(edtGiaSach.Text);
            b.publish_year = btnNgayXB.Value.ToString("yyyy/MM/dd");
            library.EditBook(b, a, c);
            LoadDataBOOK();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            library.DeleteBook(id);
            LoadDataBOOK();
        }

        private void ViewAllBook_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = library.LoadDataBOOK();
            dataGridView1.DataSource = data;
        
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            string column = "NAME";
            string text = this.bunifuDropdown2.selectedValue;
            if (text == "Tên sách")
            {
                column = "NAME";
            }
            if (text == "Mã ID")
            {
                column = "BOOK_ID";
            }
            if (text == "Nhà sản xuất")
            {
                column = "PH_ID";
            }
            if (text == "Tác giả")
            {
                column = "AUTHOR";
            }
            if (text == "Tóm tắt")
            {
                column = "SUMMARY";
            }

            string query = SBook.Text;
            DataTable data = new DataTable();
            data = library.SearchBook(column, query);
            dataGridView1.DataSource = data;
        }
    }
}
