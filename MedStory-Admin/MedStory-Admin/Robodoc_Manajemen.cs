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
    public partial class Robodoc_Manajemen : UserControl
    {
        public Robodoc_Manajemen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Penyakit pykt = new Penyakit(namaCtrl.Text.Trim(), Convert.ToInt32(levelCtrl.Text.Trim()), penangananCtrl.Text.Trim(), pencegahanCtrl.Text.Trim(), rasioCtrl.Text.Trim());
            DBMedStory.AddPenyakit(pykt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gejala gjl = new Gejala(namaGejalaCtrl.Text.Trim());
            DBMedStory.AddGejala(gjl);
        }

        private void Robodoc_Manajemen_Load(object sender, EventArgs e)
        {

        }
    }
}
