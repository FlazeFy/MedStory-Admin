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
    public partial class Darurat_Database : UserControl
    {
        public Darurat_Database()
        {
            InitializeComponent();
        }

        private void Darurat_Database_Load(object sender, EventArgs e)
        {

        }
        public void displayFaskes()
        {
            DBMedStory.ReadUser("SELECT * FROM faskes", dataGridView1);
        }
        public void displayDokterPraktik()
        {
            DBMedStory.ReadUser("SELECT * FROM dokterpraktik", dataGridView2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Semua")
            {
                displayDokterPraktik();
            }
            else if (comboBox3.Text != "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM dokterpraktik WHERE spesialis = '" + comboBox3.Text + "'", dataGridView2);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Semua")
            {
                displayFaskes();
            } 
            else if (comboBox2.Text == ">= 4.5")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating >= 4.5", dataGridView1);
            }
            else if (comboBox2.Text == "4.0 - 4.4")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating >= 4.0 AND rating <= 4.4", dataGridView1);
            }
            else if (comboBox2.Text == "3.5 - 3.9")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating >= 3.5 AND rating <= 3.9", dataGridView1);
            }
            else if (comboBox2.Text == "3.0 - 3.4")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating >= 3.0 AND rating <= 3.4", dataGridView1);
            }
            else if (comboBox2.Text == "2.5-2.9")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating >= 2.5 AND rating <= 2.9", dataGridView1);
            }
            else if (comboBox2.Text == "<= 2.4")
            {
                DBMedStory.ReadUser("SELECT * FROM faskes WHERE rating <= 2.4", dataGridView1);
            }
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM faskes WHERE namaFaskes LIKE '%" + searchBox1.Text + "%' OR alamat LIKE '%" + searchBox1.Text + "%'", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM dokterpraktik WHERE namaDokter LIKE '%" + textBox1.Text + "%' OR lokasi LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }
    }
}
