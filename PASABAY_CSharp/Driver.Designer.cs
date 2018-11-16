namespace PASABAY_CSharp
{
    partial class frmDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDriver));
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnZoomin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnZoomout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDestination = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pctMarker = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctSettings = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pctSettings2 = new System.Windows.Forms.PictureBox();
            this.pctProfile = new System.Windows.Forms.PictureBox();
            this.pctProfile2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(-1, 131);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(482, 367);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 0D;
            this.gMap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // btnZoomin
            // 
            this.btnZoomin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZoomin.BackColor = System.Drawing.Color.White;
            this.btnZoomin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomin.BorderRadius = 0;
            this.btnZoomin.ButtonText = "+";
            this.btnZoomin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomin.DisabledColor = System.Drawing.Color.Gray;
            this.btnZoomin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZoomin.Iconimage = null;
            this.btnZoomin.Iconimage_right = null;
            this.btnZoomin.Iconimage_right_Selected = null;
            this.btnZoomin.Iconimage_Selected = null;
            this.btnZoomin.IconMarginLeft = 0;
            this.btnZoomin.IconMarginRight = 0;
            this.btnZoomin.IconRightVisible = true;
            this.btnZoomin.IconRightZoom = 0D;
            this.btnZoomin.IconVisible = true;
            this.btnZoomin.IconZoom = 90D;
            this.btnZoomin.IsTab = false;
            this.btnZoomin.Location = new System.Drawing.Point(417, 376);
            this.btnZoomin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoomin.Name = "btnZoomin";
            this.btnZoomin.Normalcolor = System.Drawing.Color.White;
            this.btnZoomin.OnHovercolor = System.Drawing.Color.Gray;
            this.btnZoomin.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnZoomin.selected = false;
            this.btnZoomin.Size = new System.Drawing.Size(51, 52);
            this.btnZoomin.TabIndex = 1;
            this.btnZoomin.Text = "+";
            this.btnZoomin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZoomin.Textcolor = System.Drawing.Color.Black;
            this.btnZoomin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomin.Click += new System.EventHandler(this.btnZoomin_Click);
            // 
            // btnZoomout
            // 
            this.btnZoomout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnZoomout.BackColor = System.Drawing.Color.White;
            this.btnZoomout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomout.BorderRadius = 0;
            this.btnZoomout.ButtonText = "-";
            this.btnZoomout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomout.DisabledColor = System.Drawing.Color.Gray;
            this.btnZoomout.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZoomout.Iconimage = null;
            this.btnZoomout.Iconimage_right = null;
            this.btnZoomout.Iconimage_right_Selected = null;
            this.btnZoomout.Iconimage_Selected = null;
            this.btnZoomout.IconMarginLeft = 0;
            this.btnZoomout.IconMarginRight = 0;
            this.btnZoomout.IconRightVisible = true;
            this.btnZoomout.IconRightZoom = 0D;
            this.btnZoomout.IconVisible = true;
            this.btnZoomout.IconZoom = 90D;
            this.btnZoomout.IsTab = false;
            this.btnZoomout.Location = new System.Drawing.Point(417, 436);
            this.btnZoomout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoomout.Name = "btnZoomout";
            this.btnZoomout.Normalcolor = System.Drawing.Color.White;
            this.btnZoomout.OnHovercolor = System.Drawing.Color.Gray;
            this.btnZoomout.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnZoomout.selected = false;
            this.btnZoomout.Size = new System.Drawing.Size(51, 52);
            this.btnZoomout.TabIndex = 2;
            this.btnZoomout.Text = "-";
            this.btnZoomout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnZoomout.Textcolor = System.Drawing.Color.Black;
            this.btnZoomout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomout.Click += new System.EventHandler(this.btnZoomout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your route";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-1, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 367);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select destination:";
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
            this.btnDestination.Location = new System.Drawing.Point(79, 567);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(323, 41);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Find Route";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(127, 614);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(227, 48);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Find Route";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pctMarker
            // 
            this.pctMarker.BackColor = System.Drawing.Color.Transparent;
            this.pctMarker.Image = ((System.Drawing.Image)(resources.GetObject("pctMarker.Image")));
            this.pctMarker.Location = new System.Drawing.Point(77, 567);
            this.pctMarker.Name = "pctMarker";
            this.pctMarker.Size = new System.Drawing.Size(42, 36);
            this.pctMarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMarker.TabIndex = 7;
            this.pctMarker.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(202, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(156, 20);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctSettings
            // 
            this.pctSettings.BackColor = System.Drawing.Color.Transparent;
            this.pctSettings.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings.Image")));
            this.pctSettings.Location = new System.Drawing.Point(433, 87);
            this.pctSettings.Name = "pctSettings";
            this.pctSettings.Size = new System.Drawing.Size(65, 62);
            this.pctSettings.TabIndex = 9;
            this.pctSettings.TabStop = false;
            this.pctSettings.Click += new System.EventHandler(this.pctSettings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(281, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 210);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Log out";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Exit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Help";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "APP settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account settings";
            // 
            // pctSettings2
            // 
            this.pctSettings2.BackColor = System.Drawing.Color.Transparent;
            this.pctSettings2.Image = ((System.Drawing.Image)(resources.GetObject("pctSettings2.Image")));
            this.pctSettings2.Location = new System.Drawing.Point(433, 87);
            this.pctSettings2.Name = "pctSettings2";
            this.pctSettings2.Size = new System.Drawing.Size(65, 62);
            this.pctSettings2.TabIndex = 10;
            this.pctSettings2.TabStop = false;
            this.pctSettings2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctProfile
            // 
            this.pctProfile.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctProfile.Image = ((System.Drawing.Image)(resources.GetObject("pctProfile.Image")));
            this.pctProfile.Location = new System.Drawing.Point(399, 90);
            this.pctProfile.Name = "pctProfile";
            this.pctProfile.Size = new System.Drawing.Size(30, 32);
            this.pctProfile.TabIndex = 11;
            this.pctProfile.TabStop = false;
            this.pctProfile.Click += new System.EventHandler(this.pctProfile_Click);
            // 
            // pctProfile2
            // 
            this.pctProfile2.BackColor = System.Drawing.Color.Transparent;
            this.pctProfile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctProfile2.Image = ((System.Drawing.Image)(resources.GetObject("pctProfile2.Image")));
            this.pctProfile2.Location = new System.Drawing.Point(399, 90);
            this.pctProfile2.Name = "pctProfile2";
            this.pctProfile2.Size = new System.Drawing.Size(30, 32);
            this.pctProfile2.TabIndex = 12;
            this.pctProfile2.TabStop = false;
            this.pctProfile2.Click += new System.EventHandler(this.pctProfile2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(281, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 90);
            this.panel3.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Profile";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(74, 738);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "     ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 772);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pctProfile2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pctSettings2);
            this.Controls.Add(this.pctSettings);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pctMarker);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZoomout);
            this.Controls.Add(this.btnZoomin);
            this.Controls.Add(this.gMap);
            this.Controls.Add(this.pctProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.frmDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSettings2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfile2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private Bunifu.Framework.UI.BunifuFlatButton btnZoomin;
        private Bunifu.Framework.UI.BunifuFlatButton btnZoomout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btnDestination;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pctMarker;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pctSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctSettings2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctProfile;
        private System.Windows.Forms.PictureBox pctProfile2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}