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
        public UC_Book()
        {
            InitializeComponent();
            this.dataTypeOfBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTypeOfBook_CellClick);
            bunifuDropdown1.AddItem("Tên thể loại");
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

    }
}
