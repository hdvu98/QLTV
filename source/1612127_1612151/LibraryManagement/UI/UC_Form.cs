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
    public partial class UC_Form : UserControl
    {
        string id = "";
        List<string> list2 = new List<string>();
        public delegate string USname();
        public event USname OnUSName = null;
      
        LibraryBUS library = new LibraryBUS();
        public UC_Form()
        {
       
            InitializeComponent();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
            DataTable dt = library.GetIDFromNameBook();
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("BOOK_ID")).ToList();
            foreach (var it in list)
            {
                dropdownMaSach.AddItem(it);
                dropdownMS.AddItem(it);
            }
            DataTable dt2 = library.GetIDFromReader();
            list2 = dt2.AsEnumerable().Select(r => r.Field<string>("READER_ID")).ToList();
            foreach (var it in list2)
            {
                dropdownDocGia.AddItem(it);
                dropdownDG.AddItem(it);
            }
         
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edtMaPhieuTra.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            edtMaNhanVien.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            bunifuDatepicker2.Value = DateTime.Parse(dataGridView4.CurrentRow.Cells[3].Value.ToString());
        }

     
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = library.GetIDFromNameBook();
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("BOOK_ID")).ToList();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ToString() == dataGridView3.CurrentRow.Cells[1].Value.ToString())
                {
                    dropdownMS.selectedIndex = i;
                }
            }
            edtTienPhat.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            DataTable tiencoc = library.GetTienCoc(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            edtTienCoc.Text = tiencoc.Rows[0][0].ToString();
            string maID = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            DataTable madocgia = library.GetMaDocGia(maID);
            
            for(int i =0;i<list2.Count;i++)
            {
                dropdownDG.selectedIndex = i;
                if(dropdownDG.selectedValue == madocgia.Rows[0][0].ToString())
                {
                    break;
                }
            }
        }
          
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = library.GetIDFromNameBook();
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("BOOK_ID")).ToList();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ToString() == dataGridView2.CurrentRow.Cells[1].Value.ToString())
                {
                    dropdownMaSach.selectedIndex = i;
                   
                }
            }
         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = library.GetIDFromReader();
            List<string> list = dt.AsEnumerable().Select(r => r.Field<string>("NAME")).ToList();

            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].ToString() == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                {
                  dropdownDocGia.selectedIndex = i;
                }
            }
         
            edtMaPhieuMuon.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            edtMaNhanVienLap1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            loan_date.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            exp_date.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            edtDatCoc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public void LoadDataBorrowForm()
        {
            library.UpdateGiaTien();
            DataTable dt = library.LoadDataBorrow_Form();
            dataGridView1.DataSource = dt;
        }

        public void LoadDataBorrow_Details(string a)
        {
            DataTable dt = library.LoadDataBorrow_FormDetails(a);
            dataGridView2.DataSource = dt;
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentCell.RowIndex.ToString());
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            DataTable dt = library.LoadDataBorrow_FormDetails(id);
            dataGridView2.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentCell.RowIndex.ToString());
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (CheckC.Checked == true)
            {
                DataTable dt = library.LoadDataEmployee(OnUSName());
                Borrow_Form bf = new Borrow_Form();
                bf.Employee_ID = dt.Rows[0][0].ToString();
                bf.Reader_ID = dropdownDocGia.selectedValue;
                bf.LOAN_date = loan_date.Value.ToString("yyyy/MM/dd");
                bf.EXP_date = exp_date.Value.ToString("yyyy/MM/dd");
                bf.Deposit = edtDatCoc.Text;
                library.InsertBorrowForm(bf);
                LoadDataBorrowForm();
            }

            if (CheckD.Checked == true)
            {
                DataTable dt3 = library.GetIDFromBorrowForm();
                List<string> list = dt3.AsEnumerable().Select(r => r.Field<string>("FORM_ID")).ToList();
                Borrow_Details bd = new Borrow_Details();
                int tam = list.Count();
                bd.Form_ID = id;
                DataTable dt4 = library.GetTienBook(dropdownMaSach.selectedValue);
                bd.Amount = dt4.Rows[0][0].ToString();
                bd.BOOK_ID = dropdownMaSach.selectedValue;
                DataTable check = library.CheckBookIDHaveBorrowDetails(id);
                DataTable soluong = library.GetSoLuongSach(dropdownMaSach.selectedValue);
                string sl = soluong.Rows[0][0].ToString();
                if (int.Parse(sl) == 0)
                {
                    MessageBox.Show("Sách bạn muốn thêm tạm thời không còn");
                    return;
                }
                else if (check.Rows.Count == 0)
                {
                    sl = (int.Parse(sl) - 1).ToString();
                    library.UpDateSoLuongBook(sl, dropdownMaSach.selectedValue);
                    library.InsertBorrowFormDetails(bd);
                    library.UpdateGiaTien();
                    LoadDataBorrowForm();
                    LoadDataBorrow_Details(id);
                }
                else
                {
                    List<string> ch = check.AsEnumerable().Select(r => r.Field<string>("BOOK_ID")).ToList();
                    for (int i = 0; i < ch.Count(); i++)
                    {
                        if (ch[i] == dropdownMaSach.selectedValue)
                        {
                            MessageBox.Show("Dữ liệu sách đã có! Không thể thêm được nữa");
                            return;
                        }
                    }
                    sl = (int.Parse(sl) - 1).ToString();
                    library.UpDateSoLuongBook(sl, dropdownMaSach.selectedValue);
                    library.InsertBorrowFormDetails(bd);
                    library.UpdateGiaTien();
                    LoadDataBorrowForm();
                    LoadDataBorrow_Details(id);

                }
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView1.CurrentCell.RowIndex.ToString());
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
            if (CheckC.Checked == true)
            {
                Borrow_Form bf = new Borrow_Form();
                bf.Form_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bf.Reader_ID = dropdownDocGia.selectedValue;
                bf.LOAN_date = loan_date.Value.ToString("yyyy/MM/dd");
                bf.EXP_date = exp_date.Value.ToString("yyyy/MM/dd");
                bf.Deposit = edtDatCoc.Text;
                library.EditBorrowForm(bf);
                LoadDataBorrowForm();
            }

            if(CheckD.Checked == true)
            {
             
                Borrow_Details bd = new Borrow_Details();
                bd.ID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                bd.Form_ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string masachtamthoi = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                bd.BOOK_ID = dropdownMaSach.selectedValue;

                DataTable dt = library.GetTienBook(dropdownMaSach.selectedValue);
                bd.Amount = dt.Rows[0][0].ToString();

                DataTable soluong = library.GetSoLuongSach(dropdownMaSach.selectedValue);
                string sl = soluong.Rows[0][0].ToString();
                
                DataTable soluong2 = library.GetSoLuongSach(masachtamthoi);
                string sl2 = soluong2.Rows[0][0].ToString();

                DataTable check = library.CheckBookIDHaveBorrowDetails(id);
               
                if (int.Parse(sl) == 0)
                {
                    MessageBox.Show("Sách bạn muốn thay đổi tạm thời không còn");
                    return;
                }
                else 
                {
                    List<string> ch = check.AsEnumerable().Select(r => r.Field<string>("BOOK_ID")).ToList();
                    for (int i = 0; i < ch.Count(); i++)
                    {
                        if (ch[i] == dropdownMaSach.selectedValue)
                        {
                            MessageBox.Show("Dữ liệu sách đã có! Không thể chỉnh sửa được nữa");
                            return;
                        }
                    }
                    sl = (int.Parse(sl) - 1).ToString();
                    library.UpDateSoLuongBook(sl, dropdownMaSach.selectedValue);
                    sl2 = (int.Parse(sl2) + 1).ToString();
                    library.UpDateSoLuongBook(sl2, masachtamthoi);
                    library.EditBorrowFormDetails(bd);
                    library.UpdateGiaTien();
                    LoadDataBorrowForm();
                    LoadDataBorrow_Details(id);
               }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = library.CheckBorrowFormDetailsValid(id);
            string id2 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (CheckC.Checked == true)
            {
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Không xóa được do có dữ liệu liên quan");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;
                        library.DeleteBorrowForm(id);
                        LoadDataBorrowForm();
                    }
                }
              
            }
            if(CheckD.Checked == true)
            {
                string masach = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                DataTable soluong = library.GetSoLuongSach(masach);
                string sl = soluong.Rows[0][0].ToString();
                
                if (MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                library.DeleteBorrowForm_Details(id2);
                sl = (int.Parse(sl) + 1).ToString();
                library.UpDateSoLuongBook(sl, masach);
                library.UpdateGiaTien();
                LoadDataBorrowForm();
                int index = int.Parse(dataGridView1.CurrentCell.RowIndex.ToString());
                string i = dataGridView1.Rows[index].Cells[0].Value.ToString();
                LoadDataBorrow_Details(i);
            }
          }
        public void LoadDataPayForm()
        {
            DataTable dt = library.LoadDataPayForm();
            dataGridView4.DataSource = dt;
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            int index = int.Parse(dataGridView4.CurrentCell.RowIndex.ToString());
            string id = dataGridView4.Rows[index].Cells[0].Value.ToString();
           
            DataTable dt = library.LoadDataPay_FormDetails(id);
            dataGridView3.DataSource = dt;
        }

        private void btnAddphieutra_Click(object sender, EventArgs e)
        {
            if(CheckA.Checked == true)
            {
                Pay_form pf = new Pay_form();
                DataTable dt = library.LoadDataEmployee(OnUSName());
                pf.Employee_id = dt.Rows[0][0].ToString();
           
                library.InsertPayForm(pf);
                LoadDataPayForm();
            }
         
        }

      

       
    }
}