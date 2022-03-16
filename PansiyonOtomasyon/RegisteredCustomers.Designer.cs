namespace PansiyonOtomasyon
{
    partial class RegisteredCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisteredCustomers));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.NO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isDeleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnshowcustomers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btndeletecustomers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnupdatecustomers = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtidnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtroomnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtprice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsurname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtgender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.entrydatetime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.enddatetime = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txttotalday = new System.Windows.Forms.Label();
            this.txtsearchcustomer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnregistercustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtisdeleted = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnsearchcustomers = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1170, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1241, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.toppanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.toppanel.Controls.Add(this.pictureBox3);
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Controls.Add(this.pictureBox2);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1277, 32);
            this.toppanel.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1211, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NO,
            this.IDNumber,
            this.AD,
            this.Surname,
            this.Gender,
            this.Phone,
            this.EMail,
            this.RoomNumber,
            this.Price,
            this.EntryDate,
            this.EndDate,
            this.isDeleted});
            this.listView1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 242);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1276, 361);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // NO
            // 
            this.NO.Text = "No";
            this.NO.Width = 35;
            // 
            // IDNumber
            // 
            this.IDNumber.Text = "IDNumber";
            this.IDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDNumber.Width = 115;
            // 
            // AD
            // 
            this.AD.Text = "Name";
            this.AD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD.Width = 100;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Surname.Width = 120;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gender.Width = 80;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 135;
            // 
            // EMail
            // 
            this.EMail.Text = "Email";
            this.EMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EMail.Width = 200;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "Room";
            this.RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomNumber.Width = 75;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 80;
            // 
            // EntryDate
            // 
            this.EntryDate.Text = "EntryDate";
            this.EntryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EntryDate.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.Text = "EndDate";
            this.EndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndDate.Width = 125;
            // 
            // isDeleted
            // 
            this.isDeleted.Text = "isDeleted";
            this.isDeleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isDeleted.Width = 85;
            // 
            // btnshowcustomers
            // 
            this.btnshowcustomers.ActiveBorderThickness = 1;
            this.btnshowcustomers.ActiveCornerRadius = 25;
            this.btnshowcustomers.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnshowcustomers.ActiveForecolor = System.Drawing.Color.White;
            this.btnshowcustomers.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnshowcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnshowcustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnshowcustomers.BackgroundImage")));
            this.btnshowcustomers.ButtonText = "Show Customers";
            this.btnshowcustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowcustomers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshowcustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnshowcustomers.IdleBorderThickness = 1;
            this.btnshowcustomers.IdleCornerRadius = 15;
            this.btnshowcustomers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnshowcustomers.IdleForecolor = System.Drawing.Color.White;
            this.btnshowcustomers.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnshowcustomers.Location = new System.Drawing.Point(1075, 178);
            this.btnshowcustomers.Margin = new System.Windows.Forms.Padding(5);
            this.btnshowcustomers.Name = "btnshowcustomers";
            this.btnshowcustomers.Size = new System.Drawing.Size(188, 57);
            this.btnshowcustomers.TabIndex = 18;
            this.btnshowcustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnshowcustomers.Click += new System.EventHandler(this.btnshowcustomers_Click);
            // 
            // btndeletecustomers
            // 
            this.btndeletecustomers.ActiveBorderThickness = 1;
            this.btndeletecustomers.ActiveCornerRadius = 25;
            this.btndeletecustomers.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btndeletecustomers.ActiveForecolor = System.Drawing.Color.White;
            this.btndeletecustomers.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btndeletecustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btndeletecustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndeletecustomers.BackgroundImage")));
            this.btndeletecustomers.ButtonText = "Delete";
            this.btndeletecustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletecustomers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeletecustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btndeletecustomers.IdleBorderThickness = 1;
            this.btndeletecustomers.IdleCornerRadius = 15;
            this.btndeletecustomers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btndeletecustomers.IdleForecolor = System.Drawing.Color.White;
            this.btndeletecustomers.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btndeletecustomers.Location = new System.Drawing.Point(1075, 111);
            this.btndeletecustomers.Margin = new System.Windows.Forms.Padding(5);
            this.btndeletecustomers.Name = "btndeletecustomers";
            this.btndeletecustomers.Size = new System.Drawing.Size(188, 57);
            this.btndeletecustomers.TabIndex = 37;
            this.btndeletecustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndeletecustomers.Click += new System.EventHandler(this.btndeletecustomers_Click);
            // 
            // btnupdatecustomers
            // 
            this.btnupdatecustomers.ActiveBorderThickness = 1;
            this.btnupdatecustomers.ActiveCornerRadius = 25;
            this.btnupdatecustomers.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnupdatecustomers.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdatecustomers.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnupdatecustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnupdatecustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdatecustomers.BackgroundImage")));
            this.btnupdatecustomers.ButtonText = "Update";
            this.btnupdatecustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdatecustomers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdatecustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnupdatecustomers.IdleBorderThickness = 1;
            this.btnupdatecustomers.IdleCornerRadius = 15;
            this.btnupdatecustomers.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnupdatecustomers.IdleForecolor = System.Drawing.Color.White;
            this.btnupdatecustomers.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnupdatecustomers.Location = new System.Drawing.Point(1075, 44);
            this.btnupdatecustomers.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdatecustomers.Name = "btnupdatecustomers";
            this.btnupdatecustomers.Size = new System.Drawing.Size(188, 57);
            this.btnupdatecustomers.TabIndex = 38;
            this.btnupdatecustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdatecustomers.Click += new System.EventHandler(this.btnupdatecustomers_Click);
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtname.HintForeColor = System.Drawing.Color.Empty;
            this.txtname.HintText = "";
            this.txtname.isPassword = false;
            this.txtname.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtname.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtname.LineThickness = 3;
            this.txtname.Location = new System.Drawing.Point(235, 39);
            this.txtname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(146, 42);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Name";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtphone
            // 
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtphone.HintForeColor = System.Drawing.Color.Empty;
            this.txtphone.HintText = "";
            this.txtphone.isPassword = false;
            this.txtphone.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtphone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtphone.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtphone.LineThickness = 3;
            this.txtphone.Location = new System.Drawing.Point(14, 139);
            this.txtphone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(211, 42);
            this.txtphone.TabIndex = 5;
            this.txtphone.Text = "Phone Number";
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            this.txtemail.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtemail.HintForeColor = System.Drawing.Color.Empty;
            this.txtemail.HintText = "";
            this.txtemail.isPassword = false;
            this.txtemail.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtemail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtemail.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtemail.LineThickness = 3;
            this.txtemail.Location = new System.Drawing.Point(235, 89);
            this.txtemail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(355, 42);
            this.txtemail.TabIndex = 4;
            this.txtemail.Text = "E-Mail";
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidnumber
            // 
            this.txtidnumber.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtidnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidnumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtidnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtidnumber.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtidnumber.HintText = "";
            this.txtidnumber.isPassword = false;
            this.txtidnumber.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtidnumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtidnumber.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtidnumber.LineThickness = 3;
            this.txtidnumber.Location = new System.Drawing.Point(14, 39);
            this.txtidnumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(211, 42);
            this.txtidnumber.TabIndex = 0;
            this.txtidnumber.Text = "ID Number";
            this.txtidnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtroomnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomnumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtroomnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtroomnumber.HintForeColor = System.Drawing.Color.Empty;
            this.txtroomnumber.HintText = "";
            this.txtroomnumber.isPassword = false;
            this.txtroomnumber.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtroomnumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtroomnumber.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtroomnumber.LineThickness = 3;
            this.txtroomnumber.Location = new System.Drawing.Point(235, 139);
            this.txtroomnumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.Size = new System.Drawing.Size(168, 42);
            this.txtroomnumber.TabIndex = 6;
            this.txtroomnumber.Text = "Room Number";
            this.txtroomnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprice
            // 
            this.txtprice.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtprice.HintForeColor = System.Drawing.Color.Empty;
            this.txtprice.HintText = "";
            this.txtprice.isPassword = false;
            this.txtprice.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtprice.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtprice.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtprice.LineThickness = 3;
            this.txtprice.Location = new System.Drawing.Point(413, 139);
            this.txtprice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(177, 42);
            this.txtprice.TabIndex = 7;
            this.txtprice.Text = "Price";
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsurname
            // 
            this.txtsurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtsurname.HintForeColor = System.Drawing.Color.Empty;
            this.txtsurname.HintText = "";
            this.txtsurname.isPassword = false;
            this.txtsurname.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtsurname.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtsurname.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtsurname.LineThickness = 3;
            this.txtsurname.Location = new System.Drawing.Point(391, 39);
            this.txtsurname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(199, 42);
            this.txtsurname.TabIndex = 2;
            this.txtsurname.Text = "Surname";
            this.txtsurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtgender
            // 
            this.txtgender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtgender.HintForeColor = System.Drawing.Color.Empty;
            this.txtgender.HintText = "";
            this.txtgender.isPassword = false;
            this.txtgender.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtgender.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtgender.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtgender.LineThickness = 3;
            this.txtgender.Location = new System.Drawing.Point(14, 89);
            this.txtgender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(211, 42);
            this.txtgender.TabIndex = 3;
            this.txtgender.Text = "Gender";
            this.txtgender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entrydatetime
            // 
            this.entrydatetime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.entrydatetime.BorderRadius = 0;
            this.entrydatetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.entrydatetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entrydatetime.FormatCustom = null;
            this.entrydatetime.Location = new System.Drawing.Point(14, 205);
            this.entrydatetime.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.entrydatetime.Name = "entrydatetime";
            this.entrydatetime.Size = new System.Drawing.Size(211, 30);
            this.entrydatetime.TabIndex = 8;
            this.entrydatetime.Value = new System.DateTime(2017, 5, 6, 18, 13, 38, 0);
            // 
            // enddatetime
            // 
            this.enddatetime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(102)))));
            this.enddatetime.BorderRadius = 0;
            this.enddatetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enddatetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddatetime.FormatCustom = null;
            this.enddatetime.Location = new System.Drawing.Point(234, 205);
            this.enddatetime.Margin = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.enddatetime.Name = "enddatetime";
            this.enddatetime.Size = new System.Drawing.Size(211, 30);
            this.enddatetime.TabIndex = 9;
            this.enddatetime.Value = new System.DateTime(2017, 5, 7, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 185);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(68, 13);
            this.bunifuCustomLabel1.TabIndex = 34;
            this.bunifuCustomLabel1.Text = "Entry Date";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(232, 185);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(59, 13);
            this.bunifuCustomLabel2.TabIndex = 35;
            this.bunifuCustomLabel2.Text = "End Date";
            // 
            // txttotalday
            // 
            this.txttotalday.AutoSize = true;
            this.txttotalday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttotalday.Location = new System.Drawing.Point(132, 185);
            this.txttotalday.Name = "txttotalday";
            this.txttotalday.Size = new System.Drawing.Size(41, 13);
            this.txttotalday.TabIndex = 36;
            this.txttotalday.Text = "label1";
            this.txttotalday.Visible = false;
            // 
            // txtsearchcustomer
            // 
            this.txtsearchcustomer.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.txtsearchcustomer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.txtsearchcustomer.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.txtsearchcustomer.BorderThickness = 3;
            this.txtsearchcustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchcustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearchcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtsearchcustomer.isPassword = false;
            this.txtsearchcustomer.Location = new System.Drawing.Point(600, 44);
            this.txtsearchcustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsearchcustomer.Name = "txtsearchcustomer";
            this.txtsearchcustomer.Size = new System.Drawing.Size(465, 57);
            this.txtsearchcustomer.TabIndex = 39;
            this.txtsearchcustomer.Text = "Enter Name";
            this.txtsearchcustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnregistercustomer
            // 
            this.btnregistercustomer.ActiveBorderThickness = 1;
            this.btnregistercustomer.ActiveCornerRadius = 25;
            this.btnregistercustomer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnregistercustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnregistercustomer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnregistercustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.btnregistercustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistercustomer.BackgroundImage")));
            this.btnregistercustomer.ButtonText = "Add New Customer";
            this.btnregistercustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistercustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnregistercustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnregistercustomer.IdleBorderThickness = 1;
            this.btnregistercustomer.IdleCornerRadius = 15;
            this.btnregistercustomer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnregistercustomer.IdleForecolor = System.Drawing.Color.White;
            this.btnregistercustomer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnregistercustomer.Location = new System.Drawing.Point(691, 177);
            this.btnregistercustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnregistercustomer.Name = "btnregistercustomer";
            this.btnregistercustomer.Size = new System.Drawing.Size(374, 57);
            this.btnregistercustomer.TabIndex = 41;
            this.btnregistercustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnregistercustomer.Click += new System.EventHandler(this.btnregistercustomer_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(625, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtisdeleted
            // 
            this.txtisdeleted.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtisdeleted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtisdeleted.Enabled = false;
            this.txtisdeleted.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtisdeleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtisdeleted.HintForeColor = System.Drawing.Color.Empty;
            this.txtisdeleted.HintText = "";
            this.txtisdeleted.isPassword = false;
            this.txtisdeleted.LineFocusedColor = System.Drawing.Color.Maroon;
            this.txtisdeleted.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.txtisdeleted.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.txtisdeleted.LineThickness = 3;
            this.txtisdeleted.Location = new System.Drawing.Point(461, 189);
            this.txtisdeleted.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtisdeleted.Name = "txtisdeleted";
            this.txtisdeleted.Size = new System.Drawing.Size(129, 42);
            this.txtisdeleted.TabIndex = 10;
            this.txtisdeleted.Text = "isDeleted";
            this.txtisdeleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsearchcustomers
            // 
            this.btnsearchcustomers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsearchcustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnsearchcustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearchcustomers.BorderRadius = 0;
            this.btnsearchcustomers.ButtonText = "SEARCH";
            this.btnsearchcustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchcustomers.DisabledColor = System.Drawing.Color.Gray;
            this.btnsearchcustomers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsearchcustomers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsearchcustomers.Iconimage")));
            this.btnsearchcustomers.Iconimage_right = null;
            this.btnsearchcustomers.Iconimage_right_Selected = null;
            this.btnsearchcustomers.Iconimage_Selected = null;
            this.btnsearchcustomers.IconMarginLeft = 0;
            this.btnsearchcustomers.IconMarginRight = 0;
            this.btnsearchcustomers.IconRightVisible = true;
            this.btnsearchcustomers.IconRightZoom = 0D;
            this.btnsearchcustomers.IconVisible = true;
            this.btnsearchcustomers.IconZoom = 90D;
            this.btnsearchcustomers.IsTab = false;
            this.btnsearchcustomers.Location = new System.Drawing.Point(751, 109);
            this.btnsearchcustomers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnsearchcustomers.Name = "btnsearchcustomers";
            this.btnsearchcustomers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(95)))), ((int)(((byte)(123)))));
            this.btnsearchcustomers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.btnsearchcustomers.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnsearchcustomers.selected = false;
            this.btnsearchcustomers.Size = new System.Drawing.Size(171, 50);
            this.btnsearchcustomers.TabIndex = 42;
            this.btnsearchcustomers.Text = "SEARCH";
            this.btnsearchcustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearchcustomers.Textcolor = System.Drawing.Color.White;
            this.btnsearchcustomers.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsearchcustomers.Click += new System.EventHandler(this.btnsearchcustomers_Click);
            // 
            // RegisteredCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1277, 605);
            this.Controls.Add(this.btnsearchcustomers);
            this.Controls.Add(this.txtisdeleted);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnregistercustomer);
            this.Controls.Add(this.txtsearchcustomer);
            this.Controls.Add(this.btnupdatecustomers);
            this.Controls.Add(this.btndeletecustomers);
            this.Controls.Add(this.txttotalday);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.enddatetime);
            this.Controls.Add(this.entrydatetime);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtroomnumber);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnshowcustomers);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisteredCustomers";
            this.Text = "RegisteredCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NO;
        private System.Windows.Forms.ColumnHeader IDNumber;
        private System.Windows.Forms.ColumnHeader AD;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader EMail;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader EntryDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnshowcustomers;
        private Bunifu.Framework.UI.BunifuThinButton2 btnregistercustomer;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsearchcustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnupdatecustomers;
        private Bunifu.Framework.UI.BunifuThinButton2 btndeletecustomers;
        private System.Windows.Forms.Label txttotalday;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker enddatetime;
        private Bunifu.Framework.UI.BunifuDatepicker entrydatetime;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtgender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsurname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtroomnumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtidnumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtemail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtname;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ColumnHeader isDeleted;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtisdeleted;
        private Bunifu.Framework.UI.BunifuFlatButton btnsearchcustomers;
    }
}