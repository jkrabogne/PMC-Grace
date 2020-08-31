using System;
using MonAd.MonAdClasses;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace MonAd
{
    public partial class Member_info : Form
    {
        MonAdClass c = new MonAdClass();
        SqlCommand piccmd;
        byte[] images = null;
        SqlConnection conn = new SqlConnection(myconn);

        public Member_info()
        {
            InitializeComponent();
        }

        static string myconn = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void Member_info_Load(object sender, EventArgs e)
        {
            conn.Open();
            string InfoQuery = "Select * From tbl_info WHERE Memberid = '" + label_Memberid.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(InfoQuery, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            tb_firstname.Text = dt.Rows[0][1].ToString();
            tb_lastname.Text = dt.Rows[0][2].ToString();
            tb_contact.Text = dt.Rows[0][3].ToString();
            tb_age.Text = dt.Rows[0][4].ToString();
            tb_address.Text = dt.Rows[0][5].ToString();
            tb_gender.Text = dt.Rows[0][6].ToString();
            tb_category.Text = dt.Rows[0][7].ToString();
            tb_civilstatus.Text = dt.Rows[0][8].ToString();

            string picQuery = "Select Photo From tbl_PhyInfo WHERE Memberid = '" + label_Memberid.Text + "'";
            piccmd = new SqlCommand(picQuery,conn);
            SqlDataReader DataRead = piccmd.ExecuteReader();
            DataRead.Read();

            if(DataRead.HasRows)
            {
                byte[] images = (byte[])DataRead[0];
            
                if (images == null)
                {
                    pic_MemberPhoto.Image = null;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(images);
                    pic_MemberPhoto.Image = Image.FromStream(mstream);
                    label_NoData.Hide();
                }
            }
        }

        private void Member_info_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
