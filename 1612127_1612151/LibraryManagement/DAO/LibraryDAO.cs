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
            string sql = "Select * from BOOK_TYPE";
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
    }
}
