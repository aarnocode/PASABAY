namespace PASABAY_CSharp
{
    partial class frm_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_student));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_DriverPop = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Pasabay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Babay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_Searching = new System.Windows.Forms.PictureBox();
            this.panel_DriverInfo = new System.Windows.Forms.Panel();
            this.pictureBox_QRScan = new System.Windows.Forms.PictureBox();
            this.pctMarker = new System.Windows.Forms.PictureBox();
            this.btn_WaitPickUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDestination = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Searching = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label_DriverInfo = new System.Windows.Forms.Label();
            this.panel_DropOff = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_DropOff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label_Payment = new System.Windows.Forms.Label();
            this.panel_DropOff2 = new System.Windows.Forms.Panel();
            this.panel_CarDetails = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_SearchingForDriver = new System.Windows.Forms.Panel();
            this.panel_paymentlabel = new System.Windows.Forms.Panel();
            this.pctProfile2 = new System.Windows.Forms.PictureBox();
            this.pctSettings2 = new System.Windows.Forms.PictureBox();
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.pctProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_DriverPop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Searching)).BeginInit();
            this.panel_DriverInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarker)).BeginInit();
            this.panel_DropOff.SuspendLayout();
            this.panel_DropOff2.SuspendLayout();
            this.panel_CarDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_SearchingForDriver.SuspendLayout();
            this.panel_paymentlabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 703);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "     ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(202, 5);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel_DriverPop);
            this.panel1.Controls.Add(this.pictureBox_Searching);
            this.panel1.Location = new System.Drawing.Point(-9, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 367);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_DriverPop
            // 
            this.panel_DriverPop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.panel_DriverPop.Controls.Add(this.bunifuFlatButton3);
            this.panel_DriverPop.Controls.Add(this.btn_Pasabay);
            this.panel_DriverPop.Controls.Add(this.btn_Babay);
            this.panel_DriverPop.Controls.Add(this.label3);
            this.panel_DriverPop.Controls.Add(this.label4);
            this.panel_DriverPop.Location = new System.Drawing.Point(31, 114);
            this.panel_DriverPop.Name = "panel_DriverPop";
            this.panel_DriverPop.Size = new System.Drawing.Size(420, 194);
            this.panel_DriverPop.TabIndex = 1;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "View Car Details";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(148, 92);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(120, 24);
            this.bunifuFlatButton3.TabIndex = 18;
            this.bunifuFlatButton3.Text = "View Car Details";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btn_Pasabay
            // 
            this.btn_Pasabay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Pasabay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_Pasabay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pasabay.BorderRadius = 0;
            this.btn_Pasabay.ButtonText = "PASABAY!";
            this.btn_Pasabay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pasabay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Pasabay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Pasabay.Iconimage = null;
            this.btn_Pasabay.Iconimage_right = null;
            this.btn_Pasabay.Iconimage_right_Selected = null;
            this.btn_Pasabay.Iconimage_Selected = null;
            this.btn_Pasabay.IconMarginLeft = 0;
            this.btn_Pasabay.IconMarginRight = 0;
            this.btn_Pasabay.IconRightVisible = true;
            this.btn_Pasabay.IconRightZoom = 0D;
            this.btn_Pasabay.IconVisible = true;
            this.btn_Pasabay.IconZoom = 90D;
            this.btn_Pasabay.IsTab = false;
            this.btn_Pasabay.Location = new System.Drawing.Point(209, 134);
            this.btn_Pasabay.Name = "btn_Pasabay";
            this.btn_Pasabay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_Pasabay.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Pasabay.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Pasabay.selected = false;
            this.btn_Pasabay.Size = new System.Drawing.Size(120, 32);
            this.btn_Pasabay.TabIndex = 17;
            this.btn_Pasabay.Text = "PASABAY!";
            this.btn_Pasabay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pasabay.Textcolor = System.Drawing.Color.Black;
            this.btn_Pasabay.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pasabay.Click += new System.EventHandler(this.btn_Pasabay_Click);
            // 
            // btn_Babay
            // 
            this.btn_Babay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Babay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_Babay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Babay.BorderRadius = 0;
            this.btn_Babay.ButtonText = "BABAY!";
            this.btn_Babay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Babay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Babay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Babay.Iconimage = null;
            this.btn_Babay.Iconimage_right = null;
            this.btn_Babay.Iconimage_right_Selected = null;
            this.btn_Babay.Iconimage_Selected = null;
            this.btn_Babay.IconMarginLeft = 0;
            this.btn_Babay.IconMarginRight = 0;
            this.btn_Babay.IconRightVisible = true;
            this.btn_Babay.IconRightZoom = 0D;
            this.btn_Babay.IconVisible = true;
            this.btn_Babay.IconZoom = 90D;
            this.btn_Babay.IsTab = false;
            this.btn_Babay.Location = new System.Drawing.Point(83, 134);
            this.btn_Babay.Name = "btn_Babay";
            this.btn_Babay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_Babay.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_Babay.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Babay.selected = false;
            this.btn_Babay.Size = new System.Drawing.Size(120, 32);
            this.btn_Babay.TabIndex = 16;
            this.btn_Babay.Text = "BABAY!";
            this.btn_Babay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Babay.Textcolor = System.Drawing.Color.Black;
            this.btn_Babay.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Babay.Click += new System.EventHandler(this.btn_Babay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Would you like him to pick you up?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(38, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mr. Stan Lee is on his way!";
            // 
            // pictureBox_Searching
            // 
            this.pictureBox_Searching.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Searching.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Searching.Image")));
            this.pictureBox_Searching.Location = new System.Drawing.Point(79, 59);
            this.pictureBox_Searching.Name = "pictureBox_Searching";
            this.pictureBox_Searching.Size = new System.Drawing.Size(325, 280);
            this.pictureBox_Searching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Searching.TabIndex = 0;
            this.pictureBox_Searching.TabStop = false;
            this.pictureBox_Searching.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_DriverInfo
            // 
            this.panel_DriverInfo.BackColor = System.Drawing.Color.Transparent;
            this.panel_DriverInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_DriverInfo.BackgroundImage")));
            this.panel_DriverInfo.Controls.Add(this.pctProfile2);
            this.panel_DriverInfo.Controls.Add(this.label_DriverInfo);
            this.panel_DriverInfo.Controls.Add(this.pctSettings2);
            this.panel_DriverInfo.Controls.Add(this.pctSettings);
            this.panel_DriverInfo.Controls.Add(this.pctProfile);
            this.panel_DriverInfo.Location = new System.Drawing.Point(0, 28);
            this.panel_DriverInfo.Name = "panel_DriverInfo";
            this.panel_DriverInfo.Size = new System.Drawing.Size(464, 536);
            this.panel_DriverInfo.TabIndex = 2;
            this.panel_DriverInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_DriverInfo_Paint);
            // 
            // pictureBox_QRScan
            // 
            this.pictureBox_QRScan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_QRScan.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_QRScan.Image")));
            this.pictureBox_QRScan.Location = new System.Drawing.Point(132, 59);
            this.pictureBox_QRScan.Name = "pictureBox_QRScan";
            this.pictureBox_QRScan.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_QRScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_QRScan.TabIndex = 0;
            this.pictureBox_QRScan.TabStop = false;
            this.pictureBox_QRScan.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pctMarker
            // 
            this.pctMarker.BackColor = System.Drawing.Color.Transparent;
            this.pctMarker.Image = ((System.Drawing.Image)(resources.GetObject("pctMarker.Image")));
            this.pctMarker.Location = new System.Drawing.Point(77, 549);
            this.pctMarker.Name = "pctMarker";
            this.pctMarker.Size = new System.Drawing.Size(42, 36);
            this.pctMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMarker.TabIndex = 11;
            this.pctMarker.TabStop = false;
            // 
            // btn_WaitPickUp
            // 
            this.btn_WaitPickUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_WaitPickUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_WaitPickUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_WaitPickUp.BorderRadius = 0;
            this.btn_WaitPickUp.ButtonText = "Wait for Pick-up";
            this.btn_WaitPickUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WaitPickUp.DisabledColor = System.Drawing.Color.Gray;
            this.btn_WaitPickUp.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_WaitPickUp.Iconimage = null;
            this.btn_WaitPickUp.Iconimage_right = null;
            this.btn_WaitPickUp.Iconimage_right_Selected = null;
            this.btn_WaitPickUp.Iconimage_Selected = null;
            this.btn_WaitPickUp.IconMarginLeft = 0;
            this.btn_WaitPickUp.IconMarginRight = 0;
            this.btn_WaitPickUp.IconRightVisible = true;
            this.btn_WaitPickUp.IconRightZoom = 0D;
            this.btn_WaitPickUp.IconVisible = true;
            this.btn_WaitPickUp.IconZoom = 90D;
            this.btn_WaitPickUp.IsTab = false;
            this.btn_WaitPickUp.Location = new System.Drawing.Point(127, 595);
            this.btn_WaitPickUp.Name = "btn_WaitPickUp";
            this.btn_WaitPickUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_WaitPickUp.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_WaitPickUp.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_WaitPickUp.selected = false;
            this.btn_WaitPickUp.Size = new System.Drawing.Size(227, 48);
            this.btn_WaitPickUp.TabIndex = 10;
            this.btn_WaitPickUp.Text = "Wait for Pick-up";
            this.btn_WaitPickUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_WaitPickUp.Textcolor = System.Drawing.Color.Black;
            this.btn_WaitPickUp.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaitPickUp.Click += new System.EventHandler(this.btn_WaitPickUp_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.btnDestination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnDestination.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestination.ForeColor = System.Drawing.Color.Black;
            this.btnDestination.HintForeColor = System.Drawing.Color.Black;
            this.btnDestination.HintText = "Where to go?";
            this.btnDestination.isPassword = false;
            this.btnDestination.LineFocusedColor = System.Drawing.Color.Maroon;
            this.btnDestination.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDestination.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.btnDestination.LineThickness = 4;
            this.btnDestination.Location = new System.Drawing.Point(79, 548);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(323, 41);
            this.btnDestination.TabIndex = 9;
            this.btnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select destination:";
            // 
            // label_Searching
            // 
            this.label_Searching.AutoSize = true;
            this.label_Searching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.label_Searching.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Searching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label_Searching.Location = new System.Drawing.Point(35, 7);
            this.label_Searching.Name = "label_Searching";
            this.label_Searching.Size = new System.Drawing.Size(246, 25);
            this.label_Searching.TabIndex = 12;
            this.label_Searching.Text = "Searching for a Driver!";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label_DriverInfo
            // 
            this.label_DriverInfo.AutoSize = true;
            this.label_DriverInfo.BackColor = System.Drawing.Color.Transparent;
            this.label_DriverInfo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DriverInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label_DriverInfo.Location = new System.Drawing.Point(12, 62);
            this.label_DriverInfo.Name = "label_DriverInfo";
            this.label_DriverInfo.Size = new System.Drawing.Size(119, 25);
            this.label_DriverInfo.TabIndex = 13;
            this.label_DriverInfo.Text = "Driver Info";
            // 
            // panel_DropOff
            // 
            this.panel_DropOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.panel_DropOff.Controls.Add(this.bunifuFlatButton2);
            this.panel_DropOff.Controls.Add(this.btn_DropOff);
            this.panel_DropOff.Location = new System.Drawing.Point(23, 520);
            this.panel_DropOff.Name = "panel_DropOff";
            this.panel_DropOff.Size = new System.Drawing.Size(419, 123);
            this.panel_DropOff.TabIndex = 14;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Share Driver Info";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(31, 56);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(171, 48);
            this.bunifuFlatButton2.TabIndex = 12;
            this.bunifuFlatButton2.Text = "Share Driver Info";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_DropOff
            // 
            this.btn_DropOff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_DropOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_DropOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DropOff.BorderRadius = 0;
            this.btn_DropOff.ButtonText = "Drop Off";
            this.btn_DropOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DropOff.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DropOff.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DropOff.Iconimage = null;
            this.btn_DropOff.Iconimage_right = null;
            this.btn_DropOff.Iconimage_right_Selected = null;
            this.btn_DropOff.Iconimage_Selected = null;
            this.btn_DropOff.IconMarginLeft = 0;
            this.btn_DropOff.IconMarginRight = 0;
            this.btn_DropOff.IconRightVisible = true;
            this.btn_DropOff.IconRightZoom = 0D;
            this.btn_DropOff.IconVisible = true;
            this.btn_DropOff.IconZoom = 90D;
            this.btn_DropOff.IsTab = false;
            this.btn_DropOff.Location = new System.Drawing.Point(219, 56);
            this.btn_DropOff.Name = "btn_DropOff";
            this.btn_DropOff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btn_DropOff.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btn_DropOff.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DropOff.selected = false;
            this.btn_DropOff.Size = new System.Drawing.Size(180, 48);
            this.btn_DropOff.TabIndex = 11;
            this.btn_DropOff.Text = "Drop Off";
            this.btn_DropOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DropOff.Textcolor = System.Drawing.Color.Black;
            this.btn_DropOff.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DropOff.Click += new System.EventHandler(this.btn_DropOff_Click);
            // 
            // label_Payment
            // 
            this.label_Payment.AutoSize = true;
            this.label_Payment.BackColor = System.Drawing.Color.Transparent;
            this.label_Payment.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label_Payment.Location = new System.Drawing.Point(31, 5);
            this.label_Payment.Name = "label_Payment";
            this.label_Payment.Size = new System.Drawing.Size(110, 25);
            this.label_Payment.TabIndex = 15;
            this.label_Payment.Text = "Payment";
            this.label_Payment.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel_DropOff2
            // 
            this.panel_DropOff2.BackColor = System.Drawing.Color.White;
            this.panel_DropOff2.Controls.Add(this.pictureBox_QRScan);
            this.panel_DropOff2.Location = new System.Drawing.Point(0, 120);
            this.panel_DropOff2.Name = "panel_DropOff2";
            this.panel_DropOff2.Size = new System.Drawing.Size(464, 371);
            this.panel_DropOff2.TabIndex = 1;
            this.panel_DropOff2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_CarDetails
            // 
            this.panel_CarDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.panel_CarDetails.Controls.Add(this.pictureBox1);
            this.panel_CarDetails.Location = new System.Drawing.Point(22, 165);
            this.panel_CarDetails.Name = "panel_CarDetails";
            this.panel_CarDetails.Size = new System.Drawing.Size(420, 188);
            this.panel_CarDetails.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_SearchingForDriver
            // 
            this.panel_SearchingForDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel_SearchingForDriver.Controls.Add(this.label_Searching);
            this.panel_SearchingForDriver.Location = new System.Drawing.Point(74, 79);
            this.panel_SearchingForDriver.Name = "panel_SearchingForDriver";
            this.panel_SearchingForDriver.Size = new System.Drawing.Size(317, 42);
            this.panel_SearchingForDriver.TabIndex = 1;
            // 
            // panel_paymentlabel
            // 
            this.panel_paymentlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel_paymentlabel.Controls.Add(this.label_Payment);
            this.panel_paymentlabel.Location = new System.Drawing.Point(-18, 80);
            this.panel_paymentlabel.Name = "panel_paymentlabel";
            this.panel_paymentlabel.Size = new System.Drawing.Size(225, 40);
            this.panel_paymentlabel.TabIndex = 15;
            // 
            // pctProfile2
            // 
            this.pctProfile2.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctProfile2.Image = ((System.Drawing.Image)(resources.GetObject("pctProfile2.Image")));
            this.pctProfile2.Location = new System.Drawing.Point(390, 60);
            this.pctProfile2.Name = "pctProfile2";
            this.pctProfile2.Size = new System.Drawing.Size(30, 32);
            this.pctProfile2.TabIndex = 19;
            this.pctProfile2.TabStop = false;
            // 
            // pctSettings2
            // 
            this.pctSettings2.BackColor = System.Drawing.Color.Transparent;
            this.pctSettings2.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings2.Image")));
            this.pctSettings2.Location = new System.Drawing.Point(424, 57);
            this.pctSettings2.Name = "pctSettings2";
            this.pctSettings2.Size = new System.Drawing.Size(65, 62);
            this.pctSettings2.TabIndex = 17;
            this.pctSettings2.TabStop = false;
            // 
            // pctSettings
            // 
            this.pctSettings.BackColor = System.Drawing.Color.Transparent;
            this.pctSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings.Image")));
            this.pctSettings.Location = new System.Drawing.Point(424, 57);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(65, 62);
            this.pctSettings.TabIndex = 16;
            this.pctSettings.TabStop = false;
            // 
            // pctProfile
            // 
            this.pctProfile.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctProfile.Image = ((System.Drawing.Image)(resources.GetObject("pctProfile.Image")));
            this.pctProfile.Location = new System.Drawing.Point(390, 60);
            this.pctProfile.Name = "pctProfile";
            this.pctProfile.Size = new System.Drawing.Size(30, 32);
            this.pctProfile.TabIndex = 18;
            this.pctProfile.TabStop = false;
            // 
            // frm_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 733);
            this.Controls.Add(this.panel_DriverInfo);
            this.Controls.Add(this.panel_paymentlabel);
            this.Controls.Add(this.panel_SearchingForDriver);
            this.Controls.Add(this.panel_DropOff);
            this.Controls.Add(this.pctMarker);
            this.Controls.Add(this.btn_WaitPickUp);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_CarDetails);
            this.Controls.Add(this.panel_DropOff2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_student";
            this.Load += new System.EventHandler(this.frm_student_Load);
            this.panel1.ResumeLayout(false);
            this.panel_DriverPop.ResumeLayout(false);
            this.panel_DriverPop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Searching)).EndInit();
            this.panel_DriverInfo.ResumeLayout(false);
            this.panel_DriverInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarker)).EndInit();
            this.panel_DropOff.ResumeLayout(false);
            this.panel_DropOff2.ResumeLayout(false);
            this.panel_DropOff2.PerformLayout();
            this.panel_CarDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_SearchingForDriver.ResumeLayout(false);
            this.panel_SearchingForDriver.PerformLayout();
            this.panel_paymentlabel.ResumeLayout(false);
            this.panel_paymentlabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctMarker;
        private Bunifu.Framework.UI.BunifuFlatButton btn_WaitPickUp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Searching;
        private System.Windows.Forms.Label label_Searching;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel_DriverPop;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Pasabay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Babay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_DriverInfo;
        private System.Windows.Forms.Label label_DriverInfo;
        private System.Windows.Forms.Panel panel_DropOff;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DropOff;
        private System.Windows.Forms.Label label_Payment;
        private System.Windows.Forms.PictureBox pictureBox_QRScan;
        private System.Windows.Forms.Panel panel_DropOff2;
        private System.Windows.Forms.Panel panel_CarDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_SearchingForDriver;
        private System.Windows.Forms.Panel panel_paymentlabel;
        private System.Windows.Forms.PictureBox pctProfile2;
        private System.Windows.Forms.PictureBox pctSettings2;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.PictureBox pctProfile;
    }
}