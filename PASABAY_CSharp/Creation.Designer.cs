namespace PASABAY_CSharp
{
    partial class frmCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreation));
            this.Button_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Password = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtContactNoP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtParent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtContact = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMI = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(154)))));
            this.Button_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(154)))));
            this.Button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Login.BorderRadius = 5;
            this.Button_Login.ButtonText = "Create";
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(154)))));
            this.Button_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Login.Iconimage = null;
            this.Button_Login.Iconimage_right = null;
            this.Button_Login.Iconimage_right_Selected = null;
            this.Button_Login.Iconimage_Selected = null;
            this.Button_Login.IconMarginLeft = 0;
            this.Button_Login.IconMarginRight = 0;
            this.Button_Login.IconRightVisible = true;
            this.Button_Login.IconRightZoom = 0D;
            this.Button_Login.IconVisible = true;
            this.Button_Login.IconZoom = 90D;
            this.Button_Login.IsTab = false;
            this.Button_Login.Location = new System.Drawing.Point(294, 664);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(154)))));
            this.Button_Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Login.selected = false;
            this.Button_Login.Size = new System.Drawing.Size(109, 32);
            this.Button_Login.TabIndex = 8;
            this.Button_Login.Text = "Create";
            this.Button_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Login.Textcolor = System.Drawing.Color.Black;
            this.Button_Login.TextFont = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(202, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 20);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "Username";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(52, 203);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(219, 37);
            this.bunifuMaterialTextbox1.TabIndex = 30;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "Password";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(52, 252);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(219, 37);
            this.bunifuMaterialTextbox2.TabIndex = 31;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Account Information";
            // 
            // checkBox_Password
            // 
            this.checkBox_Password.AutoSize = true;
            this.checkBox_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Password.Location = new System.Drawing.Point(94, 298);
            this.checkBox_Password.Name = "checkBox_Password";
            this.checkBox_Password.Size = new System.Drawing.Size(133, 22);
            this.checkBox_Password.TabIndex = 29;
            this.checkBox_Password.Text = "Show Password";
            this.checkBox_Password.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Type of Payment";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PayMaya",
            "GCash",
            "UnionBank"});
            this.comboBox1.Location = new System.Drawing.Point(290, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // txtContactNoP
            // 
            this.txtContactNoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtContactNoP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNoP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNoP.ForeColor = System.Drawing.Color.Black;
            this.txtContactNoP.HintForeColor = System.Drawing.Color.Empty;
            this.txtContactNoP.HintText = "Parent Contact No.";
            this.txtContactNoP.isPassword = false;
            this.txtContactNoP.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtContactNoP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtContactNoP.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtContactNoP.LineThickness = 4;
            this.txtContactNoP.Location = new System.Drawing.Point(51, 615);
            this.txtContactNoP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContactNoP.Name = "txtContactNoP";
            this.txtContactNoP.Size = new System.Drawing.Size(219, 37);
            this.txtContactNoP.TabIndex = 44;
            this.txtContactNoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParent
            // 
            this.txtParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtParent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtParent.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParent.ForeColor = System.Drawing.Color.Black;
            this.txtParent.HintForeColor = System.Drawing.Color.Empty;
            this.txtParent.HintText = "Parent/Guardian Full Name";
            this.txtParent.isPassword = false;
            this.txtParent.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtParent.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtParent.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtParent.LineThickness = 4;
            this.txtParent.Location = new System.Drawing.Point(51, 577);
            this.txtParent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(354, 37);
            this.txtParent.TabIndex = 43;
            this.txtParent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "Email Address";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(51, 528);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 37);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.HintForeColor = System.Drawing.Color.Empty;
            this.txtAge.HintText = "Age";
            this.txtAge.isPassword = false;
            this.txtAge.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtAge.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAge.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtAge.LineThickness = 4;
            this.txtAge.Location = new System.Drawing.Point(326, 403);
            this.txtAge.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(52, 37);
            this.txtAge.TabIndex = 41;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.HintForeColor = System.Drawing.Color.Empty;
            this.txtContact.HintText = "Contact No.";
            this.txtContact.isPassword = false;
            this.txtContact.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtContact.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtContact.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtContact.LineThickness = 4;
            this.txtContact.Location = new System.Drawing.Point(51, 482);
            this.txtContact.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(219, 37);
            this.txtContact.TabIndex = 40;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMI
            // 
            this.txtMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtMI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMI.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.ForeColor = System.Drawing.Color.Black;
            this.txtMI.HintForeColor = System.Drawing.Color.Empty;
            this.txtMI.HintText = "M.I";
            this.txtMI.isPassword = false;
            this.txtMI.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtMI.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMI.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtMI.LineThickness = 4;
            this.txtMI.Location = new System.Drawing.Point(326, 354);
            this.txtMI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(52, 37);
            this.txtMI.TabIndex = 38;
            this.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtAddress.HintText = "Address";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtAddress.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtAddress.LineThickness = 4;
            this.txtAddress.Location = new System.Drawing.Point(51, 438);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(354, 37);
            this.txtAddress.TabIndex = 39;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.txtFirstName.HintText = "First Name";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtFirstName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtFirstName.LineThickness = 4;
            this.txtFirstName.Location = new System.Drawing.Point(52, 396);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(219, 37);
            this.txtFirstName.TabIndex = 37;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.HintForeColor = System.Drawing.Color.Empty;
            this.txtLastName.HintText = "Last Name";
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtLastName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtLastName.LineThickness = 4;
            this.txtLastName.Location = new System.Drawing.Point(51, 354);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(219, 37);
            this.txtLastName.TabIndex = 36;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Personal Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 738);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "     ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 772);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtContactNoP);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Password);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creation";
            this.Load += new System.EventHandler(this.frmCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton Button_Login;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContactNoP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtParent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAge;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtContact;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMI;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}