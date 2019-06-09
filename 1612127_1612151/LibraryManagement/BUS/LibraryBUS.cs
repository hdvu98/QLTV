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

        public int InsertPublish_House(Publishing_house ph)
        {
            return library.InsertPublish_House(ph);
        }
        
        public int EditPublish_House(Publishing_house ph)
        {
            return library.EditPublish_House(ph);
        }

        public int DeletePublish_House(string id)
        {
            return library.DeletePublish_House(id);
        }

        public DataTable SearchPublish_House(string column,string query)
        {
            return library.SearchPublish_House(column,query);
        }
        public DataTable GetDataNamePH()
        {
            return library.GetDataNamePH();
        }
        public DataTable GetDataBookTypeName()
        {
            return library.GetDataBookTypeName();
        }
        public int InsertReader(Reader rd)
        {
            return library.InsertReader(rd);
        }
        public int EditReader(Reader rd)
        {
            return library.EditReader(rd);
        }
        public int DeleteReader(string id)
        {
            return library.DeleteReader(id);
        }

        public DataTable SearchReader(string column,string query)
        {
            return library.SearchReader(column, query);
        }
        public DataTable GetIDFromNameNXB(string query)
        {
            return library.GetIDFromNameNXB(query);
        }
        public DataTable GetIDFromNameBookType(string query)
        {
            return library.GetIDFromNameBookType(query);
        }
        public int InsertBook(Book b, string ph, int bt)
        {
            return library.InsertBook(b, ph, bt);

        }
        public int EditBook(Book b,string ph,int bt)
        {
            return library.EditBook(b, ph, bt);
        }

        public int DeleteBook(string id)
        {
            return library.DeleteBook(id);
        }

        public DataTable SearchBook(string column, string query)
        {
            return library.SearchBook(column, query);
        }
    }   
}
