namespace MonAd
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_CivilStatus = new System.Windows.Forms.Label();
            this.cb_CivilStatus = new System.Windows.Forms.ComboBox();
            this.label_FPCode = new System.Windows.Forms.Label();
            this.pb_proPic = new System.Windows.Forms.PictureBox();
            this.label_proPic = new System.Windows.Forms.Label();
            this.button_Register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_AddMember = new System.Windows.Forms.Label();
            this.tb_Firstname = new System.Windows.Forms.TextBox();
            this.tb_Lastname = new System.Windows.Forms.TextBox();
            this.tb_Contact = new System.Windows.Forms.TextBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Memberid = new System.Windows.Forms.TextBox();
            this.tb_Category = new System.Windows.Forms.TextBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.button_upload = new System.Windows.Forms.Button();
            this.tb_fpcode = new System.Windows.Forms.TextBox();
            this.Scan = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pb_proPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Firstname.ForeColor = System.Drawing.Color.White;
            this.label_Firstname.Location = new System.Drawing.Point(277, 98);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(81, 21);
            this.label_Firstname.TabIndex = 0;
            this.label_Firstname.Text = "Firstname";
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lastname.ForeColor = System.Drawing.Color.White;
            this.label_Lastname.Location = new System.Drawing.Point(279, 175);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(79, 21);
            this.label_Lastname.TabIndex = 9;
            this.label_Lastname.Text = "Lastname";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contact.ForeColor = System.Drawing.Color.White;
            this.label_Contact.Location = new System.Drawing.Point(19, 268);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(67, 21);
            this.label_Contact.TabIndex = 11;
            this.label_Contact.Text = "Contact";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.ForeColor = System.Drawing.Color.White;
            this.label_Address.Location = new System.Drawing.Point(19, 493);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(70, 21);
            this.label_Address.TabIndex = 13;
            this.label_Address.Text = "Address";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.ForeColor = System.Drawing.Color.White;
            this.label_Gender.Location = new System.Drawing.Point(277, 337);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(64, 21);
            this.label_Gender.TabIndex = 18;
            this.label_Gender.Text = "Gender";
            // 
            // cb_Gender
            // 
            this.cb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cb_Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gender.ForeColor = System.Drawing.Color.White;
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_Gender.Location = new System.Drawing.Point(281, 361);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(230, 29);
            this.cb_Gender.TabIndex = 19;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Age.ForeColor = System.Drawing.Color.White;
            this.label_Age.Location = new System.Drawing.Point(277, 268);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(40, 21);
            this.label_Age.TabIndex = 20;
            this.label_Age.Text = "Age";
            // 
            // label_CivilStatus
            // 
            this.label_CivilStatus.AutoSize = true;
            this.label_CivilStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CivilStatus.ForeColor = System.Drawing.Color.White;
            this.label_CivilStatus.Location = new System.Drawing.Point(19, 412);
            this.label_CivilStatus.Name = "label_CivilStatus";
            this.label_CivilStatus.Size = new System.Drawing.Size(89, 21);
            this.label_CivilStatus.TabIndex = 22;
            this.label_CivilStatus.Text = "Civil Status";
            // 
            // cb_CivilStatus
            // 
            this.cb_CivilStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cb_CivilStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CivilStatus.ForeColor = System.Drawing.Color.White;
            this.cb_CivilStatus.FormattingEnabled = true;
            this.cb_CivilStatus.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.cb_CivilStatus.Location = new System.Drawing.Point(23, 436);
            this.cb_CivilStatus.Name = "cb_CivilStatus";
            this.cb_CivilStatus.Size = new System.Drawing.Size(230, 29);
            this.cb_CivilStatus.TabIndex = 23;
            // 
            // label_FPCode
            // 
            this.label_FPCode.AutoSize = true;
            this.label_FPCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FPCode.ForeColor = System.Drawing.Color.White;
            this.label_FPCode.Location = new System.Drawing.Point(564, 124);
            this.label_FPCode.Name = "label_FPCode";
            this.label_FPCode.Size = new System.Drawing.Size(59, 21);
            this.label_FPCode.TabIndex = 24;
            this.label_FPCode.Text = "Status:";
            // 
            // pb_proPic
            // 
            this.pb_proPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_proPic.Location = new System.Drawing.Point(12, 87);
            this.pb_proPic.Name = "pb_proPic";
            this.pb_proPic.Size = new System.Drawing.Size(123, 109);
            this.pb_proPic.TabIndex = 25;
            this.pb_proPic.TabStop = false;
            // 
            // label_proPic
            // 
            this.label_proPic.AutoSize = true;
            this.label_proPic.BackColor = System.Drawing.Color.Transparent;
            this.label_proPic.ForeColor = System.Drawing.Color.White;
            this.label_proPic.Location = new System.Drawing.Point(20, 130);
            this.label_proPic.Name = "label_proPic";
            this.label_proPic.Size = new System.Drawing.Size(104, 13);
            this.label_proPic.TabIndex = 26;
            this.label_proPic.Text = "Please Insert Picture";
            // 
            // button_Register
            // 
            this.button_Register.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_Register.BackColor = System.Drawing.Color.Transparent;
            this.button_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Register.BorderRadius = 0;
            this.button_Register.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.button_Register.ButtonText = "Register";
            this.button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Register.DisabledColor = System.Drawing.Color.Gray;
            this.button_Register.Iconcolor = System.Drawing.Color.Transparent;
            this.button_Register.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_Register.Iconimage")));
            this.button_Register.Iconimage_right = null;
            this.button_Register.Iconimage_right_Selected = null;
            this.button_Register.Iconimage_Selected = null;
            this.button_Register.IconMarginLeft = 0;
            this.button_Register.IconMarginRight = 0;
            this.button_Register.IconRightVisible = true;
            this.button_Register.IconRightZoom = 0D;
            this.button_Register.IconVisible = true;
            this.button_Register.IconZoom = 90D;
            this.button_Register.IsTab = false;
            this.button_Register.Location = new System.Drawing.Point(645, 569);
            this.button_Register.Name = "button_Register";
            this.button_Register.Normalcolor = System.Drawing.Color.Transparent;
            this.button_Register.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_Register.OnHoverTextColor = System.Drawing.Color.White;
            this.button_Register.selected = false;
            this.button_Register.Size = new System.Drawing.Size(196, 38);
            this.button_Register.TabIndex = 28;
            this.button_Register.Text = "Register";
            this.button_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Register.Textcolor = System.Drawing.Color.White;
            this.button_Register.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.label_AddMember);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 80);
            this.panel1.TabIndex = 29;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.ImageActive = null;
            this.button_Exit.Location = new System.Drawing.Point(850, 11);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(32, 32);
            this.button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Exit.TabIndex = 31;
            this.button_Exit.TabStop = false;
            this.button_Exit.Zoom = 10;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // label_AddMember
            // 
            this.label_AddMember.AutoSize = true;
            this.label_AddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddMember.ForeColor = System.Drawing.Color.White;
            this.label_AddMember.Location = new System.Drawing.Point(334, 21);
            this.label_AddMember.Name = "label_AddMember";
            this.label_AddMember.Size = new System.Drawing.Size(177, 37);
            this.label_AddMember.TabIndex = 30;
            this.label_AddMember.Text = "Add Member";
            // 
            // tb_Firstname
            // 
            this.tb_Firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Firstname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Firstname.ForeColor = System.Drawing.Color.White;
            this.tb_Firstname.Location = new System.Drawing.Point(281, 130);
            this.tb_Firstname.Name = "tb_Firstname";
            this.tb_Firstname.Size = new System.Drawing.Size(230, 29);
            this.tb_Firstname.TabIndex = 32;
            // 
            // tb_Lastname
            // 
            this.tb_Lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Lastname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lastname.ForeColor = System.Drawing.Color.White;
            this.tb_Lastname.Location = new System.Drawing.Point(281, 202);
            this.tb_Lastname.Name = "tb_Lastname";
            this.tb_Lastname.Size = new System.Drawing.Size(230, 29);
            this.tb_Lastname.TabIndex = 33;
            // 
            // tb_Contact
            // 
            this.tb_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Contact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Contact.ForeColor = System.Drawing.Color.White;
            this.tb_Contact.Location = new System.Drawing.Point(23, 292);
            this.tb_Contact.Name = "tb_Contact";
            this.tb_Contact.Size = new System.Drawing.Size(230, 29);
            this.tb_Contact.TabIndex = 34;
            // 
            // tb_Age
            // 
            this.tb_Age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Age.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.ForeColor = System.Drawing.Color.White;
            this.tb_Age.Location = new System.Drawing.Point(281, 292);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(230, 29);
            this.tb_Age.TabIndex = 35;
            this.tb_Age.TextChanged += new System.EventHandler(this.Tb_Age_TextChanged);
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Address.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.ForeColor = System.Drawing.Color.White;
            this.tb_Address.Location = new System.Drawing.Point(23, 517);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(488, 29);
            this.tb_Address.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Member ID";
            // 
            // tb_Memberid
            // 
            this.tb_Memberid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Memberid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Memberid.ForeColor = System.Drawing.Color.White;
            this.tb_Memberid.Location = new System.Drawing.Point(145, 155);
            this.tb_Memberid.Name = "tb_Memberid";
            this.tb_Memberid.Size = new System.Drawing.Size(116, 29);
            this.tb_Memberid.TabIndex = 41;
            // 
            // tb_Category
            // 
            this.tb_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_Category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category.ForeColor = System.Drawing.Color.White;
            this.tb_Category.Location = new System.Drawing.Point(23, 361);
            this.tb_Category.Name = "tb_Category";
            this.tb_Category.Size = new System.Drawing.Size(230, 29);
            this.tb_Category.TabIndex = 42;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Category.ForeColor = System.Drawing.Color.White;
            this.label_Category.Location = new System.Drawing.Point(23, 337);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(77, 21);
            this.label_Category.TabIndex = 43;
            this.label_Category.Text = "Category";
            // 
            // button_upload
            // 
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(33, 202);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(75, 23);
            this.button_upload.TabIndex = 44;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.Button_upload_Click);
            // 
            // tb_fpcode
            // 
            this.tb_fpcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tb_fpcode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fpcode.ForeColor = System.Drawing.Color.White;
            this.tb_fpcode.Location = new System.Drawing.Point(559, 155);
            this.tb_fpcode.Multiline = true;
            this.tb_fpcode.Name = "tb_fpcode";
            this.tb_fpcode.Size = new System.Drawing.Size(323, 384);
            this.tb_fpcode.TabIndex = 37;
            this.tb_fpcode.TextChanged += new System.EventHandler(this.Tb_fpcode_TextChanged);
            // 
            // Scan
            // 
            this.Scan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Scan.BackColor = System.Drawing.Color.Transparent;
            this.Scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scan.BorderRadius = 0;
            this.Scan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scan.ButtonText = "Scan";
            this.Scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scan.DisabledColor = System.Drawing.Color.Gray;
            this.Scan.Iconcolor = System.Drawing.Color.Transparent;
            this.Scan.Iconimage = ((System.Drawing.Image)(resources.GetObject("Scan.Iconimage")));
            this.Scan.Iconimage_right = null;
            this.Scan.Iconimage_right_Selected = null;
            this.Scan.Iconimage_Selected = null;
            this.Scan.IconMarginLeft = 0;
            this.Scan.IconMarginRight = 0;
            this.Scan.IconRightVisible = true;
            this.Scan.IconRightZoom = 0D;
            this.Scan.IconVisible = true;
            this.Scan.IconZoom = 90D;
            this.Scan.IsTab = false;
            this.Scan.Location = new System.Drawing.Point(145, 569);
            this.Scan.Name = "Scan";
            this.Scan.Normalcolor = System.Drawing.Color.Transparent;
            this.Scan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Scan.OnHoverTextColor = System.Drawing.Color.White;
            this.Scan.selected = false;
            this.Scan.Size = new System.Drawing.Size(196, 38);
            this.Scan.TabIndex = 45;
            this.Scan.Text = "Scan";
            this.Scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Scan.Textcolor = System.Drawing.Color.White;
            this.Scan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(894, 619);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.tb_Category);
            this.Controls.Add(this.tb_Memberid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_fpcode);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Contact);
            this.Controls.Add(this.tb_Lastname);
            this.Controls.Add(this.tb_Firstname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label_proPic);
            this.Controls.Add(this.pb_proPic);
            this.Controls.Add(this.label_FPCode);
            this.Controls.Add(this.cb_CivilStatus);
            this.Controls.Add(this.label_CivilStatus);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Contact);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_Firstname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_proPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label label_Contact;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_CivilStatus;
        private System.Windows.Forms.ComboBox cb_CivilStatus;
        private System.Windows.Forms.Label label_FPCode;
        private System.Windows.Forms.PictureBox pb_proPic;
        private System.Windows.Forms.Label label_proPic;
        private Bunifu.Framework.UI.BunifuFlatButton button_Register;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton button_Exit;
        private System.Windows.Forms.Label label_AddMember;
        private System.Windows.Forms.TextBox tb_Firstname;
        private System.Windows.Forms.TextBox tb_Lastname;
        private System.Windows.Forms.TextBox tb_Contact;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Memberid;
        private System.Windows.Forms.TextBox tb_Category;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.TextBox tb_fpcode;
        private Bunifu.Framework.UI.BunifuFlatButton Scan;
    }
}