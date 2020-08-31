using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAd.MonAdClasses
{
    class MonAdClass
    {
        public string Memberid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Contactno { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Category { get; set; }
        public string Civilstatus { get; set; }
       
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_info";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert (MonAdClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_info (Memberid, Firstname, Lastname, Contactno, Gender, Age, Category, Civilstatus, Address) VALUES (@Memberid, @Firstname, @Lastname, @Contactno, @Gender, @Age, @Category, @Civilstatus, @Address)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Memberid", c.Memberid);
                cmd.Parameters.AddWithValue("@Firstname", c.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", c.Lastname);
                cmd.Parameters.AddWithValue("@Contactno", c.Contactno);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Category", c.Category);
                cmd.Parameters.AddWithValue("@Civilstatus", c.Civilstatus);
                cmd.Parameters.AddWithValue("@Address", c.Address);
               

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                
            }
            return isSuccess;
        }
        public bool Update(MonAdClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_info SET Firstname=@Firstname, Lastname=@Lastname, Contactno=@Contactno, Age=@Age, Address=@Address, Gender=@Gender, Category=@Category, Civilstatus=@Civilstatus, Status=@Status, Attendance=@Attendance WHERE Memberid=@Memberid";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Memberid", c.Memberid);
                cmd.Parameters.AddWithValue("@Firstname", c.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", c.Lastname);
                cmd.Parameters.AddWithValue("@Contactno", c.Contactno);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Category", c.Category);
                cmd.Parameters.AddWithValue("@Civilstatus", c.Civilstatus);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(MonAdClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_info WHERE Memberid=@Memberid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Memberid", c.Memberid);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
