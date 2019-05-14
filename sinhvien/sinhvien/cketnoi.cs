using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace sinhvien
{
    class cketnoi
    {
        public string chuoiketnoi="Data Source=.\\SQLSERVER2008;Initial Catalog=sinhvien;Integrated Security=True";
        public DataTable sql_select(string sql_query)
        {
            DataTable dt=new DataTable();
            SqlConnection sql_conn=new SqlConnection(chuoiketnoi);
            sql_conn.Open();
            SqlCommand sql_comm=new SqlCommand(sql_query,sql_conn);
            SqlDataReader sql_data_reader=sql_comm.ExecuteReader();
            dt.Load(sql_data_reader);
            sql_conn.Close();
            return dt;
        }
        public void sql_insert_delete_update(string sql_query)
        {
            SqlConnection sql_conn=new SqlConnection(chuoiketnoi);
            sql_conn.Open();
            SqlCommand sql_comm=new SqlCommand(sql_query,sql_conn);
            int TTH=sql_comm.ExecuteNonQuery();
            sql_conn.Close();

        }
        
    }
}
