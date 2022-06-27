
namespace MedStory_Admin
{
    partial class Darurat_Manajemen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darurat_Manajemen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namaFaskesCtrl = new System.Windows.Forms.TextBox();
            this.ratingCtrl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alamatCtrl = new System.Windows.Forms.RichTextBox();
            this.fasilitasCtrl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.poliklinikCtrl = new System.Windows.Forms.RichTextBox();
            this.kontakCtrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kordinatCtrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kordinatCtrl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.kontakCtrl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.poliklinikCtrl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fasilitasCtrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.alamatCtrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.namaFaskesCtrl);
            this.groupBox1.Controls.Add(this.ratingCtrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 422);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fasilitas Kesehatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Alamat";
            // 
            // namaFaskesCtrl
            // 
            this.namaFaskesCtrl.Location = new System.Drawing.Point(122, 29);
            this.namaFaskesCtrl.Name = "namaFaskesCtrl";
            this.namaFaskesCtrl.Size = new System.Drawing.Size(284, 22);
            this.namaFaskesCtrl.TabIndex = 68;
            // 
            // ratingCtrl
            // 
            this.ratingCtrl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ratingCtrl.FormattingEnabled = true;
            this.ratingCtrl.Items.AddRange(new object[] {
            "5.0",
            "4.8",
            "4.6",
            "4.4",
            "4.2",
            "4.0",
            "3.8",
            "3.6",
            "3.4",
            "3.2",
            "3.0",
            "2.8",
            "2.6",
            "2.4",
            "2.2",
            "2.0",
            "1.8",
            "1.6",
            "1.4",
            "1.2",
            "1.0",
            "0.8",
            "0.6",
            "0.4",
            "0.2"});
            this.ratingCtrl.Location = new System.Drawing.Point(469, 29);
            this.ratingCtrl.Name = "ratingCtrl";
            this.ratingCtrl.Size = new System.Drawing.Size(98, 24);
            this.ratingCtrl.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nama";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(427, 368);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 36);
            this.button18.TabIndex = 12;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(469, 368);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 36);
            this.button16.TabIndex = 10;
            this.button16.Text = "Tambahkan";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 28);
            this.label7.TabIndex = 71;
            this.label7.Text = "Nomor Darurat | Manajemen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Tambah Data";
            // 
            // alamatCtrl
            // 
            this.alamatCtrl.Location = new System.Drawing.Point(122, 61);
            this.alamatCtrl.Name = "alamatCtrl";
            this.alamatCtrl.Size = new System.Drawing.Size(445, 45);
            this.alamatCtrl.TabIndex = 72;
            this.alamatCtrl.Text = "";
            // 
            // fasilitasCtrl
            // 
            this.fasilitasCtrl.Location = new System.Drawing.Point(122, 115);
            this.fasilitasCtrl.Name = "fasilitasCtrl";
            this.fasilitasCtrl.Size = new System.Drawing.Size(445, 88);
            this.fasilitasCtrl.TabIndex = 74;
            this.fasilitasCtrl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Fasilitas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Poliklinik";
            // 
            // poliklinikCtrl
            // 
            this.poliklinikCtrl.Location = new System.Drawing.Point(122, 212);
            this.poliklinikCtrl.Name = "poliklinikCtrl";
            this.poliklinikCtrl.Size = new System.Drawing.Size(445, 88);
            this.poliklinikCtrl.TabIndex = 76;
            this.poliklinikCtrl.Text = "";
            // 
            // kontakCtrl
            // 
            this.kontakCtrl.Location = new System.Drawing.Point(122, 306);
            this.kontakCtrl.Name = "kontakCtrl";
            this.kontakCtrl.Size = new System.Drawing.Size(135, 22);
            this.kontakCtrl.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Kontak";
            // 
            // kordinatCtrl
            // 
            this.kordinatCtrl.Location = new System.Drawing.Point(347, 306);
            this.kordinatCtrl.Name = "kordinatCtrl";
            this.kordinatCtrl.Size = new System.Drawing.Size(220, 22);
            this.kordinatCtrl.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Kordinat";
            // 
            // Darurat_Manajemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Darurat_Manajemen";
            this.Size = new System.Drawing.Size(1225, 800);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namaFaskesCtrl;
        private System.Windows.Forms.ComboBox ratingCtrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox alamatCtrl;
        private System.Windows.Forms.RichTextBox poliklinikCtrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox fasilitasCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kordinatCtrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kontakCtrl;
        private System.Windows.Forms.Label label8;
    }
}
