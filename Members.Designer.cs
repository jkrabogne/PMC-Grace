namespace MonAd
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.tile_ViewMembers = new Bunifu.Framework.UI.BunifuTileButton();
            this.tile_AddMember = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // tile_ViewMembers
            // 
            this.tile_ViewMembers.BackColor = System.Drawing.Color.Transparent;
            this.tile_ViewMembers.color = System.Drawing.Color.Transparent;
            this.tile_ViewMembers.colorActive = System.Drawing.Color.Transparent;
            this.tile_ViewMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tile_ViewMembers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile_ViewMembers.ForeColor = System.Drawing.Color.White;
            this.tile_ViewMembers.Image = ((System.Drawing.Image)(resources.GetObject("tile_ViewMembers.Image")));
            this.tile_ViewMembers.ImagePosition = 25;
            this.tile_ViewMembers.ImageZoom = 50;
            this.tile_ViewMembers.LabelPosition = 51;
            this.tile_ViewMembers.LabelText = "View Members";
            this.tile_ViewMembers.Location = new System.Drawing.Point(6, 8);
            this.tile_ViewMembers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tile_ViewMembers.Name = "tile_ViewMembers";
            this.tile_ViewMembers.Size = new System.Drawing.Size(163, 164);
            this.tile_ViewMembers.TabIndex = 0;
            this.tile_ViewMembers.Click += new System.EventHandler(this.Tile_ViewMembers_Click);
            // 
            // tile_AddMember
            // 
            this.tile_AddMember.BackColor = System.Drawing.Color.Transparent;
            this.tile_AddMember.color = System.Drawing.Color.Transparent;
            this.tile_AddMember.colorActive = System.Drawing.Color.Transparent;
            this.tile_AddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tile_AddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tile_AddMember.ForeColor = System.Drawing.Color.White;
            this.tile_AddMember.Image = ((System.Drawing.Image)(resources.GetObject("tile_AddMember.Image")));
            this.tile_AddMember.ImagePosition = 25;
            this.tile_AddMember.ImageZoom = 50;
            this.tile_AddMember.LabelPosition = 51;
            this.tile_AddMember.LabelText = "Add Member";
            this.tile_AddMember.Location = new System.Drawing.Point(181, 8);
            this.tile_AddMember.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tile_AddMember.Name = "tile_AddMember";
            this.tile_AddMember.Size = new System.Drawing.Size(163, 164);
            this.tile_AddMember.TabIndex = 1;
            this.tile_AddMember.Click += new System.EventHandler(this.Tile_AddMember_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tile_AddMember);
            this.Controls.Add(this.tile_ViewMembers);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(567, 399);
            this.Load += new System.EventHandler(this.Members_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tile_ViewMembers;
        private Bunifu.Framework.UI.BunifuTileButton tile_AddMember;
    }
}
