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

namespace LibraryManagement
{
    public partial class UC_Book : UserControl
    {
        LibraryBUS library = new LibraryBUS();
        public UC_Book()
        {
            InitializeComponent();
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
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

      
    }
}
