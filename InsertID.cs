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
using System.Configuration;
using MonAd;
using System.IO.Ports;


namespace MonAd
{
    public partial class InsertID : Form
    {
        private SerialPort myport;
        private string in_data;
        string PortName = "COM3";
        public InsertID()//SerialPort myport
        {
            InitializeComponent();
        }

        
        AddMember am = new AddMember();

        


        MonAdClass c = new MonAdClass();
        AdminHome ah = new AdminHome();
        string timenow = DateTime.Now.ToLongTimeString();
        string datenow = DateTime.Now.ToLongDateString();
        int enter = 13;

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlConnection con = new SqlConnection(myconnstrng);

        

        private void Pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            
            //First statement
            //Checking if the Member has been recorded time-in in attendance table
            SqlDataAdapter Attsda = new SqlDataAdapter("Select Date,Memberid From tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'", con);
            
            DataTable Attdt = new DataTable();
            Attsda.Fill(Attdt);


            //Second statement
            //Checking if the Member doesn't timed-out yet
            SqlDataAdapter sdanull = new SqlDataAdapter("SELECT Date,Memberid FROM tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "' AND Time_Out is null", con);
            DataTable dtnull = new DataTable();
            sdanull.Fill(dtnull);

            //If both statements are true, then it will be recorded as time-out
            if (Attdt.Rows.Count >= 1 && dtnull.Rows.Count >= 1)
            {
                string upstr = "UPDATE tbl_Attendance SET Time_Out = '" + timenow + "' WHERE Date =  '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'";
                SqlCommand upcmd = new SqlCommand(upstr, con);
                int u = upcmd.ExecuteNonQuery();

                string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Time Out','" + timenow + "')";
                SqlCommand scmd = new SqlCommand(logstr, con);
                int n = scmd.ExecuteNonQuery();

                MessageBox.Show("Successfuly Timed-Out");
                tb_IDnum.Text = "";


            }

            //If the member has not been timed-in yet 
            else if (Attdt.Rows.Count >= 1)
            {
                string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                SqlCommand attcmd = new SqlCommand(attstr, con);
                int m = attcmd.ExecuteNonQuery();

                string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                SqlCommand scmd = new SqlCommand(logstr, con);
                int n = scmd.ExecuteNonQuery();

                MessageBox.Show("ID number successfully inserted");
                tb_IDnum.Text = "";
            }

            //If the member has been timed-out but wants to time-in again
            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Memberid From tbl_info where Memberid = '" + tb_IDnum.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count >= 1)
                {

                    string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                    SqlCommand attcmd = new SqlCommand(attstr, con);
                    int m = attcmd.ExecuteNonQuery();


                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                    MessageBox.Show("ID number successfully inserted");
                    tb_IDnum.Text = "";

                }

                //If the member has not been recorded yet in the database
                else
                {
                    MessageBox.Show("Invalid ID number, Please try again");
                }


            }

        }

