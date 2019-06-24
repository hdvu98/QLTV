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
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;

namespace LibraryManagement
{
    public partial class UC_Stat : UserControl
    {
        LibraryBUS library = new LibraryBUS();
        public UC_Stat()
        {
            InitializeComponent();
            DatePickerFromChart.Format = DateTimePickerFormat.Custom;
            DatePickerFromChart.CustomFormat = "yyyy-MM-dd";

            DatePickerToChart.Format = DateTimePickerFormat.Custom;
            DatePickerToChart.CustomFormat = "yyyy-MM-dd";

            MonthPickerChart.Format = DateTimePickerFormat.Custom;
            MonthPickerChart.CustomFormat = "M/yyyy";

            DatePickerFromStat.Format = DateTimePickerFormat.Custom;
            DatePickerFromStat.CustomFormat = "yyyy-MM-dd";

            DatePickerToStat.Format = DateTimePickerFormat.Custom;
            DatePickerToStat.CustomFormat = "yyyy-MM-dd";

            MonthPickerStat.Format = DateTimePickerFormat.Custom;
            MonthPickerStat.CustomFormat = "M/yyyy";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            if(radioButtonNgay.Checked)
            {
                tableName.Text = "THỐNG KÊ LƯỢNG PHIẾU MƯỢN TỪ NGÀY "+DatePickerFromStat.Text.ToString()+" TỚI NGÀY "+DatePickerToStat.Text.ToString();
                dataGridView1.DataSource = library.thongKePhieuMuonTheoNgay(DatePickerFromStat.Text, DatePickerToStat.Text);
            }
            else
            {
                var date = MonthPickerStat.Text.ToString();
                var index = date.Split('/');
                string month = null; 
                string year = null;
                if(index.Length==2)
                {
                    month = index[0];
                    year = index[1];
                }

                tableName.Text = "THỐNG KÊ LƯỢNG PHIẾU MƯỢN THEO THÁNG "+MonthPickerStat.Text.ToString();
                dataGridView1.DataSource = library.thongKePhieuMuonTheoThang(month, year);
            }
           
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            DataTable rs = null;
            if (radioButtonNgay2.Checked)
            {
                rs = library.thongKePhieuMuonTheoNgay(DatePickerFromChart.Text, DatePickerToChart.Text);
            }
            else
            {
                var date = MonthPickerChart.Text.ToString();
                var index = date.Split('/');
                string month = null;
                string year = null;
                if (index.Length == 2)
                {
                    month = index[0];
                    year = index[1];
                }

                rs = library.thongKePhieuMuonTheoThang(month, year);
            }

            var arrayNames = (from DataColumn x in rs.Columns
                              select x.ColumnName).ToArray();




        }

    }
}
