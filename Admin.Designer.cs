namespace MonAd
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dgvMemberInfo = new System.Windows.Forms.DataGridView();
            this.PBLogout = new System.Windows.Forms.PictureBox();
            this.PBClose = new System.Windows.Forms.PictureBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PBPrint = new System.Windows.Forms.PictureBox();
            this.PBpv = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label9 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.timer_TimeNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberInfo
            // 
            this.dgvMemberInfo.AllowUserToAddRows = false;
            this.dgvMemberInfo.AllowUserToDeleteRows = false;
            this.dgvMemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMemberInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInfo.Location = new System.Drawing.Point(15, 54);
            this.dgvMemberInfo.Name = "dgvMemberInfo";
            this.dgvMemberInfo.ReadOnly = true;
            this.dgvMemberInfo.Size = new System.Drawing.Size(1067, 411);
            this.dgvMemberInfo.TabIndex = 55;
            this.dgvMemberInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInfo_CellContentClick);
            this.dgvMemberInfo.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMemberInfo_RowHeaderMouseClick);
            // 
            // PBLogout
            // 
            this.PBLogout.Image = ((System.Drawing.Image)(resources.GetObject("PBLogout.Image")));
            this.PBLogout.Location = new System.Drawing.Point(15, 471);
            this.PBLogout.Name = "PBLogout";
            this.PBLogout.Size = new System.Drawing.Size(49, 43);
            this.PBLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogout.TabIndex = 54;
            this.PBLogout.TabStop = false;
            this.PBLogout.Click += new System.EventHandler(this.PBLogout_Click);
            // 
            // PBClose
            // 
            this.PBClose.Image = ((System.Drawing.Image)(resources.GetObject("PBClose.Image")));
            this.PBClose.Location = new System.Drawing.Point(1062, -1);
            this.PBClose.Name = "PBClose";
            this.PBClose.Size = new System.Drawing.Size(20, 20);
            this.PBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBClose.TabIndex = 53;
            this.PBClose.TabStop = false;
            this.PBClose.Click += new System.EventHandler(this.PBClose_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(618, 478);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 29);
            this.btnclear.TabIndex = 52;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(818, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(469, 478);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(118, 29);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "Delete Member";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(316, 478);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(127, 29);
            this.btnupdate.TabIndex = 47;
            this.btnupdate.Text = "Update Member";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(79, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1003, 20);
            this.txtSearch.TabIndex = 39;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Search:";
            // 
            // PBPrint
            // 
            this.PBPrint.Image = ((System.Drawing.Image)(resources.GetObject("PBPrint.Image")));
            this.PBPrint.Location = new System.Drawing.Point(79, 471);
            this.PBPrint.Name = "PBPrint";
            this.PBPrint.Size = new System.Drawing.Size(92, 40);
            this.PBPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPrint.TabIndex = 58;
            this.PBPrint.TabStop = false;
            this.PBPrint.Click += new System.EventHandler(this.PBPrint_Click);
            // 
            // PBpv
            // 
            this.PBpv.Image = ((System.Drawing.Image)(resources.GetObject("PBpv.Image")));
            this.PBpv.Location = new System.Drawing.Point(194, 471);
            this.PBpv.Name = "PBpv";
            this.PBpv.Size = new System.Drawing.Size(95, 36);
            this.PBpv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBpv.TabIndex = 59;
            this.PBpv.TabStop = false;
            this.PBpv.Click += new System.EventHandler(this.PBpv_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(207, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Print Preview";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // timer_TimeNow
            // 
            this.timer_TimeNow.Tick += new System.EventHandler(this.Timer_TimeNow_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 523);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PBpv);
            this.Controls.Add(this.PBPrint);
            this.Controls.Add(this.dgvMemberInfo);
            this.Controls.Add(this.PBLogout);
            this.Controls.Add(this.PBClose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nnnnn";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMemberInfo;
        private System.Windows.Forms.PictureBox PBLogout;
        private System.Windows.Forms.PictureBox PBClose;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBPrint;
        private System.Windows.Forms.PictureBox PBpv;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer timer_TimeNow;
    }
}