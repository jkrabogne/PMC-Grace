using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MonAd.MonAdClasses;
using System.IO;
using System.IO.Ports;

namespace MonAd
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlConnection con = new SqlConnection(myconnstr);

        private SerialPort myport;
        private string in_data;
        string PortName = "COM3";
        private string dataOut;
        
        string imgLocation = "";
        SqlCommand piccmd;
        

        MonAdClass c = new MonAdClass();

        int Age;
        
        public void MemberID()
        {
            SqlDataAdapter idsda = new SqlDataAdapter("Select TOP 1 Memberid +1 " +
                    "FROM tbl_info " +
                    "ORDER BY Memberid DESC; ", con);

            DataTable iddt = new DataTable();
            idsda.Fill(iddt);


            if (iddt.Rows.Count == 1)
            {
                tb_Memberid.Text = iddt.Rows[0][0].ToString();
            }
            else if (iddt.Rows.Count < 1)
            {
                tb_Memberid.Text = "1";
            }
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myport.ReadExisting();
            this.Invoke(new EventHandler(displaydata_event));
            
        }
        private void displaydata_event(object sender, EventArgs e)
        {
            tb_fpcode.AppendText(in_data);

        }

        private void AddMember_Load(object sender, EventArgs e)
        {
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

            MemberID();

            tb_Memberid.Enabled = false;
            tb_Category.Enabled = false;
            button_Register.Enabled = false;
            con.Open();
            
        }

        public void Clear()
        {
            MemberID();

            tb_Firstname.Text = "";
            tb_Lastname.Text = "";
            tb_Contact.Text = "";
            tb_Age.Text = "";
            tb_Category.Text = "";
            cb_Gender.Text = "";
            cb_CivilStatus.Text = "";
            tb_Address.Text = "";
            tb_fpcode.Text = "";

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Close();
            myport.Close();
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
                c.Memberid = tb_Memberid.Text;
                c.Firstname = tb_Firstname.Text;
                c.Lastname = tb_Lastname.Text;
                c.Contactno = tb_Contact.Text;
                c.Gender = cb_Gender.Text;
                c.Age = tb_Age.Text;
                c.Category = tb_Category.Text;
                c.Civilstatus = cb_CivilStatus.Text;
                c.Address = tb_Address.Text;
                
                byte[] images = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                string regquery = "INSERT INTO tbl_PhyInfo (Memberid,Photo) " +
                                   "VALUES ('" + tb_Memberid.Text + "',@images)";
                piccmd = new SqlCommand(regquery, con);
                piccmd.Parameters.Add(new SqlParameter("@images", images));
                int n = piccmd.ExecuteNonQuery();

                bool sucess = c.Insert(c);
                if (sucess == true)
                {
                    if (n > 0)
                    {
                        MessageBox.Show("New Member Successfully Added");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Failed To Add New Member. Try Again");
                }

        }

        private void Tb_Age_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Age = int.Parse(tb_Age.Text);
                if (Age < 13)
                {
                    tb_Category.Text = "Child";

                }
                else if (Age > 12 && Age < 20)
                {
                    tb_Category.Text = "Youth";
                }
                else if (Age >= 20)
                {
                    tb_Category.Text = "Adult";
                }

            } catch (Exception ex)
            { 

            }finally
            {

            }
        }

        private void Button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog picdialog = new OpenFileDialog();
            picdialog.Filter = "PNG Files (*.png)|*.png|JPG, JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg";

            if(picdialog.ShowDialog() == DialogResult.OK)
            {
                label_proPic.Hide();
                imgLocation = picdialog.FileName.ToString();
                pb_proPic.ImageLocation = imgLocation;
            }
        }

        private void Tb_fpcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Scan_Click(object sender, EventArgs e)
        {
            
            if (tb_Firstname.TextLength == 0 || tb_Lastname.TextLength == 0 || tb_Age.TextLength == 0)
            {
                MessageBox.Show("Please Supply All Fields!!");
            }

            if (tb_Contact.Text.Length < 7)
            {
                MessageBox.Show("Invalid Contact Number!!");
            }
            else
            {
                button_Register.Enabled = true;
                dataOut = tb_Memberid.Text;
                myport.WriteLine(dataOut);

                myport.DataReceived += myPort_DataReceived;

            }
        }
    }
}
