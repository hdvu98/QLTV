using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class LibraryBUS
    {
        LibraryDAO library = new LibraryDAO();
        public DataTable LoadDataBOOK()
        {
            return library.LoadDataBOOK();
        }

        public DataTable LoadDataBOOK_TYPE()
        {
            return library.LoadDataBOOK_TYPE();
        }

        public DataTable LoadDataPUBLISHING_HOUSE()
        {
            return library.LoadDataPUBLISHING_HOUSE();
        }

        public DataTable LoadDataREADER()
        {
            return library.LoadDataREADER();
        }

        public int InsertBook_type(Book_type bt)
        {
            return library.InsertBook_type(bt);
        }

        public int EditBook_type(Book_type bt)
        {
            return library.EditBook_type(bt);
        }

        public int DeleteBook_type(int id)
        {
            return library.DeleteBook_type(id);
        }

        public DataTable SearchBook_type(string query)
        {
            return library.SearchBook_type(query);
        }
    }
}
