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
    public partial class Members : UserControl
    {
        public Members()
        {
            InitializeComponent();
        }

        private void Tile_ViewMembers_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }

        private void Members_Load(object sender, EventArgs e)
        {

        }

        private void Tile_AddMember_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.Show();
        }
    }
}
