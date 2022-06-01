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
    public partial class Asupan_Database : UserControl
    {
        public Asupan_Database()
        {
            InitializeComponent();
        }
        public void displayAsupan()
        {
            DBMedStory.ReadUser("SELECT * FROM asupan", dataGridView1);
        }
        public void displayKebutuhan()
        {
            DBMedStory.ReadUser("SELECT kebutuhankalori.id_kebutuhan, kebutuhankalori.id_user, pengguna.namaPengguna, kebutuhankalori.kalori, kebutuhankalori.date FROM kebutuhankalori JOIN pengguna USING(id_user)", dataGridView2);
        }
        public void displayJadwal()
        {
            DBMedStory.ReadUser("SELECT jadwalkalori.id_jadwal, jadwalkalori.id_user, pengguna.namaPengguna, jadwalkalori.id_asupan, asupan.nama, asupan.kategori, asupan.kalori, jadwalkalori.date, jadwalkalori.waktu FROM jadwalkalori JOIN asupan USING(id_asupan) JOIN pengguna USING(id_user)", dataGridView3);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan", dataGridView1);
            }
                else if (comboBox3.Text == "Rendah (<= 100 cal)")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan WHERE kalori <= 100", dataGridView1);
            }
                else if (comboBox3.Text == "Sedang (101 cal - 200 cal)")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan WHERE kalori > 100 AND kalori <= 200", dataGridView1);
            }
                else if (comboBox3.Text == "Tinggi (> 200 cal)")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan WHERE kalori > 200", dataGridView1);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Semua")
            {
                displayAsupan();
            }
            else if (comboBox2.Text != "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan WHERE kategori = '" + comboBox2.Text + "'", dataGridView1);
            }
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Semua")
            {
                displayJadwal();
            }
            else if (comboBox4.Text != "Semua")
            {
                DBMedStory.ReadUser("SELECT jadwalkalori.id_jadwal, jadwalkalori.id_user, pengguna.namaPengguna, jadwalkalori.id_asupan, asupan.nama, asupan.kategori, asupan.kalori, jadwalkalori.date, jadwalkalori.waktu FROM jadwalkalori JOIN asupan USING(id_asupan) JOIN pengguna USING(id_user) WHERE jadwalkalori.waktu = '" + comboBox4.Text + "'", dataGridView3);
            }
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM asupan WHERE nama LIKE '%" + searchBox1.Text + "%'", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT kebutuhankalori.id_kebutuhan, kebutuhankalori.id_user, pengguna.namaPengguna, kebutuhankalori.kalori, kebutuhankalori.date FROM kebutuhankalori JOIN pengguna USING(id_user) WHERE pengguna.namaPengguna LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT jadwalkalori.id_jadwal, jadwalkalori.id_user, pengguna.namaPengguna, jadwalkalori.id_asupan, asupan.nama, asupan.kategori, asupan.kalori, jadwalkalori.date, jadwalkalori.waktu FROM jadwalkalori JOIN asupan USING(id_asupan) JOIN pengguna USING(id_user) WHERE pengguna.namaPengguna LIKE '%" + textBox2.Text + "%' OR asupan.nama LIKE '%" + textBox2.Text + "%'", dataGridView3);
        }
    }
}
