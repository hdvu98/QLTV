using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class LibraryDAO
    {
        public DataTable LoadDataBOOK()
        {
            string sql = "Select * from BOOK";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }
        
        public DataTable LoadDataBOOK_TYPE()
        {
            string sql = "Select BTYPE_ID as N'Mã số', BTYPE AS N'Thể loại'from BOOK_TYPE";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }
        public DataTable LoadDataPUBLISHING_HOUSE()
        {
            string sql = "Select * from PUBLISHING_HOUSE";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

        public DataTable LoadDataREADER()
        {
            string sql = "Select * from READER";
            var rs = ProcessData.LoadData(sql);
            return rs;
        }
        public int InsertBook_type(Book_type bt)
        {
           string sql = string.Format("Insert into BOOK_TYPE values (N'{0}')",bt.BType);

           var rs = ProcessData.Execute(sql);

           return rs;
        }
        public int EditBook_type(Book_type bt)
        {
            string sql = string.Format("Update BOOK_TYPE Set BTYPE = N'{1}' Where BTYPE_ID={0}", bt.Id, bt.BType);
            var rs = ProcessData.Execute(sql);
            return rs;
        }

        public int DeleteBook_type(int id)
        {
            string sql = string.Format("Delete from BOOK_TYPE Where BTYPE_ID = '{0}'", id);
            var rs = ProcessData.Execute(sql);

            return rs;
        }

        public DataTable SearchBook_type(string query)
        {
            string sql = string.Format("Select BTYPE_ID as N'Mã số', BTYPE as N'Thể loại' from BOOK_TYPE Where FREETEXT(BTYPE,N'{0}')", query);
            var rs = ProcessData.LoadData(sql);
            return rs;
        }

    }
}
