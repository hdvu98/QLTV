using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Borrow_Details
    {
        public string ID { get; set; }
        public string Form_ID { get; set; }
        public string BOOK_ID { get; set; }
        public string Amount { get; set; }
    }
}
