using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Borrow_Form
    {
        public string Form_ID { get; set; }
        public string Reader_ID {get;set;}
        public string Employee_ID { get; set; }
        public string LOAN_date { get; set; }
        public string EXP_date { get; set; }
        public string Deposit { get; set; }
    }
}
