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
                DBMedStory.ReadUser("SELECT * FROM asupan", dataGridView1);
            }
            else if (comboBox2.Text != "Semua")
            {
                DBMedStory.ReadUser("SELECT * FROM asupan WHERE kategori = '" + comboBox2.Text + "'", dataGridView1);
            }
        }
    }
}
