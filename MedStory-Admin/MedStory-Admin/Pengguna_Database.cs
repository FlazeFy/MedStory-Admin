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
    public partial class Pengguna_Database : UserControl
    {
        public Pengguna_Database()
        {
            InitializeComponent();
            
        }

        private void Pengguna_Database_Load(object sender, EventArgs e)
        {

        }
        public void displayUser()
        {
            DBMedStory.ReadUser("SELECT * FROM pengguna", dataGridView1);
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM pengguna WHERE namaPengguna LIKE '%" + searchBox1.Text + "%' OR namaLengkap LIKE '%" + searchBox1.Text + "%'", dataGridView1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Pria")
            {
                DBMedStory.ReadUser("SELECT * FROM pengguna WHERE jKelamin = 'Pria'", dataGridView1);
            }
                else if (comboBox3.Text == "Wanita")
            {
                DBMedStory.ReadUser("SELECT * FROM pengguna WHERE jKelamin = 'Wanita'", dataGridView1);
            }
                else if (comboBox3.Text == "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM pengguna", dataGridView1);
            }
        }
    }
}
