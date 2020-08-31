namespace MonAd
{
    partial class InsertID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertID));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IDnum = new System.Windows.Forms.TextBox();
            this.button_Insert = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Port = new System.Windows.Forms.ComboBox();
            this.button_read = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Insert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pb_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 71);
            this.panel1.TabIndex = 0;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Exit.Image")));
            this.pb_Exit.Location = new System.Drawing.Point(403, 3);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(30, 33);
            this.pb_Exit.TabIndex = 1;
            this.pb_Exit.TabStop = false;
            this.pb_Exit.Click += new System.EventHandler(this.Pb_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Insert ID Number";
            // 
            // tb_IDnum
            // 
            this.tb_IDnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_IDnum.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDnum.Location = new System.Drawing.Point(137, 90);
            this.tb_IDnum.Name = "tb_IDnum";
            this.tb_IDnum.Size = new System.Drawing.Size(158, 32);
            this.tb_IDnum.TabIndex = 1;
            this.tb_IDnum.TextChanged += new System.EventHandler(this.Tb_IDnum_TextChanged);
            this.tb_IDnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_IDnum_KeyPress);
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.Color.Transparent;
            this.button_Insert.Image = ((System.Drawing.Image)(resources.GetObject("button_Insert.Image")));
            this.button_Insert.ImageActive = null;
            this.button_Insert.Location = new System.Drawing.Point(179, 142);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(71, 59);
            this.button_Insert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Insert.TabIndex = 2;
            this.button_Insert.TabStop = false;
            this.button_Insert.Zoom = 10;
            this.button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Port Here";
            // 
            // cb_Port
            // 
            this.cb_Port.FormattingEnabled = true;
            this.cb_Port.Location = new System.Drawing.Point(334, 181);
            this.cb_Port.Name = "cb_Port";
            this.cb_Port.Size = new System.Drawing.Size(60, 21);
            this.cb_Port.TabIndex = 5;
            this.cb_Port.Text = "COM3";
            // 
            // button_read
            // 
            this.button_read.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_read.BackColor = System.Drawing.Color.Transparent;
            this.button_read.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_read.BorderRadius = 0;
            this.button_read.ButtonText = "Read Data";
            this.button_read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_read.DisabledColor = System.Drawing.Color.Gray;
            this.button_read.Iconcolor = System.Drawing.Color.Transparent;
            this.button_read.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_read.Iconimage")));
            this.button_read.Iconimage_right = null;
            this.button_read.Iconimage_right_Selected = null;
            this.button_read.Iconimage_Selected = null;
            this.button_read.IconMarginLeft = 0;
            this.button_read.IconMarginRight = 0;
            this.button_read.IconRightVisible = true;
            this.button_read.IconRightZoom = 0D;
            this.button_read.IconVisible = true;
            this.button_read.IconZoom = 90D;
            this.button_read.IsTab = false;
            this.button_read.Location = new System.Drawing.Point(0, 181);
            this.button_read.Name = "button_read";
            this.button_read.Normalcolor = System.Drawing.Color.Transparent;
            this.button_read.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_read.OnHoverTextColor = System.Drawing.Color.White;
            this.button_read.selected = false;
            this.button_read.Size = new System.Drawing.Size(143, 32);
            this.button_read.TabIndex = 6;
            this.button_read.Text = "Read Data";
            this.button_read.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_read.Textcolor = System.Drawing.Color.White;
            this.button_read.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // InsertID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(436, 213);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.cb_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.tb_IDnum);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertID";
            this.Load += new System.EventHandler(this.InsertID_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_Insert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IDnum;
        private Bunifu.Framework.UI.BunifuImageButton button_Insert;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Port;
        private Bunifu.Framework.UI.BunifuFlatButton button_read;
    }
}