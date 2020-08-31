using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MonAd.MonAdClasses;

namespace MonAd.MonAdClasses
{
    class AttendanceClass
    {

        public string Time = DateTime.Now.ToLongTimeString();
        public string Date = DateTime.Now.ToLongDateString();
        MonAdClass mc = new MonAdClass();

        public static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable GetAttendance()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dtatt = new DataTable();

            try
            {
                string query = "SELECT * FROM tbl_Attendance";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dtatt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dtatt;
        }

    }


}