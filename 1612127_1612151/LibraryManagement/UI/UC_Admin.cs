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
    public partial class UC_Admin : UserControl
    {
        public delegate string USname();
        public event USname OnUSName = null;
        LibraryBUS library = new LibraryBUS();
        public UC_Admin()
        {
            InitializeComponent();
           
        }

        public void LoadDataNhanVien()
        {
            DataTable dt = library.LoadDataNhanVien(OnUSName());
            dataGridView1.DataSource = dt;
        }

        public void GetNameEmployee()
        {
            DataTable dt = library.LoadDataEmployee(OnUSName());
            string name = dt.Rows[0][2].ToString();
          
     
        }
      
    }
}
