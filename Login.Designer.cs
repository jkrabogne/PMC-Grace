namespace MonAd
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.button_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_tbdisable = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.tb_LoginID = new System.Windows.Forms.TextBox();
            this.button_Members = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_tbdisable)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(149, 125);
            this.Password.Margin = new System.Windows.Forms.Padding(0);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(201, 22);
            this.Password.TabIndex = 9;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(149, 99);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(201, 20);
            this.Username.TabIndex = 8;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            this.Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(60, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(60, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(116, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(425, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.TabIndex = 12;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button_Login
            // 
            this.button_Login.Activecolor = System.Drawing.Color.Transparent;
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.BorderRadius = 0;
            this.button_Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_Login.ButtonText = "Login";
            this.button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Login.DisabledColor = System.Drawing.Color.Gray;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Login.Iconimage = null;
            this.button_Login.Iconimage_right = null;
            this.button_Login.Iconimage_right_Selected = null;
            this.button_Login.Iconimage_Selected = null;
            this.button_Login.IconMarginLeft = 0;
            this.button_Login.IconMarginRight = 0;
            this.button_Login.IconRightVisible = true;
            this.button_Login.IconRightZoom = 0D;
            this.button_Login.IconVisible = true;
            this.button_Login.IconZoom = 90D;
            this.button_Login.IsTab = false;
            this.button_Login.Location = new System.Drawing.Point(170, 162);
            this.button_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Login.Name = "button_Login";
            this.button_Login.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Login.OnHovercolor = System.Drawing.Color.White;
            this.button_Login.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_Login.selected = false;
            this.button_Login.Size = new System.Drawing.Size(124, 45);
            this.button_Login.TabIndex = 13;
            this.button_Login.Text = "Login";
            this.button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Login.Textcolor = System.Drawing.Color.White;
            this.button_Login.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // button_tbdisable
            // 
            this.button_tbdisable.BackColor = System.Drawing.Color.Transparent;
            this.button_tbdisable.Image = ((System.Drawing.Image)(resources.GetObject("button_tbdisable.Image")));
            this.button_tbdisable.ImageActive = null;
            this.button_tbdisable.Location = new System.Drawing.Point(12, 189);
            this.button_tbdisable.Name = "button_tbdisable";
            this.button_tbdisable.Size = new System.Drawing.Size(43, 38);
            this.button_tbdisable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_tbdisable.TabIndex = 14;
            this.button_tbdisable.TabStop = false;
            this.button_tbdisable.Zoom = 10;
            this.button_tbdisable.Click += new System.EventHandler(this.Button_tbdisable_Click);
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(90, 217);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(55, 13);
            this.label_Date.TabIndex = 15;
            this.label_Date.Text = "Date Now";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(265, 217);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(55, 13);
            this.label_Time.TabIndex = 16;
            this.label_Time.Text = "Time Now";
            // 
            // timer_DateTime
            // 
            this.timer_DateTime.Tick += new System.EventHandler(this.Timer_DateTime_Tick);
            // 
            // tb_LoginID
            // 
            this.tb_LoginID.Location = new System.Drawing.Point(360, 210);
            this.tb_LoginID.Name = "tb_LoginID";
            this.tb_LoginID.Size = new System.Drawing.Size(100, 20);
            this.tb_LoginID.TabIndex = 17;
            this.tb_LoginID.TextChanged += new System.EventHandler(this.Tb_LoginID_TextChanged);
            // 
            // button_Members
            // 
            this.button_Members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_Members.ForeColor = System.Drawing.Color.White;
            this.button_Members.Location = new System.Drawing.Point(377, 181);
            this.button_Members.Name = "button_Members";
            this.button_Members.Size = new System.Drawing.Size(75, 23);
            this.button_Members.TabIndex = 18;
            this.button_Members.Text = "Attendance";
            this.button_Members.UseVisualStyleBackColor = false;
            this.button_Members.Click += new System.EventHandler(this.Button_Members_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(464, 239);
            this.ControlBox = false;
            this.Controls.Add(this.button_Members);
            this.Controls.Add(this.tb_LoginID);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.button_tbdisable);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_tbdisable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Exit;
        private Bunifu.Framework.UI.BunifuFlatButton button_Login;
        private Bunifu.Framework.UI.BunifuImageButton button_tbdisable;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Timer timer_DateTime;
        private System.Windows.Forms.TextBox tb_LoginID;
        private System.Windows.Forms.Button button_Members;
    }
}