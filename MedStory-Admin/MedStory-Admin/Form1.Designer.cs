
namespace MedStory_Admin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NomorDaruratButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.activeMark = new System.Windows.Forms.Panel();
            this.RoboDocButton = new System.Windows.Forms.Button();
            this.PenggunaButton = new System.Windows.Forms.Button();
            this.AsupanButton = new System.Windows.Forms.Button();
            this.ForumButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.activeNav = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.RoboDocManButton = new System.Windows.Forms.Button();
            this.databaseButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.robodoc_Database1 = new MedStory_Admin.Robodoc_Database();
            this.darurat_Database1 = new MedStory_Admin.Darurat_Database();
            this.asupan_Database1 = new MedStory_Admin.Asupan_Database();
            this.pengguna_Database1 = new MedStory_Admin.Pengguna_Database();
            this.forum_Database1 = new MedStory_Admin.Forum_Database();
            this.robodoc_Manajemen1 = new MedStory_Admin.Robodoc_Manajemen();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.NomorDaruratButton);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.activeMark);
            this.panel1.Controls.Add(this.RoboDocButton);
            this.panel1.Controls.Add(this.PenggunaButton);
            this.panel1.Controls.Add(this.AsupanButton);
            this.panel1.Controls.Add(this.ForumButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 884);
            this.panel1.TabIndex = 0;
            // 
            // NomorDaruratButton
            // 
            this.NomorDaruratButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.NomorDaruratButton.FlatAppearance.BorderSize = 0;
            this.NomorDaruratButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NomorDaruratButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomorDaruratButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NomorDaruratButton.Image = ((System.Drawing.Image)(resources.GetObject("NomorDaruratButton.Image")));
            this.NomorDaruratButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomorDaruratButton.Location = new System.Drawing.Point(16, 405);
            this.NomorDaruratButton.Margin = new System.Windows.Forms.Padding(4);
            this.NomorDaruratButton.Name = "NomorDaruratButton";
            this.NomorDaruratButton.Size = new System.Drawing.Size(304, 74);
            this.NomorDaruratButton.TabIndex = 7;
            this.NomorDaruratButton.Text = "   Nomor Darurat";
            this.NomorDaruratButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NomorDaruratButton.UseVisualStyleBackColor = false;
            this.NomorDaruratButton.Click += new System.EventHandler(this.NomorDaruratButton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(196, 829);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 43);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(266, 852);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "v1.0";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(11, 829);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(174, 43);
            this.button9.TabIndex = 6;
            this.button9.Text = "Ganti Akun";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // activeMark
            // 
            this.activeMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.activeMark.Location = new System.Drawing.Point(0, 117);
            this.activeMark.Name = "activeMark";
            this.activeMark.Size = new System.Drawing.Size(15, 74);
            this.activeMark.TabIndex = 2;
            // 
            // RoboDocButton
            // 
            this.RoboDocButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.RoboDocButton.FlatAppearance.BorderSize = 0;
            this.RoboDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoboDocButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoboDocButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RoboDocButton.Image = ((System.Drawing.Image)(resources.GetObject("RoboDocButton.Image")));
            this.RoboDocButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RoboDocButton.Location = new System.Drawing.Point(16, 337);
            this.RoboDocButton.Margin = new System.Windows.Forms.Padding(4);
            this.RoboDocButton.Name = "RoboDocButton";
            this.RoboDocButton.Size = new System.Drawing.Size(304, 74);
            this.RoboDocButton.TabIndex = 5;
            this.RoboDocButton.Text = "   RoboDoc";
            this.RoboDocButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RoboDocButton.UseVisualStyleBackColor = false;
            this.RoboDocButton.Click += new System.EventHandler(this.RoboDocButton_Click);
            // 
            // PenggunaButton
            // 
            this.PenggunaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PenggunaButton.FlatAppearance.BorderSize = 0;
            this.PenggunaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenggunaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenggunaButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PenggunaButton.Image = ((System.Drawing.Image)(resources.GetObject("PenggunaButton.Image")));
            this.PenggunaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PenggunaButton.Location = new System.Drawing.Point(16, 191);
            this.PenggunaButton.Margin = new System.Windows.Forms.Padding(4);
            this.PenggunaButton.Name = "PenggunaButton";
            this.PenggunaButton.Size = new System.Drawing.Size(304, 74);
            this.PenggunaButton.TabIndex = 4;
            this.PenggunaButton.Text = "   Pengguna";
            this.PenggunaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PenggunaButton.UseVisualStyleBackColor = false;
            this.PenggunaButton.Click += new System.EventHandler(this.PenggunaButton_Click);
            // 
            // AsupanButton
            // 
            this.AsupanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AsupanButton.FlatAppearance.BorderSize = 0;
            this.AsupanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsupanButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsupanButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AsupanButton.Image = ((System.Drawing.Image)(resources.GetObject("AsupanButton.Image")));
            this.AsupanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AsupanButton.Location = new System.Drawing.Point(16, 263);
            this.AsupanButton.Margin = new System.Windows.Forms.Padding(4);
            this.AsupanButton.Name = "AsupanButton";
            this.AsupanButton.Size = new System.Drawing.Size(304, 74);
            this.AsupanButton.TabIndex = 3;
            this.AsupanButton.Text = "   Asupan";
            this.AsupanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AsupanButton.UseVisualStyleBackColor = false;
            this.AsupanButton.Click += new System.EventHandler(this.AsupanButton_Click);
            // 
            // ForumButton
            // 
            this.ForumButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ForumButton.FlatAppearance.BorderSize = 0;
            this.ForumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForumButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForumButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ForumButton.Image = ((System.Drawing.Image)(resources.GetObject("ForumButton.Image")));
            this.ForumButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ForumButton.Location = new System.Drawing.Point(16, 117);
            this.ForumButton.Margin = new System.Windows.Forms.Padding(4);
            this.ForumButton.Name = "ForumButton";
            this.ForumButton.Size = new System.Drawing.Size(304, 74);
            this.ForumButton.TabIndex = 2;
            this.ForumButton.Text = "   Forum";
            this.ForumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ForumButton.UseVisualStyleBackColor = false;
            this.ForumButton.Click += new System.EventHandler(this.ForumButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, Flazen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(131)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.activeNav);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.RoboDocManButton);
            this.panel2.Controls.Add(this.databaseButton);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(319, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1237, 71);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // activeNav
            // 
            this.activeNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.activeNav.Location = new System.Drawing.Point(261, 58);
            this.activeNav.Name = "activeNav";
            this.activeNav.Size = new System.Drawing.Size(150, 6);
            this.activeNav.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Location = new System.Drawing.Point(725, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 45);
            this.button13.TabIndex = 9;
            this.button13.Text = "Riwayat";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Location = new System.Drawing.Point(569, 7);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(150, 45);
            this.button14.TabIndex = 8;
            this.button14.Text = "Statistik";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // RoboDocManButton
            // 
            this.RoboDocManButton.FlatAppearance.BorderSize = 0;
            this.RoboDocManButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoboDocManButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RoboDocManButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RoboDocManButton.Location = new System.Drawing.Point(414, 7);
            this.RoboDocManButton.Name = "RoboDocManButton";
            this.RoboDocManButton.Size = new System.Drawing.Size(150, 45);
            this.RoboDocManButton.TabIndex = 7;
            this.RoboDocManButton.Text = "Manajemen";
            this.RoboDocManButton.UseVisualStyleBackColor = true;
            this.RoboDocManButton.Click += new System.EventHandler(this.RoboDocManButton_Click);
            // 
            // databaseButton
            // 
            this.databaseButton.FlatAppearance.BorderSize = 0;
            this.databaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.databaseButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.databaseButton.Location = new System.Drawing.Point(259, 7);
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(150, 45);
            this.databaseButton.TabIndex = 6;
            this.databaseButton.Text = "Database";
            this.databaseButton.UseVisualStyleBackColor = true;
            this.databaseButton.Click += new System.EventHandler(this.databaseButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(1105, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 49);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.minimize);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(1167, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 49);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.turnOff);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1461, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(1517, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 50);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // robodoc_Database1
            // 
            this.robodoc_Database1.Location = new System.Drawing.Point(319, 67);
            this.robodoc_Database1.Name = "robodoc_Database1";
            this.robodoc_Database1.Size = new System.Drawing.Size(1225, 800);
            this.robodoc_Database1.TabIndex = 6;
            // 
            // darurat_Database1
            // 
            this.darurat_Database1.Location = new System.Drawing.Point(319, 70);
            this.darurat_Database1.Name = "darurat_Database1";
            this.darurat_Database1.Size = new System.Drawing.Size(1225, 800);
            this.darurat_Database1.TabIndex = 5;
            // 
            // asupan_Database1
            // 
            this.asupan_Database1.Location = new System.Drawing.Point(325, 76);
            this.asupan_Database1.Name = "asupan_Database1";
            this.asupan_Database1.Size = new System.Drawing.Size(1225, 800);
            this.asupan_Database1.TabIndex = 4;
            // 
            // pengguna_Database1
            // 
            this.pengguna_Database1.Location = new System.Drawing.Point(325, 76);
            this.pengguna_Database1.Name = "pengguna_Database1";
            this.pengguna_Database1.Size = new System.Drawing.Size(1225, 800);
            this.pengguna_Database1.TabIndex = 3;
            // 
            // forum_Database1
            // 
            this.forum_Database1.Location = new System.Drawing.Point(325, 76);
            this.forum_Database1.Name = "forum_Database1";
            this.forum_Database1.Size = new System.Drawing.Size(1225, 801);
            this.forum_Database1.TabIndex = 2;
            // 
            // robodoc_Manajemen1
            // 
            this.robodoc_Manajemen1.Location = new System.Drawing.Point(319, 67);
            this.robodoc_Manajemen1.Name = "robodoc_Manajemen1";
            this.robodoc_Manajemen1.Size = new System.Drawing.Size(1225, 800);
            this.robodoc_Manajemen1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.robodoc_Manajemen1);
            this.Controls.Add(this.robodoc_Database1);
            this.Controls.Add(this.darurat_Database1);
            this.Controls.Add(this.asupan_Database1);
            this.Controls.Add(this.pengguna_Database1);
            this.Controls.Add(this.forum_Database1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ForumButton;
        private System.Windows.Forms.Button PenggunaButton;
        private System.Windows.Forms.Button AsupanButton;
        private System.Windows.Forms.Button RoboDocButton;
        private System.Windows.Forms.Panel activeMark;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button databaseButton;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button RoboDocManButton;
        private System.Windows.Forms.Panel activeNav;
        private System.Windows.Forms.Button NomorDaruratButton;
        private Forum_Database forum_Database1;
        private Pengguna_Database pengguna_Database1;
        private Asupan_Database asupan_Database1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Darurat_Database darurat_Database1;
        private Robodoc_Database robodoc_Database1;
        private Robodoc_Manajemen robodoc_Manajemen1;
    }
}

