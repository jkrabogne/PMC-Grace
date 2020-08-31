using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonAd.MonAdClasses;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace MonAd
{
    public partial class AttendanceList : Form
    {
        public AttendanceList()
        {
            InitializeComponent();
        }

        AttendanceClass ac = new AttendanceClass();
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");
        private void AttendanceList_Load(object sender, EventArgs e)
        {
            con.Open();
            timer_DateTime.Start();
            DataTable dt = ac.GetAttendance();
            dg_attendance.DataSource = dt;

            string hisdate = "SELECT DISTINCT Date FROM tbl_Attendance";
            SqlCommand hdtcmd = new SqlCommand(hisdate, con);
            hdtcmd.ExecuteNonQuery();

            DataTable dtdate = new DataTable();
            SqlDataAdapter sdate = new SqlDataAdapter(hdtcmd);
            sdate.Fill(dtdate);

            foreach (DataRow dr in dtdate.Rows)
            {
                cb_Attdate.Items.Add(dr["Date"].ToString());
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_DateTime_Tick(object sender, EventArgs e)
        {
            //label_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Cb_Attdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
