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
    public partial class UC_Reader : UserControl
    {
        LibraryBUS library = new LibraryBUS();
        public UC_Reader()
        {
            InitializeComponent();
        }
        public void LoadDataREADER()
        {
            var table = library.LoadDataREADER();
            dataGridView1.DataSource = table;
        }
    }
}
