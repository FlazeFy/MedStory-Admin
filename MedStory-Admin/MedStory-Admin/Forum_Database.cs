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

        private void searchBox2_TextChanged(object sender, EventArgs e)
        {
            DBMedStory.ReadUser("SELECT * FROM diskusi WHERE namaPengguna LIKE '%" + searchBox2.Text + "%' OR pertanyaan LIKE '%" + searchBox2.Text + "%'", dataGridView2);
        }
    }
}
