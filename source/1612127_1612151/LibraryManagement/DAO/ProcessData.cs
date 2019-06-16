using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class ProcessData
    {
        public static DataTable LoadData(string sql)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";

            SqlConnection connect = new SqlConnection(path);

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public static int Execute(string sql)
        {
            string path = @"Data Source=.\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True";

            SqlConnection connect = new SqlConnection(path);
            connect.Open();


            SqlCommand command = new SqlCommand(sql, connect);

            var rs = command.ExecuteNonQuery();

            connect.Close();
            return rs;

        }
    }
}
