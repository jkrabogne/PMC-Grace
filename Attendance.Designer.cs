namespace MonAd
{
    partial class Attendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tile_Insert = new Bunifu.Framework.UI.BunifuTileButton();
            this.tile_ViewAttendance = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tile_Insert);
            this.panel1.Controls.Add(this.tile_ViewAttendance);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 399);
            this.panel1.TabIndex = 1;
            // 
            // tile_Insert
            // 
            this.tile_Insert.BackColor = System.Drawing.Color.Transparent;
            this.tile_Insert.color = System.Drawing.Color.Transparent;
            this.tile_Insert.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tile_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tile_Insert.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile_Insert.ForeColor = System.Drawing.Color.White;
            this.tile_Insert.Image = ((System.Drawing.Image)(resources.GetObject("tile_Insert.Image")));
            this.tile_Insert.ImagePosition = 25;
            this.tile_Insert.ImageZoom = 50;
            this.tile_Insert.LabelPosition = 51;
            this.tile_Insert.LabelText = "Insert ID Number";
            this.tile_Insert.Location = new System.Drawing.Point(198, 8);
            this.tile_Insert.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tile_Insert.Name = "tile_Insert";
            this.tile_Insert.Size = new System.Drawing.Size(180, 168);
            this.tile_Insert.TabIndex = 2;
            this.tile_Insert.Click += new System.EventHandler(this.Tile_Insert_Click);
            // 
            // tile_ViewAttendance
            // 
            this.tile_ViewAttendance.BackColor = System.Drawing.Color.Transparent;
            this.tile_ViewAttendance.color = System.Drawing.Color.Transparent;
            this.tile_ViewAttendance.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tile_ViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tile_ViewAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile_ViewAttendance.ForeColor = System.Drawing.Color.White;
            this.tile_ViewAttendance.Image = ((System.Drawing.Image)(resources.GetObject("tile_ViewAttendance.Image")));
            this.tile_ViewAttendance.ImagePosition = 25;
            this.tile_ViewAttendance.ImageZoom = 50;
            this.tile_ViewAttendance.LabelPosition = 51;
            this.tile_ViewAttendance.LabelText = "View Attendance";
            this.tile_ViewAttendance.Location = new System.Drawing.Point(6, 8);
            this.tile_ViewAttendance.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tile_ViewAttendance.Name = "tile_ViewAttendance";
            this.tile_ViewAttendance.Size = new System.Drawing.Size(180, 168);
            this.tile_ViewAttendance.TabIndex = 1;
            this.tile_ViewAttendance.Click += new System.EventHandler(this.Tile_ViewAttendance_Click);
            this.tile_ViewAttendance.MouseHover += new System.EventHandler(this.Tile_ViewAttendance_MouseHover);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(861, 399);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton tile_ViewAttendance;
        private Bunifu.Framework.UI.BunifuTileButton tile_Insert;
    }
}
