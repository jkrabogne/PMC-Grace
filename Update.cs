using MonAd.MonAdClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonAd
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        EventsClass c = new EventsClass();
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void PBView_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            c.Announcement = txtAnt.Text;
            c.Programs = txtPro.Text;
            c.Calendar_Of_Activities = txtCal.Text;

            bool sucess = c.Insert(c);
            if (sucess == true)
            {
                MessageBox.Show("Successfully Added");

                Clear();
            }
            else
            {
                MessageBox.Show("Failed To Add. Try Again");
            }

            DataTable dt = c.Select();
            dgvEventInfo.DataSource = dt;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvEventInfo.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.Entryno = int.Parse(txtEntryno.Text);
            c.Announcement = txtAnt.Text;
            c.Programs = txtPro.Text;
            c.Calendar_Of_Activities = txtCal.Text;

            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated.");

                DataTable dt = c.Select();
                dgvEventInfo.DataSource = dt;

                Clear();
            }
            else
            {

                MessageBox.Show("Failed to Update.Try Again.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.Entryno = Convert.ToInt32(txtEntryno.Text);

            bool success = c.Delete(c);
            if (success == true)
            {

                MessageBox.Show("Successfully Deleted.");


                DataTable dt = c.Select();
                dgvEventInfo.DataSource = dt;

                Clear();
            }
            else
            {

                MessageBox.Show("Failed To Delete. Try Again.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        public void Clear()
        {
            txtAnt.Text = "";
            txtPro.Text = "";
            txtCal.Text = "";
        }

        private void dgvEventInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtEntryno.Text = dgvEventInfo.Rows[rowIndex].Cells[0].Value.ToString();
            txtAnt.Text = dgvEventInfo.Rows[rowIndex].Cells[1].Value.ToString();
            txtPro.Text = dgvEventInfo.Rows[rowIndex].Cells[2].Value.ToString();
            txtCal.Text = dgvEventInfo.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void PBPrint_Click(object sender, EventArgs e)
        {

            Bitmap bm = new Bitmap(dgvEventInfo.Width, dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
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
            Bitmap bm = new Bitmap(this.dgvEventInfo.Width, this.dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PBpv_Click(object sender, EventArgs e)
        {
            int height = dgvEventInfo.Height;
            dgvEventInfo.Height = dgvEventInfo.RowCount * dgvEventInfo.RowTemplate.Height * 2;
            Bitmap bm = new Bitmap(dgvEventInfo.Width, dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
            dgvEventInfo.Height = height;

            this.printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void TxtEntryno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
