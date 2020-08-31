namespace MonAd
{
    partial class HistoryLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryLogs));
            this.dg_HLogs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label_History = new System.Windows.Forms.Label();
            this.cb_Date = new System.Windows.Forms.ComboBox();
            this.button_clear = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_HLogs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_HLogs
            // 
            this.dg_HLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_HLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_HLogs.Location = new System.Drawing.Point(12, 125);
            this.dg_HLogs.Name = "dg_HLogs";
            this.dg_HLogs.Size = new System.Drawing.Size(776, 258);
            this.dg_HLogs.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label_History);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 82);
            this.panel1.TabIndex = 1;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(757, 12);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(32, 34);
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.Pb_Exit_Click);
            // 
            // label_History
            // 
            this.label_History.AutoSize = true;
            this.label_History.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_History.ForeColor = System.Drawing.Color.White;
            this.label_History.Location = new System.Drawing.Point(303, 22);
            this.label_History.Name = "label_History";
            this.label_History.Size = new System.Drawing.Size(170, 37);
            this.label_History.TabIndex = 0;
            this.label_History.Text = "History Logs";
            // 
            // cb_Date
            // 
            this.cb_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cb_Date.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Date.ForeColor = System.Drawing.Color.White;
            this.cb_Date.FormattingEnabled = true;
            this.cb_Date.Items.AddRange(new object[] {
            "All History"});
            this.cb_Date.Location = new System.Drawing.Point(11, 90);
            this.cb_Date.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(271, 29);
            this.cb_Date.TabIndex = 2;
            this.cb_Date.Text = "All History";
            this.cb_Date.SelectedIndexChanged += new System.EventHandler(this.Cb_Date_SelectedIndexChanged);
            // 
            // button_clear
            // 
            this.button_clear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_clear.BorderRadius = 0;
            this.button_clear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_clear.ButtonText = "Clear History";
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.DisabledColor = System.Drawing.Color.Gray;
            this.button_clear.Iconcolor = System.Drawing.Color.Transparent;
            this.button_clear.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_clear.Iconimage")));
            this.button_clear.Iconimage_right = null;
            this.button_clear.Iconimage_right_Selected = null;
            this.button_clear.Iconimage_Selected = null;
            this.button_clear.IconMarginLeft = 0;
            this.button_clear.IconMarginRight = 0;
            this.button_clear.IconRightVisible = true;
            this.button_clear.IconRightZoom = 0D;
            this.button_clear.IconVisible = true;
            this.button_clear.IconZoom = 90D;
            this.button_clear.IsTab = false;
            this.button_clear.Location = new System.Drawing.Point(632, 88);
            this.button_clear.Name = "button_clear";
            this.button_clear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_clear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.button_clear.OnHoverTextColor = System.Drawing.Color.White;
            this.button_clear.selected = false;
            this.button_clear.Size = new System.Drawing.Size(156, 31);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear History";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clear.Textcolor = System.Drawing.Color.White;
            this.button_clear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // HistoryLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.cb_Date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_HLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoryLogs";
            this.Load += new System.EventHandler(this.HistoryLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_HLogs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_HLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label label_History;
        private System.Windows.Forms.ComboBox cb_Date;
        private Bunifu.Framework.UI.BunifuFlatButton button_clear;
    }
}