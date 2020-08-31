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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            Login l = new Login();
            if (panel2.Width >= 600) {

                timer1.Stop();
                l.Show();
                this.Hide();           
             } else if (panel2.Width < 600)
            {
                l.Hide();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
