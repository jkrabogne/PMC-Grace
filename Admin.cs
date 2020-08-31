using MonAd.MonAdClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace MonAd
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
        }

        MonAdClass c = new MonAdClass();
        private void PBLogout_Click(object sender, EventArgs e)
        { 
        

            this.Close();
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dgvMemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvMemberInfo.DataSource = dt;
            timer_TimeNow.Start();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_info WHERE Firstname LIKE '%" + keyword + "%' OR Lastname LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvMemberInfo.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        { /*
            c.Memberid = int.Parse(txtMemberid.Text);
            c.Firstname = txtFirstname.Text;
            c.Lastname = txtLastname.Text;
            c.Contactno = txtContactno.Text;
            c.Gender = cbxGender.Text;
            c.Age = txtAge.Text;
            c.Category = txtCat.Text;
            c.Civilstatus = txtCiv.Text;
            c.Address = txtAddress.Text;

            bool success = c.Update(c);
            if (success == true)
            {

                MessageBox.Show("Member has been successfully Updated.");

                DataTable dt = c.Select();
                dgvMemberInfo.DataSource = dt;

                Clear();
            }
            else
            {

                MessageBox.Show("Failed to Update Member.Try Again.");
            } */

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            /*
            c.Memberid = Convert.ToInt32(txtMemberid.Text);
            bool success = c.Delete(c);
            if (success == true)
            {

                MessageBox.Show("Member Successfully Deleted.");


                DataTable dt = c.Select();
                dgvMemberInfo.DataSource = dt;

                Clear();
            }
            else
            {

                MessageBox.Show("Failed To Delete Member. Try Again.");
            }*/

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        public void Clear()
        {
            /*
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtContactno.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            cbxGender.Text = "";
            txtMemberid.Text = "";
            txtCat.Text = "";
            txtCiv.Text = "";*/
        }

        private void dgvMemberInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            int rowIndex = e.RowIndex;
            txtMemberid.Text = dgvMemberInfo.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvMemberInfo.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastname.Text = dgvMemberInfo.Rows[rowIndex].Cells[2].Value.ToString();
            txtContactno.Text = dgvMemberInfo.Rows[rowIndex].Cells[3].Value.ToString();
            txtAge.Text = dgvMemberInfo.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvMemberInfo.Rows[rowIndex].Cells[5].Value.ToString();
            cbxGender.Text = dgvMemberInfo.Rows[rowIndex].Cells[6].Value.ToString();
            txtCat.Text = dgvMemberInfo.Rows[rowIndex].Cells[7].Value.ToString();
            txtCiv.Text = dgvMemberInfo.Rows[rowIndex].Cells[8].Value.ToString();*/

            Member_info mi = new Member_info();

            mi.label_Memberid.Text = dgvMemberInfo.CurrentRow.Cells[0].Value.ToString();
            mi.Show();
        }

        private void PBUpdate_Click(object sender, EventArgs e)
        {
            Update obj = new Update();
            obj.Show();
            this.Hide();
        }

        private void PBPrint_Click(object sender, EventArgs e)
        {
            int height = dgvMemberInfo.Height;
            dgvMemberInfo.Height = dgvMemberInfo.RowCount * dgvMemberInfo.RowTemplate.Height * 2;
            Bitmap bm = new Bitmap(dgvMemberInfo.Width, dgvMemberInfo.Height);
            dgvMemberInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvMemberInfo.Width, this.dgvMemberInfo.Height));
            dgvMemberInfo.Height = height;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "document";
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void PBpv_Click(object sender, EventArgs e)
        {
            int height = dgvMemberInfo.Height;
            dgvMemberInfo.Height = dgvMemberInfo.RowCount * dgvMemberInfo.RowTemplate.Height * 2;
            Bitmap bm = new Bitmap(dgvMemberInfo.Width, dgvMemberInfo.Height);
            dgvMemberInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvMemberInfo.Width, this.dgvMemberInfo.Height));
            dgvMemberInfo.Height = height;

            this.printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvMemberInfo.Width, this.dgvMemberInfo.Height);
            dgvMemberInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvMemberInfo.Width, this.dgvMemberInfo.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
  
        private void DrawRectangle(Pens pens, object p, int v1, object x, int v2, object y, int v3, object width, int v4, object height)
        {
            width = dgvMemberInfo.Columns[0].Width;
            height = dgvMemberInfo.Rows[0].Height;
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            
        }

        private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click_1(object sender, EventArgs e)
        {

        }

        private void Timer_TimeNow_Tick(object sender, EventArgs e)
        {
        }

        private void TxtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_Date_Click(object sender, EventArgs e)
        {

        }
    }
}