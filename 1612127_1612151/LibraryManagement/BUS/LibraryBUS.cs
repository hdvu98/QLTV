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
    }
}
