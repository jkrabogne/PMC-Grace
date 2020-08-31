using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using MonAd.MonAdClasses;
using System.IO;
using System.IO.Ports;

namespace MonAd
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {

            InitializeComponent();
            panel_side.Height = button_Dashboard.Height;
            panel_side.Hide();
        }
        AttendanceClass ac = new AttendanceClass();
        private void AdminHome_Load(object sender, EventArgs e)
        {
            //SerialConnectionClass sc = new SerialConnectionClass();

            panel_Menu.Width =  50;
            timer_DateTime.Start();
            attendance1.Hide();
            members1.Hide();

            //Login l = new Login();

        }

        private void Panel_Menu_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }

        private void Panel_Menu_MouseLeave(object sender, EventArgs e)
        {
            panel_Menu.Width = 50;
        }

        private void Pb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_DateTime_Tick(object sender, EventArgs e)
        {

            label_Time.Text = DateTime.Now.ToLongTimeString();
            label_Date.Text = DateTime.Now.ToLongDateString();
        }

        private void button_Members_Click(object sender, EventArgs e)
        {
            members1.Show();
            attendance1.Hide();
            panel_Menu.Width = 50;
        }

        private void Button_Events_Click(object sender, EventArgs e)
        {
            Update upev = new Update();
            upev.Show();
        }

        private void Button_Logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Button_Dashboard_Click(object sender, EventArgs e)
        {
            panel_side.Height = button_Dashboard.Height;
            panel_side.Show();
        }

        private void Attendance1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Attendance_Click(object sender, EventArgs e)
        {
            attendance1.Show();
            members1.Hide();
            panel_Menu.Width = 50;
        }

        private void Button_Dashboard_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }

        private void Button_Members_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }

        private void Button_Attendance_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }

        private void Button_Events_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }

        private void Button_Logout_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }


        private void Button_History_Click(object sender, EventArgs e)
        {
            HistoryLogs hl = new HistoryLogs();
            hl.Show();
        }

        private void Button_History_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 250;
        }


        private void Panel_Workspace_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 50;
        }

        private void Attendance1_MouseHover(object sender, EventArgs e)
        {
            panel_Menu.Width = 50;
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Members1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}