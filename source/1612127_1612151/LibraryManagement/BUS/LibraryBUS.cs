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

        public DataTable CheckBook_typeValid(string query)
        {
            return library.CheckBook_typeValid(query);
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

        public DataTable CheckPublish_house(string query)
        {
            return library.CheckPublish_house(query);
        }
        public int DeletePublish_House(string id)
        {
            return library.DeletePublish_House(id);
        }

        public DataTable SearchPublish_House(string column, string query)
        {
            return library.SearchPublish_House(column, query);
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

        public DataTable SearchReader(string column, string query)
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
        public int EditBook(Book b, string ph, int bt)
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

        public DataTable FindAccount(string username, string password)
        {
            return library.FindAccount(username, password);
        }

        public DataTable LoadDataEmployee(string username)
        {
            return library.LoadDataEmployee(username);
        }

        public int EditEmployee(Employee ep)
        {
            return library.EditEmployee(ep);
        }

        public DataTable LoadDataAccount(string us)
        {
            return library.LoadDataAccount(us);
        }
        public int EditPasswordAccount(string us, string pw)
        {
            return library.EditPasswordAccount(us, pw);
        }

        public DataTable LoadDataNhanVien(string username)
        {
            return library.LoadDataNhanVien(username);
        }

        public DataTable FindNameAccount(string username)
        {
            return library.FindNameAccount(username);
        }

        public DataTable LoadDataBorrow_Form()
        {
            return library.LoadDataBorrow_Form();
        }
        public DataTable LoadDataBorrow_FormDetails(string form_id)
        {
            return library.LoadDataBorrow_FormDetails(form_id);
        }
        public DataTable GetIDFromNameBook()
        {
            return library.GetIDFromNameBook();
        }
        public DataTable GetIDFromReader()
        {
            return library.GetIDFromReader();
        }
        public int InsertBorrowForm(Borrow_Form bf)
        {
            return library.InsertBorrowForm(bf);
        }
        public int InsertBorrowFormDetails(Borrow_Details bd)
        {
            return library.InsertBorrowFormDetails(bd);
        }
        public DataTable GetIDFromBorrowForm()
        {
            return library.GetIDFromBorrowForm();
        }
        public int EditBorrowForm(Borrow_Form bf)
        {
           return library.EditBorrowForm(bf);
        }
        public int EditBorrowFormDetails(Borrow_Details bd)
        {
            return library.EditBorrowFormDetails(bd);
        }
        public DataTable CheckBorrowFormDetailsValid(string query)
        {
            return library.CheckBorrowFormDetailsValid(query);
        }
        public int DeleteBorrowForm_Details(string query)
        {
            return library.DeleteBorrowForm_Details(query);
        }
        public int DeleteBorrowForm(string query)
        {
            return library.DeleteBorrowForm(query);
        }
        public DataTable LoadDataPayForm()
        {
            return library.LoadDataPayForm();
        }
        public DataTable GetTienBook(string query)
        {
            return library.GetTienBook(query);
        }
        public int UpdateGiaTien()
        {
            return library.UpdateGiaTien();
        }

        public int UpdateTienCoc()
        {
            return library.UpdateTienCoc();
        }

        public DataTable LoadDataPay_FormDetails(string payformId)
        {
            return library.LoadDataPay_FormDetails(payformId);
        }
        public DataTable CheckBookIDHaveBorrowDetails(string book_id)
        {
            return library.CheckBookIDHaveBorrowDetails(book_id);
        }
        public DataTable GetSoLuongSach(string query)
        {
            return library.GetSoLuongSach(query);
        }
        public int UpDateSoLuongBook(string soluong, string masach)
        {
            return library.UpDateSoLuongBook(soluong, masach);
        }
        public DataTable GetTienCoc(string id)
        {
            return library.GetTienCoc(id);
        }
        public DataTable GetMaDocGia(string id) 
        {
            return library.GetMaDocGia(id);
        }
        public int InsertPayForm(Pay_form pf)
        {
            return library.InsertPayForm(pf);
        }
    }
}
