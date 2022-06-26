
namespace MedStory_Admin
{
    partial class Asupan_Manajemen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asupan_Manajemen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.kategoriCtrl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namaCtrl = new System.Windows.Forms.TextBox();
            this.ukuranCtrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kaloriCtrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kaloriCtrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ukuranCtrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.namaCtrl);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.kategoriCtrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 132);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asupan";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(294, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 21);
            this.checkBox1.TabIndex = 66;
            this.checkBox1.Text = "With Image";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // kategoriCtrl
            // 
            this.kategoriCtrl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.kategoriCtrl.FormattingEnabled = true;
            this.kategoriCtrl.Items.AddRange(new object[] {
            "Daging",
            "Sayuran",
            "Buah",
            "Seafood",
            "Lainnya"});
            this.kategoriCtrl.Location = new System.Drawing.Point(122, 60);
            this.kategoriCtrl.Name = "kategoriCtrl";
            this.kategoriCtrl.Size = new System.Drawing.Size(160, 24);
            this.kategoriCtrl.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kategori";
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
            this.button18.Location = new System.Drawing.Point(427, 84);
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
            this.button16.Location = new System.Drawing.Point(469, 84);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(613, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 70;
            this.label8.Text = "Edit Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 28);
            this.label7.TabIndex = 66;
            this.label7.Text = "Asupan | Manajemen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tambah Data";
            // 
            // namaCtrl
            // 
            this.namaCtrl.Location = new System.Drawing.Point(122, 29);
            this.namaCtrl.Name = "namaCtrl";
            this.namaCtrl.Size = new System.Drawing.Size(160, 22);
            this.namaCtrl.TabIndex = 68;
            // 
            // ukuranCtrl
            // 
            this.ukuranCtrl.Location = new System.Drawing.Point(407, 29);
            this.ukuranCtrl.Name = "ukuranCtrl";
            this.ukuranCtrl.Size = new System.Drawing.Size(160, 22);
            this.ukuranCtrl.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Ukuran";
            // 
            // kaloriCtrl
            // 
            this.kaloriCtrl.Location = new System.Drawing.Point(122, 98);
            this.kaloriCtrl.Name = "kaloriCtrl";
            this.kaloriCtrl.Size = new System.Drawing.Size(160, 22);
            this.kaloriCtrl.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Kalori";
            // 
            // Asupan_Manajemen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Asupan_Manajemen";
            this.Size = new System.Drawing.Size(1225, 800);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox kategoriCtrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namaCtrl;
        private System.Windows.Forms.TextBox kaloriCtrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ukuranCtrl;
        private System.Windows.Forms.Label label2;
    }
}
