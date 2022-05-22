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
    public partial class Forum_Database : UserControl
    {
        public Forum_Database()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void displayDiskusi()
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi", dataGridView2);
        }
        public void displayDiskusiTerbalas()
        {
            DBMedStory.ReadUser("SELECT * FROM balasan", dataGridView3);
        }

        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi WHERE namaPengguna LIKE '%" + searchBox2.Text + "%' OR pertanyaan LIKE '%" + searchBox2.Text + "%'", dataGridView2);
        }

        private void searchBox3_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT id_balasan, pengirim, isi, id_diskusi, datetime, imageURL, status FROM balasan WHERE pengirim LIKE '%" + searchBox3.Text + "%' OR isi LIKE '%" + searchBox3.Text + "%'", dataGridView3);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Semua kategori")
            {
                DBMedStory.ReadUser("SELECT * FROM diskusi", dataGridView2);
            } 
                else
            {
                DBMedStory.ReadUser("SELECT * FROM diskusi WHERE kategori = '" + comboBox2.Text + "'", dataGridView2);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Teks saja")
            {
                DBMedStory.ReadUser("SELECT * FROM diskusi WHERE imageURL = 'null'", dataGridView2);
            }
            else if (comboBox4.Text == "Dengan gambar")
            {
                DBMedStory.ReadUser("SELECT * FROM diskusi WHERE imageURL != 'null'", dataGridView2);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Terjawab")
            {
                DBMedStory.ReadUser("SELECT * FROM balasan WHERE status = 'verified'", dataGridView3);
            }
                else if (comboBox3.Text == "Belum terjawab")
            {
                DBMedStory.ReadUser("SELECT * FROM balasan WHERE status = 'null'", dataGridView3);
            } 
                else if (comboBox3.Text == "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM balasan", dataGridView3);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text == "Teks saja")
            {
                DBMedStory.ReadUser("SELECT * FROM balasan WHERE imageURL = 'null'", dataGridView3);
            }
            else if (comboBox5.Text == "Dengan gambar")
            {
                DBMedStory.ReadUser("SELECT * FROM balasan WHERE imageURL != 'null'", dataGridView3);
            }
        }

        private void Forum_Database_Load(object sender, EventArgs e)
        {

        }
    }
}
