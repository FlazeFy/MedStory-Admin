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
    public partial class Forum_Manajemen : UserControl
    {
        public Forum_Manajemen()
        {
            InitializeComponent();
        }

        private void Forum_Manajemen_Load(object sender, EventArgs e)
        {

        }
        public void displayDiskusi()
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi", dataGridView2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Diskusi dis = new Diskusi(pertanyaanCtrl.Text.Trim(), kategoriCtrl.Text.Trim());
            DBMedStory.AddDiskusi(dis);
            displayDiskusi();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi WHERE namaPengguna LIKE '%" + textBox1.Text + "%' OR pertanyaan LIKE '%" + textBox1.Text + "%'", dataGridView2);
        }
    }
}
