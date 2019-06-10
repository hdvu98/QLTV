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
    public partial class UC_Profile : UserControl
    {
        LibraryBUS library = new LibraryBUS();

       
        public UC_Profile()
        {
            InitializeComponent();

          
        }
        public void LoadDataEmployee()
        {
            //Login lg = new Login();
            //string us = lg.getUsername();
            //MessageBox.Show(us);

           // DataTable data = library.LoadDataEmployee();
            
        }
    }
}
