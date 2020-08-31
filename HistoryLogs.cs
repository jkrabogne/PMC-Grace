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
using System.Data.SqlClient;
using System.Data.Sql;

namespace MonAd
{
    public partial class HistoryLogs : Form
    {
        public HistoryLogs()
        {
            InitializeComponent();
        }

        HistoryClass hc = new HistoryClass();
        SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");

        private void Pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryLogs_Load(object sender, EventArgs e)
        {
            con.Open();

            DataTable dt = hc.GetHistory();
            dg_HLogs.DataSource = dt;

            string hisdate = "SELECT DISTINCT Date FROM tbl_History";
            SqlCommand hdtcmd = new SqlCommand(hisdate, con);
            hdtcmd.ExecuteNonQuery();

            DataTable dtdate = new DataTable();
            SqlDataAdapter sdate = new SqlDataAdapter(hdtcmd);
            sdate.Fill(dtdate);

            foreach (DataRow dr in dtdate.Rows)
            {
                cb_Date.Items.Add(dr["Date"].ToString());
            }
        }


        private void Button_clear_Click(object sender, EventArgs e)
        {
            string clrstr = "DROP TABLE tbl_History";
            SqlCommand clrcmd = new SqlCommand(clrstr, con);
            int c = clrcmd.ExecuteNonQuery();

            try
            {
                string clrstrb = "CREATE TABLE tbl_History (" +
                    "Entryno int identity(1,1)," +
                    "Date varchar(50)," +
                    "UserID varchar(50)," +
                    "Task varchar(50)," +
                    "Time varchar(50) " +
                    ")";
                SqlCommand clrcmdb = new SqlCommand(clrstrb, con);
                int cb = clrcmdb.ExecuteNonQuery();

                MessageBox.Show("History Logs are Successfuly Cleared!");
                this.Hide();

            }
            catch (Exception ex)
            {

            }
        }

        private void Cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

            string AllHistory = "All History";
            AllHistory = cb_Date.ToString();

            if (cb_Date.SelectedItem.ToString() == "All History")
            {
                HistoryLogs hl = new HistoryLogs();
                this.Close();
                hl.Show();

            }
            else
            {
                string hisdate = "SELECT Entryno,UserID,Task,Time FROM tbl_History WHERE Date = '" + cb_Date.SelectedItem.ToString() + "' ORDER BY Entryno";
                SqlCommand hdtcmd = new SqlCommand(hisdate, con);
                hdtcmd.ExecuteNonQuery();

                DataTable dtdate = new DataTable();
                SqlDataAdapter sdate = new SqlDataAdapter(hdtcmd);
                sdate.Fill(dtdate);

                foreach (DataRow dr in dtdate.Rows)
                {
                    dg_HLogs.DataSource = dtdate;
                }

            }
        }
    }
}
