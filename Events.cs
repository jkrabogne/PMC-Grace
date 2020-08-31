using MonAd.MonAdClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonAd
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }
        EventsClass c = new EventsClass();

        public object Me { get; private set; }
        public object PowerPacks { get; private set; }
        public System.Windows.Forms.DataGridViewAutoSizeRowsMode AutoSizeRowsMode { get; set; }

        private void Events_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvEventInfo.DataSource = dt;
        }

        private void PBClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBBack_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void dgvEventInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void PBPrint_Click(object sender, EventArgs e)
        {
            int height = dgvEventInfo.Height;
            dgvEventInfo.Height = dgvEventInfo.RowCount * dgvEventInfo.RowTemplate.Height * 2;
            Bitmap bm = new Bitmap(dgvEventInfo.Width, dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
            dgvEventInfo.Height = height;
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
            Bitmap bm = new Bitmap(this.dgvEventInfo.Width,this.dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0,0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            printDocument1.DefaultPageSettings.Margins.Bottom = 0;
        }

        private void PBpv_Click(object sender, EventArgs e)
        {
            int height = dgvEventInfo.Height;
            dgvEventInfo.Height = dgvEventInfo.RowCount * dgvEventInfo.RowTemplate.Height * 2;
            Bitmap bm = new Bitmap(dgvEventInfo.Width, dgvEventInfo.Height);
            dgvEventInfo.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEventInfo.Width, this.dgvEventInfo.Height));
            dgvEventInfo.Height = height;

 
            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dgvEventInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvEventInfo[0, 0];

            string text = cell.Value.ToString();
            Size textSize = TextRenderer.MeasureText(text, dgvEventInfo.Font);
            int charWidth = textSize.Width / text.Length;
            int charCount = cell.GetContentBounds(cell.RowIndex).Width / charWidth;

            

        }
        void sizeDGV(DataGridView dgv)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dgv.ScrollBars = ScrollBars.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            totalHeight += dgv.Rows.Count * 4;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }
        
    }
}
