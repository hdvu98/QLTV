using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Book
    {
        public string Book_Id { get; set; }
        public string Name { get; set; }
        public string author { get; set; }
        public string btype_id { get; set; }
        public string ph_id { get; set; }
        public float price { get; set; }
        public string publish_year { get; set; }
        public string amount { get; set; }
        public string summary { get; set; }
    }
}
