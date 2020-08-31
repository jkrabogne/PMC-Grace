using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonAd
{
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
        }
        
        private void Tile_ViewAttendance_MouseHover(object sender, EventArgs e)
        {
        }

        private void Tile_ViewAttendance_Click(object sender, EventArgs e)
        {
            AttendanceList al = new AttendanceList();
            al.Show();
        }

        private void Tile_Insert_Click(object sender, EventArgs e)
        {
            InsertID InsID = new InsertID();
            InsID.Show();
        }
    }
}
