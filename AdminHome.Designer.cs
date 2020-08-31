namespace MonAd
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_PMCGrace = new System.Windows.Forms.Label();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.pb_Minimized = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Events = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Attendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button_Members = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_side = new System.Windows.Forms.Panel();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.button_Dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.panel_Workspace = new System.Windows.Forms.Panel();
            this.members1 = new MonAd.Members();
            this.attendance1 = new MonAd.Attendance();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.panel_Workspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_Top.Controls.Add(this.label_Time);
            this.panel_Top.Controls.Add(this.label_Date);
            this.panel_Top.Controls.Add(this.label_PMCGrace);
            this.panel_Top.Controls.Add(this.pb_Exit);
            this.panel_Top.Controls.Add(this.pb_Minimized);
            this.panel_Top.Controls.Add(this.pictureBox1);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1002, 125);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Top_Paint);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.ForeColor = System.Drawing.Color.White;
            this.label_Time.Location = new System.Drawing.Point(654, 92);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(80, 21);
            this.label_Time.TabIndex = 6;
            this.label_Time.Text = "TimeNow";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.Color.White;
            this.label_Date.Location = new System.Drawing.Point(333, 92);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(78, 21);
            this.label_Date.TabIndex = 2;
            this.label_Date.Text = "DateNow";
            // 
            // label_PMCGrace
            // 
            this.label_PMCGrace.AutoSize = true;
            this.label_PMCGrace.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PMCGrace.ForeColor = System.Drawing.Color.White;
            this.label_PMCGrace.Location = new System.Drawing.Point(372, 12);
            this.label_PMCGrace.Name = "label_PMCGrace";
            this.label_PMCGrace.Size = new System.Drawing.Size(317, 40);
            this.label_PMCGrace.TabIndex = 5;
            this.label_PMCGrace.Text = "PMC-Grace Montalban";
            // 
            // pb_Exit
            // 
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(955, 12);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(33, 33);
            this.pb_Exit.TabIndex = 4;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.Pb_Exit_Click);
            // 
            // pb_Minimized
            // 
            this.pb_Minimized.Image = ((System.Drawing.Image)(resources.GetObject("pb_Minimized.Image")));
            this.pb_Minimized.Location = new System.Drawing.Point(917, 12);
            this.pb_Minimized.Name = "pb_Minimized";
            this.pb_Minimized.Size = new System.Drawing.Size(32, 33);
            this.pb_Minimized.TabIndex = 3;
            this.pb_Minimized.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_Menu.Controls.Add(this.button_History);
            this.panel_Menu.Controls.Add(this.button_Logout);
            this.panel_Menu.Controls.Add(this.button_Events);
            this.panel_Menu.Controls.Add(this.button_Attendance);
            this.panel_Menu.Controls.Add(this.button_Members);
            this.panel_Menu.Controls.Add(this.panel_side);
            this.panel_Menu.Controls.Add(this.pb_Logo);
            this.panel_Menu.Controls.Add(this.button_Dashboard);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(50, 700);
            this.panel_Menu.TabIndex = 1;
            this.panel_Menu.MouseLeave += new System.EventHandler(this.Panel_Menu_MouseLeave);
            this.panel_Menu.MouseHover += new System.EventHandler(this.Panel_Menu_MouseHover);
            // 
            // button_History
            // 
            this.button_History.Activecolor = System.Drawing.Color.Transparent;
            this.button_History.BackColor = System.Drawing.Color.Transparent;
            this.button_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_History.BorderRadius = 0;
            this.button_History.ButtonText = "History Logs";
            this.button_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_History.DisabledColor = System.Drawing.Color.Gray;
            this.button_History.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_History.ForeColor = System.Drawing.Color.White;
            this.button_History.Iconcolor = System.Drawing.Color.Transparent;
            this.button_History.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_History.Iconimage")));
            this.button_History.Iconimage_right = null;
            this.button_History.Iconimage_right_Selected = null;
            this.button_History.Iconimage_Selected = null;
            this.button_History.IconMarginLeft = 11;
            this.button_History.IconMarginRight = 0;
            this.button_History.IconRightVisible = true;
            this.button_History.IconRightZoom = 0D;
            this.button_History.IconVisible = true;
            this.button_History.IconZoom = 80D;
            this.button_History.IsTab = false;
            this.button_History.Location = new System.Drawing.Point(0, 300);
            this.button_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_History.Name = "button_History";
            this.button_History.Normalcolor = System.Drawing.Color.Transparent;
            this.button_History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_History.OnHoverTextColor = System.Drawing.Color.White;
            this.button_History.selected = false;
            this.button_History.Size = new System.Drawing.Size(250, 45);
            this.button_History.TabIndex = 7;
            this.button_History.Text = "History Logs";
            this.button_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_History.Textcolor = System.Drawing.Color.White;
            this.button_History.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_History.Click += new System.EventHandler(this.Button_History_Click);
            this.button_History.MouseHover += new System.EventHandler(this.Button_History_MouseHover);
            // 
            // button_Logout
            // 
            this.button_Logout.Activecolor = System.Drawing.Color.Transparent;
            this.button_Logout.BackColor = System.Drawing.Color.Transparent;
            this.button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Logout.BorderRadius = 0;
            this.button_Logout.ButtonText = "Logout";
            this.button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logout.DisabledColor = System.Drawing.Color.Gray;
            this.button_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.Color.White;
            this.button_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Logout.Iconimage")));
            this.button_Logout.Iconimage_right = null;
            this.button_Logout.Iconimage_right_Selected = null;
            this.button_Logout.Iconimage_Selected = null;
            this.button_Logout.IconMarginLeft = 11;
            this.button_Logout.IconMarginRight = 0;
            this.button_Logout.IconRightVisible = true;
            this.button_Logout.IconRightZoom = 0D;
            this.button_Logout.IconVisible = true;
            this.button_Logout.IconZoom = 80D;
            this.button_Logout.IsTab = false;
            this.button_Logout.Location = new System.Drawing.Point(0, 340);
            this.button_Logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Logout.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Logout.selected = false;
            this.button_Logout.Size = new System.Drawing.Size(250, 45);
            this.button_Logout.TabIndex = 6;
            this.button_Logout.Text = "Logout";
            this.button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Textcolor = System.Drawing.Color.White;
            this.button_Logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
            this.button_Logout.MouseHover += new System.EventHandler(this.Button_Logout_MouseHover);
            // 
            // button_Events
            // 
            this.button_Events.Activecolor = System.Drawing.Color.Transparent;
            this.button_Events.BackColor = System.Drawing.Color.Transparent;
            this.button_Events.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Events.BorderRadius = 0;
            this.button_Events.ButtonText = "Events";
            this.button_Events.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Events.DisabledColor = System.Drawing.Color.Gray;
            this.button_Events.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Events.ForeColor = System.Drawing.Color.White;
            this.button_Events.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Events.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Events.Iconimage")));
            this.button_Events.Iconimage_right = null;
            this.button_Events.Iconimage_right_Selected = null;
            this.button_Events.Iconimage_Selected = null;
            this.button_Events.IconMarginLeft = 11;
            this.button_Events.IconMarginRight = 0;
            this.button_Events.IconRightVisible = true;
            this.button_Events.IconRightZoom = 0D;
            this.button_Events.IconVisible = true;
            this.button_Events.IconZoom = 80D;
            this.button_Events.IsTab = false;
            this.button_Events.Location = new System.Drawing.Point(0, 260);
            this.button_Events.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Events.Name = "button_Events";
            this.button_Events.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Events.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Events.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Events.selected = false;
            this.button_Events.Size = new System.Drawing.Size(250, 45);
            this.button_Events.TabIndex = 5;
            this.button_Events.Text = "Events";
            this.button_Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Events.Textcolor = System.Drawing.Color.White;
            this.button_Events.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Events.Click += new System.EventHandler(this.Button_Events_Click);
            this.button_Events.MouseHover += new System.EventHandler(this.Button_Events_MouseHover);
            // 
            // button_Attendance
            // 
            this.button_Attendance.Activecolor = System.Drawing.Color.Transparent;
            this.button_Attendance.BackColor = System.Drawing.Color.Transparent;
            this.button_Attendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Attendance.BorderRadius = 0;
            this.button_Attendance.ButtonText = "Attendance";
            this.button_Attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Attendance.DisabledColor = System.Drawing.Color.Gray;
            this.button_Attendance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Attendance.ForeColor = System.Drawing.Color.White;
            this.button_Attendance.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Attendance.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Attendance.Iconimage")));
            this.button_Attendance.Iconimage_right = null;
            this.button_Attendance.Iconimage_right_Selected = null;
            this.button_Attendance.Iconimage_Selected = null;
            this.button_Attendance.IconMarginLeft = 11;
            this.button_Attendance.IconMarginRight = 0;
            this.button_Attendance.IconRightVisible = true;
            this.button_Attendance.IconRightZoom = 0D;
            this.button_Attendance.IconVisible = true;
            this.button_Attendance.IconZoom = 80D;
            this.button_Attendance.IsTab = false;
            this.button_Attendance.Location = new System.Drawing.Point(0, 220);
            this.button_Attendance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Attendance.Name = "button_Attendance";
            this.button_Attendance.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Attendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Attendance.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Attendance.selected = false;
            this.button_Attendance.Size = new System.Drawing.Size(250, 45);
            this.button_Attendance.TabIndex = 4;
            this.button_Attendance.Text = "Attendance";
            this.button_Attendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Attendance.Textcolor = System.Drawing.Color.White;
            this.button_Attendance.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Attendance.Click += new System.EventHandler(this.Button_Attendance_Click);
            this.button_Attendance.MouseHover += new System.EventHandler(this.Button_Attendance_MouseHover);
            // 
            // button_Members
            // 
            this.button_Members.Activecolor = System.Drawing.Color.Transparent;
            this.button_Members.BackColor = System.Drawing.Color.Transparent;
            this.button_Members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Members.BorderRadius = 0;
            this.button_Members.ButtonText = "Members";
            this.button_Members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Members.DisabledColor = System.Drawing.Color.Gray;
            this.button_Members.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Members.ForeColor = System.Drawing.Color.White;
            this.button_Members.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Members.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Members.Iconimage")));
            this.button_Members.Iconimage_right = null;
            this.button_Members.Iconimage_right_Selected = null;
            this.button_Members.Iconimage_Selected = null;
            this.button_Members.IconMarginLeft = 11;
            this.button_Members.IconMarginRight = 0;
            this.button_Members.IconRightVisible = true;
            this.button_Members.IconRightZoom = 0D;
            this.button_Members.IconVisible = true;
            this.button_Members.IconZoom = 80D;
            this.button_Members.IsTab = false;
            this.button_Members.Location = new System.Drawing.Point(0, 180);
            this.button_Members.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Members.Name = "button_Members";
            this.button_Members.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Members.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Members.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Members.selected = false;
            this.button_Members.Size = new System.Drawing.Size(250, 45);
            this.button_Members.TabIndex = 3;
            this.button_Members.Text = "Members";
            this.button_Members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Members.Textcolor = System.Drawing.Color.White;
            this.button_Members.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Members.Click += new System.EventHandler(this.button_Members_Click);
            this.button_Members.MouseHover += new System.EventHandler(this.Button_Members_MouseHover);
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.White;
            this.panel_side.Location = new System.Drawing.Point(0, 140);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(10, 48);
            this.panel_side.TabIndex = 2;
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(69, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(100, 101);
            this.pb_Logo.TabIndex = 1;
            this.pb_Logo.TabStop = false;
            // 
            // button_Dashboard
            // 
            this.button_Dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.button_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Dashboard.BorderRadius = 0;
            this.button_Dashboard.ButtonText = "Dashboard";
            this.button_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.button_Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dashboard.ForeColor = System.Drawing.Color.White;
            this.button_Dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Dashboard.Iconimage")));
            this.button_Dashboard.Iconimage_right = null;
            this.button_Dashboard.Iconimage_right_Selected = null;
            this.button_Dashboard.Iconimage_Selected = null;
            this.button_Dashboard.IconMarginLeft = 11;
            this.button_Dashboard.IconMarginRight = 0;
            this.button_Dashboard.IconRightVisible = true;
            this.button_Dashboard.IconRightZoom = 0D;
            this.button_Dashboard.IconVisible = true;
            this.button_Dashboard.IconZoom = 80D;
            this.button_Dashboard.IsTab = false;
            this.button_Dashboard.Location = new System.Drawing.Point(0, 140);
            this.button_Dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Dashboard.Name = "button_Dashboard";
            this.button_Dashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_Dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Dashboard.selected = false;
            this.button_Dashboard.Size = new System.Drawing.Size(250, 45);
            this.button_Dashboard.TabIndex = 0;
            this.button_Dashboard.Text = "Dashboard";
            this.button_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Dashboard.Textcolor = System.Drawing.Color.White;
            this.button_Dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dashboard.Click += new System.EventHandler(this.Button_Dashboard_Click);
            this.button_Dashboard.MouseHover += new System.EventHandler(this.Button_Dashboard_MouseHover);
            // 
            // timer_DateTime
            // 
            this.timer_DateTime.Tick += new System.EventHandler(this.Timer_DateTime_Tick);
            // 
            // panel_Workspace
            // 
            this.panel_Workspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_Workspace.Controls.Add(this.members1);
            this.panel_Workspace.Controls.Add(this.attendance1);
            this.panel_Workspace.Location = new System.Drawing.Point(47, 119);
            this.panel_Workspace.Name = "panel_Workspace";
            this.panel_Workspace.Size = new System.Drawing.Size(955, 581);
            this.panel_Workspace.TabIndex = 3;
            this.panel_Workspace.MouseHover += new System.EventHandler(this.Panel_Workspace_MouseHover);
            // 
            // members1
            // 
            this.members1.Location = new System.Drawing.Point(3, 3);
            this.members1.Name = "members1";
            this.members1.Size = new System.Drawing.Size(567, 399);
            this.members1.TabIndex = 8;
            this.members1.MouseHover += new System.EventHandler(this.Members1_MouseHover);
            // 
            // attendance1
            // 
            this.attendance1.Location = new System.Drawing.Point(3, 3);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(949, 449);
            this.attendance1.TabIndex = 7;
            this.attendance1.Load += new System.EventHandler(this.Attendance1_Load);
            this.attendance1.MouseHover += new System.EventHandler(this.Attendance1_MouseHover);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Workspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHome_FormClosed);
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.panel_Workspace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Menu;
        private Bunifu.Framework.UI.BunifuFlatButton button_Dashboard;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Label label_PMCGrace;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.PictureBox pb_Minimized;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_DateTime;
        private Bunifu.Framework.UI.BunifuFlatButton button_Members;
        private System.Windows.Forms.Panel panel_Workspace;
        private Bunifu.Framework.UI.BunifuFlatButton button_Attendance;
        private Bunifu.Framework.UI.BunifuFlatButton button_Logout;
        private Bunifu.Framework.UI.BunifuFlatButton button_Events;
        private Attendance attendance1;
        public System.Windows.Forms.Label label_Time;
        private Bunifu.Framework.UI.BunifuFlatButton button_History;
        public System.Windows.Forms.Label label_Date;
        private Members members1;
    }
}