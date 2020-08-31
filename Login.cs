using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonAd.MonAdClasses;
using System.IO;
using System.IO.Ports;

namespace MonAd
{
    public partial class Login : Form
    {
        int attempts = 1;
        /*
        public SerialPort myport;
        private string in_data;
        private string port = "COM3";
        private string LoginID;
        */
        public Login()
        {
            InitializeComponent();

        }

        
        /*private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadExisting();
            this.Invoke(new EventHandler(displaydata_event));

        }
        private void displaydata_event(object sender, EventArgs e)
        {
            tb_LoginID.AppendText(in_data);

        }*/

        HistoryClass hc = new HistoryClass();
        int enter = 13;

        private void Login_Load(object sender, EventArgs e)
        {
         /*   myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = port;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myPort_DataReceived;
            myport.Open();

            if (!myport.IsOpen)
                try
                {
                    myport.Open();
                    
                }
                catch
                {
                    MessageBox.Show("The Fingerprint Scanner device is not found, Please try to reconnect the Device", "Device Connection Error");
                }
                
            
            
    */
            timer_DateTime.Start();
            tb_LoginID.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {

            if (attempts <= 3)
            {
                AdminHome ah = new AdminHome();

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");

                //Login using typing the Password
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From tbl_Login where Username = '" + Username.Text + "'and Password = '" + Password.Text + "'", con);
                con.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + label_Date.Text + "','" + Username.Text + "','" + button_Login.Text + "','" + label_Time.Text + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                        ah.Show();
                        this.Hide();

                }
                else if (attempts == 3)
                {
                    MessageBox.Show("Maximum attempts exceeded,Program will close");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Check your username and password " + attempts + " out of 3 attempts");

                    attempts = attempts + 1;
                    Password.Text = "";
                }

            }
            
        }

        private void Button_tbdisable_Click(object sender, EventArgs e)
        {
            Username.Dispose();
            Password.Dispose();
            label2.Dispose();
            label3.Dispose();

        }

        private void Timer_DateTime_Tick(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Now.ToLongDateString();
            label_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == enter)
            {
                if (attempts <= 3)
                {

                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From tbl_Login where Username = '" + Username.Text + "'and Password = '" + Password.Text + "'", con);
                    con.Open();

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + label_Date.Text + "','" + Username.Text + "','" + button_Login.Text + "','" + label_Time.Text + "')";
                        SqlCommand scmd = new SqlCommand(logstr, con);
                        int n = scmd.ExecuteNonQuery();

                        AdminHome ah = new AdminHome();
                        ah.Show();
                        this.Hide();

                    }

                    else if (attempts == 3)
                    {
                        MessageBox.Show("Maximum attempts exceeded,Program will close");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Check your username and password " + attempts + " out of 3 attempts");

                        attempts = attempts + 1;
                        Password.Text = "";
                    }

                }
            }
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == enter)
            {
                if (attempts <= 3)
                {

                    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From tbl_Login where Username = '" + Username.Text + "'and Password = '" + Password.Text + "'", con);
                    con.Open();

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + label_Date.Text + "','" + Username.Text + "','" + button_Login.Text + "','" + label_Time.Text + "')";
                        SqlCommand scmd = new SqlCommand(logstr, con);
                        int n = scmd.ExecuteNonQuery();

                        AdminHome ah = new AdminHome();
                        ah.Show();
                        this.Hide();

                    }

                    else if (attempts == 3)
                    {
                        MessageBox.Show("Maximum attempts exceeded,Program will close");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Check your username and password " + attempts + " out of 3 attempts");

                        attempts = attempts + 1;
                        Password.Text = "";
                    }

                }
            }
        }

        private void Tb_LoginID_TextChanged(object sender, EventArgs e)
        {
            if (attempts <= 3)
            {
                AdminHome ah = new AdminHome();

                SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=MonAd;Integrated Security=True");

                //Login using FP scanner
                SqlDataAdapter sdafp = new SqlDataAdapter("Select Count (ID) From tbl_Login where ID = '" + tb_LoginID.Text + "'", con);
                con.Open();
                
                DataTable dtfp = new DataTable();
                sdafp.Fill(dtfp);

                if (dtfp.Rows[0][0].ToString() == "1")
                {
                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + label_Date.Text + "','" + tb_LoginID.Text + "','" + button_Login.Text + "','" + label_Time.Text + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                    ah.Show();
                    this.Close();
                    con.Close();

                }
                
                else if (attempts == 3)
                {
                    MessageBox.Show("Maximum attempts exceeded,Program will close");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Check your username and password " + attempts + " out of 3 attempts");

                    attempts = attempts + 1;
                    Password.Text = "";
                }

            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Button_Members_Click(object sender, EventArgs e)
        {
            InsertID ii = new InsertID();

            ii.Show();
        }
    }
    
}