        private void InsertID_Load(object sender, EventArgs e)
        {
            con.Open();
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = PortName;
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            myport.DataReceived += myPort_DataReceived;

            if (!myport.IsOpen)
                try
                {
                    myport.Open();

                }
                catch
                {
                    MessageBox.Show("The Fingerprint Scanner device is not found, Please try to reconnect the Device", "Device Connection Error");
                }

        }


        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadExisting();
            this.Invoke(new EventHandler(displaydata_event));

        }
        private void displaydata_event(object sender, EventArgs e)
        {
            tb_IDnum.AppendText(in_data);

        }

        private void Tb_IDnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == enter)
            {
                //First statement
                //Checking if the Member has been recorded time-in in attendance table
                SqlDataAdapter Attsda = new SqlDataAdapter("Select Date,Memberid From tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'", con);
                
                DataTable Attdt = new DataTable();
                Attsda.Fill(Attdt);


                //Second statement
                //Checking if the Member doesn't timed-out yet
                SqlDataAdapter sdanull = new SqlDataAdapter("SELECT Date,Memberid FROM tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "' AND Time_Out is null", con);
                DataTable dtnull = new DataTable();
                sdanull.Fill(dtnull);

                //If both statements are true, then it will be recorded as time-out
                if (Attdt.Rows.Count >= 1 && dtnull.Rows.Count >= 1)
                {
                    string upstr = "UPDATE tbl_Attendance SET Time_Out = '" + timenow + "' WHERE Date =  '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'";
                    SqlCommand upcmd = new SqlCommand(upstr, con);
                    int u = upcmd.ExecuteNonQuery();

                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Time Out','" + timenow + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                    MessageBox.Show("Successfuly Timed-Out");
                    tb_IDnum.Text = "";


                }

                //If the member has not been timed-in yet 
                else if (Attdt.Rows.Count >= 1)
                {
                    string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                    SqlCommand attcmd = new SqlCommand(attstr, con);
                    int m = attcmd.ExecuteNonQuery();

                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                    MessageBox.Show("ID number successfully inserted");
                    tb_IDnum.Text = "";
                }

                //If the member has been timed-out but wants to time-in again
                else
                {

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Memberid From tbl_info where Memberid = '" + tb_IDnum.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);


                    if (dt.Rows.Count >= 1)
                    {

                        string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                        SqlCommand attcmd = new SqlCommand(attstr, con);
                        int m = attcmd.ExecuteNonQuery();


                        string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                        SqlCommand scmd = new SqlCommand(logstr, con);
                        int n = scmd.ExecuteNonQuery();

                        MessageBox.Show("ID number successfully inserted");
                        tb_IDnum.Text = "";

                    }

                    //If the member has not been recorded yet in the database
                    else
                    {
                        MessageBox.Show("Invalid ID number, Please try again");
                    }


                }
            }
        }

        private void Tb_IDnum_TextChanged(object sender, EventArgs e)
        {
            //First statement
            //Checking if the Member has been recorded time-in in attendance table
            SqlDataAdapter Attsda = new SqlDataAdapter("Select Date,Memberid From tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'", con);

            DataTable Attdt = new DataTable();
            Attsda.Fill(Attdt);


            //Second statement
            //Checking if the Member doesn't timed-out yet
            SqlDataAdapter sdanull = new SqlDataAdapter("SELECT Date,Memberid FROM tbl_Attendance WHERE Date = '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "' AND Time_Out is null", con);
            DataTable dtnull = new DataTable();
            sdanull.Fill(dtnull);

            //If both statements are true, then it will be recorded as time-out
            if (Attdt.Rows.Count >= 1 && dtnull.Rows.Count >= 1)
            {
                string upstr = "UPDATE tbl_Attendance SET Time_Out = '" + timenow + "' WHERE Date =  '" + datenow + "' AND Memberid = '" + tb_IDnum.Text + "'";
                SqlCommand upcmd = new SqlCommand(upstr, con);
                int u = upcmd.ExecuteNonQuery();

                string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Time Out','" + timenow + "')";
                SqlCommand scmd = new SqlCommand(logstr, con);
                int n = scmd.ExecuteNonQuery();

                MessageBox.Show("Successfuly Timed-Out");
                tb_IDnum.Text = "";


            }

            //If the member has not been timed-in yet 
            else if (Attdt.Rows.Count >= 1)
            {
                string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                SqlCommand attcmd = new SqlCommand(attstr, con);
                int m = attcmd.ExecuteNonQuery();

                string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                SqlCommand scmd = new SqlCommand(logstr, con);
                int n = scmd.ExecuteNonQuery();

                MessageBox.Show("ID number successfully inserted");
                tb_IDnum.Text = "";
            }

            //If the member has been timed-out but wants to time-in again
            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Memberid From tbl_info where Memberid = '" + tb_IDnum.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count >= 1)
                {

                    string attstr = "INSERT INTO tbl_Attendance  (Date,Memberid,Time_In) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','" + timenow + "')";
                    SqlCommand attcmd = new SqlCommand(attstr, con);
                    int m = attcmd.ExecuteNonQuery();


                    string logstr = "INSERT INTO tbl_History  (Date,UserID,Task,Time) VALUES ('" + datenow + "','" + tb_IDnum.Text + "','Attended','" + timenow + "')";
                    SqlCommand scmd = new SqlCommand(logstr, con);
                    int n = scmd.ExecuteNonQuery();

                    MessageBox.Show("ID number successfully inserted");
                    tb_IDnum.Text = "";

                }

                //If the member has not been recorded yet in the database
                else
                {
                    MessageBox.Show("Invalid ID number, Please try again");
                }


            }
        }
    }
}
