namespace MonAd
{
    partial class AttendanceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_attendance = new System.Windows.Forms.DataGridView();
            this.timer_DateTime = new System.Windows.Forms.Timer(this.components);
            this.cb_Attdate = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 54);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pb_Exit
            // 
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(755, 9);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(33, 33);
            this.pb_Exit.TabIndex = 8;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.Pb_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance";
            // 
            // dg_attendance
            // 
            this.dg_attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_attendance.Location = new System.Drawing.Point(12, 119);
            this.dg_attendance.Name = "dg_attendance";
            this.dg_attendance.Size = new System.Drawing.Size(776, 293);
            this.dg_attendance.TabIndex = 1;
            // 
            // timer_DateTime
            // 
            this.timer_DateTime.Tick += new System.EventHandler(this.Timer_DateTime_Tick);
            // 
            // cb_Attdate
            // 
            this.cb_Attdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Attdate.FormattingEnabled = true;
            this.cb_Attdate.Location = new System.Drawing.Point(12, 69);
            this.cb_Attdate.Name = "cb_Attdate";
            this.cb_Attdate.Size = new System.Drawing.Size(349, 29);
            this.cb_Attdate.TabIndex = 4;
            this.cb_Attdate.Text = "Select Date";
            this.cb_Attdate.SelectedIndexChanged += new System.EventHandler(this.Cb_Attdate_SelectedIndexChanged);
            // 
            // AttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Attdate);
            this.Controls.Add(this.dg_attendance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceList";
            this.Load += new System.EventHandler(this.AttendanceList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_attendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_attendance;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Timer timer_DateTime;
        private System.Windows.Forms.ComboBox cb_Attdate;
    }
}