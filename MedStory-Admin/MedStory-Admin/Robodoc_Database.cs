using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedStory_Admin
{
    public partial class Robodoc_Database : UserControl
    {
        public Robodoc_Database()
        {
            InitializeComponent();
        }

        private void RoboDoc_Database_Load(object sender, EventArgs e)
        {

        }
        public void displayPenyakit()
        {
            DBMedStory.ReadUser("SELECT * FROM smartdoc", dataGridView1);
        }
        public void displayGejala()
        {
            DBMedStory.ReadUser("SELECT * FROM gejala", dataGridView2);
        }
        public void displayRelasi()
        {
            DBMedStory.ReadUser("SELECT id_relasi, id_penyakit, id_gejala, nama_penyakit, nama_gejala FROM relasipenyakitgejala JOIN gejala using(id_gejala) JOIN smartdoc using(id_penyakit)", dataGridView3);
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM smartdoc WHERE nama_penyakit LIKE '%" + searchBox1.Text + "%'", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM gejala WHERE nama_gejala LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT id_relasi, id_penyakit, id_gejala, nama_penyakit, nama_gejala FROM relasipenyakitgejala JOIN gejala using(id_gejala) JOIN smartdoc using(id_penyakit) WHERE nama_penyakit LIKE '%" + textBox2.Text + "%' OR nama_gejala LIKE '%" + textBox2.Text + "%'", dataGridView3);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Semua")
            {
                displayPenyakit();
                displayRelasi();
            }
            else if (comboBox2.Text != "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM smartdoc WHERE level = '" + comboBox2.Text + "'", dataGridView1);
                DBMedStory.ReadUser("SELECT id_relasi, id_penyakit, id_gejala, nama_penyakit, nama_gejala FROM relasipenyakitgejala JOIN gejala using(id_gejala) JOIN smartdoc using(id_penyakit) WHERE level = '" + comboBox2.Text + "'", dataGridView3);
            }
        }
    }
}
